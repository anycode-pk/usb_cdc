using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;
using BusinessLogic.Other;

namespace BusinessLogic.StateImplementation
{
    public class StateReady : IDeviceState
    {
        public bool StartCycle(IList<CmdList> cmdsList, MeasureCycle currentCycle, MeasurementManager context)
        {
            context.TodoCommands = cmdsList;
            context.CurrentCycle = currentCycle;
            context.SetDeviceStat(new StateWorking());
            context.RunCycleMeasurement();
            return true;
        }

        public bool StopCycle(MeasurementManager context)
        {
            return false;
        }

        public bool SingleMeasurement(CmdList cmdList, MeasureCycle currentCycle, MeasurementManager context)
        {
            context.SingleCommandList = cmdList;
            context.CurrentCycle = currentCycle;
            context.SetDeviceStat(new StateWorking());
            context.RunSingle();            
            return true;
        }

        public byte[] RawExecute(byte cmd, short index, short value, int returnedBytes, MeasurementManager context)
        {
            context.SetDeviceStat(new StateWorking());
            return context.RunRawExecute(cmd, index, value, returnedBytes);
        }
    }
}
