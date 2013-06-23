using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Classes
{
    class BannedAccount
    {
        public int Id { get; set; }
        public int BanDate { get; set; }
        public int UnbanDate { get; set; }
        public string BannedBy { get; set; }
        public bool Active { get; set; }

        public BannedAccount(int id, int banDate, int unbanDate, string bannedBy, bool active)
        {
            this.Id = id;
            this.BanDate = banDate;
            this.UnbanDate = unbanDate;
            this.BannedBy = bannedBy;
            this.Active = active;
        }
    }
}
