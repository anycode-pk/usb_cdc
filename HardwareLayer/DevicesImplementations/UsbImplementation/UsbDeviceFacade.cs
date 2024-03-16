using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibUsbDotNet;
using LibUsbDotNet.DeviceNotify;
using LibUsbDotNet.Main;

namespace HardwareLayer.DevicesImplementations.UsbImplementation
{
    /// <summary>
    /// Fasada pośrednicząca pomiędzy implementacja stategii dla USB a klasą obsługującą bibliotekę LibUsbDotNet.
    /// </summary>
    public class UsbDeviceFacade
    {
        private LibUsbDotNet.UsbDevice usbDevice;
        private UsbDeviceFinder usbFinder;
        private IDeviceNotifier usbDeviceNotifier;
        public event EventHandler OnConnectDevice;
        public event EventHandler OnDisconnectDevice;
        public event EventHandler<DeviceNotifyEventArgs> OnOtherDeviceNotifyEvent;

        public bool IsConnected
        {
            get
            {
                if (usbDevice == null)
                    return false;

                if (usbDevice.IsOpen == false || usbDevice.UsbRegistryInfo.IsAlive == false)
                {
                    ForceClose();
                    return false;
                }
                return true;
            }
        }

        public UsbDeviceFacade(int vid, int pid)
        {
            usbFinder = new UsbDeviceFinder(vid, pid);
            usbDeviceNotifier = DeviceNotifier.OpenDeviceNotifier();
            usbDeviceNotifier.OnDeviceNotify += new EventHandler<DeviceNotifyEventArgs>(UsbDeviceNotifier_OnDeviceNotify);
        }

        public bool TryConnect()
        {
            usbDevice = LibUsbDotNet.UsbDevice.OpenUsbDevice(usbFinder);
            return IsConnected;
        }

        public void ForceClose()
        {
            try
            {
                usbDevice.Close();
            }
            catch
            {
            }
            finally
            {
                usbDevice = null;
            }
        }

        private void UsbDeviceNotifier_OnDeviceNotify(object sender, DeviceNotifyEventArgs e)
        {
            if (e.EventType == EventType.DeviceArrival)
            {
                if (e.Device.IdVendor == usbFinder.Vid && e.Device.IdProduct == usbFinder.Pid)
                {
                    usbDevice = LibUsbDotNet.UsbDevice.OpenUsbDevice(usbFinder);

                    if (IsConnected)
                    {
                        if (OnConnectDevice != null)
                            OnConnectDevice(this, e);
                    }
                    return;
                }
            }
            else if (e.EventType == EventType.DeviceRemoveComplete)
            {
                if (usbDevice != null)
                {
                    if (usbDevice.UsbRegistryInfo.Vid == e.Device.IdVendor &&
                        usbDevice.UsbRegistryInfo.Pid == e.Device.IdProduct)// &&
                    {
                        ForceClose();

                        if (OnDisconnectDevice != null)
                            OnDisconnectDevice(this, e);

                        return;
                    }
                }
            }

            if (OnOtherDeviceNotifyEvent != null)
                OnOtherDeviceNotifyEvent(this, e);
        }


        public bool ExecuteWithoutResult(byte cmd, short value, short index)
        {
            if (IsConnected == false)
                return false;

            UsbSetupPacket packet = new UsbSetupPacket((byte)UsbRequestType.TypeVendor, cmd, value, index, 0);
            int temp1;
            object temp2 = null;
            return usbDevice.ControlTransfer(ref packet, temp2, 0, out temp1);
        }

        public byte[] ExecuteWithDataResult(byte cmd, short value, short index, int returnedBytes)
        {
            if (IsConnected == false)
                return null;

            byte[] buffer = new byte[returnedBytes];
            UsbSetupPacket packet = new UsbSetupPacket((byte)(UsbCtrlFlags.Direction_In | UsbCtrlFlags.Recipient_Device | UsbCtrlFlags.RequestType_Vendor), cmd, value, index, (short)returnedBytes);
            int temp1;
            usbDevice.ControlTransfer(ref packet, buffer, returnedBytes, out temp1);
            return buffer;
        }
    }
}
