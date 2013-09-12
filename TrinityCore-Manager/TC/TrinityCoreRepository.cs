using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager.TC
{

    static class TrinityCoreRepository
    {

        private const string TrinityCoreGit = "git://github.com/TrinityCore/TrinityCore.git";

        public static async Task Clone(string cloneTo, IProgress<double> progress)
        {

            await Task.Run(() =>
            {

                var thandler = new TransferProgressHandler(h =>
                {

                    progress.Report(((double)h.ReceivedObjects / h.TotalObjects) * 100);

                    return 0;

                });

                var chandler = new CheckoutProgressHandler((path, completedSteps, totalSteps) =>

                    progress.Report(((double)completedSteps / totalSteps) * 100)

                );

                Repository.Clone(TrinityCoreGit, cloneTo, false, true, thandler, chandler);

            });

        }

        public static async Task Pull(string gitDir, IProgress<string> progress)
        {

            await Task.Run(() =>
            {

                string args = String.Format("/c \"{0}\" pull -v --progress", GetGitLocation());

                Process pullProc = ProcessHelper.StartProcess("cmd.exe", gitDir, args);

                pullProc.BeginErrorReadLine();
                pullProc.BeginOutputReadLine();

                pullProc.ErrorDataReceived += (sender, e) => progress.Report(e.Data);
                pullProc.OutputDataReceived += (sender, e) => progress.Report(e.Data);

                pullProc.WaitForExit();

            });

        }

        private static string GetGitLocation()
        {

            string git;

            if (Environment.Is64BitOperatingSystem)
            {
                git = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Git",
                "bin", "git.exe");
            }
            else
            {
                git = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Git", "bin",
                "git.exe");
            }

            if (!File.Exists(git))
                return String.Empty;

            return git;

        }

    }

}
