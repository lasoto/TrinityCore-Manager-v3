using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore_Manager.Database.Enums;

namespace TrinityCore_Manager.Database.Classes
{
    class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Hash { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public string LastIp { get; set; }
        public int FailedLogins { get; set; }
        public int Locked { get; set; }
        public string LockCountry { get; set; }
        public DateTime LastLogin { get; set; }
        public bool Online { get; set; }
        public Expansion Exp { get; set; }
    }
}
