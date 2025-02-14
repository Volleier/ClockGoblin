using System;
using System.Diagnostics;

namespace Core.Librarys
{
    public class ProcessHelper
    {
        public static bool Run(string filename, string[] args)
        {
            try
            {
                string arguments = "";
                foreach (string arg in args)
                {
                    arguments += $"\"{arg}\" ";
                }
                arguments = arguments.Trim();
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo(filename, arguments);
                process.StartInfo = startInfo;
                process.Start();
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
                return false;
            }

        }
    }
}
