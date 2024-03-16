using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;
using CommonModel.Entities;
using CommonModel.Enums;

namespace ApplicationLogic.Interfaces.ReadyState
{
    public interface IMeasureStationView : IBaseView
    {
        string DeviceName { set; }
        string ConfigurationName { set; }
        string UserName { set; }
        string DeviceStatus { set; }
        IList<CmdList> CmdsList { set; get; }
        CmdList CurrentCmdList { set; get; }
        string CycleDescription { get; }
        string MeasuremetDescription { get; }
        void LockControls(CycleType cycleType);
        void UnlockControls(CycleType cycleType);
        bool Repeat { get; }
        CycleType CurrentCycleType { set; get; }
        MeasureValue CurrentMeasureValues { set; }
    }
}
