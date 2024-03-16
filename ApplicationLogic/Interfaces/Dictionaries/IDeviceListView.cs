using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;
using ApplicationLogic.Global;

namespace ApplicationLogic.Interfaces.Dictionaries
{
    public interface IDeviceListView : ApplicationLogic.Interfaces.Base.IBaseView
    {
        IList<Device> Devices { set; }
        Device CurrentDevice { get; }
        IList<Device> SelectedDevices { get; }
        ViewFunctionTypes ViewFuncType { set; }
        WindowResult WindowResult { get; }
    }
}
