using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HardwareLayer.DevicesImplementations.UsbImplementation
{
    public class UsbPacket : CommandPacket
    {
        public UsbPacket(CommandPacket cmdP)
        {
            this.Command = cmdP.Command;
            this.Parameters = cmdP.Parameters;
            this.ReturnsByte = cmdP.ReturnsByte; 
        }

        public short Index 
        {
            get
            {
                if (this.Parameters[0] != null)
                    return this.Parameters[0];
                else
                    return 0;
            }
        }
        public short Value 
        {
            get
            {
                if (this.Parameters[1] != null)
                    return this.Parameters[1];
                else
                    return 0;
            }
        }
    }
}
