using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;
using CommonModel.Entities;
using CommonModel.Enums;

namespace ApplicationLogic.Interfaces.Dictionaries
{
    public interface IDeviceEditView : IBaseView
    {
        Device CurrentDevice { set; get; }
        IList<InterfacesType> InterfaceType { set; get; }
    }
}
