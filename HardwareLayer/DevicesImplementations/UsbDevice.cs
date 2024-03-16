using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HardwareLayer.DevicesImplementations.UsbImplementation;
using System.Globalization;

namespace HardwareLayer.DevicesImplementations
{
    /// <summary>
    /// Implementacja strategii dla urządzenia USB.
    /// </summary>
    public class UsbDevice : IDeviceStrategy
    {
        private UsbDeviceFacade baseDevice;
        public event EventHandler OnConnect;
        public event EventHandler OnDisconnect;

        public bool Connect(string majorId, string minorId)
        {
            baseDevice = new UsbDeviceFacade(FromHex(majorId), FromHex(minorId));
            bool result = baseDevice.TryConnect();

            if (result)
            {
                baseDevice.OnConnectDevice += new EventHandler(baseDevice_OnConnect);
                baseDevice.OnDisconnectDevice += new EventHandler(baseDevice_OnDisconnect);
            }
            return result;
        }

        void baseDevice_OnDisconnect(object sender, EventArgs e)
        {
            OnDisconnect(this, e);
        }

        void baseDevice_OnConnect(object sender, EventArgs e)
        {
            OnConnect(this, e);
        }

        public byte[] Execute(CommandPacket command)
        {
            if (baseDevice == null || command == null)
                return null;

            UsbPacket cmd = new UsbPacket(command);
            byte[] bufferResult;
            if (cmd.ReturnsByte == 0)
            {
                bool tmpResult = baseDevice.ExecuteWithoutResult(cmd.Command, cmd.Value, cmd.Index);
                bufferResult = new byte[1];
                bufferResult[0] = tmpResult ? (byte) 1 : (byte) 0;
            }
            else
            {
                bufferResult = baseDevice.ExecuteWithDataResult(cmd.Command, cmd.Value, cmd.Index, cmd.ReturnsByte);
            }

            return bufferResult;
        }

        public void Disconect()
        {
            if (baseDevice == null)
                return;

            baseDevice.ForceClose();
        }

        public bool IsConnetced
        {
            get { return baseDevice.IsConnected; }
        }

        private int FromHex(string value)
        {
            if (value.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                value = value.Substring(2);
            }
            int result = 0;
            try
            {
                result = Int32.Parse(value, NumberStyles.HexNumber);
            }
            catch { }
            return result;
        }
    }
}
