using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Classes
{
    class Character
    {
        public int guid { get; set; } // int
        public int account { get; set; } // int
        public string name { get; set; } // varchar
        public byte race { get; set; } // tinyint
        public byte Class { get; set; } // tinyint
        public byte gender { get; set; } // tinyint
        public byte level { get; set; } // tinyint
        public int xp { get; set; } // int
        public int money { get; set; } // int
        public int playerBytes { get; set; } // int
        public int playerBytes2 { get; set; } // int
        public int playerFlags { get; set; } // int
        public double position_x { get; set; } // float
        public double position_y { get; set; } // float
        public double position_z { get; set; } // float
        public int map { get; set; } // not sure if this should be int, in the table design it says it's 'smallint'
        public int instance_id { get; set; } // int
        public byte instance_mode_mask { get; set; } // tinyint
        public double orientation { get; set; } // double
        public string taximask { get; set; } // text
        public byte online { get; set; }  // tinyint
        public byte cinematic { get; set; }  // tinyint
        public int totaltime { get; set; }  // int
        public int leveltime { get; set; }  // int
        public int logout_time { get; set; } // int
        public byte is_logout_resting { get; set; } // tinyint
        public double rest_bonus { get; set; } // float
        public int resettalents_cost { get; set; } // int
        public int resettalent_time { get; set; } // int
        public double trans_x { get; set; } // float
        public double trans_y { get; set; } // float
        public double trans_z { get; set; } // float
        public double trans_o { get; set; } // float
        public int transguid { get; set; } // not sure if this should be int, in the table design it says it's 'mediumint'
        public int extra_flags { get; set; } // not sure if this should be int, in the table design it says it's 'smallint'
        public byte stable_slots { get; set; } // tinyint
        public int at_login { get; set; } // not sure if this should be int, in the table design it says it's 'smallint'
        public int zone { get; set; }  // not sure if this should be int, in the table design it says it's 'smallint'
        public int death_expire_time { get; set; } // int
        public string taxi_path { get; set; } // text
        public int arena_points { get; set; } // int
        public int totalHonorPoints { get; set; } // int
        public int todayHonorPoints { get; set; } // int
        public int yesterdayHonorPoints { get; set; } // int
        public int totalKills { get; set; } // int
        public int todayKills { get; set; } // not sure if this should be int, in the table design it says it's 'smallint'
        public int yesterdayKills { get; set; } // not sure if this should be int, in the table design it says it's 'smallint'
        public int chosenTitle { get; set; } // int
        public string knownCurrencies { get; set; } // not sure if this should be string, in the table design it says it's 'bigint'
        public int watchedFaction { get; set; } // int
        public byte drunk { get; set; } // tinyint
        public int health { get; set; } // int
        public int power1 { get; set; } // int
        public int power2 { get; set; } // int
        public int power3 { get; set; } // int
        public int power4 { get; set; } // int
        public int power5 { get; set; } // int
        public int power6 { get; set; } // int
        public int power7 { get; set; } // int
        public int latency { get; set; } // not sure if this should be int, in the table design it says it's 'mediumint'
        public byte speccount { get; set; } // tinyint
        public byte activespec { get; set; } // tinyint
        public string exploredZones { get; set; } // longtext
        public string equipmentCache { get; set; } // longtext
        public int ammoId { get; set; }  // int
        public string knownTitles { get; set; } // longtext
        public byte actionBars { get; set; } // tinyint
        public byte grantableLevels { get; set; } // tinyint
        public int deleteInfos_Account { get; set; } // int
        public string deleteInfos_Name { get; set; } // varchar
        public int deleteDate { get; set; } // int
    }
}
