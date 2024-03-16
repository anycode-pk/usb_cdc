using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace ApplicationLogic.Interfaces.DevicesCfg
{
    public interface ICmdListListView : ApplicationLogic.Interfaces.Base.IBaseView
    {
        IList<CmdList> CommandsList { set; }
        CmdList CurrentCmdList { get; }
        IList<ConfDevice> Configurations { set; }
        ConfDevice CurrentConfiguration { get; }
        void DisableEditing();
    }
}
