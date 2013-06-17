using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;
using TrinityCore_Manager.Database;

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

        }

        private async void wizard1_WizardPageChanging(object sender, WizardCancelPageChangeEventArgs e)
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

                if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {

                    MessageBoxEx.Show(this, "You must fill in all of the Remote Access details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    e.Cancel = true;

                }
                else
                {
                    e.NewPage = mysqlDetailsPage;
                }

            }
            else if (e.OldPage == mysqlDetailsPage)
            {

                string host = mySqlHostTextBox.Text;
                int port = MySQLIntegerInputX.Value;
                string username = mySqlUsernameTextBox.Text;
                string password = mySqlPassTextBox.Text;

                if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
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

                    mySqlConnectionProgressBar.Visible = true;

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

                    mySqlConnectionProgressBar.Visible = false;

                    if (success)
                    {
                        e.NewPage = createDBsPage;
                    }
                    else
                    {

                        MessageBoxEx.Show(this, "Could not connect to MySQL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        mysqlDetailsPage.NextButtonEnabled = eWizardButtonState.True;
                    
                    }

                }

            }

        }

        private void browseButton_Click(object sender, EventArgs e)
        {

            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    string path = dialog.SelectedPath;

                    folderTextBox.Text = path;

                }

            }

        }

        private void downloadCreateDBButton_Click(object sender, EventArgs e)
        {

        }

    }
}
