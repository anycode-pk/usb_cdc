using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace ApplicationLogic.Interfaces.DevicesCfg
{
    public interface ICmdListEditView : ApplicationLogic.Interfaces.Base.IBaseView
    {
        CmdList CurrentCmdList { set; get; }
        IList<Command> CurrentCommands { set; get; }
        Command SelectedCommand { get; }
        IList<ConfDevice> Configurations { set; }
        void LockCommands();
    }
}
