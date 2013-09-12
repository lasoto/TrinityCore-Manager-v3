using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using TrinityCore_Manager.Misc;

namespace TrinityCore_Manager.TC
{
    static class CMake
    {

        public static readonly string CMakeBinLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "CMake", "bin");

        public static async Task<bool> Generate(string sourceDir, string destDir, bool x64, IProgress<string> progress, CancellationToken token)
        {

            return await Task.Run(() =>
            {

                if (!Directory.Exists(CMakeBinLocation))
                    return false;

                string cmake = Path.Combine(CMakeBinLocation, "cmake.exe");

                if (!File.Exists(cmake))
                    return false;

                string args = String.Empty;

                if (x64)
                {
                    if (VisualStudio.Version == VSVersion.VisualStudio11)
                        args = String.Format("-G \"Visual Studio 11 Win64\" \"{0}\"", sourceDir);
                    else if (VisualStudio.Version == VSVersion.VisualStudio10)
                        args = String.Format("-G \"Visual Studio 10 Win64\" \"{0}\"", sourceDir);
                }
                else
                {
                    if (VisualStudio.Version == VSVersion.VisualStudio11)
                        args = String.Format("-G \"Visual Studio 11\" \"{0}\"", sourceDir);
                    else if (VisualStudio.Version == VSVersion.VisualStudio10)
                        args = String.Format("-G \"Visual Studio 10 \" \"{0}\"", sourceDir);
                }

                if (!String.IsNullOrEmpty(args))
                {

                    var proc = ProcessHelper.StartProcess(cmake, destDir, args);

                    int id = proc.Id;

                    proc.EnableRaisingEvents = true;

                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();

                    proc.OutputDataReceived += (sender, e) =>
                    {

                        progress.Report(e.Data);

                        if (token.IsCancellationRequested)
                        {

                            if (ProcessHelper.ProcessExists(id))
                            {
                                proc.Kill();
                                proc.Dispose();
                            }

                        }

                    };

                    proc.ErrorDataReceived += (sender, e) =>
                    {

                        progress.Report(e.Data);

                        if (token.IsCancellationRequested)
                        {

                            if (ProcessHelper.ProcessExists(id))
                            {
                                proc.Kill();
                                proc.Dispose();
                            }

                        }

                    };

                    proc.WaitForExit();

                    return true;

                }

                return false;

            }, token);

        }

    }
}
