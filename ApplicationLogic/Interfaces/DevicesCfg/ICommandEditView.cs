using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;
using ApplicationLogic.Global;

namespace ApplicationLogic.Interfaces.DevicesCfg
{
    public interface ICommandEditView : ApplicationLogic.Interfaces.Base.IBaseView
    {
        Command CurrentCommand { get; set; }
        IList<CmdArchetype> CmdArchetypes { set; }
        IList<Unit> Units { set; }
        WindowResult WindowResult { get; }
        Command CloneOfCommand { get; }
    }
}
