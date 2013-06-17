using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database
{
    class WorldDatabase : MySqlDatabase
    {

        public WorldDatabase(string serverHost, int port, string username, string password, string dbName) : base(serverHost, port, username, password, dbName)
        {
        }

        public async Task CleanupLoot()
        {
            await this.ExecuteScript(@"CREATE TABLE `Loot_temp` (`lootid` INT(8) UNSIGNED NOT NULL PRIMARY KEY DEFAULT '0');
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
                                    DELETE FROM `mail_loot_template` WHERE `item` NOT IN (SELECT `entry` FROM `item_template`);");
        }

        public async Task CleanRefLoot()
        {
            await this.ExecuteScript(@"CREATE TABLE `RL_temp` (`ref_id` INT(8) UNSIGNED NOT NULL PRIMARY KEY DEFAULT '0');
                                    INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `gameobject_loot_template` WHERE `mincountOrRef` <0;
                                    INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `item_loot_template` WHERE `mincountOrRef` <0;
                                    INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `creature_loot_template` WHERE `mincountOrRef` <0;
                                    INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `spell_loot_template` WHERE `mincountOrRef` <0;
                                    INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `prospecting_loot_template` WHERE `mincountOrRef` <0;
                                    INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `milling_loot_template` WHERE `mincountOrRef` <0;
                                    INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `mail_loot_template` WHERE `mincountOrRef` <0;
                                    INSERT IGNORE INTO `RL_temp` SELECT DISTINCT(`mincountOrRef`)*-1 FROM `reference_loot_template` WHERE `mincountOrRef`<0;
                                    DELETE FROM `reference_loot_template` WHERE `entry` NOT IN (SELECT `ref_id` FROM `RL_temp`);
                                    DROP TABLE `RL_temp`;");
        }

        public async Task CleanWorld()
        {
            await this.ExecuteScript(@"DELETE FROM `gameobject` WHERE `id` NOT IN (SELECT `entry` FROM `gameobject_template`);
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
                                    DELETE FROM `pet_levelstats` WHERE `creature_entry` NOT IN (SELECT `entry` FROM `creature_template`);");
        }

    }
}
