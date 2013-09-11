using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Classes
{
    public class GuildMember
    {

        public int GuildId { get; set; }
        public int Guid { get; set; }
        public int Rank { get; set; }
        public string PNote { get; set; }
        public string Offnote { get; set; }

    }
}
