using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace BusinessLogic.Other
{
    /// <summary>
    /// Argument zdarzenia dla zmiany stanu urządzenia.
    /// </summary>
    public class DeviceStateEventArgs : EventArgs
    {
        public IDeviceState State { get; set; }
        public DeviceStateEventArgs(IDeviceState state)
        {
            State = state;
        }
    }
}
