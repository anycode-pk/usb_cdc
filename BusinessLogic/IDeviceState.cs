using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace BusinessLogic
{
    /// <summary>
    /// Interfejs dla stanu urządzenia, realizuje wzorzec stan.
    /// </summary>
    public interface IDeviceState
    {
        bool StartCycle(IList<CmdList> cmdsList, MeasureCycle currentCycle, MeasurementManager context);
        bool StopCycle(MeasurementManager context);
        bool SingleMeasurement(CmdList cmdList, MeasureCycle currentCycle, MeasurementManager context);
        byte[] RawExecute(byte cmd, short index, short value, int returnedBytes, MeasurementManager context);
    }
}
