using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;
using CommonModel.Entities;

namespace ApplicationLogic.Interfaces.Dictionaries
{
    public interface IStationEditView : IBaseView
    {
        MeasureStation CurrentStation { set; get; }
        IList<User> CurrentUsers { set; get; }
        IList<User> SelectedUsersToDelete { get; }
        IList<Device> CurrentDevices { set; get; }
        IList<Device> SelectedDevicesToDelete { get; }
    }
}
