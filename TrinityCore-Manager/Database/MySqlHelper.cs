using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TrinityCore_Manager.Database
{
    static class MySqlHelper
    {

        public static async Task BackupDatabase(this MySqlDatabase db, string outputFile, IProgress<int> progress, CancellationToken token)
        {

            using (var backup = new MySqlBackup(db.ConnectionString))
            {

                var tcs = new TaskCompletionSource<bool>();

                backup.ExportInfo.FileName = outputFile;
                backup.ExportInfo.AsynchronousMode = true;
                
                backup.Export();
                backup.ExportProgressChanged += (sender, e) => progress.Report(e.PercentageCompleted);
                backup.ExportCompleted += (sender, e) => tcs.SetResult(true);

                await tcs.Task;

            }

        }

        public static async Task ExecuteScript(this MySqlDatabase db, string sqlFile)
        {
            await ExecuteScript(db, new FileInfo(sqlFile));
        }

        public static async Task ExecuteScript(this MySqlDatabase db, FileInfo scriptFile)
        {

            if (!scriptFile.Exists)
                return;

            string scriptTxt = File.ReadAllText(scriptFile.FullName);

            using (var conn = new MySqlConnection(db.ConnectionString))
            {

                var script = new MySqlScript(conn, scriptTxt);

                var tcs = new TaskCompletionSource<bool>();

                script.ScriptCompleted += (sender, e) => tcs.SetResult(true);
                script.Error += (sender, e) => tcs.SetResult(true);

                script.Execute();

                await tcs.Task;

                conn.Close();

            }

        }

    }
}
