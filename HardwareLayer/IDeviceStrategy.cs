using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HardwareLayer
{
    /// <summary>
    /// Interfejs strategii dla implementacji urządzeń.
    /// </summary>
    public interface IDeviceStrategy
    {
        bool Connect(string majorId, string minorId);
        byte[] Execute(CommandPacket command);
        void Disconect();
        bool IsConnetced { get; }
        event EventHandler OnConnect;
        event EventHandler OnDisconnect;
    }
}
