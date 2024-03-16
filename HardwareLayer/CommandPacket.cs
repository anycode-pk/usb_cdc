using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HardwareLayer
{
    /// <summary>
    /// Pakiet danych wymagany przez warstwę obsługi sprzętu.
    /// </summary>
    public class CommandPacket
    {
        public byte Command { set; get; }
        public short[] Parameters { set; get; }
        public int ReturnsByte { set; get; }
    }
}
