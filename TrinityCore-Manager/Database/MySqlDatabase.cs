using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TrinityCore_Manager.Database
{
    class MySqlDatabase : IDatabase
    {

        public string ConnectionString { get; private set; }

        public MySqlDatabase(string serverHost, int port, string username, string password, string dbName)
        {

            var connStr = new MySqlConnectionStringBuilder();
            connStr.Server = serverHost;
            connStr.Port = (uint)port;
            connStr.UserID = username;
            connStr.Password = password;
            connStr.Database = dbName;
            connStr.AllowUserVariables = true;

            ConnectionString = connStr.ToString();

        }

        public void CleanupAccounts(DateTime date)
        {
            ExecuteNonQuery("DELETE FROM `auth`.`account` WHERE `last_login` < @date AND `joindate` < @date;", new MySqlParameter("@date", date.ToString("yyyy-MM-dd HH:mm:ss")));
            ExecuteNonQuery("DELETE FROM `auth`.`account` WHERE `last_login` < @date AND `last_login` <> '0000-00-00 00:00:00';", new MySqlParameter("@date", date.ToString("yyyy-MM-dd HH:mm:ss")));
        }

        #region Helper Methods

        public void ExecuteNonQuery(string nonQuery, params MySqlParameter[] mParams)
        {

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {

                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(nonQuery, conn))
                {

                    foreach (var param in mParams)
                    {
                        cmd.Parameters.Add(param);
                    }

                    cmd.ExecuteNonQuery();

                }

                conn.Close();

            }

        }

        public DataTable ExecuteQuery(string query, params MySqlParameter[] mParams)
        {

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {

                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    foreach (var param in mParams)
                    {
                        cmd.Parameters.Add(param);
                    }

                    var reader = cmd.ExecuteReader();

                    var dt = new DataTable();
                    dt.Load(reader);

                    conn.Close();

                    return dt;

                }

            }

        }

        #endregion

    }
}
