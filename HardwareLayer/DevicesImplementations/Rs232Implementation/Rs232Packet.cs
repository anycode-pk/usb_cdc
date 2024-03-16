using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HardwareLayer.DevicesImplementations.Rs232Implementation
{
    public class Rs232Packet : CommandPacket
    {
        public Rs232Packet(CommandPacket cmdP)
        {
            this.Command = cmdP.Command;
            this.Parameters = cmdP.Parameters;
            this.ReturnsByte = cmdP.ReturnsByte;               
                
        }

        /// <summary>
        /// Zwraca pełny string rozkazu, oczekiwany przez RS-232.
        /// </summary>
        public string FullCommand
        {
            get
            {
                if (this.Parameters[0] != null && this.Parameters[1] != null)
                {
                    string ret = string.Format("{0}{1}{2}x", this.Command.ToString(), this.Parameters[0].ToString(), this.Parameters[1].ToString());
                    return ret;
                }
                
                else return "";
            }
        }
    }
}
