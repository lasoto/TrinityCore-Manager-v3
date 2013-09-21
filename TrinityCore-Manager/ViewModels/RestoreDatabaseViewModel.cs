using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;
using Catel.MVVM.Services;
using TrinityCore_Manager.Models;
using TrinityCore_Manager.TCM;
using TrinityCore_Manager.Database;

namespace TrinityCore_Manager.ViewModels
{
    public class RestoreDatabaseViewModel : ViewModelBase
    {

        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly IPleaseWaitService _pleaseWaitService;
        private readonly IMessageService _messageService;

        private readonly Regex _dtRegex = new Regex("[0-9]{2}-[0-9]{2}-[0-9]{2}-[0-9]{2}-[0-9]{2}-[0-9]{2}", RegexOptions.Compiled);

        private List<Backup> _backups;


        public Command DeleteBackupCommand { get; private set; }

        public Command RestoreDatabaseCommand { get; private set; }

        public RestoreDatabaseViewModel(RestoreDatabaseModel model, IUIVisualizerService uiVisualizerService, IPleaseWaitService pleaseWaitService, IMessageService messageService)
        {

            RestoreDatabase = model;

            _uiVisualizerService = uiVisualizerService;
            _pleaseWaitService = pleaseWaitService;
            _messageService = messageService;

            DeleteBackupCommand = new Command(DeleteBackup);
            RestoreDatabaseCommand = new Command(RestoreDatabaseNow);

            Init();

        }

        private async void RestoreDatabaseNow()
        {

            if (string.IsNullOrEmpty(SelectedDatabase))
            {

                _messageService.ShowError("No backup selected!");

                return;

            }

            var backup = _backups.FirstOrDefault(p => p.BackupText == SelectedDatabase);

            if (backup == null)
            {

                _messageService.ShowError("An error has occurred!");

                return;

            }

            string fName = Path.Combine(TCManager.BackupLocation, backup.FileName);

            if (!File.Exists(fName))
            {

                _messageService.ShowError("Could not find backup file!");

                return;

            }

            RestoringDatabase = true;

            Progress<int> progress = new Progress<int>(prog =>
            {
                RestoringDatabaseProgress = prog;
            });

            CancellationTokenSource cts = new CancellationTokenSource();

            switch (backup.BackupType)
            {

                case BackupType.Auth:

                    await TCManager.Instance.AuthDatabase.Restore(fName, progress, cts.Token);

                    break;

                case BackupType.Character:

                    await TCManager.Instance.CharDatabase.Restore(fName, progress, cts.Token);

                    break;

                case BackupType.World:

                    await TCManager.Instance.WorldDatabase.Restore(fName, progress, cts.Token);

                    break;


            }

            RestoringDatabase = false;
            RestoringDatabaseProgress = 0;

            _messageService.Show("Restore completed!");

        }

        private void DeleteBackup()
        {

            if (string.IsNullOrEmpty(SelectedDatabase))
            {

                _messageService.ShowError("No backup selected!");

                return;

            }

            var backup = _backups.FirstOrDefault(p => p.BackupText == SelectedDatabase);

            if (backup == null)
            {

                _messageService.ShowError("An error has occurred!");

                return;

            }

            string fName = Path.Combine(TCManager.BackupLocation, backup.FileName);

            if (!File.Exists(fName))
            {

                _messageService.ShowError("Could not find backup file!");

                return;

            }

            File.Delete(fName);

            Init();

        }

        private void Init()
        {

            if (!Directory.Exists(TCManager.BackupLocation))
                Directory.CreateDirectory(TCManager.BackupLocation);

            string[] files = Directory.GetFiles(TCManager.BackupLocation);

            const string format = "MM-dd-yy-hh-mm-ss";

            _backups = new List<Backup>();

            foreach (string file in files)
            {

                string fileName = Path.GetFileName(file);

                DateTime dt;

                string dtStr = Path.GetFileNameWithoutExtension(fileName);

                if (String.IsNullOrEmpty(dtStr))
                    continue;

                Match mat = _dtRegex.Match(dtStr);

                if (!mat.Success)
                    continue;

                if (!DateTime.TryParseExact(mat.Value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                    continue;

                string typeSub = dtStr.Substring(dtStr.LastIndexOf("-", StringComparison.Ordinal) + 1);

                BackupType bType = BackupType.Auth;

                switch (typeSub)
                {

                    case "auth":

                        bType = BackupType.Auth;

                        break;

                    case "char":

                        bType = BackupType.Character;

                        break;

                    case "world":

                        bType = BackupType.World;

                        break;

                    default:

                        bType = BackupType.Error;

                        break;

                }

                if (bType == BackupType.Error)
                    continue;

                _backups.Add(new Backup() { FileName = fileName, BackupType = bType, BackedUpOn = dt });

            }

            DatabaseFiles.Clear();

            _backups.Sort((x, y) => y.CompareTo(x));

            foreach (Backup backup in _backups)
            {

                string type;

                switch (backup.BackupType)
                {

                    case BackupType.Auth:

                        type = "Auth Database";

                        break;

                    case BackupType.Character:

                        type = "Character Database";

                        break;

                    case BackupType.World:

                        type = "World Database";

                        break;

                    default:

                        type = "ERROR";

                        break;

                }

                backup.BackupText = String.Format("{0} - {1}", backup.BackedUpOn.ToString(CultureInfo.InvariantCulture), type);

                DatabaseFiles.Add(backup.BackupText);

            }

        }

        [Model]
        public RestoreDatabaseModel RestoreDatabase
        {
            get
            {
                return GetValue<RestoreDatabaseModel>(RestoreDatabaseProperty);
            }
            set
            {
                SetValue(RestoreDatabaseProperty, value);
            }
        }

        public static readonly PropertyData RestoreDatabaseProperty = RegisterProperty("RestoreDatabase", typeof(RestoreDatabaseModel));

        [ViewModelToModel("RestoreDatabase")]
        public string AuthDatabase
        {
            get
            {
                return GetValue<string>(AuthDatabaseProperty);
            }
            set
            {
                SetValue(AuthDatabaseProperty, value);
            }
        }

        public static readonly PropertyData AuthDatabaseProperty = RegisterProperty("AuthDatabase", typeof(string));

        [ViewModelToModel("RestoreDatabase")]
        public string CharDatabase
        {
            get
            {
                return GetValue<string>(CharDatabaseProperty);
            }
            set
            {
                SetValue(CharDatabaseProperty, value);
            }
        }

        public static readonly PropertyData CharDatabaseProperty = RegisterProperty("CharDatabase", typeof(string));

        [ViewModelToModel("RestoreDatabase")]
        public string WorldDatabase
        {
            get
            {
                return GetValue<string>(WorldDatabaseProperty);
            }
            set
            {
                SetValue(WorldDatabaseProperty, value);
            }
        }

        public static readonly PropertyData WorldDatabaseProperty = RegisterProperty("WorldDatabase", typeof(string));

        [ViewModelToModel("RestoreDatabase")]
        public string SelectedDatabase
        {
            get
            {
                return GetValue<string>(SelectedDatabaseProperty);
            }
            set
            {
                SetValue(SelectedDatabaseProperty, value);
            }
        }

        public static readonly PropertyData SelectedDatabaseProperty = RegisterProperty("SelectedDatabase", typeof(string));

        [ViewModelToModel("RestoreDatabase")]
        public ObservableCollection<string> DatabaseFiles
        {
            get
            {
                return GetValue<ObservableCollection<string>>(DatabaseFilesProperty);
            }
            set
            {
                SetValue(DatabaseFilesProperty, value);
            }
        }

        public static readonly PropertyData DatabaseFilesProperty = RegisterProperty("DatabaseFiles", typeof(ObservableCollection<string>));

        public bool RestoringDatabase
        {
            get
            {
                return GetValue<bool>(RestoringDatabaseProperty);
            }
            set
            {
                SetValue(RestoringDatabaseProperty, value);
            }
        }

        public static readonly PropertyData RestoringDatabaseProperty = RegisterProperty("RestoringDatabase", typeof(bool));


        public int RestoringDatabaseProgress
        {
            get
            {
                return GetValue<int>(RestoringDatabaseProgressProperty);
            }
            set
            {
                SetValue(RestoringDatabaseProgressProperty, value);
            }
        }

        public static readonly PropertyData RestoringDatabaseProgressProperty = RegisterProperty("RestoringDatabaseProgress", typeof(int));


        class Backup : IComparable<Backup>
        {

            public string FileName { get; set; }

            public BackupType BackupType { get; set; }

            public DateTime BackedUpOn { get; set; }

            public string BackupText { get; set; }

            public int CompareTo(Backup other)
            {
                return BackedUpOn.CompareTo(other.BackedUpOn);
            }
        }

        enum BackupType
        {
            Auth,
            Character,
            World,
            Error
        }

    }
}
