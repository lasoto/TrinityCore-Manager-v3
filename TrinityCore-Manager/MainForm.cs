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

        private void lootCleanupButton_Click(object sender, EventArgs e)
        {
            /* THIS SQL CODE HAS TO BE EXECUTED ONCE THE cleanLoot BUTTON IS CLICKED
             * 
             * 
             * 
CREATE TABLE `Loot_temp` (`lootid` INT(8) UNSIGNED NOT NULL PRIMARY KEY DEFAULT '0');
INSERT IGNORE INTO `Loot_temp` SELECT `entry` FROM `item_template`;
DELETE FROM `prospecting_loot_template` WHERE `entry` NOT IN (SELECT `lootid` FROM `Loot_temp`);
DELETE FROM `Loot_temp`;
INSERT IGNORE INTO `Loot_temp` SELECT `skinloot` FROM `creature_template` WHERE skinloot>0;
DELETE FROM `skinning_loot_template` WHERE `entry` NOT IN (SELECT `lootid` FROM `Loot_temp`);
DELETE FROM `Loot_temp`;
INSERT IGNORE INTO `Loot_temp` SELECT `lootid` FROM `creature_template` WHERE lootid>0;
DELETE FROM `creature_loot_template` WHERE `entry` NOT IN (SELECT `lootid` FROM `Loot_temp`);
DELETE FROM `Loot_temp`;
DROP TABLE `Loot_temp`;
DELETE FROM `disenchant_loot_template` WHERE `item` NOT IN (SELECT `entry` FROM `item_template`);
DELETE FROM `disenchant_loot_template` WHERE `entry` NOT IN (SELECT `disenchantid` FROM `item_template`);
DELETE FROM `pickpocketing_loot_template` WHERE `item` NOT IN (SELECT `entry` FROM `item_template`);
DELETE FROM `prospecting_loot_template` WHERE `entry` NOT IN (SELECT `entry` FROM `item_template`);
DELETE FROM `prospecting_loot_template` WHERE `item` NOT IN (SELECT `entry` FROM `item_template`);
DELETE FROM `mail_loot_template` WHERE `item` NOT IN (SELECT `entry` FROM `item_template`);
             */

        }

        private void cleanRefLootButton_Click(object sender, EventArgs e)
        {
            /* THIS SQL CODE HAS TO BE EXECUTED ONCE THE cleanRefLoot BUTTON IS CLICKED 
             * 
             * 
CREATE TABLE `RL_temp` (`ref_id` INT(8) UNSIGNED NOT NULL PRIMARY KEY DEFAULT '0');
INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `gameobject_loot_template` WHERE `mincountOrRef` <0;
INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `item_loot_template` WHERE `mincountOrRef` <0;
INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `creature_loot_template` WHERE `mincountOrRef` <0;
INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `spell_loot_template` WHERE `mincountOrRef` <0;
INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `prospecting_loot_template` WHERE `mincountOrRef` <0;
INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `milling_loot_template` WHERE `mincountOrRef` <0;
INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `mail_loot_template` WHERE `mincountOrRef` <0;
INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `reference_loot_template` WHERE `mincountOrRef`<0;
DELETE FROM `reference_loot_template` WHERE `entry` NOT IN (SELECT `ref_id` FROM `RL_temp`);
DROP TABLE `RL_temp`;
             *
             * 
             */
        }

        private void cleanWorldButton_Click(object sender, EventArgs e)
        {
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
    }
}