using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;
using BusinessLogic.StateImplementation;
using DataManager.Repositories;
using HardwareLayer.DevicesImplementations.UsbImplementation;
using System.Threading;
using BusinessLogic.Other;
using CommonModel.ModelChandegEvents;
using HardwareLayer;

namespace BusinessLogic
{
    /// <summary>
    /// Menadżer wykonujący pomiary, wykorzystuje kontekst urządzenia.
    /// </summary>
    public class MeasurementManager
    {
        internal CmdList SingleCommandList;
        internal IList<CmdList> TodoCommands;
        private IDeviceState deviceState;
      
        internal MeasureCycle CurrentCycle;
        private MeasurementRepository measureRepo;
        private MeasureValueRepository valuesRepo;
        private bool repeat;
        private Thread cycleThread;
        private string measurementDescription;

        public string MeasurementDescription
        {
            set { measurementDescription = value; }
        }

        public delegate void DeviceStateChangedEventHandler(DeviceStateEventArgs eventArgs);
        public event DeviceStateChangedEventHandler OnDeviceStateChanged;

        public delegate void CurrentCmdsListChangedEventHandler(CmdsListChangedEventArgs eventArgs);
        public event CurrentCmdsListChangedEventHandler OnCmdsListChanged;

        public delegate void CurrentMeasureValueChangedEventHandler(MeasureValuesCahngedEventArgs eventArgs);
        public event CurrentMeasureValueChangedEventHandler OnMeasureValueChanged;

        public bool Repeat
        {
            get { return repeat; }
            set { repeat = value; }
        }

        internal void SetDeviceStat(IDeviceState devState)
        {
            this.deviceState = devState;
            OnDeviceStateChanged(new DeviceStateEventArgs(deviceState));
        }

        public MeasurementManager()
        {            
            measureRepo = new MeasurementRepository();
            valuesRepo = new MeasureValueRepository();
            repeat = false;

            if (DeviceContext.Instance.CurrentDevice.IsConnetced)
            {
               deviceState = new StateReady();
            }
            else
            {
                deviceState = new StateDisconnected();
            }

            DeviceContext.Instance.CurrentDevice.OnConnect += new EventHandler(CurrentDevice_OnConnect);
            DeviceContext.Instance.CurrentDevice.OnDisconnect += new EventHandler(CurrentDevice_OnDisconnect);
        }

        private void CurrentDevice_OnDisconnect(object sender, EventArgs e)
        {
            SetDeviceStat(new StateDisconnected());
        }

        void CurrentDevice_OnConnect(object sender, EventArgs e)
        {
            SetDeviceStat(new StateReady());
        }

        public void PostInitializeState()
        {
            this.SetDeviceStat(deviceState);
        }

        public bool StartCycle(IList<CmdList> cmdsList, MeasureCycle currentCycle)
        {
            return deviceState.StartCycle(cmdsList, currentCycle, this);
        }

        public bool StopCycle()
        {
            return deviceState.StopCycle(this);
        }

        public bool SingleMeasuremet(CmdList cmdList, MeasureCycle currentCycle)
        {
            return deviceState.SingleMeasurement(cmdList, currentCycle, this);
        }

        public byte[] RawExecute(byte cmd, short index, short value, int returnedBytes)
        {
            return deviceState.RawExecute(cmd, index, value, returnedBytes, this);
        }

        internal void RunSingleMeasurement()
        {
            Measurement measure = new Measurement()
            {
                MeasureCycle = this.CurrentCycle,
                Description = this.measurementDescription,
                Time = DateTime.Now,
                Type = 0
            };
            measureRepo.InsertOrUpdate(measure);

            foreach (Command cmd in SingleCommandList.Command)
            {
                byte[] result = DeviceContext.Instance.CurrentDevice.Execute(
                    new CommandPacket() { Command = (byte)cmd.CommandValue, Parameters = new short[] { (short)cmd.Index, (short)cmd.Value }, ReturnsByte = cmd.ReturnByte });
                MeasureValue mValue;                
                if (cmd.ReturnByte == 0)
                {
                    mValue = new MeasureValue()
                    {
                        Command = cmd,                        
                        Measurement = measure,
                        Time = DateTime.Now,
                        Error = DeviceContext.Instance.CurrentDevice.IsConnetced ? 0 : 1,
                        UnitValue = 0,
                        DevValue = 0
                    };
                }
                else
                {
                    /* Błędy:
                                             * 0 - ok
                                             * 1 - urzadzenie odłączone
                                             * 2 - błąd przy zwracaniu danych
                                             * */
                    int devValue = 0, error = 0;
                    if (result == null)
                    {
                        error = 2;
                    }
                    else
                    {
                        if (result.Length > 1)
                        { devValue = BytesToLittleEndian(result); }
                        else
                        { devValue = (int)result[0]; }
                    }
                    mValue = new MeasureValue()
                    {
                        Command = cmd,
                        Measurement = measure,
                        Time = DateTime.Now,
                        Error = DeviceContext.Instance.CurrentDevice.IsConnetced ? error : 1,
                        UnitValue = ToRealUnit(devValue, cmd),
                        DevValue = devValue
                    };
                }

                valuesRepo.InsertOrUpdate(mValue);
                OnMeasureValueChanged(new MeasureValuesCahngedEventArgs(mValue));
                Thread.Sleep((int)cmd.PostDelay);
            }
            SetDeviceStat(new StateReady());
        }

        internal void RunCycleMeasurement()
        {
            cycleThread = new Thread(Run);
            cycleThread.Start();
        }

        internal void RunSingle()
        {
            cycleThread = new Thread(RunSingleMeasurement);
            cycleThread.Start();
        }

        internal void ForceStopCycleMeasurement()
        {
            try
            {
                cycleThread.Abort();
            }
            catch (Exception ex)
            {
                CommonModel.CommonContext.Instance.LogException(ex);
            }
        }

        internal void Run()
        {
            this.RunCycle();
            while (this.repeat)
            {
                this.RunCycle();
            }
            this.SetDeviceStat(new StateReady());
        }

        private void RunCycle()
        {
            foreach (CmdList cmdList in TodoCommands)
            {
                Measurement measure = new Measurement()
                {
                    MeasureCycle = this.CurrentCycle,
                    Description = this.measurementDescription,
                    Time = DateTime.Now,
                    Type = 0
                };
                measureRepo.InsertOrUpdate(measure);

                OnCmdsListChanged(new CmdsListChangedEventArgs(cmdList));

                foreach (Command cmd in cmdList.Command)
                {
                    byte[] result = DeviceContext.Instance.CurrentDevice.Execute(
                        new CommandPacket() { Command = (byte)cmd.CommandValue, Parameters = new short[] { (short)cmd.Index, (short)cmd.Value }, ReturnsByte = cmd.ReturnByte });                  
                    MeasureValue mValue;

                    if (cmd.ReturnByte == 0)
                    {
                        mValue = new MeasureValue()
                        {
                            Command = cmd,
                            Measurement = measure,
                            Time = DateTime.Now,
                            Error = DeviceContext.Instance.CurrentDevice.IsConnetced ? 0 : 1,
                            UnitValue = 0,
                            DevValue = 0
                        };
                    }
                    else
                    {
                        /* Błędy:
                         * 0 - ok
                         * 1 - urzadzenie odłączone
                         * 2 - błąd przy zwracaniu danych
                         * */
                        int devValue = 0, error = 0;
                        if (result == null)
                        {
                            error = 2;
                        }
                        else
                        {
                            if (result.Length > 1)
                            { devValue = BytesToLittleEndian(result); }
                            else
                            { devValue = (int)result[0]; }
                        }

                        mValue = new MeasureValue()
                        {
                            Command = cmd,
                            Measurement = measure,
                            Time = DateTime.Now,
                            Error = DeviceContext.Instance.CurrentDevice.IsConnetced ? error : 1,
                            UnitValue = ToRealUnit(devValue, cmd),
                            DevValue = devValue
                        };
                    }
                    valuesRepo.InsertOrUpdate(mValue);
                    OnMeasureValueChanged(new MeasureValuesCahngedEventArgs(mValue));
                    Thread.Sleep((int)cmd.PostDelay);
                }
                Thread.Sleep((int)cmdList.PostDelay);
            }
        }

        internal byte[] RunRawExecute(byte cmd, short index, short value, int returnedBytes)
        {
            byte[] result = DeviceContext.Instance.CurrentDevice.Execute(
                       new CommandPacket() { Command = cmd, Parameters = new short[] { index, value }, ReturnsByte = returnedBytes });
            SetDeviceStat(new StateReady());
            return result;
        }

        private int BytesToLittleEndian(byte[] bytes)
        {
            return BitConverter.ToUInt16(bytes, 0);
        }

        private decimal ToRealUnit(int devValue, Command cmd)
        {
            decimal counter = (decimal)cmd.HighRagneUnit - (decimal)cmd.LowRangeUnit;
            decimal denominator = (decimal)cmd.HighRangeDev - (decimal)cmd.LowRangeDev;
            decimal multiplies = counter / (denominator > 0 ? denominator : 1);
            return (devValue * multiplies);
        }        
    }
}
