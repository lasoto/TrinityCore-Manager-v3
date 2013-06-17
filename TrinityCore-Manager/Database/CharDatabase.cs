using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Database
{
    class CharDatabase : MySqlDatabase
    {
        public CharDatabase(string serverHost, int port, string username, string password, string dbName) : base(serverHost, port, username, password, dbName)
        {
        }
    }
}
