using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.ReadyState;
using BusinessLogic;
using CommonModel.Entities;
using ApplicationLogic.Helpers;
using BusinessLogic.Other;
using BusinessLogic.StateImplementation;

namespace ApplicationLogic.Presenters.ReadyState
{
    public class TestDevicePresenter : ApplicationLogic.Presenters.Base.BasePresenter<ITestDeviceView>
    {

        private DeviceManager deviceManager;
        private MeasurementManager measureManager;
        public TestDevicePresenter(ITestDeviceView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            this.View.DeviceStatus = TextContentRepository.DeviceStateDisconnect;
        }

        public void Connect()
        {
            deviceManager = new DeviceManager();
            Device tmpDevice = new Device()
            {
                Interface = 0,
                PID = this.View.Pid,
                VID = this.View.Vid
            };

            if (deviceManager.Connect(tmpDevice) == false)
            {
                this.View.ShowError(TextContentRepository.DeviceConnError, TextContentRepository.Attention);
            }
            else
            {
                measureManager = new MeasurementManager();
                measureManager.OnDeviceStateChanged += new MeasurementManager.DeviceStateChangedEventHandler(measureManager_OnDeviceStateChanged);
            }
        }

        private void measureManager_OnDeviceStateChanged(BusinessLogic.Other.DeviceStateEventArgs eventArgs)
        {
            if (eventArgs.State is StateDisconnected)
            {
                this.View.DeviceStatus = TextContentRepository.DeviceStateDisconnect;
            }
            else if (eventArgs.State is StateReady)
            {
                this.View.DeviceStatus = TextContentRepository.DeviceStateReady;

            }
            else if (eventArgs.State is StateWorking)
            {
                this.View.DeviceStatus = TextContentRepository.DeviceStateWorking;
            }
            else
            {
                this.View.DeviceStatus = TextContentRepository.DeviceStateNone;
            }
        }

        public void Execute()
        {
            if (measureManager == null)
            {
                this.View.ResultAscii = TextContentRepository.DeviceStateDisconnect;
                this.View.ResultBin = TextContentRepository.DeviceStateDisconnect;
                this.View.ResultDec = TextContentRepository.DeviceStateDisconnect;
                this.View.ResultHex = TextContentRepository.DeviceStateDisconnect;
            }
            else
            {
                byte[] result = measureManager.RawExecute(this.View.Command, this.View.Index, this.View.Value, this.View.ReturnesByres);
                int resultInt = BytesToLittleEndian(result);
                this.View.ResultDec = resultInt.ToString();
                this.View.ResultHex = resultInt.ToString("X");
                this.View.ResultBin = Convert.ToString(resultInt, 2);
                this.View.ResultAscii = Encoding.ASCII.GetString(result);
            }

        }

        private int BytesToLittleEndian(byte[] bytes)
        {
            int ret = 0;
            try
            {
                ret = BitConverter.ToUInt16(bytes, 0);
            }
            catch { }
            return ret;
        }
    }
}
