using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace ApplicationLogic.Interfaces.DevicesCfg
{
    public interface ICmdArchetypeListView : ApplicationLogic.Interfaces.Base.IBaseView
    {
        IList<CmdArchetype> CmdArchetypes { set; }
        CmdArchetype CurrentCmdArchetype { get; }
    }
}
