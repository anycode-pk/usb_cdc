using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.DevicesCfg;
using DataManager.Repositories;
using CommonModel.Entities;

namespace ApplicationLogic.Presenters.DevicesCfg
{
    public class CommandEditPresenter : ApplicationLogic.Presenters.Base.BasePresenter<ICommandEditView>
    {
        public CommandEditPresenter(ICommandEditView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public void CopyArchetype()
        {
            Command cmd = this.View.CurrentCommand;            
           
                cmd.ArchetypeId = this.View.CurrentCommand.ArchetypeId;
                cmd.HighRagneUnit = this.View.CurrentCommand.CmdArchetype.HighRangeUnit;
                cmd.HighRangeDev = this.View.CurrentCommand.CmdArchetype.HighRangeDev;
                cmd.Index = this.View.CurrentCommand.CmdArchetype.Index;
                cmd.LowRangeDev = this.View.CurrentCommand.CmdArchetype.LowRangeDev;
                cmd.LowRangeUnit = this.View.CurrentCommand.CmdArchetype.LowRangeUnit;
                cmd.Name = this.View.CurrentCommand.CmdArchetype.Name;
                cmd.ReturnByte = this.View.CurrentCommand.CmdArchetype.ReturnByte;
                cmd.Value = this.View.CurrentCommand.CmdArchetype.Value;
                cmd.CommandValue = (int) this.View.CurrentCommand.CmdArchetype.CommandValue;
                cmd.PostDelay = 0;
            
            this.View.CurrentCommand = cmd;
        }
    }
}
