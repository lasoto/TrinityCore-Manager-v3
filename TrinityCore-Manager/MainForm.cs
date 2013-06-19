using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DevComponents.DotNetBar;
using Microsoft.Win32;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.Database;
using TrinityCore_Manager.Security;

namespace TrinityCore_Manager
{
    public partial class MainForm : Office2007RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            CheckSettings();

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

            /* 
             * THIS SQL CODE HAS TO BE EXECUTED ONCE THE CLEANWORLD BUTTON IS CLICKED 
                
DELETE FROM `gameobject` WHERE `id` NOT IN (SELECT `entry` FROM `gameobject_template`);
DELETE FROM `creature` WHERE `id` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM areatrigger_involvedrelation WHERE `quest` NOT IN (SELECT `Id` FROM `quest_template`);
DELETE FROM `battlemaster_entry` WHERE `entry` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM `battlemaster_entry` WHERE `bg_template` NOT IN (SELECT `id` FROM `battleground_template`);
DELETE FROM `creature_addon` WHERE `guid` NOT IN (SELECT `guid` FROM `creature`);
DELETE FROM `creature_ai_scripts` WHERE `creature_id` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM `creature_formations` WHERE leaderGUID NOT IN (SELECT `guid` FROM `creature`);
DELETE FROM `creature_formations` WHERE memberGUID NOT IN (SELECT `guid` FROM `creature`);
DELETE FROM `creature_involvedrelation` WHERE `id` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM `creature_involvedrelation` WHERE `quest` NOT IN (SELECT `Id` FROM `quest_template`);
DELETE FROM `creature_onkill_reputation` WHERE `creature_id` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM `creature_questrelation` WHERE `id` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM `creature_questrelation` WHERE `quest` NOT IN (SELECT `Id` FROM `quest_template`);
DELETE FROM `creature_template_addon` WHERE `entry` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM `game_event_creature_quest` WHERE `id` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM `game_event_creature_quest` WHERE `quest` NOT IN (SELECT `Id` FROM `quest_template`);
DELETE FROM `game_event_creature_quest` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_gameobject_quest` WHERE `id` NOT IN (SELECT `entry` FROM `gameobject_template`);
DELETE FROM `game_event_gameobject_quest` WHERE `quest` NOT IN (SELECT `Id` FROM `quest_template`);
DELETE FROM `game_event_gameobject_quest` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_model_equip` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_battleground_holiday` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_condition` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_creature` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_gameobject` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_npc_vendor` WHERE `item` NOT IN (SELECT `entry` FROM `item_template`);
DELETE FROM `game_event_npc_vendor` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_npcflag` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_pool` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_prerequisite` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_prerequisite` WHERE `prerequisite_event` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_quest_condition` WHERE `eventEntry` NOT IN (SELECT `eventEntry` FROM `game_event`);
DELETE FROM `game_event_quest_condition` WHERE `quest` NOT IN (SELECT `Id` FROM `quest_template`);
DELETE FROM `gameobject_involvedrelation` WHERE `id` NOT IN (SELECT `entry` FROM `gameobject_template`);
DELETE FROM `gameobject_involvedrelation` WHERE `quest` NOT IN (SELECT `Id` FROM `quest_template`);
DELETE FROM `mail_level_reward` WHERE `senderEntry` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM `npc_spellclick_spells` WHERE `npc_entry` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM `npc_trainer` WHERE `entry` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM `npc_vendor` WHERE `entry` NOT IN (SELECT `entry` FROM `creature_template`);
DELETE FROM `npc_vendor` WHERE `item` NOT IN (SELECT `entry` FROM `item_template`);
DELETE FROM `pet_levelstats` WHERE `creature_entry` NOT IN (SELECT `entry` FROM `creature_template`);
             * 
             */
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
            this.Show();
        }

    }
}