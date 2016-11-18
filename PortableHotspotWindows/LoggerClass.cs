using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PortableHotspotWindows
{
    class LoggerClass
    {
        public static void WriteLog(String log)
        {
            String FilePath = Application.StartupPath + @"\log.txt";
            File.AppendAllText(FilePath, Environment.NewLine + log);
        }
    }
}
