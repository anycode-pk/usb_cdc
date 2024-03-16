using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;

namespace ApplicationLogic.Interfaces.ReadyState
{
    public interface ITestDeviceView : IBaseView
    {
        string Vid { get; }
        string Pid { get; }
        string DeviceStatus { set; }
        byte Command { get; }
        short Index { get; }
        short Value { get; }
        int ReturnesByres { get; }
        string ResultBin { set; }
        string ResultDec { set; }
        string ResultHex { set; }
        string ResultAscii { set; }
    }
}
