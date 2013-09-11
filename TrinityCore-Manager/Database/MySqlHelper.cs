using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TrinityCore_Manager.TCM;
using System.Diagnostics;
using TrinityCore_Manager.Misc;

namespace TrinityCore_Manager.Database
{
    static class MySqlHelper
    {

        public static async Task BackupDatabase(this MySqlDatabase db, string outputFile, CancellationToken token)
        {

            await Task.Run(() =>
            {

                string mdump = TCManager.MySQLDumpLocation;
                string args = String.Format("/c \"{0}\" -u {1} -p{2} -h {3} -P {4} {5}", mdump, db.Username, db.Password, db.Host, db.Port, db.DatabaseName);

                if (!File.Exists(mdump))
                    return;

                Process dumpProc = ProcessHelper.StartProcess("cmd.exe", Path.GetDirectoryName(outputFile), args);

                StreamReader reader = dumpProc.StandardOutput;
                
                StreamWriter writer = new StreamWriter(outputFile);

                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }

                dumpProc.WaitForExit();

                writer.Flush();
                writer.Close();
                writer.Dispose();

            });

        }

        //public static async Task BackupDatabaseStructure(this MySqlDatabase db, string outputFile, IProgress<int> progress, CancellationToken token)
        //{

        //    await Task.Run(() =>
        //    {

        //        using (var backup = new MySqlBackup(db.ConnectionString))
        //        {

        //            var tcs = new TaskCompletionSource<bool>();

        //            backup.ExportInfo.FileName = outputFile;
        //            backup.ExportInfo.AddCreateDatabase = true;
        //            backup.ExportInfo.AsynchronousMode = true;
        //            backup.ExportInfo.AutoCloseConnection = true;
        //            backup.ExportInfo.CalculateTotalRowsFromDatabase = false;
        //            backup.ExportInfo.ExportEvents = false;
        //            backup.ExportInfo.ExportFunctions = false;
        //            backup.ExportInfo.ExportRows = false;
        //            backup.ExportInfo.ExportStoredProcedures = false;
        //            backup.ExportInfo.ExportTableStructure = true;
        //            backup.ExportInfo.ExportTriggers = false;
        //            backup.ExportInfo.ExportViews = false;
        //            backup.ExportInfo.MaxSqlLength = 10000000;
        //            backup.ExportInfo.ZipOutputFile = false;

        //            backup.Export();

        //            backup.ExportProgressChanged += (sender, e) =>
        //            {

        //                progress.Report(e.PercentageCompleted);

        //                if (token.IsCancellationRequested)
        //                {
        //                    Thread.CurrentThread.Abort();
        //                }

        //            };

        //            backup.ExportCompleted += (sender, e) => tcs.SetResult(true);

        //            tcs.Task.Wait();

        //        }

        //    });

        //}

        //public static async Task BackupDatabase(this MySqlDatabase db, string outputFile, IProgress<int> progress, CancellationToken token)
        //{

        //    await Task.Run(() =>
        //    {

        //        using (var backup = new MySqlBackup(db.ConnectionString))
        //        {

        //            var tcs = new TaskCompletionSource<bool>();

        //            backup.ExportInfo.FileName = outputFile;
        //            backup.ExportInfo.AddCreateDatabase = false;
        //            backup.ExportInfo.AsynchronousMode = true;
        //            backup.ExportInfo.AutoCloseConnection = true;
        //            backup.ExportInfo.CalculateTotalRowsFromDatabase = true;
        //            backup.ExportInfo.ExportEvents = true;
        //            backup.ExportInfo.ExportFunctions = true;
        //            backup.ExportInfo.ExportRows = true;
        //            backup.ExportInfo.ExportStoredProcedures = true;
        //            backup.ExportInfo.ExportTableStructure = false;
        //            backup.ExportInfo.ExportTriggers = true;
        //            backup.ExportInfo.ExportViews = true;
        //            backup.ExportInfo.MaxSqlLength = 10000000;
        //            backup.ExportInfo.ZipOutputFile = false;

        //            backup.Export();

        //            backup.ExportProgressChanged += (sender, e) =>
        //            {

        //                progress.Report(e.PercentageCompleted);

        //                if (token.IsCancellationRequested)
        //                {
        //                    Thread.CurrentThread.Abort();
        //                }

        //            };

        //            backup.ExportCompleted += (sender, e) => tcs.SetResult(true);

        //            tcs.Task.Wait();

        //        }

        //    });

        //}

        public static async Task Restore(this MySqlDatabase db, string inputFile, IProgress<int> progress, CancellationToken token)
        {

            await db.ExecuteScript("SET GLOBAL max_allowed_packet = 1024*1024*1024;");

            await Task.Run(() =>
            {

                using (var backup = new MySqlBackup(db.ConnectionString))
                {

                    var tcs = new TaskCompletionSource<bool>();

                    backup.ImportInfo.FileName = inputFile;
                    backup.ImportInfo.AsynchronousMode = true;
                    backup.ImportInfo.AutoCloseConnection = true;
                    backup.ImportInfo.IgnoreSqlError = true;

                    backup.Import();
                    backup.ImportProgressChanged += (sender, e) => progress.Report(e.PercentageCompleted);
                    backup.ImportCompleted += (sender, e) => tcs.SetResult(true);

                    tcs.Task.Wait();

                }

            });

        }

        public static async Task ExecuteScript(this MySqlDatabase db, FileInfo sqlFile)
        {
            await ExecuteScript(db, File.ReadAllText(sqlFile.FullName));
        }

        public static async Task ExecuteScript(this MySqlDatabase db, string sql)
        {

            await Task.Run(() =>
            {

                using (var conn = new MySqlConnection(db.ConnectionString))
                {

                    var script = new MySqlScript(conn, sql);

                    var tcs = new TaskCompletionSource<bool>();

                    script.ScriptCompleted += (sender, e) => tcs.SetResult(true);
                    script.Error += (sender, e) => tcs.SetResult(true);

                    script.Execute();

                    tcs.Task.Wait();

                    conn.Close();

                }

            });

        }

        public static async Task<bool> TestConnection(this MySqlDatabase db)
        {

            return await Task.Run(() =>
            {
                using (var conn = new MySqlConnection(db.ConnectionString))
                {

                    try
                    {

                        conn.Open();

                        conn.Close();

                        return true;

                    }
                    catch (Exception)
                    {
                        return false;
                    }

                }
            });

        }

    }
}
