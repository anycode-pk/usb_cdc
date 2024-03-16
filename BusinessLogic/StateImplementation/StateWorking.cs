using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace BusinessLogic.StateImplementation
{
    public class StateWorking : IDeviceState
    {
        public bool StartCycle(IList<CmdList> cmdsList, MeasureCycle currentCycle, MeasurementManager context)
        {
            return false;
        }

        public bool StopCycle(MeasurementManager context)
        {
            context.ForceStopCycleMeasurement();
            context.SetDeviceStat(new StateReady());
            return true;
        }

        public bool SingleMeasurement(CmdList cmdList, MeasureCycle currentCycle, MeasurementManager context)
        {
            return false;
        }


        public byte[] RawExecute(byte cmd, short index, short value, int returnedBytes, MeasurementManager context)
        {
            return new byte[] { 0 };
        }
    }
}
