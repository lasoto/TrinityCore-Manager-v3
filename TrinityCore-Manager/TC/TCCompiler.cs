using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrinityCore_Manager.Misc;

namespace TrinityCore_Manager.TC
{
    static class TCCompiler
    {

        public static async Task<bool> Clean(string trunkDir, bool x64, IProgress<string> progress, CancellationToken token)
        {

            return await Task.Run(() =>
            {

                string args = String.Empty;

                if (x64)
                {
                    args = String.Format("\"{0}\\TrinityCore.sln\" /t:Clean", trunkDir);
                }
                else
                {
                    args = String.Format("\"{0}\\TrinityCore.sln\" /t:Clean", trunkDir);
                }

                string cpath = VisualStudio.GetCompilerPath();

                var proc = ProcessHelper.StartProcess(cpath, Path.GetDirectoryName(cpath), args);

                proc.EnableRaisingEvents = true;

                proc.BeginOutputReadLine();

                proc.OutputDataReceived += (sender, e) =>
                {

                    progress.Report(e.Data);

                    if (token.IsCancellationRequested)
                    {

                        proc.Kill();
                        proc.Dispose();

                        token.ThrowIfCancellationRequested();

                    }

                };

                proc.WaitForExit();

                return true;

            }, token);

        }

        public static async Task<bool> Compile(string trunkDir, bool x64, IProgress<string> progress, CancellationToken token)
        {

            return await Task.Run(() =>
            {

                string args = String.Empty;

                if (x64)
                {
                    args = String.Format("\"{0}\\TrinityCore.sln\" /t:Build /p:Configuration=Release /p:Platform=x64", trunkDir);
                }
                else
                {
                    args = String.Format("\"{0}\\TrinityCore.sln\" /t:Build /p:Configuration=Release /p:Platform=Win32", trunkDir);
                }

                string cpath = VisualStudio.GetCompilerPath();

                var proc = ProcessHelper.StartProcess(cpath, Path.GetDirectoryName(cpath), args);

                proc.EnableRaisingEvents = true;

                proc.BeginOutputReadLine();

                proc.OutputDataReceived += (sender, e) =>
                {

                    progress.Report(e.Data);

                    if (token.IsCancellationRequested)
                    {

                        proc.Kill();
                        proc.Dispose();

                        token.ThrowIfCancellationRequested();

                    }

                };

                proc.WaitForExit();

                return true;

            }, token);

        }

    }
}
