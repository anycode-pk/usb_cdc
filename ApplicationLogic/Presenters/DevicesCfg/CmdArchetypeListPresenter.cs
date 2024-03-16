using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.DevicesCfg;
using CommonModel.Entities;
using DataManager.Repositories;
using ApplicationLogic.Helpers;

namespace ApplicationLogic.Presenters.DevicesCfg
{
    public class CmdArchetypeListPresenter : ApplicationLogic.Presenters.Base.BasePresenter<ICmdArchetypeListView>
    {
        CmdArchetypeRepository cmdArRepo = new CmdArchetypeRepository();
        public CmdArchetypeListPresenter(ICmdArchetypeListView view)
            : base(view)
        { }

        public override void Initialize()
        {
            this.View.CmdArchetypes = cmdArRepo.GetAll();
        }

        public void ShowEditor(ICmdArchetypeEditView view, CmdArchetype current)
        {
            if (current == null)
                return;

            if (current.Id == 0)
            {
                current.Device = new DeviceRepository().GetDefault();
            }

            view.CurrentCmdArchetype = current;
            view.AvaibleDevices = new DeviceRepository().GetAll();
            view.ShowView();
        }

        public void DeleteCmdArchetype()
        {
            if (this.View.ShowQuestion(TextContentRepository.CmdArchetypeDeleteQuestion, TextContentRepository.Attention) == true)
            {
                if (cmdArRepo.Remove(this.View.CurrentCmdArchetype) == false)
                {
                    this.View.ShowError(TextContentRepository.CmdArchetypeDeleteError, TextContentRepository.Attention);
                }
            }  
        }
    }
}
