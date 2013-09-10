using System;

namespace TrinityCore_Manager.Database.Classes
{
    class PlayerInformation
    {
        public string CharacterName { get; set; }
        public DateTime LastLogin { get; set; }
        public string LastIp { get; set; }
        public string Email { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public string Map { get; set; }
        public string Money { get; set; }
        public string Account { get; set; }
        public string AccountId { get; set; }
        public string GmLevel { get; set; }
        public string PlayedTime { get; set; }
        public int Level { get; set; }
        public string Area { get; set; }
        public int Phase { get; set; }
    }
}
