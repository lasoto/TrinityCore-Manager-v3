using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Catel.Data;
using Catel.MVVM;
using Catel.MVVM.Services;
using TrinityCore_Manager.Clients;
using TrinityCore_Manager.Extensions;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.Models;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly IPleaseWaitService _pleaseWaitService;
        private readonly IMessageService _messageService;

        private DispatcherTimer _backupTimer;

        public Command ExecuteConsoleCommand { get; private set; }

        public Command StartServerCommand { get; private set; }

        public Command StopServerCommand { get; private set; }

        public MainWindowViewModel(IUIVisualizerService uiVisualizerService, IPleaseWaitService pleaseWaitService, IMessageService messageService)
        {

            _uiVisualizerService = uiVisualizerService;
            _pleaseWaitService = pleaseWaitService;
            _messageService = messageService;

            ExecuteConsoleCommand = new Command(ExecConsoleCommand);
            StartServerCommand = new Command(StartServer);
            StopServerCommand = new Command(StopServer);

            CheckSettings();
            InitBackupTimer();

        }

        private void InitBackupTimer()
        {

            if (Settings.Default.BackupScheduleAuth || Settings.Default.BackupScheduleChar || Settings.Default.BackupScheduleWorld)
            {

                TCManager.Instance.ScheduleBackups();

                if (_backupTimer != null)
                {
                    _backupTimer.Stop();
                }
                else
                {
                    _backupTimer = new DispatcherTimer();
                }


                _backupTimer.Tick += backupTimer_Tick;
                _backupTimer.Interval = new TimeSpan(0, 0, 1);
                _backupTimer.Start();

                BackupCountingDown = true;

            }
            else
            {
                BackupCountingDown = false;
            }

        }

        private void backupTimer_Tick(object sender, EventArgs e)
        {

            DateTimeOffset dto = TCManager.Instance.BackupNext;

            TimeSpan ts = dto - DateTime.Now;

            BackupText = String.Format("Next backup: {0}", ts.ToReadableString());

        }

        private void ShowWizard(bool exit = false)
        {

            var set = Settings.Default;

            var wm = new WizardModel
            {
                ConnectLocally = (ServerType)set.ServerType == ServerType.Local,
                ConnectRemotely = (ServerType)set.ServerType == ServerType.RemoteAccess,
                ServerFolderLocation = set.ServerFolder,
                Host = set.RAHost,
                Port = set.RAPort,
                Username = set.RAUsername,
                Password = String.Empty,
                MySQLHost = set.DBHost,
                MySQLPort = set.DBPort,
                MySQLUsername = set.DBUsername,
                MySQLPassword = String.Empty,
                SelectedAuthDB = set.DBAuthName,
                SelectedCharDB = set.DBCharName,
                SelectedWorldDB = set.DBWorldName,
            };

            var wizardView = new SetupWizardViewModel(wm, _uiVisualizerService, _pleaseWaitService, _messageService);

            var result = _uiVisualizerService.ShowDialog(wizardView);

            if (result.HasValue && result.Value)
            {
            }
            else if (exit)
            {
                Application.Current.Shutdown();
            }

        }

        private void CheckSettings()
        {

            var set = Settings.Default;

            if (String.IsNullOrEmpty(set.DBHost) || String.IsNullOrEmpty(set.DBUsername) || String.IsNullOrEmpty(set.DBPassword) || String.IsNullOrEmpty(set.DBAuthName) ||
                String.IsNullOrEmpty(set.DBCharName) || String.IsNullOrEmpty(set.DBWorldName))
            {
                ShowWizard(true);
            }
            else if ((ServerType)set.ServerType == ServerType.Local)
            {
                if (String.IsNullOrEmpty(set.ServerFolder))
                {
                    ShowWizard(true);
                }
            }
            else if ((ServerType)set.ServerType == ServerType.RemoteAccess)
            {
                if (String.IsNullOrEmpty(set.RAUsername) || String.IsNullOrEmpty(set.RAPassword))
                {
                    ShowWizard(true);
                }
            }

        }

        private void StartServer()
        {

            TCManager inst = TCManager.Instance;

            IMessageService imsgs = GetService<IMessageService>();

            if (!File.Exists(Path.Combine(Settings.Default.ServerFolder, "authserver.exe")))
            {

                imsgs.ShowError(new Exception("The file authserver.exe does not exist!"));

                return;

            }

            if (!File.Exists(Path.Combine(Settings.Default.ServerFolder, "worldserver.exe")))
            {

                imsgs.ShowError(new Exception("The file worldserver.exe does not exist!"));

                return;

            }

            if (inst.AuthClient != null)
            {
                if (inst.AuthClient.IsOnline)
                {

                    MessageResult result = imsgs.Show("Authserver is already running! Kill it?", "Kill it?", MessageButton.YesNo, MessageImage.Question);

                    if (result == MessageResult.No)
                        return;

                    ProcessHelper.KillProcess(((LocalClient)inst.AuthClient).UnderlyingProcessId);

                }
            }

            if (inst.WorldClient != null)
            {
                if (inst.WorldClient.IsOnline)
                {

                    MessageResult result = imsgs.Show("Worldserver is already running! Kill it?", "Kill it?", MessageButton.YesNo, MessageImage.Question);

                    if (result == MessageResult.No)
                        return;

                    ProcessHelper.KillProcess(((LocalClient)inst.WorldClient).UnderlyingProcessId);

                }
            }

            var authClient = new LocalClient(Path.Combine(Settings.Default.ServerFolder, "authserver.exe"));
            var worldClient = new LocalClient(Path.Combine(Settings.Default.ServerFolder, "worldserver.exe"));

            inst.AuthClient = authClient;
            inst.WorldClient = worldClient;

            AuthOnline = true;
            WorldOnline = true;
            ServerOnline = true;

            inst.AuthClient.Start();
            inst.WorldClient.Start();

            authClient.ClientExited += authClient_ClientExited;
            worldClient.ClientExited += worldClient_ClientExited;

        }

        private void StopServer()
        {

            var inst = TCManager.Instance;

            var authClient = inst.AuthClient;
            var worldClient = inst.WorldClient;

            if (authClient == null)
                throw new NullReferenceException("authClient");

            if (worldClient == null)
                throw new NullReferenceException("worldClient");


            authClient.Stop();
            worldClient.Stop();

        }

        private void worldClient_ClientExited(object sender, EventArgs e)
        {
            WorldOnline = false;
            ServerOnline = false;
        }

        private void authClient_ClientExited(object sender, EventArgs e)
        {
            AuthOnline = false;
            ServerOnline = false;
        }

        private async void ExecConsoleCommand()
        {

            ConsoleCommand = String.Empty;

            if (TCManager.Instance.Online)
                await TCAction.ExecuteCommand(ConsoleCommand);

        }

        public bool AuthOnline
        {
            get
            {
                return GetValue<bool>(AuthOnlineProperty);
            }
            set
            {
                SetValue(AuthOnlineProperty, value);
            }
        }

        public static readonly PropertyData AuthOnlineProperty = RegisterProperty("AuthOnline", typeof(bool));

        public bool WorldOnline
        {
            get
            {
                return GetValue<bool>(WorldOnlineProperty);
            }
            set
            {
                SetValue(WorldOnlineProperty, value);
            }
        }

        public static readonly PropertyData WorldOnlineProperty = RegisterProperty("WorldOnline", typeof(bool));

        public bool ServerOnline
        {
            get
            {
                return GetValue<bool>(ServerOnlineProperty);
            }
            set
            {
                SetValue(ServerOnlineProperty, value);
            }
        }

        public static readonly PropertyData ServerOnlineProperty = RegisterProperty("ServerOnline", typeof(bool));

        public bool BackupCountingDown
        {
            get
            {
                return GetValue<bool>(BackupCountingDownProperty);
            }
            set
            {
                SetValue(BackupCountingDownProperty, value);
            }
        }

        public static readonly PropertyData BackupCountingDownProperty = RegisterProperty("BackupCountingDown", typeof(bool));

        public string ConsoleCommand
        {
            get
            {
                return GetValue<string>(ConsoleCommandProperty);
            }
            set
            {
                SetValue(ConsoleCommandProperty, value);
            }
        }

        public static readonly PropertyData ConsoleCommandProperty = RegisterProperty("ConsoleCommand", typeof(string));

        public string BackupText
        {
            get
            {
                return GetValue<string>(BackupTextProperty);
            }
            set
            {
                SetValue(BackupTextProperty, value);
            }
        }

        public static readonly PropertyData BackupTextProperty = RegisterProperty("BackupText", typeof(string));

    }
}
