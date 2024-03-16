using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;
using CommonModel.Enums;
using HardwareLayer;
using HardwareLayer.DevicesImplementations;

namespace BusinessLogic
{
    /// <summary>
    /// Menadżer umożliwiający połączenie z urządzeniem i utworzenie kontekstu urządzenia.
    /// </summary>
    public class DeviceManager
    {
        private IDeviceStrategy deviceHL;
        public bool Connect(Device device)
        {
            bool result = false;
            switch (device.Interface)
            {
                case (int)InterfacesType.USB:
                    this.deviceHL = new UsbDevice();

                    if (deviceHL.Connect(device.VID, device.PID))
                    {
                        result = true;
                        DeviceContext.Instance.CurrentDevice = deviceHL;
                    }
                    break;
                case (int) InterfacesType.RS232:
                    this.deviceHL = new Rs232Device();

                    if (deviceHL.Connect(device.VID, device.PID))
                    {
                        result = true;
                        DeviceContext.Instance.CurrentDevice = deviceHL;
                    }
                    break;
                   
            }
            return result;
        }
    }
}
