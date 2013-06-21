using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DevComponents.DotNetBar;
using Microsoft.Win32;
using TrinityCore_Manager.Compile_Forms;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.Database;
using TrinityCore_Manager.Security;
using TrinityCore_Manager.TC;
using TrinityCore_Manager.TCP;

namespace TrinityCore_Manager
{
    public partial class MainForm : Office2007RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private TCClient _raClient;

        private bool _isCloning;
        private bool _isCompiling;

        private CancellationTokenSource _compilerCTS;

        private void MainForm_Load(object sender, EventArgs e)
        {

            _isCloning = false;

            SetInitial();
            CheckSettings();
            Init();

        }

        private void SetInitial()
        {
            platformComboBox.SelectedIndex = 0;
        }

        private void Init()
        {

            if (Settings.Default.ServerType == (int)ServerType.RemoteAccess)
            {

                startServerButton.Enabled = false;
                stopServerButton.Enabled = false;
                openConfigurationFileButton.Enabled = false;
                raTabItem.Visible = true;

                //if (Settings.Default.RAAutoConnect)
                ConnectRA();

            }
            else
            {
                worldServerTab.Visible = true;
                authServerTab.Visible = true;
            }

        }

        private void ConnectRA()
        {

            _raClient = new TCClient(Settings.Default.RAHost, Settings.Default.RAPort);

            try
            {
                _raClient.Connect();
            }
            catch (Exception ex)
            {

                _raClient.Dispose();

                MessageBoxEx.Show(this, "Could not connect to RA! (" + ex.Message + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void DisableAll()
        {
        }

        private void CheckSettings(bool exit = false)
        {

            var set = Settings.Default;

            if (string.IsNullOrEmpty(set.DBHost) || string.IsNullOrEmpty(set.DBUsername) || string.IsNullOrEmpty(set.DBPassword) || string.IsNullOrEmpty(set.DBAuthName) ||
                string.IsNullOrEmpty(set.DBCharName) || string.IsNullOrEmpty(set.DBWorldName))
            {

                if (!exit)
                {
                    using (var wizard = new SetupWizard())
                    {
                        Hide();
                        wizard.FormClosing += wizard_FormClosing;
                        wizard.ShowDialog();
                    }
                }
                else
                {
                    Application.Exit();
                }

            }
            else if ((ServerType)set.ServerType == ServerType.Local)
            {
                if (string.IsNullOrEmpty(set.ServerFolder))
                {
                    if (!exit)
                    {
                        using (var wizard = new SetupWizard())
                        {
                            Hide();
                            wizard.FormClosing += wizard_FormClosing;
                            wizard.ShowDialog();
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else if ((ServerType)set.ServerType == ServerType.RemoteAccess)
            {
                if (string.IsNullOrEmpty(set.RAUsername) || string.IsNullOrEmpty(set.RAPassword))
                {
                    if (!exit)
                    {
                        using (var wizard = new SetupWizard())
                        {
                            Hide();
                            wizard.FormClosing += wizard_FormClosing;
                            wizard.ShowDialog();
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }

        }

        void wizard_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Show();

            var sw = (SetupWizard)sender;

            if (!sw.Result)
            {
                Application.Exit();
            }
            else
            {
                CheckSettings(true);
            }

        }

        private void otherCommandsButton_Click(object sender, EventArgs e)
        {
            OtherCommands otherCommands = new OtherCommands();
            otherCommands.ShowDialog();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.ShowDialog();
        }

        private void editAccountButton_Click(object sender, EventArgs e)
        {
            EditAccount editAccount = new EditAccount();
            editAccount.ShowDialog();
        }

        private void addAccountBanButton_Click(object sender, EventArgs e)
        {
            AddAccountBan addAccBan = new AddAccountBan();
            addAccBan.ShowDialog();
        }

        private void removeAccountBanButton_Click(object sender, EventArgs e)
        {
            RemoveAccountBan removeAccBan = new RemoveAccountBan();
            removeAccBan.ShowDialog();
        }

        private void addIpBanButton_Click(object sender, EventArgs e)
        {
            AddIPBan addIpBan = new AddIPBan();
            addIpBan.ShowDialog();
        }

        private void removeIpBanButton_Click(object sender, EventArgs e)
        {
            RemoveIPBan removeIpBan = new RemoveIPBan();
            removeIpBan.ShowDialog();
        }

        private void accountCleanupButton_Click(object sender, EventArgs e)
        {
            AccountCleanup accCleanup = new AccountCleanup();
            accCleanup.ShowDialog();
        }

        private void showPlayerInfoButton_Click(object sender, EventArgs e)
        {
            PlayerInformation playerInfo = new PlayerInformation();
            playerInfo.ShowDialog();
        }

        private void setLevelButton_Click(object sender, EventArgs e)
        {
            CharacterSetLevel setLevel = new CharacterSetLevel();
            setLevel.ShowDialog();
        }

        private void setReputationButton_Click(object sender, EventArgs e)
        {
            CharacterSetReputation setReputation = new CharacterSetReputation();
            setReputation.ShowDialog();
        }

        private void setSkillLevelButton_Click(object sender, EventArgs e)
        {
            CharacterSetSkillLevel setSkill = new CharacterSetSkillLevel();
            setSkill.ShowDialog();
        }

        private void createItemButton_Click(object sender, EventArgs e)
        {
            CreateItem createItem = new CreateItem();
            createItem.ShowDialog();
        }

        private void createNpcButton_Click(object sender, EventArgs e)
        {
            CreateNPC createNPC = new CreateNPC();
            createNPC.ShowDialog();
        }

        private void findFirstUnusedGuidForNpcButton_Click(object sender, EventArgs e)
        {
            FindGUID findGUID = new FindGUID();
            findGUID.ShowDialog();
        }

        private void findNpcButton_Click(object sender, EventArgs e)
        {
            FindNPC findNPC = new FindNPC();
            findNPC.ShowDialog();
        }

        private void findItemButton_Click(object sender, EventArgs e)
        {
            FindItem findItem = new FindItem();
            findItem.ShowDialog();
        }

        private void createGuildButton_Click(object sender, EventArgs e)
        {
            CreateGuild createGuild = new CreateGuild();
            createGuild.ShowDialog();
        }

        private void editGuildButton_Click(object sender, EventArgs e)
        {
            EditGuild editGuild = new EditGuild();
            editGuild.ShowDialog();
        }

        private void deleteGuildButton_Click(object sender, EventArgs e)
        {
            DeleteGuild deleteGuild = new DeleteGuild();
            deleteGuild.ShowDialog();
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            SendMail sendMail = new SendMail();
            sendMail.ShowDialog();
        }

        private void startEventButton_Click(object sender, EventArgs e)
        {
            EventStart eventStart = new EventStart();
            eventStart.ShowDialog();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void eventActiveButton_Click(object sender, EventArgs e)
        {
            EventActiveList evActList = new EventActiveList();
            evActList.ShowDialog();
        }

        private void openConfigurationFileButton_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Settings.Default.ServerFolder, "worldserver.conf");
            Process.Start("notepad.exe", path);
        }

        private async void cleanWorldButton_Click(object sender, EventArgs e)
        {
            await TCManager.Instance.WorldDatabase.CleanWorld();
        }

        private void setupWizardButton_Click(object sender, EventArgs e)
        {
            using (var sWizard = new SetupWizard())
            {
                sWizard.FormClosing += sWizard_FormClosing;
                sWizard.ShowDialog();
            }
        }

        void sWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Init();
        }

        private async void compileTrinityCoreButton_Click(object sender, EventArgs e)
        {

            if (platformComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "A platform must be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (string.IsNullOrEmpty(Settings.Default.TrunkLocation))
            {

                MessageBoxEx.Show(this, "You must first set the trunk location for TrinityCore!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (_isCloning)
            {

                MessageBoxEx.Show(this, "Cloning in progress. Please wait until this has finished!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (_isCompiling)
            {

                if (_compilerCTS != null)
                    _compilerCTS.Cancel();

                compileProgressBar.Visible = false;
                compileTrinityCoreButton.Text = "Compile && Replace TC";

                return;

            }

            bool x64 = platformComboBox.SelectedIndex == 1;

            _compilerCTS = new CancellationTokenSource();

            var progress = new Progress<string>(prog => Invoke((MethodInvoker)delegate
                                                {
                                                    outputTextBox.AppendText(prog + Environment.NewLine);
                                                }));

            outputTextBox.Text = String.Empty;

            compileProgressBar.Visible = true;
            compileProgressBar.ProgressType = eProgressItemType.Marquee;

            _isCompiling = true;

            compileTrinityCoreButton.Text = "Cancel Compile";
            consoleTabControl.SelectedTab = outputTabItem;

            string temp = FileHelper.GenerateTempDirectory();

            await CMake.Generate(Settings.Default.TrunkLocation, temp, x64, progress, _compilerCTS.Token).ContinueWith(task1 =>
            {

                if (task1.Result)
                {

                    _compilerCTS = new CancellationTokenSource();

                    TCCompiler.Compile(temp, x64, progress, _compilerCTS.Token).ContinueWith(task2 =>
                    {

                        _isCompiling = false;

                        if (task2.Result)
                            FileHelper.CopyDirectory(Path.Combine(temp, "bin", "Release"), Settings.Default.ServerFolder);

                        Invoke((MethodInvoker)delegate
                        {

                            compileProgressBar.Visible = false;
                            compileTrinityCoreButton.Text = "Compile && Replace TC";


                            try
                            {
                                FileHelper.DeleteDirectory(temp);
                            }
                            catch (Exception)
                            {
                                MessageBoxEx.Show(this, "Error while trying to delete the temporary directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            if (!task2.Result)
                            {
                                MessageBoxEx.Show(this, "An error has occurred while trying to compile TrinityCore!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        });

                    });

                }
                else
                {

                    _isCompiling = false;

                    Invoke((MethodInvoker)delegate
                    {

                        compileProgressBar.Visible = false;
                        compileTrinityCoreButton.Text = "Compile && Replace Trinity Core";

                        MessageBoxEx.Show(this, "Error while executing CMake!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        try
                        {
                            FileHelper.DeleteDirectory(temp);
                        }
                        catch (Exception)
                        {
                            MessageBoxEx.Show(this, "Error while trying to delete the temporary directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    });

                }

            });

        }

        private void setTrunkLocationButton_Click(object sender, EventArgs e)
        {
            using (var stl = new SetTrunkLocation())
            {
                if (stl.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.TrunkLocation = stl.TrunkLocation;
                    Settings.Default.Save();
                }
            }
        }

        private async void downloadUpdateButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Settings.Default.TrunkLocation))
            {

                MessageBoxEx.Show(this, "Trunk location is requried!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (_isCloning)
            {

                MessageBoxEx.Show(this, "Cloning already in progress!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (_isCompiling)
            {

                MessageBoxEx.Show(this, "Currently compiling TC! Please wait until this has finished.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            _isCloning = true;

            compileProgressBar.ProgressType = eProgressItemType.Marquee;
            compileProgressBar.Visible = true;

            downloadUpdateButton.Enabled = false;

            var progress = new Progress<double>(prog => Invoke((MethodInvoker)delegate
                                                {

                                                    if (compileProgressBar.ProgressType == eProgressItemType.Marquee)
                                                        compileProgressBar.ProgressType = eProgressItemType.Standard;

                                                    compileProgressBar.Value = Convert.ToInt32(prog);

                                                }));

            if (new DirectoryInfo(Settings.Default.TrunkLocation).GetFiles().Length == 0)
            {

                await TrinityCoreRepository.Clone(Settings.Default.TrunkLocation, progress).ContinueWith(task =>
                {

                    Invoke((MethodInvoker)delegate
                    {

                        compileProgressBar.Visible = false;
                        downloadUpdateButton.Enabled = true;

                        MessageBoxEx.Show(this, "Cloning has been completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    });

                    _isCloning = false;

                });

            }
            else
            {

                await TrinityCoreRepository.Fetch(Settings.Default.TrunkLocation, progress).ContinueWith(task =>
                {

                    Invoke((MethodInvoker)delegate
                    {

                        compileProgressBar.Visible = false;
                        downloadUpdateButton.Enabled = true;

                        MessageBoxEx.Show(this, "The TrinityCore repository has been updated to the latest version.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    });

                    _isCloning = false;

                });

            }

        }
    }
}