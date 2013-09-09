using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.Security;

namespace TrinityCore_Manager
{
    public partial class SetupWizard : DevComponents.DotNetBar.Office2007Form
    {

        public bool Result { get; set; }

        public SetupWizard()
        {
            InitializeComponent();
        }

        private void SetupWizard_Load(object sender, EventArgs e)
        {

            var settings = Settings.Default;

            if (settings.ServerType == (int)ServerType.Local)
            {
                localCheckBox.Checked = true;
            }
            else
            {
                remoteCheckBox.Checked = true;
            }

            folderTextBox.Text = settings.ServerFolder;

            hostTextBox.Text = settings.RAHost;
            portIntegerInput.Value = settings.RAPort;
            usernameTextBox.Text = settings.RAUsername;
            passwordTextBox.Text = "";
            autoConnectCheckBox.Checked = settings.RAAutoConnect;

            mySqlHostTextBox.Text = settings.DBHost;
            MySQLIntegerInputX.Value = settings.DBPort;
            mySqlUsernameTextBox.Text = settings.DBUsername;
            mySqlPassTextBox.Text = "";

            authDBTextBox.Text = settings.DBAuthName;
            charactersDBTextBox.Text = settings.DBCharName;
            worldDBTextBox.Text = settings.DBWorldName;


        }

        private async void wizard1_WizardPageChanging(object sender, WizardCancelPageChangeEventArgs e)
        {

            if (e.PageChangeSource == eWizardPageChangeSource.NextButton)
            {

                if (e.OldPage == connectOptionPage)
                {

                    if (remoteCheckBox.Checked)
                    {
                        e.NewPage = raDetailsPage;
                    }
                    else if (localCheckBox.Checked)
                    {
                        e.NewPage = trinitySFolderPage;
                    }
                    else
                    {

                        MessageBoxEx.Show(this, "You must select one of the options before continuing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        e.Cancel = true;

                    }

                }
                else if (e.OldPage == trinitySFolderPage)
                {

                    if (string.IsNullOrEmpty(folderTextBox.Text))
                    {

                        MessageBoxEx.Show(this, "You must select the folder for TrinityCore", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        e.Cancel = true;

                    }
                    else
                    {
                        e.NewPage = mysqlDetailsPage;
                    }

                }
                else if (e.OldPage == raDetailsPage)
                {

                    string host = hostTextBox.Text;
                    int port = portIntegerInput.Value;
                    string username = usernameTextBox.Text;
                    string password = passwordTextBox.Text;

                    if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(port.ToString()))
                    {
                        MessageBoxEx.Show(this, "You must fill in all of the Remote Access details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else
                        e.NewPage = mysqlDetailsPage;

                }
                else if (e.OldPage == mysqlDetailsPage)
                {

                    string host = mySqlHostTextBox.Text;
                    int port = MySQLIntegerInputX.Value;
                    string username = mySqlUsernameTextBox.Text;
                    string password = mySqlPassTextBox.Text;

                    if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(port.ToString()))
                    {
                        MessageBoxEx.Show(this, "MySQL details required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else
                    {
                        var connStr = new MySqlConnectionStringBuilder();
                        connStr.Server = host;
                        connStr.Port = (uint)port;
                        connStr.UserID = username;
                        connStr.Password = password;
                        connStr.Database = "mysql";

                        mySqlConnectionProgressBar2.Visible = true;

                        mysqlDetailsPage.NextButtonEnabled = eWizardButtonState.False;
                        e.Cancel = true;

                        bool success = await Task.Run(() =>
                        {
                            using (var conn = new MySqlConnection(connStr.ToString()))
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

                        mySqlConnectionProgressBar2.Visible = false;

                        if (success)
                        {
                            wizard1.SelectedPage = createDBsPage;
                        }
                        else
                        {
                            MessageBoxEx.Show(this, "Could not connect to MySQL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        mysqlDetailsPage.NextButtonEnabled = eWizardButtonState.True;

                    }
                }
                else if (e.OldPage == dbDetailsPage)
                {
                    if (string.IsNullOrEmpty(authDBTextBox.Text) || string.IsNullOrEmpty(charactersDBTextBox.Text) || string.IsNullOrEmpty(worldDBTextBox.Text))
                    {
                        MessageBoxEx.Show(this, "Everything must be filled out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else
                    {
                        try
                        {
                            var connStr = new MySqlConnectionStringBuilder();
                            string host = mySqlHostTextBox.Text;
                            int port = MySQLIntegerInputX.Value;
                            string username = mySqlUsernameTextBox.Text;
                            string password = mySqlPassTextBox.Text;

                            connStr.Server = mySqlHostTextBox.Text;
                            connStr.Port = (uint)MySQLIntegerInputX.Value;
                            connStr.UserID = mySqlUsernameTextBox.Text;
                            connStr.Password = mySqlPassTextBox.Text;

                            connStr.Database = authDBTextBox.Text;
                            using (var conn = new MySqlConnection(connStr.ToString()))
                                conn.Open();

                            connStr.Database = worldDBTextBox.Text;
                            using (var conn = new MySqlConnection(connStr.ToString()))
                                conn.Open();

                            connStr.Database = charactersDBTextBox.Text;
                            using (var conn = new MySqlConnection(connStr.ToString()))
                                conn.Open();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message, "Could not connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                        }
                    }
                }
            }
            else if (e.PageChangeSource == eWizardPageChangeSource.BackButton)
            {
                if (e.OldPage == createDBsPage)
                    e.NewPage = mysqlDetailsPage;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (folderTextBox.Text.Length > 0 && Directory.Exists(folderTextBox.Text))
                    dialog.SelectedPath = folderTextBox.Text;

                if (dialog.ShowDialog() == DialogResult.OK)
                    folderTextBox.Text = dialog.SelectedPath;
            }
        }

        private void downloadCreateDBButton_Click(object sender, EventArgs e)
        {

            createDBsPage.NextButtonEnabled = eWizardButtonState.False;
            downloadProgressBar2.Visible = true;
        }

        private void wizard1_FinishButtonClick(object sender, CancelEventArgs e)
        {

            var settings = Settings.Default;

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[1024];

            rng.GetBytes(buffer);
            string salt = BitConverter.ToString(buffer);

            settings.Entropy = salt;

            settings.DBHost = mySqlHostTextBox.Text;
            settings.DBPort = MySQLIntegerInputX.Value;
            settings.DBUsername = mySqlUsernameTextBox.Text;
            settings.DBPassword = mySqlPassTextBox.Text.ToSecureString().EncryptString(Encoding.Unicode.GetBytes(salt));
            settings.DBAuthName = authDBTextBox.Text;
            settings.DBCharName = charactersDBTextBox.Text;
            settings.DBWorldName = worldDBTextBox.Text;

            if (localCheckBox.Checked)
            {
                settings.ServerType = (int)ServerType.Local;
                settings.ServerFolder = folderTextBox.Text;
            }
            else
            {
                settings.ServerType = (int)ServerType.RemoteAccess;
                settings.RAUsername = usernameTextBox.Text;
                settings.RAPassword = passwordTextBox.Text.ToSecureString().EncryptString(Encoding.Unicode.GetBytes(salt));
                settings.RAHost = hostTextBox.Text;
                settings.RAPort = portIntegerInput.Value;
                settings.RAAutoConnect = autoConnectCheckBox.Checked;
            }

            Result = true;

            settings.Save();

            Close();

        }

        private void wizard1_CancelButtonClick(object sender, CancelEventArgs e)
        {
            if (MessageBoxEx.Show(this, "Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void mysqlDetailsPage_Click(object sender, EventArgs e)
        {

        }

        private void wizard1_Load(object sender, EventArgs e)
        {

        }

    }
}
