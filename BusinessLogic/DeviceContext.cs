using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HardwareLayer;

namespace BusinessLogic
{
    /// <summary>
    /// Kontekst aktualnego urządzenia, singleton.
    /// </summary>
    internal class DeviceContext
    {
        private static DeviceContext instance;

        internal static DeviceContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeviceContext();
                }
                return instance;
            }
        }

        private DeviceContext()
        {
        }

        internal IDeviceStrategy CurrentDevice { set; get; }
    }
}
