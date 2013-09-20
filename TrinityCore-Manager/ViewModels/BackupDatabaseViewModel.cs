using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;
using Catel.MVVM.Services;
using TrinityCore_Manager.Database;
using TrinityCore_Manager.Models;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager.ViewModels
{
    public class BackupDatabaseViewModel : ViewModelBase
    {

        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly IPleaseWaitService _pleaseWaitService;
        private readonly IMessageService _messageService;

        private bool _busy;

        private CancellationTokenSource _cts;

        public Command BackupNowCommand { get; private set; }

        public Command SaveCommand { get; private set; }

        private const string Format = "MM-dd-yy-hh-mm-ss";

        public BackupDatabaseViewModel(BackupDatabaseModel model, IUIVisualizerService uiVisualizerService, IPleaseWaitService pleaseWaitService, IMessageService messageService)
        {

            BackupDatabase = model;

            _uiVisualizerService = uiVisualizerService;
            _pleaseWaitService = pleaseWaitService;
            _messageService = messageService;

            _busy = false;

            BackupNowCommand = new Command(BackupNow);
            SaveCommand = new Command(SaveAndClose);


        }

        private async void BackupNow()
        {

            if (!AuthSelected && !CharSelected && !WorldSelected)
            {

                _messageService.ShowError("You must select a database to backup!");

                return;

            }

            _pleaseWaitService.Show("Exporting...");

            _busy = true;

            _cts = new CancellationTokenSource();

            string nowStr = DateTime.Now.ToString(Format);

            try
            {
                if (AuthSelected)
                {
                    await TCManager.Instance.AuthDatabase.BackupDatabase(Path.Combine(TCManager.BackupLocation, String.Format("{0}-auth.sql", nowStr)), _cts.Token);
                }

                if (CharSelected)
                {
                    await TCManager.Instance.CharDatabase.BackupDatabase(Path.Combine(TCManager.BackupLocation, String.Format("{0}-char.sql", nowStr)), _cts.Token);
                }

                if (WorldSelected)
                {
                    await TCManager.Instance.WorldDatabase.BackupDatabase(Path.Combine(TCManager.BackupLocation, String.Format("{0}-world.sql", nowStr)), _cts.Token);
                }
            }
            catch (Exception)
            {
            }

            _busy = false;

            _pleaseWaitService.Hide();

            _messageService.Show("Backup completed!");

        }

        private void SaveAndClose()
        {
            SaveAndCloseViewModel();
        }

        [Model]
        public BackupDatabaseModel BackupDatabase
        {
            get
            {
                return GetValue<BackupDatabaseModel>(BackupDatabaseProperty);
            }
            set
            {
                SetValue(BackupDatabaseProperty, value);
            }
        }

        public static readonly PropertyData BackupDatabaseProperty = RegisterProperty("BackupDatabase", typeof(BackupDatabaseModel));

        [ViewModelToModel("BackupDatabase")]
        public bool AuthSelected
        {
            get
            {
                return GetValue<bool>(AuthSelectedProperty);
            }
            set
            {
                SetValue(AuthSelectedProperty, value);
            }
        }

        public static readonly PropertyData AuthSelectedProperty = RegisterProperty("AuthSelected", typeof(bool));

        [ViewModelToModel("BackupDatabase")]
        public bool CharSelected
        {
            get
            {
                return GetValue<bool>(CharSelectedProperty);
            }
            set
            {
                SetValue(CharSelectedProperty, value);
            }
        }

        public static readonly PropertyData CharSelectedProperty = RegisterProperty("CharSelected", typeof(bool));

        [ViewModelToModel("BackupDatabase")]
        public bool WorldSelected
        {
            get
            {
                return GetValue<bool>(WorldSelectedProperty);
            }
            set
            {
                SetValue(WorldSelectedProperty, value);
            }
        }

        public static readonly PropertyData WorldSelectedProperty = RegisterProperty("WorldSelected", typeof(bool));

        [ViewModelToModel("BackupDatabase")]
        public bool BackupsScheduled
        {
            get
            {
                return GetValue<bool>(BackupScheduledProperty);
            }
            set
            {

                if (!value)
                {
                    AuthSelected = false;
                    CharSelected = false;
                    WorldSelected = false;
                }

                SetValue(BackupScheduledProperty, value);
            
            }
        }

        public static PropertyData BackupScheduledProperty = RegisterProperty("BackupsScheduled", typeof(bool));

        [ViewModelToModel("BackupDatabase")]
        public int BackupDays
        {
            get
            {
                return GetValue<int>(BackupDaysProperty);
            }
            set
            {
                SetValue(BackupDaysProperty, value);
            }
        }

        public static PropertyData BackupDaysProperty = RegisterProperty("BackupDays", typeof(int));

        [ViewModelToModel("BackupDatabase")]
        public int BackupHours
        {
            get
            {
                return GetValue<int>(BackupHoursProperty);
            }
            set
            {
                SetValue(BackupHoursProperty, value);
            }
        }

        public static PropertyData BackupHoursProperty = RegisterProperty("BackupHours", typeof(int));

        [ViewModelToModel("BackupDatabase")]
        public int BackupMinutes
        {
            get
            {
                return GetValue<int>(BackupMinutesProperty);
            }
            set
            {
                SetValue(BackupMinutesProperty, value);
            }
        }

        public static PropertyData BackupMinutesProperty = RegisterProperty("BackupMinutes", typeof(int));

    }
}
