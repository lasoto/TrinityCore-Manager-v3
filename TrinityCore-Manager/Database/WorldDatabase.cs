using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TrinityCore_Manager.Database.Classes;
using TrinityCoreManager.Database.Enums.Item_Enums;
using TrinityCore_Manager.Database.Enums;
using TrinityCore_Manager.Database.Enums.Item_Enums;
using TrinityCore_Manager.Database.Enums.Creature_Enums;

namespace TrinityCore_Manager.Database
{
    class WorldDatabase : MySqlDatabase
    {

        public WorldDatabase(string serverHost, int port, string username, string password, string dbName)
            : base(serverHost, port, username, password, dbName)
        {
        }

        public async Task<Dictionary<int, string>> SearchForItem(string searchQuery, int page)
        {
            Dictionary<int, string> items = new Dictionary<int, string>();
            DataTable dt = await ExecuteQuery(String.Format("SELECT `entry`, `name` FROM `item_template` WHERE `name` LIKE @search LIMIT 10 OFFSET {0}", page * 10), new MySqlParameter("@search", "%" + searchQuery + "%"));

            foreach (DataRow row in dt.Rows)
                items.Add(Convert.ToInt32((uint)row["entry"]), (string)row["name"]);

            return items;

        }

        public async Task<int> GetTotalPagesForItem(string searchQuery)
        {
            int totalPages = 0;
            DataTable dt = await ExecuteQuery("SELECT COUNT(*) / 10 FROM `item_template` WHERE `name` LIKE @search", new MySqlParameter("@search", "%" + searchQuery + "%"));

            foreach (DataRow row in dt.Rows)
                totalPages = (int)Math.Ceiling((double)Convert.ToInt32(dt.Rows[0]["COUNT(*) / 10"]));

            return totalPages;
        }

        public TCItem BuildItem(DataRow row)
        {
            TCItem item = new TCItem();
            item.Entry = Convert.ToInt32(row["entry"]);
            item.Class = Convert.ToInt32(row["class"]);
            item.Subclass = Convert.ToInt32(row["subclass"]);
            item.Name = (string)row["name"];
            item.DisplayId = Convert.ToInt32(row["displayid"]);
            item.Quality = Convert.ToInt32(row["quality"]);
            item.Flags = Convert.ToInt32(row["flags"]);
            item.FlagsExra = Convert.ToInt32(row["flagsextra"]);
            item.BuyCount = Convert.ToInt32(row["buycount"]);
            item.BuyPrice = Convert.ToInt32(row["buyprice"]);
            item.SellPrice = Convert.ToInt32(row["sellprice"]);
            item.InvType = (ItemInventoryType)Convert.ToInt32(row["inventorytype"]);
            item.AllowableClass = (CharacterClass)Convert.ToInt32(row["allowableclass"]);
            item.AllowableRace = (CharacterRace)Convert.ToInt32(row["allowablerace"]);
            item.ItemLevel = Convert.ToInt32(row["itemlevel"]);
            item.RequiredLevel = Convert.ToInt32(row["requiredlevel"]);
            item.RequiredSkill = Convert.ToInt32(row["requiredskill"]);
            item.RequiredSkillRank = Convert.ToInt32(row["requiredskillrank"]);
            item.RequiredSpell = Convert.ToInt32(row["requiredspell"]);
            item.RequiredHonorRank = Convert.ToInt32(row["requiredhonorrank"]);
            item.RequiredCityRank = Convert.ToInt32(row["requiredcityrank"]);
            item.RequiredReputationFaction = Convert.ToInt32(row["requiredreputationfaction"]);
            item.RequiredReputationRank = (ItemRequiredReputationRank)Convert.ToInt32(row["requiredreputationrank"]);
            item.MaxCount = Convert.ToInt32(row["maxcount"]);
            item.Stackable = Convert.ToInt32(row["stackable"]);
            item.ContainerSlots = Convert.ToInt32(row["containerslots"]);
            item.StatsCount = Convert.ToInt32(row["statscount"]);
            item.Stat_type1 = (ItemStatType)Convert.ToInt32(row["stat_type1"]);
            item.Stat_value1 = Convert.ToInt32(row["stat_value1"]);
            item.Stat_type2 = (ItemStatType)Convert.ToInt32(row["stat_type2"]);
            item.Stat_value2 = Convert.ToInt32(row["stat_value2"]);
            item.Stat_type3 = (ItemStatType)Convert.ToInt32(row["stat_type3"]);
            item.Stat_value3 = Convert.ToInt32(row["stat_value3"]);
            item.Stat_type4 = (ItemStatType)Convert.ToInt32(row["stat_type4"]);
            item.Stat_value4 = Convert.ToInt32(row["stat_value4"]);
            item.Stat_type5 = (ItemStatType)Convert.ToInt32(row["stat_type5"]);
            item.Stat_value5 = Convert.ToInt32(row["stat_value5"]);
            item.Stat_type6 = (ItemStatType)Convert.ToInt32(row["stat_type6"]);
            item.Stat_value6 = Convert.ToInt32(row["stat_value6"]);
            item.Stat_type7 = (ItemStatType)Convert.ToInt32(row["stat_type7"]);
            item.Stat_value7 = Convert.ToInt32(row["stat_value7"]);
            item.Stat_type8 = (ItemStatType)Convert.ToInt32(row["stat_type8"]);
            item.Stat_value8 = Convert.ToInt32(row["stat_value8"]);
            item.Stat_type9 = (ItemStatType)Convert.ToInt32(row["stat_type9"]);
            item.Stat_value9 = Convert.ToInt32(row["stat_value9"]);
            item.Stat_type10 = (ItemStatType)Convert.ToInt32(row["stat_type10"]);
            item.Stat_value10 = Convert.ToInt32(row["stat_value10"]);
            item.ScalingStatDistribution = Convert.ToInt32(row["scalingstatdistribution"]);
            item.ScalingStatValue = Convert.ToInt32(row["scalingstatvalue"]);
            item.Dmg_min1 = Convert.ToInt32(row["dmg_min1"]);
            item.Dmg_max1 = Convert.ToInt32(row["dmg_max1"]);
            item.Dmg_type1 = (ItemDamageType)Convert.ToInt32(row["dmg_type1"]);
            item.Dmg_min2 = Convert.ToInt32(row["dmg_min2"]);
            item.Dmg_max2 = Convert.ToInt32(row["dmg_max"]);
            item.Dmg_type2 = (ItemDamageType)Convert.ToInt32(row["dmg_type2"]);
            item.Armor = Convert.ToInt32(row["armor"]);
            item.Holy_res = Convert.ToInt32(row["holy_res"]);
            item.Fire_res = Convert.ToInt32(row["fire_res"]);
            item.Nature_res = Convert.ToInt32(row["nature_res"]);
            item.Frost_res = Convert.ToInt32(row["frost_res"]);
            item.Shadow_res = Convert.ToInt32(row["shadow_res"]);
            item.Delay = Convert.ToInt32(row["delay"]);
            item.Ammo_Type = (ItemAmmoType)Convert.ToInt32(row["ammo_type"]);
            item.RangedModRange = Convert.ToInt32(row["rangedmodrange"]);
            item.Spellid_1 = Convert.ToInt32(row["spellid_1"]);
            item.Spelltrigger_1 = Convert.ToInt32(row["spelltrigger_1"]);
            item.Spellcharges_1 = Convert.ToInt32(row["spellcharges_1"]);
            item.Spellppmrate_1 = (double)(row["spellppmrate_1"]);
            item.Spellcooldown_1 = Convert.ToInt32(row["spellcooldown_1"]);
            item.Spellcategory_1 = Convert.ToInt32(row["spellcategory_1"]);
            item.Spellcategorycooldown_1 = Convert.ToInt32(row["spellcategorycooldown_1"]);
            item.Spellid_2 = Convert.ToInt32(row["spellid_2"]);
            item.Spelltrigger_2 = Convert.ToInt32(row["spelltrigger_2"]);
            item.Spellcharges_2 = Convert.ToInt32(row["spellcharges_2"]);
            item.Spellppmrate_2 = (double)(row["spellppmrate_2"]);
            item.Spellcooldown_2 = Convert.ToInt32(row["spellcooldown_2"]);
            item.Spellcategory_2 = Convert.ToInt32(row["spellcategory_2"]);
            item.Spellcategorycooldown_2 = Convert.ToInt32(row["spellcategorycooldown_2"]);
            item.Spellid_3 = Convert.ToInt32(row["spellid_3"]);
            item.Spelltrigger_3 = Convert.ToInt32(row["spelltrigger_3"]);
            item.Spellcharges_3 = Convert.ToInt32(row["spellcharges_3"]);
            item.Spellppmrate_3 = (double)(row["spellppmrate_3"]);
            item.Spellcooldown_3 = Convert.ToInt32(row["spellcooldown_3"]);
            item.Spellcategory_3 = Convert.ToInt32(row["spellcategory_3"]);
            item.Spellcategorycooldown_3 = Convert.ToInt32(row["spellcategorycooldown_3"]);
            item.Spellid_4 = Convert.ToInt32(row["spellid_4"]);
            item.Spelltrigger_4 = Convert.ToInt32(row["spelltrigger_4"]);
            item.Spellcharges_4 = Convert.ToInt32(row["spellcharges_4"]);
            item.Spellppmrate_4 = (double)(row["spellppmrate_4"]);
            item.Spellcooldown_4 = Convert.ToInt32(row["spellcooldown_4"]);
            item.Spellcategory_4 = Convert.ToInt32(row["spellcategory_4"]);
            item.Spellcategorycooldown_4 = Convert.ToInt32(row["spellcategorycooldown_4"]);
            item.Spellid_5 = Convert.ToInt32(row["spellid_5"]);
            item.Spelltrigger_5 = Convert.ToInt32(row["spelltrigger_5"]);
            item.Spellcharges_5 = Convert.ToInt32(row["spellcharges_5"]);
            item.Spellppmrate_5 = (double)(row["spellppmrate_5"]);
            item.Spellcooldown_5 = Convert.ToInt32(row["spellcooldown_5"]);
            item.Spellcategory_5 = Convert.ToInt32(row["spellcategory_5"]);
            item.Spellcategorycooldown_5 = Convert.ToInt32(row["spellcategorycooldown_5"]);
            item.Bonding = (ItemBonding)Convert.ToInt32(row["bonding"]);
            item.Description = (string)(row["description"]);
            item.PageText = Convert.ToInt32(row["pagetext"]);
            item.LanguageID = (Language)(row["languageid"]);
            item.PageMaterial = (ItemPageMaterial)(row["pagematerial"]);
            item.Startquest = Convert.ToInt32(row["startquest"]);
            item.Lockid = Convert.ToInt32(row["lockid"]);
            item.Material = (ItemMaterial)Convert.ToInt32(row["material"]);
            item.Sheath = (ItemSheath)Convert.ToInt32(row["sheath"]);
            item.RandomProperty = Convert.ToInt32(row["randomproperty"]);
            item.RandomSuffix = Convert.ToInt32(row["randomsuffix"]);
            item.Block = Convert.ToInt32(row["block"]);
            item.ItemSet = Convert.ToInt32(row["itemset"]);
            item.MaxDurability = Convert.ToInt32(row["maxdurability"]);
            item.Area = Convert.ToInt32(row["area"]);
            item.Map = Convert.ToInt32(row["map"]);
            item.BagFamily = Convert.ToInt32(row["bagfamily"]);
            item.TotemCategory = Convert.ToInt32(row["totemcategory"]);
            item.SocketColor_1 = (ItemSocketColor)Convert.ToInt32(row["socket_color1"]);
            item.SocketContent_1 = Convert.ToInt32(row["socket_content1"]);
            item.SocketColor_2 = (ItemSocketColor)Convert.ToInt32(row["socket_color2"]);
            item.SocketContent_2 = Convert.ToInt32(row["socket_content2"]);
            item.SocketColor_3 = (ItemSocketColor)Convert.ToInt32(row["socket_color3"]);
            item.SocketContent_3 = Convert.ToInt32(row["socket_content3"]);
            item.SocketBonus = Convert.ToInt32(row["socketbonus"]);
            item.GemProperties = Convert.ToInt32(row["gemproperties"]);
            item.RequiredDisenchantSkill = Convert.ToInt32(row["requireddisenchantskill"]);
            item.ArmorDamageModifier = (double)(row["armordamagemodifier"]);
            item.Duration = Convert.ToInt32(row["duration"]);
            item.ItemLimitCategory = Convert.ToInt32(row["itemlimitcategory"]);
            item.HolidayId = Convert.ToInt32(row["holidayid"]);
            item.ScriptName = (string)(row["scriptname"]);
            item.DisenchantId = Convert.ToInt32(row["disenchantid"]);
            item.FoodType = (FoodType)Convert.ToInt32(row["foodtype"]);
            item.MinMoneyLoot = Convert.ToInt32(row["monmoneyloot"]);
            item.MaxMoneyLoot = Convert.ToInt32(row["maxmoneyloot"]);
            item.FlagsCustom = Convert.ToInt32(row["flagscustom"]);
            item.WDBVerified = Convert.ToInt32(row["wdbverified"]);


            return item;

        }

        public async Task<TCItem> GetItem(int id)
        {

            DataTable dt = await ExecuteQuery("SELECT * FROM `item_template` WHERE entry = @entry;", new MySqlParameter("@entry", id));

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return BuildItem(row);

        }

        public TCCreature BuildCreature(DataRow row)
        {

            TCCreature creature = new TCCreature();
            creature.Entry = Convert.ToInt32(row["entry"]);
            creature.Difficulty_entry_1 = Convert.ToInt32(row["difficulty_entry_1"]);
            creature.Difficulty_entry_2 = Convert.ToInt32(row["difficulty_entry_2"]);
            creature.Difficulty_entry_3 = Convert.ToInt32(row["difficulty_entry_3"]);
            creature.KillCredit1 = Convert.ToInt32(row["killcredit1"]);
            creature.KillCredit2 = Convert.ToInt32(row["killcredit2"]);
            creature.Modelid1 = Convert.ToInt32(row["modelid1"]);
            creature.Modelid2 = Convert.ToInt32(row["modelid2"]);
            creature.Modelid3 = Convert.ToInt32(row["modelid3"]);
            creature.Modelid4 = Convert.ToInt32(row["modelid4"]);
            creature.Name = (string)(row["name"]);
            creature.Subname = (string)(row["subname"]);
            creature.IconName = (string)(row["iconname"]);
            creature.Gossip_menu_id = Convert.ToInt32(row["gossip_menu_id"]);
            creature.Minlevel = Convert.ToInt32(row["minlevel"]);
            creature.Maxlevel = Convert.ToInt32(row["maxlevel"]);
            creature.Exp = Convert.ToInt32(row["exp"]);
            creature.Faction_A = Convert.ToInt32(row["faction_a"]);
            creature.Faction_H = Convert.ToInt32(row["faction_h"]);
            creature.Npcflag = Convert.ToInt32(row["npcflag"]);
            creature.Speed_walk = Convert.ToDouble(row["speed_walk"]);
            creature.Speed_run = Convert.ToDouble(row["speed_run"]);
            creature.Scale = Convert.ToDouble(row["scale"]);
            creature.Rank = (CreatureRank)Convert.ToInt32(row["rank"]);
            creature.Mindmg = Convert.ToInt32(row["mindmg"]);
            creature.Maxdmg = Convert.ToInt32(row["maxdmg"]);
            creature.Dmgschool = Convert.ToInt32(row["dmgschool"]);
            creature.Attackpower = Convert.ToInt32(row["attackpower"]);
            creature.Dmg_multiplier = Convert.ToDouble(row["dmg_multiplier"]);
            creature.Baseattacktime = Convert.ToInt32(row["baseattacktime"]);
            creature.Rangeattacktime = Convert.ToInt32(row["rangeattacktime"]);
            creature.Unit_class = Convert.ToInt32(row["unit_class"]);
            creature.Unit_flags = Convert.ToInt32(row["unit_flags"]);
            creature.Unit_flags2 = Convert.ToInt32(row["unit_flags2"]);
            creature.Dynamicflags = Convert.ToInt32(row["dynamicflags"]);
            creature.Family = (CreatureFamily)Convert.ToInt32(row["family"]);
            creature.Trainer_type = Convert.ToInt32(row["trainer_type"]);
            creature.Trainer_spell = Convert.ToInt32(row["trainer_spell"]);
            creature.Trainer_class = Convert.ToInt32(row["trainer_class"]);
            creature.Trainer_race = Convert.ToInt32(row["trainer_race"]);
            creature.Minrangedmg = Convert.ToDouble(row["minrangedmg"]);
            creature.Maxrangedmg = Convert.ToDouble(row["maxrangedmg"]);
            creature.Rangedattackpower = Convert.ToInt32(row["rangedattackpower"]);
            creature.Type = (CreatureType)Convert.ToInt32(row["type"]);
            creature.Type_flags = Convert.ToInt32(row["type_flags"]);
            creature.Lootid = Convert.ToInt32(row["lootid"]);
            creature.Pickpocketloot = Convert.ToInt32(row["pickpocketloot"]);
            creature.Skinloot = Convert.ToInt32(row["skinloot"]);
            creature.Resistance1 = Convert.ToInt32(row["resistance1"]);
            creature.Resistance2 = Convert.ToInt32(row["resistance2"]);
            creature.Resistance3 = Convert.ToInt32(row["resistance3"]);
            creature.Resistance4 = Convert.ToInt32(row["resistance4"]);
            creature.Resistance5 = Convert.ToInt32(row["resistance5"]);
            creature.Resistance6 = Convert.ToInt32(row["resistance6"]);
            creature.Spell1 = Convert.ToInt32(row["spell1"]);
            creature.Spell2 = Convert.ToInt32(row["spell2"]);
            creature.Spell3 = Convert.ToInt32(row["spell3"]);
            creature.Spell4 = Convert.ToInt32(row["spell4"]);
            creature.Spell5 = Convert.ToInt32(row["spell5"]);
            creature.Spell6 = Convert.ToInt32(row["spell6"]);
            creature.Spell7 = Convert.ToInt32(row["spell7"]);
            creature.Spell8 = Convert.ToInt32(row["spell8"]);
            creature.PetSpellDataId = Convert.ToInt32(row["petspelldataid"]);
            creature.VehicleId = Convert.ToInt32(row["vehicleid"]);
            creature.Mingold = Convert.ToInt32(row["mingold"]);
            creature.Maxgold = Convert.ToInt32(row["maxgold"]);
            creature.AIName = (string)(row["ainame"]);
            creature.MovementType = Convert.ToInt32(row["movementtype"]);
            creature.InhabitType = Convert.ToInt32(row["inhabittype"]);
            creature.HoverHeight = Convert.ToDouble(row["hoverheight"]);
            creature.Health_mod = Convert.ToDouble(row["health_mod"]);
            creature.Mana_mod = Convert.ToDouble(row["mana_mod"]);
            creature.Armor_mod = Convert.ToDouble(row["armor_mod"]);
            creature.RacialLeader = Convert.ToInt32(row["racialleader"]);
            creature.QuestItem1 = Convert.ToInt32(row["questitem1"]);
            creature.QuestItem2 = Convert.ToInt32(row["questitem2"]);
            creature.QuestItem3 = Convert.ToInt32(row["questitem3"]);
            creature.QuestItem4 = Convert.ToInt32(row["questitem4"]);
            creature.QuestItem5 = Convert.ToInt32(row["questitem5"]);
            creature.QuestItem6 = Convert.ToInt32(row["questitem6"]);
            creature.MovementId = Convert.ToInt32(row["movementid"]);
            creature.RegenHealth = Convert.ToInt32(row["regenhealth"]);
            creature.Mechanic_immune_mask = Convert.ToInt32(row["mechanic_immune_mask"]);
            creature.Flags_extra = Convert.ToInt32(row["flags_extra"]);
            creature.ScriptName = (string)(row["scriptname"]);
            creature.WDBVerified = Convert.ToInt32(row["wdbverified"]);

            return creature;
        }

        //public async Task<TCItem> GetCreature(int id)
        //{

        //    DataTable dt = await ExecuteQuery("SELECT * FROM `creature_template` WHERE entry = @entry;", new MySqlParameter("@entry", id));

        //    return BuildCreature(row);

        //}

        public TCVendor BuildVendor(DataRow row)
        {

            TCVendor vendor = new TCVendor();
            vendor.Entry = Convert.ToInt32(row["entry"]);
            vendor.Slot = Convert.ToInt32(row["slot"]);
            vendor.Item = Convert.ToInt32(row["item"]);
            vendor.Maxcount = Convert.ToInt32(row["maxcount"]);
            vendor.Incrtime = Convert.ToInt32(row["incrtime"]);
            vendor.ExtendedCost = Convert.ToInt32(row["extendedcost"]);

            return vendor;
        }

        //public async Task<TCItem> GetVendor(int id)
        //{

        //    DataTable dt = await ExecuteQuery("SELECT * FROM `npc_vendor` WHERE entry = @entry;", new MySqlParameter("@entry", id));

        //    return BuildVendor(row);

        //}

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
