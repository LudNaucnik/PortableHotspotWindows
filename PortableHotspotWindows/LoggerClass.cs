using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace PortableHotspotWindows
{
    class LoggerClass
    {
        static String sSource = @"PortableHotspotWindows";
        static String sLog = @"Application";
        static String FilePath = Application.StartupPath + @"\log.txt";
        static String BreakPoint = @"--------------------------------------------";
        public static void WriteLogInformation(String sEvent)
        {
            LogExists();
            EventLog.WriteEntry(sSource, sEvent, EventLogEntryType.Information);
            File.AppendAllText(FilePath, Environment.NewLine + DateTime.Now.ToString() + " " + EventLogEntryType.Information.ToString() + Environment.NewLine + sEvent + Environment.NewLine + BreakPoint);
        }

        public static void WriteLogWarning(String sEvent)
        {
            LogExists();
            EventLog.WriteEntry(sSource, sEvent, EventLogEntryType.Warning);
            File.AppendAllText(FilePath, Environment.NewLine + DateTime.Now.ToString() + " " + EventLogEntryType.Warning.ToString() + Environment.NewLine + sEvent + Environment.NewLine + BreakPoint);
        }

        public static void WriteLogError(String sEvent)
        {
            LogExists();
            EventLog.WriteEntry(sSource, sEvent, EventLogEntryType.Error);
            File.AppendAllText(FilePath, Environment.NewLine + DateTime.Now.ToString() + " " + EventLogEntryType.Error.ToString() + Environment.NewLine + sEvent + Environment.NewLine + BreakPoint);
        }

        public static void LogExists()
        {
            if (!EventLog.SourceExists(sSource))
            {
                EventLog.CreateEventSource(sSource, sLog);
            }
        }
    }
}
