using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;
using CommonModel.Entities;

namespace ApplicationLogic.Interfaces.DevicesCfg
{
    public interface IConfDeviceEditView : IBaseView
    {
        ConfDevice CurrentCofiguration { set; get; }
        IList<Device> AvaibleDevices { set; }
    }
}
