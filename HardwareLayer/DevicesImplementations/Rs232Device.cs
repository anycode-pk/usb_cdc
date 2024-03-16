using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using HardwareLayer.DevicesImplementations.Rs232Implementation;
using System.Threading;

namespace HardwareLayer.DevicesImplementations
{
    /// <summary>
    /// Implementacja strategii dla RS-232.
    /// </summary>
    public class Rs232Device : IDeviceStrategy
    {
        private SerialPort serialPort = new SerialPort();
        private bool connected = false;
        
        public bool Connect(string majorId, string minorId)
        {
            int baude = 19200;
            bool result = true;
            if (serialPort.IsOpen == false)
            {
                int.TryParse(minorId, out baude);
                serialPort.PortName = majorId;
                serialPort.BaudRate = baude;
                // Implementacja dla RS-232 jest przygotowana w ramach badania, stąd część parametrów jest nie konfigurowalnych.
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;

                try
                {
                    serialPort.Open();
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            return result;
        }

        public byte[] Execute(CommandPacket command)
        {
            if (serialPort.IsOpen == false || command == null)
                return null;

            Rs232Packet cmd = new Rs232Packet(command);
            bool noError = true;

            try
            {
                serialPort.Write(cmd.FullCommand);
            }
            catch
            {
                noError = false;
            }

            byte[] bufferResult;

            if (cmd.ReturnsByte == 0)
            {
                bufferResult = new byte[1];
                bufferResult[0] = noError ? (byte)1 : (byte)0;
            }
            else
            {
                try
                {
                    Thread.Sleep(20); // Odczekanie na gotowość portu.
                    string rsResult = serialPort.ReadExisting();
                    int resultInt = Convert.ToInt32(rsResult);
                    byte low = (byte)  (resultInt & 0x000000FF);
                    byte high = (byte)((resultInt & 0x0000FF00) >> 8);
                    bufferResult = new byte[2];
                    bufferResult[0] = low;
                    bufferResult[1] = high;
                }
                catch 
                {
                    bufferResult = null;
                }
            }
            return bufferResult;            
        }

        public void Disconect()
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                }
                catch
                {

                }
            }
        }

        public bool IsConnetced
        {
            get { return serialPort.IsOpen; }
        }

        public event EventHandler OnConnect;

        public event EventHandler OnDisconnect;
    }
}
