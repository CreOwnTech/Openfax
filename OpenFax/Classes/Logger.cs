using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFax.Classes
{
    public class Logger
    {
        public static void Log(string message)
        {
            if (!Directory.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "/Logs"))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "/Logs");
            }
            string logfile = "log_" + DateTime.Today.ToString("dd/MM/yyyy") + ".txt";
            if (!File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "/Logs/" + logfile))
            {
                File.Create(Path.GetDirectoryName(Application.ExecutablePath) + "/Logs/" + logfile);
            }

            using (StreamWriter streamWriter = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + "/Logs/" + logfile))
            {
                streamWriter.WriteLine(DateTime.Today.ToString("dd/MM/yyyy HH:mm:ss") + " -  " + message);
                streamWriter.Close();
            }
        }
    }
}
