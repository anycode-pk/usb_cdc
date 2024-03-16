using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CommonModel
{
    public class LogWriter
    {
        private const string directoryName = "Logs";
        public LogWriter()
        {
            DirectoryInfo dir = new DirectoryInfo(directoryName);
            if (dir.Exists == false)
                dir.Create();
        }

        public void LogMessage(string message)
        {
            StringBuilder toLog = new StringBuilder("*** ");
            toLog.Append(DateTime.Now.ToLongTimeString());
            toLog.Append(" ***");
            toLog.AppendLine();
            toLog.AppendLine(message);
            toLog.AppendLine("=== ===");
            toLog.AppendLine();

            File.AppendAllText(string.Format("{0}\\{1}.txt", directoryName, DateTime.Now.ToShortDateString()), toLog.ToString());
        }

        public void LogException(Exception ex)
        {
            this.LogMessage(ex.ToString());
        }
    }
}
