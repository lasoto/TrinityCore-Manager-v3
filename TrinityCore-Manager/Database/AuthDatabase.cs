using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TrinityCore_Manager.Database.Classes;

namespace TrinityCore_Manager.Database
{
    class AuthDatabase : MySqlDatabase
    {

        public AuthDatabase(string serverHost, int port, string username, string password, string dbName)
            : base(serverHost, port, username, password, dbName)
        {
        }

        public void CreateAccount(string username, string password, int gmlevel, int expansion)
        {
            ExecuteNonQuery("INSERT INTO `account` (`username`, `sha_pass_hash`, `expansion`) VALUES (@username, SHA1(CONCAT(UPPER(`" + username + "`), ':', UPPER(`" + password + "`))), @expansion)", new MySqlParameter("@username", username), new MySqlParameter("@expansion", expansion));
            ExecuteNonQuery("INSERT INTO `account_access` (`gmlevel`) VALUES (@gmlevel)", new MySqlParameter("@gmlevel", gmlevel));
        }

        public List<BannedAccount> GetAccounts()
        {

            DataTable ds = ExecuteQuery("SELECT `id` FROM `account`");

            Console.WriteLine(ds.Rows.Count);

            var accts = new List<BannedAccount>();

            foreach (DataRow row in ds.Rows)
            {
                accts.Add(new BannedAccount((int)row["id"], (int)row["bandate"], (int)row["unbandate"], (string)row["bannedby"], ((int)row["active"]) == 1));
            }

            return accts;

        }
        
        public void CleanupAccounts(DateTime date)
        {
            ExecuteNonQuery("DELETE FROM `auth`.`account` WHERE `last_login` < @date AND `joindate` < @date;", new MySqlParameter("@date", date.ToString("yyyy-MM-dd HH:mm:ss")));
            ExecuteNonQuery("DELETE FROM `auth`.`account` WHERE `last_login` < @date AND `last_login` <> '0000-00-00 00:00:00';", new MySqlParameter("@date", date.ToString("yyyy-MM-dd HH:mm:ss")));
        }

    }
}
