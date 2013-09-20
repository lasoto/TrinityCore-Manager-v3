using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TrinityCore_Manager.Misc
{
    static class ProcessHelper
    {

        public static Process GetFirstProcessByName(string name)
        {

            var processes = Process.GetProcessesByName(name);

            if (processes.Length > 0)
                return processes[0];

            return null;

        }

        public static bool KillProcess(string name)
        {

            var processes = Process.GetProcessesByName(name);

            foreach (var process in processes)
            {

                try
                {

                    process.Kill();

                    return true;

                }
                catch (Exception)
                {
                }

            }

            return false;

        }

        public static bool KillProcess(int pid)
        {

            try
            {

                var proc = Process.GetProcessById(pid);

                proc.Kill();

                return true;
            
            }
            catch (Exception)
            {
            }

            return false;

        }

        public static bool ProcessExists(string name)
        {
            return Process.GetProcessesByName(name).Length > 0;
        }

        public static bool ProcessExists(int pid)
        {

            try
            {

                Process.GetProcessById(pid);

                return true;

            }
            catch (Exception)
            {
            }

            return false;

        }

        /// <summary>
        /// Start a process
        /// </summary>
        /// <param name="exeLoc">The location of the exe file</param>
        /// <param name="workingDir">The directory in which to start the exe from</param>
        /// <param name="arguments">Optional arguments to pass</param>
        /// <returns>The process that has been started</returns>
        public static Process StartProcess(string exeLoc, string workingDir, string arguments = "")
        {

            var psi = new ProcessStartInfo(exeLoc);

            psi.WorkingDirectory = workingDir;

            psi.UseShellExecute = false;

            psi.CreateNoWindow = true;

            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardInput = true;

            psi.Arguments = arguments;

            var proc = new Process();
            proc.StartInfo = psi;
            proc.EnableRaisingEvents = true;

            try
            {
                proc.Start();
                return proc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "The file could not be succesfully opened!", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }

    }
}
