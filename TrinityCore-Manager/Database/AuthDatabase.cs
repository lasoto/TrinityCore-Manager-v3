using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TrinityCore_Manager.Database
{
    class AuthDatabase : MySqlDatabase
    {

        public AuthDatabase(string serverHost, int port, string username, string password, string dbName) : base(serverHost, port, username, password, dbName)
        {
        }

        public void CleanupAccounts(DateTime date)
        {
            ExecuteNonQuery("DELETE FROM `auth`.`account` WHERE `last_login` < @date AND `joindate` < @date;", new MySqlParameter("@date", date.ToString("yyyy-MM-dd HH:mm:ss")));
            ExecuteNonQuery("DELETE FROM `auth`.`account` WHERE `last_login` < @date AND `last_login` <> '0000-00-00 00:00:00';", new MySqlParameter("@date", date.ToString("yyyy-MM-dd HH:mm:ss")));
        }

    }
}
