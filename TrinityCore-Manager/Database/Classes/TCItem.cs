using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore_Manager.Database.Enums;
using TrinityCore_Manager.Database.Enums.Item_Enums;
using TrinityCoreManager.Database.Enums.Item_Enums;

namespace TrinityCore_Manager.Database.Classes
{
    public class TCItem
    {

        public int Entry { get; set; }
        public int Class { get; set; }
        public int Subclass { get; set; }
        public string Name { get; set; }
        public int DisplayId { get; set; }
        public int Quality { get; set; }
        public int Flags { get; set; }
        public int FlagsExra { get; set; }
        public int BuyCount { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public ItemInventoryType InvType { get; set; }
        public CharacterClass AllowableClass { get; set; }
        public CharacterRace AllowableRace { get; set; }
        public int ItemLevel { get; set; }
        public int RequiredLevel { get; set; }
        public int RequiredSkill { get; set; }
        public int RequiredSkillRank { get; set; }
        public int RequiredSpell { get; set; }
        public int RequiredHonorRank { get; set; }
        public int RequiredCityRank { get; set; }
        public int RequiredReputationFaction { get; set; }
        public ItemRequiredReputationRank RequiredReputationRank { get; set; }
        public int MaxCount { get; set; }
        public int Stackable { get; set; }
        public int ContainerSlots { get; set; }
        public int StatsCount { get; set; }
        public ItemStatType stat_type1 { get; set; }
        public int stat_value1 { get; set; }
        public ItemStatType stat_type2 { get; set; }
        public int stat_value2 { get; set; }
        public ItemStatType stat_type3 { get; set; }
        public int stat_value3 { get; set; }
        public ItemStatType stat_type4 { get; set; }
        public int stat_value4 { get; set; }
        public ItemStatType stat_type5 { get; set; }
        public int stat_value5 { get; set; }
        public ItemStatType stat_type6 { get; set; }
        public int stat_value6 { get; set; }
        public ItemStatType stat_type7 { get; set; }
        public int stat_value7 { get; set; }
        public ItemStatType stat_type8 { get; set; }
        public int stat_value8 { get; set; }
        public ItemStatType stat_type9 { get; set; }
        public int stat_value9 { get; set; }
        public ItemStatType stat_type10 { get; set; }
        public int stat_value10 { get; set; }
        public int ScalingStatDistribution { get; set; }
        public int ScalingStatValue { get; set; }
        public int Dmg_min1 { get; set; }
        public int Dmg_max1 { get; set; }
        public ItemDamageType Dmg_type1 { get; set; }
        public int Dmg_min2 { get; set; }
        public int Dmg_max2 { get; set; }
        public ItemDamageType Dmg_type2 { get; set; }
        public int Armor { get; set; }
        public int Holy_res { get; set; }
        public int Fire_res { get; set; }
        public int Nature_res { get; set; }
        public int Frost_res { get; set; }
        public int Shadow_res { get; set; }
        public int Arcane_res { get; set; }
        public int Delay { get; set; }
        public ItemAmmoType Ammo_Type { get; set; }
        public double RangedModRange { get; set; }
        public int Spellid_1 { get; set; }
        public int Spelltrigger_1 { get; set; }
        public int Spellcharges_1 { get; set; }
        public double Spellppmrate_1 { get; set; }
        public int Spellcooldown_1 { get; set; }
        public int Spellcategory_1 { get; set; }
        public int Spellcategorycooldown_1 { get; set; }
        public int Spellid_2 { get; set; }
        public int Spelltrigger_2 { get; set; }
        public int Spellcharges_2 { get; set; }
        public double Spellppmrate_2 { get; set; }
        public int Spellcooldown_2 { get; set; }
        public int Spellcategory_2 { get; set; }
        public int Spellcategorycooldown_2 { get; set; }
        public int Spellid_3 { get; set; }
        public int Spelltrigger_3 { get; set; }
        public int Spellcharges_3 { get; set; }
        public double Spellppmrate_3 { get; set; }
        public int Spellcooldown_3 { get; set; }
        public int Spellcategory_3 { get; set; }
        public int Spellcategorycooldown_3 { get; set; }
        public int Spellid_4 { get; set; }
        public int Spelltrigger_4 { get; set; }
        public int Spellcharges_4 { get; set; }
        public double Spellppmrate_4 { get; set; }
        public int Spellcooldown_4 { get; set; }
        public int Spellcategory_4 { get; set; }
        public int Spellcategorycooldown_4 { get; set; }
        public int Spellid_5 { get; set; }
        public int Spelltrigger_5 { get; set; }
        public int Spellcharges_5 { get; set; }
        public double Spellppmrate_5 { get; set; }
        public int Spellcooldown_5 { get; set; }
        public int Spellcategory_5 { get; set; }
        public int Spellcategorycooldown_5 { get; set; }
        public ItemBonding Bonding { get; set; }
        public string Description { get; set; }
        public int PageText { get; set; }
        public Language LanguageID { get; set; }
        public ItemPageMaterial PageMaterial { get; set; }
        public int Startquest { get; set; }
        public int Lockid { get; set; }
        public ItemMaterial Material { get; set; }
        public ItemSheath Sheath { get; set; }
        public int RandomProperty { get; set; }
        public int RandomSuffix { get; set; }
        public int Block { get; set; }
        public int ItemSet { get; set; }
        public int MaxDurability { get; set; }
        public int Area { get; set; }
        public int Map { get; set; }
        public int BagFamily { get; set; }
        public int TotemCategory { get; set; }
        public ItemSocketColor SocketColor_1 { get; set; }
        public int SocketContent_1 { get; set; }
        public ItemSocketColor SocketColor_2 { get; set; }
        public int SocketContent_2 { get; set; }
        public ItemSocketColor SocketColor_3 { get; set; }
        public int SocketContent_3 { get; set; }
        public int SocketBonus { get; set; }
        public int GemProperties { get; set; }
        public int RequiredDisenchantSkill { get; set; }
        public double ArmorDamageModifier { get; set; }
        public int Duration { get; set; }
        public int ItemLimitCategory { get; set; }
        public int HolidayId { get; set; }
        public string ScriptName { get; set; }
        public int DisenchantId { get; set; }
        public FoodType FoodType { get; set; }
        public int MinMoneyLoot { get; set; }
        public int MaxMoneyLoot { get; set; }
        public int FlagsCustom { get; set; }
        public int WDBVerified { get; set; }

    }
}
