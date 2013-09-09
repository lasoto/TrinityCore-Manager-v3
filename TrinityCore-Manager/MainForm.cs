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
using TrinityCore_Manager.Clients;
using TrinityCore_Manager.Compile_Forms;
using TrinityCore_Manager.Database.Classes;
using TrinityCore_Manager.Database_Management;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.Misc.Enums;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.Database;
using TrinityCore_Manager.Security;
using TrinityCore_Manager.TC;
using TrinityCore_Manager.TCM;
using TrinityCore_Manager.NPC_Forms;
using TrinityCore_Manager.Extensions;
using TrinityCore_Manager.SmartAI;

namespace TrinityCore_Manager
{
    public partial class MainForm : Office2007RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool _isCloning;
        private bool _isCompiling;

        private CancellationTokenSource _compilerCTS;

        private System.Windows.Forms.Timer _bTimeLeftTimer;
        private System.Windows.Forms.Timer _checkPlayersOnlineTimer;

        private void MainForm_Load(object sender, EventArgs e)
        {

            _isCloning = false;

            SetInitial();
            CheckSettings();
            InitStyle();
            InitBackupTimer();
            Init();

        }

        private void InitStyle()
        {
            switch ((TCMTheme)Settings.Default.ColorTheme)
            {

                case TCMTheme.Dark:

                    StyleManager.Style = eStyle.VisualStudio2012Dark;

                    break;

                case TCMTheme.Blue:

                    StyleManager.Style = eStyle.VisualStudio2010Blue;

                    break;

                case TCMTheme.Light:

                    StyleManager.Style = eStyle.VisualStudio2012Light;

                    break;

                case TCMTheme.Black:

                    StyleManager.Style = eStyle.Office2010Black;

                    break;

            }
        }

        private void SetInitial()
        {
            platformComboBox.SelectedIndex = 0;
            mainRibbonControl.SelectedRibbonTabItem = serverManagementTab;
        }

        private void Init()
        {

            stopServerButton.Enabled = false;

            if (Settings.Default.ServerType == (int)ServerType.RemoteAccess)
            {

                startServerButton.Enabled = false;
                openConfigurationFileButton.Enabled = false;
                connectRAButton.Enabled = true;

                //if (Settings.Default.RAAutoConnect)
                ConnectRA();

            }
            else
            {
                startServerButton.Enabled = true;
                openConfigurationFileButton.Enabled = true;
                connectRAButton.Enabled = false;
            }

            _checkPlayersOnlineTimer = new System.Windows.Forms.Timer();
            _checkPlayersOnlineTimer.Interval = (int)TimeSpan.FromSeconds(15).TotalMilliseconds;
            _checkPlayersOnlineTimer.Tick += _checkPlayersOnlineTimer_Tick;

            _checkPlayersOnlineTimer.Start();

        }

        async void _checkPlayersOnlineTimer_Tick(object sender, EventArgs e)
        {

            if (!TCManager.Instance.Online)
            {

                playersOnlineLabel.Text = "Players Online: 0";

                return;

            }

            int online = await TCManager.Instance.AuthDatabase.GetPlayersOnlineCount();

            playersOnlineLabel.Text = "Players Online: " + online;

        }

        private void InitBackupTimer()
        {

            if (Settings.Default.BackupScheduleAuth || Settings.Default.BackupScheduleChar || Settings.Default.BackupScheduleWorld)
            {

                TCManager.Instance.ScheduleBackups();

                if (_bTimeLeftTimer != null)
                {
                    _bTimeLeftTimer.Enabled = false;
                    _bTimeLeftTimer.Dispose();
                }

                nextBackupLabel.Visible = true;

                _bTimeLeftTimer = new System.Windows.Forms.Timer();
                _bTimeLeftTimer.Interval = (int)TimeSpan.FromSeconds(1).TotalMilliseconds;
                _bTimeLeftTimer.Tick += _bTimeLeftTimer_Tick;


                _bTimeLeftTimer.Start();

            }
            else
            {
                nextBackupLabel.Visible = false;
            }

        }

        void _bTimeLeftTimer_Tick(object sender, EventArgs e)
        {

            DateTimeOffset dto = TCManager.Instance.BackupNext;

            TimeSpan ts = dto - DateTime.Now;

            nextBackupLabel.Text = String.Format("Next backup: {0}", ts.ToReadableString());

        }

        private void ConnectRA()
        {

            TCManager manager = TCManager.Instance;

            if (manager.RAClient != null)
            {
                ((TCPClient)manager.RAClient).Dispose();
            }

            manager.RAClient = new TCPClient(Settings.Default.RAHost, Settings.Default.RAPort);

            TCPClient client = (TCPClient)manager.RAClient;

            try
            {
                client.Connect();
                client.TCConnected += _raClient_TCConnected;
                client.TCDisconnected += _raClient_TCDisconnected;
                client.TCMessageReceived += _raClient_TCMessageReceived;
            }
            catch (Exception ex)
            {

                client.Dispose();

                MessageBoxEx.Show(this, "Could not connect to RA! (" + ex.Message + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        void _raClient_TCMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                consoleTextBox.AppendText(e.Message + Environment.NewLine);
                consoleTextBox.ScrollToBottom();
            });
        }

        void _raClient_TCDisconnected(object sender, EventArgs e)
        {

            Invoke((MethodInvoker)delegate
            {

                consoleTextBox.AppendText("Disconnected!" + Environment.NewLine);
                consoleTextBox.ScrollToBottom();

                authServerLabel.Image = Resources.agt_action_fail_16;
                worldServerLabel.Image = Resources.agt_action_fail_16;

            });

        }

        async void _raClient_TCConnected(object sender, EventArgs e)
        {

            Invoke((MethodInvoker)delegate
            {

                consoleTextBox.AppendText("Connected!" + Environment.NewLine);

                authServerLabel.Image = Resources.agt_action_success_16;
                worldServerLabel.Image = Resources.agt_action_success_16;

            });

            await AuthenticateRA();

        }

        private async Task AuthenticateRA()
        {

            TCPClient client = (TCPClient)TCManager.Instance.RAClient;

            if (client == null)
                return;

            await client.SendMessage(Settings.Default.RAUsername);
            await client.SendMessage(Settings.Default.RAPassword.DecryptString(Encoding.Unicode.GetBytes(Settings.Default.Entropy)).ToInsecureString());

        }

        private void CheckSettings(bool exit = false)
        {

            var set = Settings.Default;

            if (String.IsNullOrEmpty(set.DBHost) || String.IsNullOrEmpty(set.DBUsername) || String.IsNullOrEmpty(set.DBPassword) || String.IsNullOrEmpty(set.DBAuthName) ||
                String.IsNullOrEmpty(set.DBCharName) || String.IsNullOrEmpty(set.DBWorldName))
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
                if (String.IsNullOrEmpty(set.ServerFolder))
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
                if (String.IsNullOrEmpty(set.RAUsername) || String.IsNullOrEmpty(set.RAPassword))
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
            if (characterListComboBox.SelectedIndex == -1)
            {
                MessageBoxEx.Show(this, "No character selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (PlayerInformation playerInfo = new PlayerInformation(characterListComboBox.Items[characterListComboBox.SelectedIndex].ToString()))
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

        private void createVendorButton_Click(object sender, EventArgs e)
        {
            CreateNPCVendor cnv = new CreateNPCVendor();
            cnv.ShowDialog();
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
            Process.Start(Path.Combine(Settings.Default.ServerFolder, "worldserver.conf"));
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

            if (String.IsNullOrEmpty(Settings.Default.TrunkLocation))
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
                compileTrinityCoreButton.Text = "Compile & Replace TC";

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
                            compileTrinityCoreButton.Text = "Compile & Replace TC";

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

            if (String.IsNullOrEmpty(Settings.Default.TrunkLocation))
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

            compileProgressBar.Visible = true;
            compileProgressBar.ProgressType = eProgressItemType.Marquee;

            downloadUpdateButton.Enabled = false;

            if (new DirectoryInfo(Settings.Default.TrunkLocation).GetFiles().Length == 0)
            {

                var progress = new Progress<double>(prog => Invoke((MethodInvoker)delegate
                {

                    if (compileProgressBar.ProgressType == eProgressItemType.Marquee)
                        compileProgressBar.ProgressType = eProgressItemType.Standard;

                    compileProgressBar.Value = Convert.ToInt32(prog);

                }));

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

                outputTextBox.Text = String.Empty;
                consoleTabControl.SelectedTab = outputTabItem;

                var progress = new Progress<string>(prog => Invoke((MethodInvoker)delegate
                {
                    outputTextBox.AppendText(prog + Environment.NewLine);
                }));

                await TrinityCoreRepository.Pull(Settings.Default.TrunkLocation, progress).ContinueWith(task =>
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

        private void startServerButton_Click(object sender, EventArgs e)
        {


            TCManager inst = TCManager.Instance;


            if (!File.Exists(Path.Combine(Settings.Default.ServerFolder, "authserver.exe")))
            {

                MessageBoxEx.Show(this, "The file authserver.exe does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (!File.Exists(Path.Combine(Settings.Default.ServerFolder, "worldserver.exe")))
            {

                MessageBoxEx.Show(this, "The file worldserver.exe does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (inst.AuthClient != null)
            {
                if (inst.AuthClient.IsOnline)
                {
                    if (MessageBoxEx.Show(this, "Authserver is already running! Kill it?", "Already running", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        return;

                    ProcessHelper.KillProcess(((LocalClient)inst.AuthClient).UnderlyingProcessId);
                }
            }

            if (inst.WorldClient != null)
            {
                if (inst.WorldClient.IsOnline)
                {
                    if (MessageBoxEx.Show(this, "Worldserver is already running! Kill it?", "Already running", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        return;

                    ProcessHelper.KillProcess(((LocalClient)inst.WorldClient).UnderlyingProcessId);
                }
            }

            consoleTextBox.Text = String.Empty;

            var authClient = new LocalClient(Path.Combine(Settings.Default.ServerFolder, "authserver.exe"));
            var worldClient = new LocalClient(Path.Combine(Settings.Default.ServerFolder, "worldserver.exe"));

            inst.AuthClient = authClient;
            inst.WorldClient = worldClient;

            inst.AuthClient.Start();
            inst.WorldClient.Start();

            stopServerButton.Enabled = true;
            startServerButton.Enabled = false;

            authClient.ClientExited += authProc_Exited;
            worldClient.ClientExited += worldProc_Exited;

            worldClient.DataReceived += WorldDataReceived;

            authServerLabel.Image = Resources.agt_action_success_16;
            worldServerLabel.Image = Resources.agt_action_success_16;

        }

        private void WorldDataReceived(object sender, ClientReceivedDataEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                if (e.Data != null && !IsDisposed)
                {
                    consoleTextBox.AppendText(e.Data + Environment.NewLine);
                    consoleTextBox.ScrollToBottom();
                }
            });
        }

        void worldProc_Exited(object sender, EventArgs e)
        {

            TCManager.Instance.AuthClient.Stop();

            if (!IsDisposed)
            {
                Invoke((MethodInvoker)delegate
                {

                    stopServerButton.Enabled = false;
                    startServerButton.Enabled = true;

                    worldServerLabel.Image = Resources.agt_action_fail_16;

                });
            }

        }

        void authProc_Exited(object sender, EventArgs e)
        {

            TCManager.Instance.WorldClient.Stop();

            if (!IsDisposed)
            {
                Invoke((MethodInvoker)delegate
                {

                    stopServerButton.Enabled = false;
                    startServerButton.Enabled = true;

                    authServerLabel.Image = Resources.agt_action_fail_16;

                });

            }

        }

        private void stopServerButton_Click(object sender, EventArgs e)
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

            consoleTextBox.Text = String.Empty;

        }

        private async void executeCommandButton_Click(object sender, EventArgs e)
        {
            if (CheckServerOnline())
                return;

            if (String.IsNullOrEmpty(executeCommandTextBox.Text))
            {

                MessageBoxEx.Show(this, "You must enter a command to execute!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            try
            {

                AddMessage(String.Format("Console: {0}: ", executeCommandTextBox.Text + Environment.NewLine), Color.Chartreuse);

                await TCAction.ExecuteCommand(executeCommandTextBox.Text);

                executeCommandTextBox.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddMessage(string message, Color color)
        {
            consoleTextBox.SelectionStart = consoleTextBox.TextLength;
            consoleTextBox.SelectionLength = 0;

            consoleTextBox.SelectionColor = color;
            consoleTextBox.AppendText(message);
            consoleTextBox.SelectionColor = consoleTextBox.ForeColor;

            consoleTextBox.ScrollToBottom();
        }

        private void executeCommandTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

        }

        private void executeCommandTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                executeCommandButton.RaiseClick();
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            var inst = TCManager.Instance;

            if (inst.AuthClient != null)
            {
                if (inst.AuthClient.IsOnline)
                {
                    inst.AuthClient.Stop();
                }
            }

            if (inst.WorldClient != null)
            {
                if (inst.WorldClient.IsOnline)
                {
                    inst.WorldClient.Stop();
                }
            }

            if (inst.RAClient != null)
            {
                if (inst.RAClient.IsOnline)
                {
                    inst.RAClient.Stop();
                }
            }

            TCManager.Instance.StopScheduledBackups();

            Application.Exit();

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm())
            {
                settings.FormClosing += settings_FormClosing;
                settings.ShowDialog();
            }
        }

        void settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            InitStyle();
        }

        private async void refreshListPlayerManagementButton_Click(object sender, EventArgs e)
        {
            if (CheckServerOnline())
                return;

            playerManagementComboBox.Items.Clear();

            List<Account> onlineAccounts = await TCManager.Instance.AuthDatabase.GetOnlineAccounts();

            foreach (Account onlineAccount in onlineAccounts)
            {
                playerManagementComboBox.Items.Add(onlineAccount.Username);
            }

        }

        private async void kickPlayerButton_Click(object sender, EventArgs e)
        {

            if (playerManagementComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "You must first select a character to kick!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            try
            {
                await TCAction.KickPlayer(playerManagementComboBox.Items[playerManagementComboBox.SelectedIndex].ToString(), String.Empty);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backupDbButton_Click(object sender, EventArgs e)
        {
            using (BackupDatabase backup = new BackupDatabase())
            {
                backup.FormClosing += backup_FormClosing;
                backup.ShowDialog();
            }
        }

        void backup_FormClosing(object sender, FormClosingEventArgs e)
        {
            InitBackupTimer();
        }

        private void restoreDbButton_Click(object sender, EventArgs e)
        {
            using (RestoreDatabase restore = new RestoreDatabase())
                restore.ShowDialog();
        }

        private async void refreshListCharacterManagementButton_Click(object sender, EventArgs e)
        {
            if (CheckServerOnline())
                return;

            characterListComboBox.Items.Clear();
            List<int> guids = await TCManager.Instance.CharDatabase.GetOnlineCharacterGuids();

            foreach (int guid in guids)
                characterListComboBox.Items.Add(TCManager.Instance.CharDatabase.GetCharacterName(guid));
        }

        private void connectRAButton_Click(object sender, EventArgs e)
        {
            if ((ServerType)Settings.Default.ServerType == ServerType.Local)
            {
                MessageBoxEx.Show(this, "RA is not enabled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TCPClient client = (TCPClient)TCManager.Instance.RAClient;

            if (client != null)
                client.Disconnect();

            ConnectRA();
        }

        private async void sendMessageButton_Click(object sender, EventArgs e)
        {
            if (serverAnnouncementCheckBox.Checked)
            {
                if (!String.IsNullOrEmpty(communicationsTextBox.Text))
                    AddMessage(String.Format("Server Announcement: {0}", communicationsTextBox.Text + Environment.NewLine), Color.DodgerBlue);

                await TCAction.AnnounceToServer(communicationsTextBox.Text);
            }
            else if (serverNotificationCheckBox.Checked)
            {
                if (!String.IsNullOrEmpty(communicationsTextBox.Text))
                    AddMessage(String.Format("Notification: {0}", communicationsTextBox.Text + Environment.NewLine), Color.DodgerBlue);

                await TCAction.NotifiyServer(communicationsTextBox.Text);
            }
            else if (gmAnnouncementCheckBox.Checked)
            {
                if (!String.IsNullOrEmpty(communicationsTextBox.Text))
                    AddMessage(String.Format("GM Notification: {0}", communicationsTextBox.Text + Environment.NewLine), Color.DodgerBlue);

                await TCAction.NotifyGMs(communicationsTextBox.Text);
            }

            communicationsTextBox.Text = String.Empty;
        }

        private async void revivePlayerButton_Click(object sender, EventArgs e)
        {
            if (characterListComboBox.SelectedIndex == -1)
            {
                MessageBoxEx.Show(this, "No character selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await TCAction.RevivePlayer(characterListComboBox.Items[characterListComboBox.SelectedIndex].ToString());

        }

        private async void forceRenameButton_Click(object sender, EventArgs e)
        {
            if (characterListComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "No character selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            await TCAction.ForceCharRename(characterListComboBox.Items[characterListComboBox.SelectedIndex].ToString());

        }

        private void communicationsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMessageButton.RaiseClick();
            }
        }

        private async void banCharacterButton_Click(object sender, EventArgs e)
        {
            if (characterListComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "No character selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            await TCAction.BanCharacter(characterListComboBox.Items[characterListComboBox.SelectedIndex].ToString());

        }

        private void reportBugButton_Click(object sender, EventArgs e)
        {
            ReportBug report = new ReportBug();
            report.ShowDialog();
        }

        private void mainRibbonControl_Click(object sender, EventArgs e)
        {

        }

        private void createSAIButton_Click(object sender, EventArgs e)
        {
            CreateSmartAI sai = new CreateSmartAI();
            sai.ShowDialog();
        }

        private bool CheckServerOnline(bool checkForAuthToo = false)
        {
            if (TCManager.Instance.WorldClient == null || !TCManager.Instance.WorldClient.IsOnline)
            {
                MessageBoxEx.Show(this, "There is no worldserver running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (checkForAuthToo && (TCManager.Instance.AuthClient == null || !TCManager.Instance.AuthClient.IsOnline))
            {
                MessageBoxEx.Show(this, "There is no authserver running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
    }
}