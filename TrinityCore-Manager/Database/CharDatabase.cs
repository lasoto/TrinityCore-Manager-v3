using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using TrinityCore_Manager.Database.Classes;

namespace TrinityCore_Manager.Database
{
    class CharDatabase : MySqlDatabase
    {
        public CharDatabase(string serverHost, int port, string username, string password, string dbName) : base(serverHost, port, username, password, dbName)
        {
        }

        public async void CreateGuild(string name, int leaderguid)
        {

            await ExecuteNonQuery("INSERT INTO `guild` (`name`, `leaderguid`) VALUES (@name, @leaderguid);", new MySqlParameter("@name", name), new MySqlParameter("@leaderguid", leaderguid));

        }

        internal Task<object> GetGuilds()
        {
            throw new NotImplementedException();
        }
    }
}
