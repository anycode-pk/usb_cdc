using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;
using CommonModel.Entities;

namespace ApplicationLogic.Interfaces.ReadyState
{
    public interface IConfigSelectorVew : IBaseView
    {
        IList<Device> Devices {set; }
        Device SelectedDevice { get;}
        IList<ConfDevice> Configurations { set; }
        ConfDevice SelectedConfigurtion { get; }
        string SessionDescription { get; }
        string ConfigurationDescription { set; }
    }
}
