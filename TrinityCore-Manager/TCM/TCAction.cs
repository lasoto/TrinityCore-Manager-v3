using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore_Manager.Commands;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.Properties;

namespace TrinityCore_Manager.TCM
{
    public static class TCAction
    {

        private static TCManager _tcm = TCManager.Instance;

        public static async Task AddAccount(string username, string password)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.CreateAccount.BuildCommand(username, password));
            else
                await _tcm.AuthDatabase.CreateAccount(username, password, 0, 0);

        }

        public static async Task BanAccount(string username, int bantime, string reason)
        {
            await GetClient().SendMessage(TCCommand.BanAccount.BuildCommand(username, bantime.ToString(), reason));
        }

        public static async Task SetGMLevel(string username, int gmlevel, int realmid)
        {
            await GetClient().SendMessage(TCCommand.SetGMLevel.BuildCommand(username, gmlevel.ToString(), realmid.ToString()));
        }

        private static TCMClient GetClient()
        {

            TCMClient client = IsRA() ? _tcm.RAClient : _tcm.WorldClient;

            if (client == null)
                throw new NullReferenceException("client");

            return client;

        }

        private static bool IsRA()
        {
            return Settings.Default.ServerType == (int)ServerType.RemoteAccess;
        }

    }
}
