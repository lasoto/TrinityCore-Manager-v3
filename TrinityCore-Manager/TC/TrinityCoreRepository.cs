using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibGit2Sharp;
using LibGit2Sharp.Handlers;

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

                using (var repo = Repository.Clone(TrinityCoreGit, cloneTo, false, true, thandler, chandler))
                {
                }

            });

        }

        public static async Task Fetch(string gitDir, IProgress<double> progress)
        {

            await Task.Run(() =>
            {

                var thandler = new TransferProgressHandler(h =>
                {

                    progress.Report(((double)h.ReceivedObjects / h.TotalObjects) * 100);

                    return 0;

                });

                using (var repo = new Repository(gitDir))
                {
                    repo.Network.Fetch(repo.Head.Remote, TagFetchMode.All, null, null, null, thandler);
                }

            });

        }

    }

}
