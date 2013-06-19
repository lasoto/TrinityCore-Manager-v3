using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database.Classes
{
    class Account
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Hash { get; set; }
        public string SessionKey { get; set; }
        public string V { get; set; }
        public string S { get; set; }
        public string Email { get; set; }

    }
}
