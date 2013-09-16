using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;
using Catel.MVVM.Services;
using MySql.Data.MySqlClient;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.Models;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.Security;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Core;

namespace TrinityCore_Manager.ViewModels
{
    public class SetupWizardViewModel : ViewModelBase
    {

        private readonly IUIVisualizerService _uiVisualizerService;
        private readonly IPleaseWaitService _pleaseWaitService;
        private readonly IMessageService _messageService;
        public Command<CancelRoutedEventArgs> Next { get; private set; }

        public Command<CancelRoutedEventArgs> Previous { get; private set; }

        public Command<CancelRoutedEventArgs> Finish { get; private set; }

        public Command AuthDB { get; private set; }

        public Command CharDB { get; private set; }

        public Command WorldDB { get; private set; }

        public SetupWizardViewModel(IUIVisualizerService uiVisualizerService, IPleaseWaitService pleaseWaitService, IMessageService messageService)
        {

            _uiVisualizerService = uiVisualizerService;
            _pleaseWaitService = pleaseWaitService;
            _messageService = messageService;

            Next = new Command<CancelRoutedEventArgs>(NextButtonPressed);
            Previous = new Command<CancelRoutedEventArgs>(PreviousButtonPressed);
            Finish = new Command<CancelRoutedEventArgs>(FinishButtonPressed);

            AuthDB = new Command(SelectAuthDB);
            CharDB = new Command(SelectCharDB);
            WorldDB = new Command(SelectWorldDB);

        }

        public SetupWizardViewModel(WizardModel model, IUIVisualizerService uiVisualizerService, IPleaseWaitService pleaseWaitService, IMessageService messageService)
            : this(uiVisualizerService, pleaseWaitService, messageService)
        {
            Wizard = model;
        }

        private void SelectAuthDB()
        {


            var selectDb = new WizardSelectDatabaseViewModel(new WizardSelectDatabaseModel(), MySQLHost, MySQLPort, MySQLUsername, MySQLPassword);

            var result = _uiVisualizerService.ShowDialog(selectDb);

            if (result.HasValue && result.Value)
            {
                SelectedAuthDB = selectDb.SelectedDatabaseName;
            }

        }

        private void SelectCharDB()
        {

            var selectDb = new WizardSelectDatabaseViewModel(new WizardSelectDatabaseModel(), MySQLHost, MySQLPort, MySQLUsername, MySQLPassword);

            var result = _uiVisualizerService.ShowDialog(selectDb);

            if (result.HasValue && result.Value)
            {
                SelectedCharDB = selectDb.SelectedDatabaseName;
            }

        }

        private void SelectWorldDB()
        {

            var selectDb = new WizardSelectDatabaseViewModel(new WizardSelectDatabaseModel(), MySQLHost, MySQLPort, MySQLUsername, MySQLPassword);

            var result = _uiVisualizerService.ShowDialog(selectDb);

            if (result.HasValue && result.Value)
            {
                SelectedWorldDB = selectDb.SelectedDatabaseName;
            }

        }

        private void NextButtonPressed(CancelRoutedEventArgs e)
        {

            var wizard = e.Source as Xceed.Wpf.Toolkit.Wizard;

            if (wizard != null)
            {

                string page = wizard.CurrentPage.Name.ToLower();

                if (page == "connectoptionpage")
                {
                    if (!ConnectLocally && !ConnectRemotely)
                    {
                        _messageService.ShowError("You must choose one of the options! If you're not sure, choose 'Locally'.");
                        e.Cancel = true;
                        return;
                    }
                }
                else if (page == "trinityinfo")
                {

                    if (ConnectLocally)
                    {

                        if (string.IsNullOrEmpty(ServerFolderLocation))
                        {

                            _messageService.ShowError("Server path cannot be empty!");

                            e.Cancel = true;

                            return;

                        }

                    }
                    else
                    {

                        if (string.IsNullOrEmpty(Host) || string.IsNullOrEmpty(Username))
                        {

                            _messageService.ShowError("All fields must be filled out!");

                            e.Cancel = true;

                            return;

                        }

                    }

                }
                else if (page == "mysqldetails")
                {

                    if (string.IsNullOrEmpty(MySQLHost) || string.IsNullOrEmpty(MySQLUsername))
                    {

                        _messageService.ShowError("All fields must be filled out!");

                        e.Cancel = true;

                        return;

                    }

                    string connectionError = String.Empty;

                    _pleaseWaitService.Show(() =>
                    {

                        var connStr = new MySqlConnectionStringBuilder();
                        connStr.Server = MySQLHost;
                        connStr.Port = (uint)MySQLPort;
                        connStr.UserID = MySQLUsername;
                        connStr.Database = "mysql";
                        connStr.Password = MySQLPassword;

                        using (var conn = new MySqlConnection(connStr.ToString()))
                        {

                            try
                            {
                                conn.Open();
                                conn.Close();
                            }
                            catch (Exception ex)
                            {
                                connectionError = ex.Message;
                            }

                        }

                    }, "Testing Connection...");

                    if (!string.IsNullOrEmpty(connectionError))
                    {

                        _messageService.ShowError(connectionError);

                        e.Cancel = true;

                    }

                }
                else if (page == "databaseselection")
                {

                    if (string.IsNullOrEmpty(SelectedAuthDB) || string.IsNullOrEmpty(SelectedCharDB) || string.IsNullOrEmpty(SelectedWorldDB))
                    {

                        _messageService.ShowError("You must choose for all databases!");

                        e.Cancel = true;

                    }

                }

            }

        }

        private void PreviousButtonPressed(CancelRoutedEventArgs e)
        {

            var wizard = e.Source as Xceed.Wpf.Toolkit.Wizard;

            if (wizard != null)
            {

                string page = wizard.CurrentPage.Name.ToLower();

            }

        }

        private void FinishButtonPressed(CancelRoutedEventArgs e)
        {

            var settings = Settings.Default;

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[1024];

            rng.GetBytes(buffer);
            string salt = BitConverter.ToString(buffer);

            rng.Dispose();

            settings.Entropy = salt;

            settings.DBHost = MySQLHost;
            settings.DBPort = MySQLPort;
            settings.DBUsername = MySQLUsername;
            settings.DBPassword = MySQLPassword.ToSecureString().EncryptString(Encoding.Unicode.GetBytes(salt));

            settings.DBAuthName = SelectedAuthDB;
            settings.DBCharName = SelectedCharDB;
            settings.DBWorldName = SelectedWorldDB;

            if (ConnectLocally)
            {
                settings.ServerType = (int)ServerType.Local;
                settings.ServerFolder = ServerFolderLocation;
            }
            else
            {
                settings.ServerType = (int)ServerType.RemoteAccess;
                settings.RAUsername = Username;
                settings.RAPassword = Password.ToSecureString().EncryptString(Encoding.Unicode.GetBytes(salt));
                settings.RAHost = Host;
                settings.RAPort = Port;
            }

            settings.Save();
            SaveAndCloseViewModel();
        }

        [Model]
        public WizardModel Wizard
        {
            get
            {
                return GetValue<WizardModel>(WizardProperty);
            }
            set
            {
                SetValue(WizardProperty, value);
            }
        }

        public static readonly PropertyData WizardProperty = RegisterProperty("Wizard", typeof(WizardModel));

        [ViewModelToModel("Wizard")]
        public bool ConnectRemotely
        {
            get
            {
                return GetValue<bool>(ConnectRemotelyProperty);
            }
            set
            {
                SetValue(ConnectRemotelyProperty, value);
            }
        }

        public static readonly PropertyData ConnectRemotelyProperty = RegisterProperty("ConnectRemotely", typeof(bool));

        [ViewModelToModel("Wizard")]
        public bool ConnectLocally
        {
            get
            {
                return GetValue<bool>(ConnectLocallyProperty);
            }
            set
            {
                SetValue(ConnectLocallyProperty, value);
            }
        }

        public static readonly PropertyData ConnectLocallyProperty = RegisterProperty("ConnectLocally", typeof(bool), true);

        [ViewModelToModel("Wizard")]
        public string ServerFolderLocation
        {
            get
            {
                return GetValue<string>(ServerFolderLocationProperty);
            }
            set
            {
                SetValue(ServerFolderLocationProperty, value);
            }
        }

        public static readonly PropertyData ServerFolderLocationProperty = RegisterProperty("ServerFolderLocation", typeof(string));

        [ViewModelToModel("Wizard")]
        public string Host
        {
            get
            {
                return GetValue<string>(HostProperty);
            }
            set
            {
                SetValue(HostProperty, value);
            }
        }

        public static readonly PropertyData HostProperty = RegisterProperty("Host", typeof(string));

        [ViewModelToModel("Wizard")]
        public int Port
        {
            get
            {
                return GetValue<int>(PortProperty);
            }
            set
            {
                SetValue(PortProperty, value);
            }
        }

        public static readonly PropertyData PortProperty = RegisterProperty("Port", typeof(int), 3443);

        [ViewModelToModel("Wizard")]
        public string Username
        {
            get
            {
                return GetValue<string>(UsernameProperty);
            }
        }

        public static readonly PropertyData UsernameProperty = RegisterProperty("Username", typeof(string));

        [ViewModelToModel("Wizard")]
        public string Password
        {
            get
            {
                return GetValue<string>(PasswordProperty);
            }
            set
            {
                SetValue(PasswordProperty, value);
            }
        }

        public static readonly PropertyData PasswordProperty = RegisterProperty("Password", typeof(string));

        [ViewModelToModel("Wizard")]
        public string MySQLHost
        {
            get
            {
                return GetValue<string>(MySQLHostProperty);
            }
            set
            {
                SetValue(MySQLHostProperty, value);
            }
        }

        public static readonly PropertyData MySQLHostProperty = RegisterProperty("MySQLHost", typeof(string));

        [ViewModelToModel("Wizard")]
        public int MySQLPort
        {
            get
            {
                return GetValue<int>(MySQLPortProperty);
            }
            set
            {
                SetValue(MySQLPortProperty, value);
            }
        }

        public static readonly PropertyData MySQLPortProperty = RegisterProperty("MySQLPort", typeof(int), 3306);

        [ViewModelToModel("Wizard")]
        public string MySQLUsername
        {
            get
            {
                return GetValue<string>(MySQLUsernameProperty);
            }
            set
            {
                SetValue(MySQLUsernameProperty, value);
            }
        }

        public static readonly PropertyData MySQLUsernameProperty = RegisterProperty("MySQLUsername", typeof(string));

        [ViewModelToModel("Wizard")]
        public string MySQLPassword
        {
            get
            {
                return GetValue<string>(MySQLPasswordProperty);
            }
            set
            {
                SetValue(MySQLPasswordProperty, value);
            }
        }

        public static readonly PropertyData MySQLPasswordProperty = RegisterProperty("MySQLPassword", typeof(string));

        [ViewModelToModel("Wizard")]
        public string SelectedAuthDB
        {
            get
            {
                return GetValue<string>(SelectedAuthDBProperty);
            }
            set
            {
                SetValue(SelectedAuthDBProperty, value);
            }
        }

        public static readonly PropertyData SelectedAuthDBProperty = RegisterProperty("SelectedAuthDB", typeof(string));

        [ViewModelToModel("Wizard")]
        public string SelectedCharDB
        {
            get
            {
                return GetValue<string>(SelectedCharDBProperty);
            }
            set
            {
                SetValue(SelectedCharDBProperty, value);
            }
        }

        public static readonly PropertyData SelectedCharDBProperty = RegisterProperty("SelectedCharDB", typeof(string));

        [ViewModelToModel("Wizard")]
        public string SelectedWorldDB
        {
            get
            {
                return GetValue<string>(SelectedWorldDBProperty);
            }
            set
            {
                SetValue(SelectedWorldDBProperty, value);
            }
        }

        public static readonly PropertyData SelectedWorldDBProperty = RegisterProperty("SelectedWorldDB", typeof(string));

    }
}
