using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Classes
{
    public class IPBan
    {

        public string IP { get; set; }
        public DateTime BanDate { get; set; }
        public DateTime UnbanDate { get; set; }
        public string BannedBy { get; set; }
        public string BanReason { get; set; }

    }
}
