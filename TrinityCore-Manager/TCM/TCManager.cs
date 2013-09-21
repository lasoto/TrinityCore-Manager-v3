using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Quartz;
using Quartz.Impl;
using TrinityCore_Manager.Database;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.Security;
using System.Diagnostics;

namespace TrinityCore_Manager.TCM
{
    class TCManager
    {

        private static object _lock = new object();

        private static TCManager _instance;

        public static TCManager Instance
        {
            get
            {
                lock (_lock)
                {

                    if (_instance == null)
                    {
                        _instance = new TCManager();
                    }

                    return _instance;

                }
            }
        }

        public TCMClient AuthClient { get; set; }
        public TCMClient WorldClient { get; set; }

        public TCMClient RAClient { get; set; }

        public AuthDatabase AuthDatabase { get; set; }
        public CharDatabase CharDatabase { get; set; }
        public WorldDatabase WorldDatabase { get; set; }

        public static readonly string BackupLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TCM", "Backups");
        public static readonly string MySQLDumpLocation = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), "mysql", "mysqldump.exe");

        public bool Online
        {
            get
            {
                return ((ServerType)Settings.Default.ServerType) == ServerType.Local ? AuthClient != null && AuthClient.IsOnline && WorldClient != null && WorldClient.IsOnline : RAClient != null && RAClient.IsOnline;
            }
        }

        public DateTimeOffset BackupNext
        {
            get
            {

                TriggerKey key = null;

                if (_triggers.ContainsKey("auth"))
                    key = _triggers["auth"];
                else if (_triggers.ContainsKey("char"))
                    key = _triggers["char"];
                else if (_triggers.ContainsKey("world"))
                    key = _triggers["world"];
                else
                    return DateTime.Now;

                if (key == null)
                    return DateTime.Now;

                ITrigger trigger = _scheduler.GetTrigger(key);

                if (trigger == null)
                    return DateTime.Now;

                DateTimeOffset? dton = trigger.GetNextFireTimeUtc();

                if (dton == null)
                    return DateTime.Now;

                DateTimeOffset dto = dton.Value;

                return dto;

            }
        }

        private IScheduler _scheduler;
        private Dictionary<string, TriggerKey> _triggers;

        public TCManager()
        {
            var set = Settings.Default;
            AuthDatabase = new AuthDatabase(set.DBHost, set.DBPort, set.DBUsername, set.DBPassword.DecryptString(Encoding.Unicode.GetBytes(set.Entropy)).ToInsecureString(), set.DBAuthName);
            CharDatabase = new CharDatabase(set.DBHost, set.DBPort, set.DBUsername, set.DBPassword.DecryptString(Encoding.Unicode.GetBytes(set.Entropy)).ToInsecureString(), set.DBCharName);
            WorldDatabase = new WorldDatabase(set.DBHost, set.DBPort, set.DBUsername, set.DBPassword.DecryptString(Encoding.Unicode.GetBytes(set.Entropy)).ToInsecureString(), set.DBWorldName);
            _triggers = new Dictionary<string, TriggerKey>();
        }

        public void ScheduleBackups()
        {

            StopScheduledBackups();

            ISchedulerFactory schedFact = new StdSchedulerFactory();

            _scheduler = schedFact.GetScheduler();
            _scheduler.Start();

            Settings.Default.Reload();

            int total = (int)TimeSpan.FromDays(Settings.Default.BackupDays).TotalMinutes;
            total += (int)TimeSpan.FromHours(Settings.Default.BackupHours).TotalMinutes;
            total += Settings.Default.BackupMinutes;

            if (Settings.Default.BackupScheduleAuth)
                CreateBackup("auth", AuthDatabase, total);

            if (Settings.Default.BackupScheduleChar)
                CreateBackup("char", CharDatabase, total);

            if (Settings.Default.BackupScheduleWorld)
                CreateBackup("world", WorldDatabase, total);

        }

        public void StopScheduledBackups()
        {

            if (!_triggers.Any())
                return;

            _scheduler.UnscheduleJobs(_triggers.Values.ToList());
            _scheduler.Clear();
            _scheduler.Shutdown();
        
            _triggers.Clear();
        
        }

        private void CreateBackup(string name, MySqlDatabase db, int intervalInMins)
        {

            IJobDetail job = JobBuilder.Create<BackupDBJob>()
                        .WithIdentity("backupjob_" + name, "backup")
                        .Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("backupjob_" + name, "backup")
                .StartAt(DateBuilder.FutureDate(intervalInMins, IntervalUnit.Minute))
                .WithSimpleSchedule(x => x.RepeatForever().WithIntervalInMinutes(intervalInMins)).Build();

            job.JobDataMap["backupname"] = name;
            job.JobDataMap["backupdb"] = db;

            _scheduler.ScheduleJob(job, trigger);

            _triggers.Add(name, trigger.Key);

        }

        private class BackupDBJob : IJob
        {
            public async void Execute(IJobExecutionContext context)
            {

                const string format = "MM-dd-yy-hh-mm-ss";

                var map = context.JobDetail.JobDataMap;

                string file = Path.Combine(BackupLocation, String.Format("{0}-{1}.sql", DateTime.Now.ToString(format), map["backupname"]));

                var db = (MySqlDatabase)map["backupdb"];

                await db.BackupDatabase(file, new CancellationToken());

            }
        }

    }

}
