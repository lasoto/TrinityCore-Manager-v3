using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Classes
{
    class Guild
    {
        public int guildid { get; set; }
        public string name { get; set; }
        public string leaderguid { get; set; }
        public byte EmblemStyle { get; set; }
        public byte EmblemColor { get; set; }
        public byte BorderStyle { get; set; }
        public byte BorderColor { get; set; }
        public byte BackgroungColor { get; set; }
        public string info { get; set; }
        public string motd { get; set; }
        public int createdate { get; set; }
        public string BankMoney { get; set; }
    }
}
