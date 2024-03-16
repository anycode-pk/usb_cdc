using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.DevicesCfg;
using DataManager.Repositories;
using CommonModel.Entities;
using ApplicationLogic.Helpers;

namespace ApplicationLogic.Presenters.DevicesCfg
{
    public class CmdListEditPresenter :  ApplicationLogic.Presenters.Base.BasePresenter<ICmdListEditView>
    {
        private CmdListRepository cmdListRepo = new CmdListRepository();
        private IList<Command> cmdToDelete = new List<Command>();
        public CmdListEditPresenter(ICmdListEditView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            this.View.CurrentCommands = this.View.CurrentCmdList.Command.ToList();

            // Sprawdzenie czy aktualny użytkownik posiada uprawnienia do definiowania rozkazów.
            if (ApplicationLogic.Global.UserRightChecker.CheckRightCurrenUser(CommonModel.Enums.RightsMapper.AllowDefineCommands) == false)
                this.View.LockCommands();
        }

        public void Save()
        {
            if (CheckNumberInOrder() == false)
            {
                this.View.ShowWarning(TextContentRepository.RepeatedNoInOrder, TextContentRepository.Info);
            }

            foreach (Command cmd in this.cmdToDelete)
            {
                if (cmd.Id != 0)
                    new CommandRepository().Remove(cmd);
            }
            
            cmdListRepo.InsertOrUpdate(this.View.CurrentCmdList);
            this.View.CloseView();
        }

        private bool CheckNumberInOrder()
        {
            bool noRepeated = true;
            if (this.View.CurrentCmdList.Command != null)
                if (this.View.CurrentCmdList.Command.Count == 1)
                    return noRepeated;

            foreach (Command cmd in this.View.CurrentCmdList.Command)
            {
                if (this.View.CurrentCmdList.Command.Where(p => p.NoInOrder == cmd.NoInOrder && p.Id != cmd.Id).Any())
                    noRepeated = false;
            }
            return noRepeated;
        }

        public void ShowCommandEditor(ICommandEditView view, Command current)
        {
            if (current == null)
                return;

            if (current.Id == 0)
            {
                current.CmdArchetype = new CmdArchetypeRepository().GetDefault();
                current.Unit = new UnitRepository().GetDefault();
            }
            view.CurrentCommand = current;

            view.CmdArchetypes = new CmdArchetypeRepository().GetAll(this.View.CurrentCmdList.ConfDevice.Device);
            view.Units = new UnitRepository().GetAll();
            view.ShowView();
            if (view.WindowResult == Global.WindowResult.Save)
            {
                if (current.Id == 0)
                {
                    current.CmdList = this.View.CurrentCmdList;
                    this.View.CurrentCmdList.Command.Add(current);
                }
            }
            else
            {// jeśli anuluj, to przepisuje wartości z kopi obiektu.
                current.ArchetypeId = view.CloneOfCommand.ArchetypeId;
                current.CmdListId = view.CloneOfCommand.CmdListId;
                current.HighRagneUnit = view.CloneOfCommand.HighRagneUnit;
                current.HighRangeDev = view.CloneOfCommand.HighRangeDev;
                current.Id = view.CloneOfCommand.Id;
                current.Index = view.CloneOfCommand.Index;
                current.LowRangeDev = view.CloneOfCommand.LowRangeDev;
                current.LowRangeUnit = view.CloneOfCommand.LowRangeUnit;
                current.Name = view.CloneOfCommand.Name;
                current.NoInOrder = view.CloneOfCommand.NoInOrder;
                current.PostDelay = view.CloneOfCommand.PostDelay;
                current.ReturnByte = view.CloneOfCommand.ReturnByte;
                current.UnitId = view.CloneOfCommand.UnitId;
                current.Value = view.CloneOfCommand.Value;   
            }
        }

        public void RemoveSelected()
        {
            if (this.View.SelectedCommand == null)
                return;

            cmdToDelete.Add(this.View.SelectedCommand);
            this.View.CurrentCmdList.Command.Remove(this.View.SelectedCommand);
        }

        public void Cancel()
        {
            foreach (Command cmd in this.View.CurrentCmdList.Command)
            {
                new CommandRepository().RejectChanges(cmd); 
            }
            cmdListRepo.RejectChanges(this.View.CurrentCmdList);
            this.View.CloseView();
        }
    }
}
