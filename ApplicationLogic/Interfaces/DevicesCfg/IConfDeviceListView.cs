using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace ApplicationLogic.Interfaces.DevicesCfg
{
    public interface IConfDeviceListView : ApplicationLogic.Interfaces.Base.IBaseView
    {
        IList<ConfDevice> Configurations { set; }
        ConfDevice CurrentConfiguration { get; }
    }
}
