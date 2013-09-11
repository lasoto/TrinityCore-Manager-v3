using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Classes
{
    class Guild
    {
        public int Guildid { get; set; }
        public string Name { get; set; }
        public int Leaderguid { get; set; }
        public byte EmblemStyle { get; set; }
        public byte EmblemColor { get; set; }
        public byte BorderStyle { get; set; }
        public byte BorderColor { get; set; }
        public byte BackgroundColor { get; set; }
        public string Info { get; set; }
        public string Motd { get; set; }
        public DateTime CreateDate { get; set; }
        public long BankMoney { get; set; }
    }
}
