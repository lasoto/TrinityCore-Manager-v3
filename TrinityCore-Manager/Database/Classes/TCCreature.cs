using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore_Manager.Database.Enums;
using TrinityCore_Manager.Database.Enums.Creature_Enums;
using TrinityCore_Manager.Database.Enums.Item_Enums;
using TrinityCoreManager.Database.Enums.Item_Enums;

namespace TrinityCore_Manager.Database.Classes
{
    public class TCCreature
    {
        public int Entry { get; set; }
        public int Difficulty_entry_1 { get; set; }
        public int Difficulty_entry_2 { get; set; }
        public int Difficulty_entry_3 { get; set; }
        public int KillCredit1 { get; set; }
        public int KillCredit2 { get; set; }
        public int Modelid1 { get; set; }
        public int Modelid2 { get; set; }
        public int Modelid3 { get; set; }
        public int Modelid4 { get; set; }
        public string Name { get; set; }
        public string Subname { get; set; }
        public string IconName { get; set; }
        public int Gossip_menu_id { get; set; }
        public int Minlevel { get; set; }
        public int Maxlevel { get; set; }
        public int Exp { get; set; }
        public int Faction_A { get; set; }
        public int Faction_H { get; set; }
        public int Npcflag { get; set; }
        public double Speed_walk { get; set; }
        public double Speed_run { get; set; }
        public double Scale { get; set; }
        public CreatureRank Rank { get; set; }
        public double Mindmg { get; set; }
        public double Maxdmg { get; set; }
        public int Dmgschool { get; set; }
        public int Attackpower { get; set; }
        public double Dmg_multiplier { get; set; }
        public int Baseattacktime { get; set; }
        public int Rangeattacktime { get; set; }
        public int Unit_class { get; set; }
        public int Unit_flags { get; set; }
        public int Unit_flags2 { get; set; }
        public int Dynamicflags { get; set; }
        public CreatureFamily Family { get; set; }
        public int Trainer_type { get; set; }
        public int Trainer_spell { get; set; }
        public int Trainer_class { get; set; }
        public int Trainer_race { get; set; }
        public double Minrangedmg { get; set; }
        public double Maxrangedmg { get; set; }
        public int Rangedattackpower { get; set; }
        public CreatureType Type { get; set; }
        public int Type_flags { get; set; }
        public int Lootid { get; set; }
        public int Pickpocketloot { get; set; }
        public int Skinloot { get; set; }
        public int Resistance1 { get; set; }
        public int Resistance2 { get; set; }
        public int Resistance3 { get; set; }
        public int Resistance4 { get; set; }
        public int Resistance5 { get; set; }
        public int Resistance6 { get; set; }
        public int Spell1 { get; set; }
        public int Spell2 { get; set; }
        public int Spell3 { get; set; }
        public int Spell4 { get; set; }
        public int Spell5 { get; set; }
        public int Spell6 { get; set; }
        public int Spell7 { get; set; }
        public int Spell8 { get; set; }
        public int PetSpellDataId { get; set; }
        public int VehicleId { get; set; }
        public int Mingold { get; set; }
        public int Maxgold { get; set; }
        public string AIName { get; set; }
        public int MovementType { get; set; }
        public int InhabitType { get; set; }
        public double HoverHeight { get; set; }
        public double Health_mod { get; set; }
        public double Mana_mod { get; set; }
        public double Armor_mod { get; set; }
        public int RacialLeader { get; set; }
        public int QuestItem1 { get; set; }
        public int QuestItem2 { get; set; }
        public int QuestItem3 { get; set; }
        public int QuestItem4 { get; set; }
        public int QuestItem5 { get; set; }
        public int QuestItem6 { get; set; }
        public int MovementId { get; set; }
        public int RegenHealth { get; set; }
        public int Mechanic_immune_mask { get; set; }
        public int Flags_extra { get; set; }
        public string ScriptName { get; set; }
        public int WDBVerified { get; set; }

    }
}
