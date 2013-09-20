using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Catel.Data;
using Catel.MVVM;
using Catel.MVVM.Services;
using Ookii.Dialogs.Wpf;
using TrinityCore_Manager.Clients;
using TrinityCore_Manager.Extensions;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.Models;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.TC;
using TrinityCore_Manager.TCM;
using TrinityCore_Manager.Views;

namespace TrinityCore_Manager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly IPleaseWaitService _pleaseWaitService;
        private readonly IMessageService _messageService;
        private readonly DispatcherService _dispatcherService;

        private bool _isCloning;
        private bool _isCompiling;

        private CancellationTokenSource _compilerCts;

        private DispatcherTimer _backupTimer;

        public Command ExecuteConsoleCommand { get; private set; }

        public Command StartServerCommand { get; private set; }

        public Command StopServerCommand { get; private set; }

        public Command OpenConfigurationCommand { get; private set; }

        public Command EditSettingsCommand { get; private set; }

        public Command DownloadUpdateTCCommand { get; private set; }

        public Command CompileCommand { get; private set; }

        public Command SelectCharacterCommand { get; private set; }

        public Command SetTrunkLocationCommand { get; private set; }

        public Command OpenSetupWizardCommand { get; private set; }

        public MainWindowViewModel(IUIVisualizerService uiVisualizerService, IPleaseWaitService pleaseWaitService, IMessageService messageService)
        {

            _uiVisualizerService = uiVisualizerService;
            _pleaseWaitService = pleaseWaitService;
            _messageService = messageService;

            _dispatcherService = GetService<DispatcherService>();

            Busy = false;

            _isCloning = false;
            _isCompiling = false;

            BusyProgress = 0.0;

            CompilePlatforms = new ObservableCollection<string>
            {
                "x86",
                "x64"
            };

            ExecuteConsoleCommand = new Command(ExecConsoleCommand);
            StartServerCommand = new Command(StartServer);
            StopServerCommand = new Command(StopServer);
            EditSettingsCommand = new Command(EditSettings);
            DownloadUpdateTCCommand = new Command(DownloadUpdateTC);
            CompileCommand = new Command(Compile);
            SelectCharacterCommand = new Command(SelectCharacter);
            SetTrunkLocationCommand = new Command(SetTrunkLocation);
            OpenConfigurationCommand = new Command(OpenConfiguration);
            OpenSetupWizardCommand = new Command(OpenSetupWizard);

            CheckSettings();
            InitBackupTimer();

            SetColorTheme(Settings.Default.ColorTheme);

            Application.Current.Exit += Current_Exit;
        }

        private async void Compile()
        {

            if (String.IsNullOrEmpty(Settings.Default.TrunkLocation))
            {

                _messageService.ShowError("You must first set the trunk location for TrinityCore!");

                return;

            }

            if (_isCloning)
            {

                _messageService.ShowError("Cloning in progress. Please wait until this has finished!");

                return;

            }

            if (_isCompiling)
            {

                if (_compilerCts != null)
                    _compilerCts.Cancel();

                _messageService.ShowError("Compiling has been aborted!");

                return;

            }

            if (Busy)
            {

                _messageService.ShowError("TrinityCore Manager is currently busy. Please wait.");

                return;

            }

            bool x64 = CompilePlatform.Equals("x64", StringComparison.OrdinalIgnoreCase);

            if (x64 && !Environment.Is64BitOperatingSystem)
            {

                _messageService.ShowError("Your operating system is not 64 bit!");

                return;

            }

            _compilerCts = new CancellationTokenSource();

            OutputText = String.Empty;

            var progress = new Progress<string>(prog => _dispatcherService.BeginInvoke(() =>
            {
                OutputText += prog + Environment.NewLine;
            }));

            Busy = true;
            BusyIndeterminate = true;

            _isCompiling = true;

            string temp = FileHelper.GenerateTempDirectory();

            bool result = await CMake.Generate(Settings.Default.TrunkLocation, temp, x64, progress, _compilerCts.Token);


            if (result)
            {

                _compilerCts = new CancellationTokenSource();

                result = await TCCompiler.Compile(temp, x64, progress, _compilerCts.Token);

                if (result)
                    FileHelper.CopyDirectory(Path.Combine(temp, "bin", "Release"), Settings.Default.ServerFolder);
                else
                    _messageService.ShowError("Compile has failed!");

                FileHelper.DeleteDirectory(temp);

            }
            else
            {
                _messageService.ShowError("Compile has failed!");
            }

            Busy = false;
            BusyIndeterminate = false;

            _isCompiling = false;

        }

        private void SetTrunkLocation()
        {
            var dialog = new VistaFolderBrowserDialog();
            dialog.SelectedPath = Settings.Default.TrunkLocation;

            var showDialog = dialog.ShowDialog();

            if (showDialog.HasValue && showDialog.Value)
            {
                Settings.Default.TrunkLocation = dialog.SelectedPath;
                Settings.Default.Save();
            }
        }

        private async void DownloadUpdateTC()
        {
            if (String.IsNullOrEmpty(Settings.Default.TrunkLocation))
            {
                if (_messageService.Show("You must first set your trunk location! Want to do this right now?", "Trunk location not set!", MessageButton.YesNo, MessageImage.Question) == MessageResult.Yes)
                    SetTrunkLocation();

                return;
            }

            if (_isCloning)
            {

                _messageService.ShowError("Cloning is already in progress!");

                return;

            }

            if (_isCompiling)
            {

                _messageService.ShowError("Currently compiling TrinityCore! Please wait until this has finished.");

                return;

            }

            Busy = true;
            BusyIndeterminate = true;

            _isCloning = true;

            if (new DirectoryInfo(Settings.Default.TrunkLocation).GetFiles().Length == 0)
            {

                var progress = new Progress<double>(prog => _dispatcherService.BeginInvoke(() =>
                                                    {

                                                        if (BusyIndeterminate)
                                                            BusyIndeterminate = false;

                                                        if (prog - BusyProgress > 1 || prog >= 99)
                                                        {
                                                            BusyProgress = prog;
                                                        }

                                                    }));

                await TrinityCoreRepository.Clone(Settings.Default.TrunkLocation, progress).ContinueWith(task =>
                {

                    _dispatcherService.Invoke(() =>
                    {

                        _messageService.Show("Cloning has been completed!", "Success");

                    });

                    _isCloning = false;

                });

            }
            else
            {

                BusyIndeterminate = true;
                OutputText = String.Empty;

                var progress = new Progress<string>(prog => _dispatcherService.BeginInvokeIfRequired(delegate
                {
                    OutputText += prog + Environment.NewLine;
                }));

                await TrinityCoreRepository.Pull(Settings.Default.TrunkLocation, progress).ContinueWith(task =>
                {

                    _dispatcherService.BeginInvokeIfRequired(() => _messageService.Show("The TrinityCore repository has been updated to the latest version.", "Success"));

                    _isCloning = false;

                });

            }

            BusyIndeterminate = false;
            BusyProgress = 0;
            Busy = false;

        }

        private void EditSettings()
        {
            var sm = new SettingsModel();
            sm.SelectedTheme = Settings.Default.ColorTheme;

            sm.Themes.Add("Black");
            sm.Themes.Add("Silver");
            sm.Themes.Add("Blue");

            _uiVisualizerService.ShowDialog(new SettingsViewModel(sm), (sender, e) =>
            {
                if (e.Result.HasValue && e.Result.Value)
                    SetColorTheme(sm.SelectedTheme);
            });

        }

        private void SelectCharacter()
        {
            var sm = new CharacterSelectingModel();
            //sm.SelectedTheme = Settings.Default.ColorTheme;

            //sm.Themes.Add("Black");
            //sm.Themes.Add("Silver");
            //sm.Themes.Add("Blue");

            _uiVisualizerService.ShowDialog(new CharacterSelectingViewModel(sm), (sender, e) =>
            {
                //if (e.Result.HasValue && e.Result.Value)
                //    SetColorTheme(sm.SelectedTheme);
            });

        }

        private void OpenSetupWizard()
        {
            ShowWizard();
        }

        private void SetColorTheme(string colorTheme)
        {

            Application.Current.Resources.BeginInit();
            Application.Current.Resources.MergedDictionaries.RemoveAt(1);

            switch (colorTheme.ToLower())
            {
                case "black":
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("pack://application:,,,/Fluent;component/Themes/Office2010/Black.xaml") });
                    break;
                case "silver":
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("pack://application:,,,/Fluent;component/Themes/Office2010/Silver.xaml") });
                    break;
                case "blue":
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("pack://application:,,,/Fluent;component/Themes/Office2010/Blue.xaml") });
                    break;
            }

            Application.Current.Resources.EndInit();

        }

        void Current_Exit(object sender, ExitEventArgs e)
        {

            var inst = TCManager.Instance;

            if (inst.AuthClient != null && inst.WorldClient != null && (inst.AuthClient.IsOnline || inst.WorldClient.IsOnline))
                StopServer();

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

            Version ver = Assembly.GetExecutingAssembly().GetName().Version;

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
                TCMVersion = string.Format("v{0}.{1}", ver.Major, ver.Minor)
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

            if (!File.Exists(Path.Combine(Settings.Default.ServerFolder, "authserver.exe")))
            {

                _messageService.ShowError(new Exception("The file 'authserver.exe' could not be found!"));

                return;

            }

            if (!File.Exists(Path.Combine(Settings.Default.ServerFolder, "worldserver.exe")))
            {

                _messageService.ShowError(new Exception("The file 'worldserver.exe' could not be found!"));

                return;

            }

            if (inst.AuthClient != null)
            {
                if (inst.AuthClient.IsOnline)
                {

                    MessageResult result = _messageService.Show("Authserver is already running! Kill it?", "Kill it?", MessageButton.YesNo, MessageImage.Question);

                    if (result == MessageResult.No)
                        return;

                    ProcessHelper.KillProcess(((LocalClient)inst.AuthClient).UnderlyingProcessId);

                }
            }

            if (inst.WorldClient != null)
            {
                if (inst.WorldClient.IsOnline)
                {

                    MessageResult result = _messageService.Show("Worldserver is already running! Kill it?", "Kill it?", MessageButton.YesNo, MessageImage.Question);

                    if (result == MessageResult.No)
                        return;

                    ProcessHelper.KillProcess(((LocalClient)inst.WorldClient).UnderlyingProcessId);

                }
            }

            ConsoleText = String.Empty;

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

            worldClient.DataReceived += worldClient_DataReceived;

        }

        void worldClient_DataReceived(object sender, ClientReceivedDataEventArgs e)
        {
            ConsoleText += e.Data + Environment.NewLine;
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

        private void OpenConfiguration()
        {
            if (!File.Exists(Path.Combine(Settings.Default.ServerFolder, "worldserver.conf")))
            {
                _messageService.ShowError(new Exception("The file 'worldserver.conf' could not be found!"));
                return;
            }

            try
            {
                Process.Start(Path.Combine(Settings.Default.ServerFolder, "worldserver.conf"));
            }
            catch
            {
                _messageService.ShowError("The config file could not be opened!");
            }
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

            if (TCManager.Instance.Online)
                await TCAction.ExecuteCommand(ConsoleCommand);

            ConsoleCommand = String.Empty;

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

        public string ConsoleText
        {
            get
            {
                return GetValue<string>(ConsoleTextProperty);
            }
            set
            {
                SetValue(ConsoleTextProperty, value);
            }
        }

        public static readonly PropertyData ConsoleTextProperty = RegisterProperty("ConsoleText", typeof(string));

        public string OutputText
        {
            get
            {
                return GetValue<string>(OutputTextProperty);
            }
            set
            {
                SetValue(OutputTextProperty, value);
            }
        }

        public static readonly PropertyData OutputTextProperty = RegisterProperty("OutputText", typeof(string));

        public bool Busy
        {
            get
            {
                return GetValue<bool>(BusyProperty);
            }
            set
            {
                SetValue(BusyProperty, value);
            }
        }

        public static readonly PropertyData BusyProperty = RegisterProperty("Busy", typeof(bool));

        public double BusyProgress
        {
            get
            {
                return GetValue<double>(BusyProgressProperty);
            }
            set
            {
                SetValue(BusyProgressProperty, value);
            }
        }

        public static readonly PropertyData BusyProgressProperty = RegisterProperty("BusyProgress", typeof(double));

        public bool BusyIndeterminate
        {
            get
            {
                return GetValue<bool>(BusyIndeterminateProperty);
            }
            set
            {
                SetValue(BusyIndeterminateProperty, value);
            }
        }

        public static readonly PropertyData BusyIndeterminateProperty = RegisterProperty("BusyIndeterminate", typeof(bool));

        public string CompilePlatform
        {
            get
            {
                return GetValue<string>(CompilePlatformProperty);
            }
            set
            {
                SetValue(CompilePlatformProperty, value);
            }
        }

        public static readonly PropertyData CompilePlatformProperty = RegisterProperty("CompilePlatform", typeof(string));

        public ObservableCollection<string> CompilePlatforms
        {
            get
            {
                return GetValue<ObservableCollection<string>>(CompilePlatformsProperty);
            }
            set
            {
                SetValue(CompilePlatformsProperty, value);
            }
        }

        public static readonly PropertyData CompilePlatformsProperty = RegisterProperty("CompilePlatforms", typeof(ObservableCollection<string>));

    }
}
