using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore_Manager.Commands;
using TrinityCore_Manager.Database.Enums;
using TrinityCore_Manager.Extensions;
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

        public static async Task BanAccount(string username, int bantime, string bannedBy, string reason)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.BanAccount.BuildCommand(username, bantime.ToString(), reason));
            else
                await _tcm.AuthDatabase.BanAccount(username, Convert.ToInt32(DateTime.Now.ToUnixTimestamp()), bantime, bannedBy, reason);

        }

        public static async Task SetGMLevel(string username, GMLevel gmlevel, int realmid)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.SetGMLevel.BuildCommand(username, ((int)gmlevel).ToString(), realmid.ToString()));
            else
                await _tcm.AuthDatabase.SetGMLevel(username, gmlevel, realmid);

        }

        public static async Task SetPlayerExpansion(string username, Expansion exp)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.SetPlayerExpansion.BuildCommand(username, ((int)exp).ToString()));
            else
                await _tcm.AuthDatabase.ChangeAccountExpansion(username, exp);


        }

        public static async Task SetPlayerPassword(string username, string password)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.SetPassword.BuildCommand(username, password, password));
            else
                await _tcm.AuthDatabase.ChangeAccountPassword(username, password);

        }

        public static async Task BanIPAddress(string ip, int bantime, int unbantime, string bannedBy, string banReason)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.BanIP.BuildCommand(ip, bantime.ToString(), unbantime.ToString(), banReason));
            else
                await _tcm.AuthDatabase.AddIpBan(ip, Convert.ToInt64(bantime).ToDateTime(), Convert.ToInt64(unbantime).ToDateTime(), bannedBy, banReason);

        }

        public static async Task UnbanIPAddress(string ip)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.UnbanIP.BuildCommand(ip));
            else
                await _tcm.AuthDatabase.RemoveIpBan(ip);

        }

        public static async Task KickPlayer(string player, string reason)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.KickPlayer.BuildCommand(player, reason));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task ExecuteCommand(string command)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(command);
            else
                throw new Exception("Server is not online!");

        }

        public static async Task SetPlayerLimit(int limit)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.SetPlayerLimit.BuildCommand(limit.ToString()));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task SetServerMotd(string motd)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.SetMOTD.BuildCommand(motd));
            else
                throw new Exception("Server is not online!");

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
