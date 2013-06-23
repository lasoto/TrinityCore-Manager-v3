using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TrinityCore_Manager.Database.Classes;
using TrinityCore_Manager.Extensions;
using TrinityCore_Manager.Security;
using MySql.Data.Types;
using TrinityCore_Manager.Database.Enums;

namespace TrinityCore_Manager.Database
{
    class AuthDatabase : MySqlDatabase
    {

        public AuthDatabase(string serverHost, int port, string username, string password, string dbName)
            : base(serverHost, port, username, password, dbName)
        {
        }

        public async Task<bool> CreateAccount(string username, string password, int gmlevel, int expansion)
        {

            DataTable dt = await ExecuteQuery("SELECT id FROM `account` WHERE username = @username", new MySqlParameter("@username", username));

            if (dt.Rows.Count > 0)
                return false;

            await ExecuteNonQuery("INSERT INTO `account` (`username`, `sha_pass_hash`, `expansion`) VALUES (@username, @hash, @expansion)", new MySqlParameter("@username", username), new MySqlParameter("@hash", String.Format("{0}:{1}", username.ToUpper(), password.ToUpper()).ToSHA1()), new MySqlParameter("@expansion", expansion));


            dt = await ExecuteQuery("SELECT id FROM `account` WHERE username = @username", new MySqlParameter("@username", username));

            if (dt.Rows.Count != 1)
                return false;

            await ExecuteNonQuery("INSERT INTO `account_access` (`id`, `gmlevel`) VALUES (@id, @gmlevel)", new MySqlParameter("@id", (int)dt.Rows[0]["id"]), new MySqlParameter("@gmlevel", gmlevel));

            return true;

        }

        public async Task<GMLevel> GetAccountAccess(int accountId)
        {

            DataTable dt = await ExecuteQuery("SELECT `gmlevel` FROM `account_access` WHERE `id` = @id", new MySqlParameter("@id", accountId));

            if (dt.Rows.Count == 0)
                return GMLevel.NA;

            DataRow row = dt.Rows[0];

            int level = (byte)row["gmlevel"];

            return (GMLevel)level;

        }

        public async Task<Account> GetAccount(int acctId)
        {

            DataTable dt = await ExecuteQuery("SELECT * FROM `account` WHERE id = @id;", new MySqlParameter("@id", acctId));

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];


            int id = row["id"] != DBNull.Value ? (int)row["id"] : -1;
            string username = row["username"] != DBNull.Value ? (string)row["username"] : String.Empty;
            string shaHash = row["sha_pass_hash"] != DBNull.Value ? (string)row["sha_pass_hash"] : String.Empty;
            string email = row["email"] != DBNull.Value ? (string)row["email"] : String.Empty;
            DateTime joinDate = row["joindate"] != DBNull.Value && ((MySqlDateTime)row["joindate"]).IsValidDateTime ? ((MySqlDateTime)row["joindate"]).GetDateTime() : DateTime.Now;
            string lastip = row["last_ip"] != DBNull.Value ? (string)row["last_ip"] : String.Empty;
            int failedLogins = row["failed_logins"] != DBNull.Value ? (int)((uint)row["failed_logins"]) : 0;
            int locked = row["locked"] != DBNull.Value ? (int)((byte)row["locked"]) : 0;
            string lockCountry = row["lock_country"] != DBNull.Value ? (string)row["lock_country"] : String.Empty;
            DateTime lastLogin = row["last_login"] != DBNull.Value && ((MySqlDateTime)row["last_login"]).IsValidDateTime ? ((MySqlDateTime)row["last_login"]).GetDateTime() : DateTime.Now;
            bool online = row["online"] != DBNull.Value && (int)((sbyte)row["online"]) == 1;
            int exp = row["expansion"] != DBNull.Value ? (int)((byte)row["expansion"]) : 0;

            var acct = new Account();
            acct.Id = id;
            acct.Username = username;
            acct.Hash = shaHash;
            acct.Email = email;
            acct.JoinDate = joinDate;
            acct.LastIp = lastip;
            acct.FailedLogins = failedLogins;
            acct.Locked = locked;
            acct.LockCountry = lockCountry;
            acct.LastLogin = lastLogin;
            acct.Online = online;
            acct.Exp = (Expansion)exp;

            return acct;

        }

        public async Task<List<Account>> GetAccounts()
        {

            DataTable dt = await ExecuteQuery("SELECT * FROM `account`");

            var accts = new List<Account>();

            foreach (DataRow row in dt.Rows)
            {

                int id = row["id"] != DBNull.Value ? (int)row["id"] : -1;
                string username = row["username"] != DBNull.Value ? (string)row["username"] : String.Empty;
                string shaHash = row["sha_pass_hash"] != DBNull.Value ? (string)row["sha_pass_hash"] : String.Empty;
                string email = row["email"] != DBNull.Value ? (string)row["email"] : String.Empty;
                DateTime joinDate = row["joindate"] != DBNull.Value && ((MySqlDateTime)row["joindate"]).IsValidDateTime ? ((MySqlDateTime)row["joindate"]).GetDateTime() : DateTime.Now;
                string lastip = row["last_ip"] != DBNull.Value ? (string)row["last_ip"] : String.Empty;
                int failedLogins = row["failed_logins"] != DBNull.Value ? (int)((uint)row["failed_logins"]) : 0;
                int locked = row["locked"] != DBNull.Value ? (int)((byte)row["locked"]) : 0;
                string lockCountry = row["lock_country"] != DBNull.Value ? (string)row["lock_country"] : String.Empty;
                DateTime lastLogin = row["last_login"] != DBNull.Value && ((MySqlDateTime)row["last_login"]).IsValidDateTime ? ((MySqlDateTime)row["last_login"]).GetDateTime() : DateTime.Now;
                bool online = row["online"] != DBNull.Value && (int)((sbyte)row["online"]) == 1;
                int exp = row["expansion"] != DBNull.Value ? (int)((byte)row["expansion"]) : 0;

                var acct = new Account();
                acct.Id = id;
                acct.Username = username;
                acct.Hash = shaHash;
                acct.Email = email;
                acct.JoinDate = joinDate;
                acct.LastIp = lastip;
                acct.FailedLogins = failedLogins;
                acct.Locked = locked;
                acct.LockCountry = lockCountry;
                acct.LastLogin = lastLogin;
                acct.Online = online;
                acct.Exp = (Expansion)exp;

                accts.Add(acct);

            }

            return accts;

        }

        public async Task<List<BannedAccount>> GetBannedAccounts()
        {

            DataTable dt = await ExecuteQuery("SELECT * FROM `account_banned` WHERE active = 1;");

            List<BannedAccount> bannedAccounts = new List<BannedAccount>();

            foreach (DataRow row in dt.Rows)
            {

                int id = Convert.ToInt32((uint)row["id"]);
                DateTime banDate = Convert.ToInt64(((uint)row["bandate"])).ToDateTime();
                DateTime unbanDate = Convert.ToInt64(((uint)row["unbandate"])).ToDateTime();
                string bannedby = (string)row["bannedby"];
                string banreason = (string)row["banreason"];
                bool active = ((byte)row["active"]) == 1;

                BannedAccount bannedAccount = new BannedAccount();
                bannedAccount.Id = id;
                bannedAccount.BanDate = banDate;
                bannedAccount.UnbanDate = unbanDate;
                bannedAccount.BannedBy = bannedby;
                bannedAccount.BanReason = banreason;
                bannedAccount.Active = active;

                bannedAccounts.Add(bannedAccount);

            }

            return bannedAccounts;

        }

        public async Task ModifyAccount(int accountId, string password, GMLevel acctLevel, Expansion exp)
        {

            Account acct = await GetAccount(accountId);

            if (acct == null)
                return;

            if (!string.IsNullOrEmpty(password))
                await ExecuteNonQuery("UPDATE `account` SET sha_pass_hash = @password, expansion = @expansion, sessionkey = '', v = '', s = '' WHERE `id` = @id;", new MySqlParameter("@password", (acct.Username.ToUpper() + ":" + password.ToUpper()).ToSHA1()), new MySqlParameter("@expansion", (int)exp), new MySqlParameter("@id", accountId));
            else
                await ExecuteNonQuery("UPDATE `account` SET expansion = @expansion WHERE `id` = @id;", new MySqlParameter("@expansion", (int)exp), new MySqlParameter("@id", accountId));

            await ExecuteNonQuery("UPDATE `account_access` SET gmlevel = @gmlevel WHERE `id` = @id;", new MySqlParameter("@gmlevel", (int)acctLevel), new MySqlParameter("@id", accountId));

        }

        public async Task CleanupAccounts(DateTime date)
        {
            await ExecuteNonQuery("DELETE FROM `auth`.`account` WHERE `last_login` < @date AND `joindate` < @date;", new MySqlParameter("@date", date.ToString("yyyy-MM-dd HH:mm:ss")));
            await ExecuteNonQuery("DELETE FROM `auth`.`account` WHERE `last_login` < @date AND `last_login` <> '0000-00-00 00:00:00';", new MySqlParameter("@date", date.ToString("yyyy-MM-dd HH:mm:ss")));
        }

        public async Task BanIp(string ip, DateTime bandate, DateTime unbandate, string bannedby, string banreason)
        {
            await ExecuteNonQuery("INSERT INTO `ip_banned` (`ip`, `bandate`, `unbandate`, `bannedby`, `banreason`) VALUES (@ip, @bandate, @unbandate, @bannedy, @banreason)", new MySqlParameter("@ip", ip), new MySqlParameter("@bandate", new MySqlDateTime(bandate)), new MySqlParameter("@unbandate", new MySqlDateTime(unbandate)), new MySqlParameter("@bannedby", bannedby), new MySqlParameter("@banreason", banreason));
        }

        public async Task RemoveAccountBan(int id)
        {
            await ExecuteNonQuery("UPDATE `account` SET `active` = 0 WHERE `id` = @id", new MySqlParameter("@id", id));
        }

        public async Task RemoveIpBan(string ip)
        {
            await ExecuteNonQuery("DELETE FROM `ip_banned` WHERE `ip` = @ip", new MySqlParameter("@ip", ip));
        }

    }
}
