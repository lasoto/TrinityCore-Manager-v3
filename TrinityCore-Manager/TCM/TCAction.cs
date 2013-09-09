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

        public static async Task SetAccountLock(string accountName, AccountLockType lockType, bool locked)
        {

            string lType;

            if (lockType == AccountLockType.Country)
                lType = "country";
            else
                lType = "ip";

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.AccountLock.BuildCommand(lType, locked ? "on" : "off"));
            //TODO: else

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

        public static async Task AnnounceToServer(string message)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.ServerAnnouncement.BuildCommand(message));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task NotifiyServer(string notification)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.ServerNotification.BuildCommand(notification));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task SendMessageToPlayer(string playerName, string message)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.SendPlayerMessage.BuildCommand(playerName, message));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task SendMail(string playerName, string subject, string text)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.SendMail.BuildCommand(playerName, "\"" + subject + "\"", "\"" + text + "\""));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task SendMoney(string playerName, string subject, string text, int money)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.SendMoney.BuildCommand(playerName, "\"" + subject + "\"", "\"" + text + "\"", money.ToString()));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task SendItems(string playerName, string subject, string text, params MailItem[] items)
        {

            if (_tcm.Online)
            {

                if (items.Length < 1)
                    throw new Exception("At least one item is required!");

                string[] cmdArgs = new string[items.Length];

                for (int i = 0; i < items.Length; i++)
                {
                    cmdArgs[i] = items[i].ItemId + ":" + items[i].Count;
                }

                await GetClient().SendMessage(TCCommand.SendItems.BuildCommand(playerName, "\"" + subject + "\"", "\"" + text + "\"", string.Join(" ", cmdArgs)));

            }
            else
            {
                throw new Exception("Server is not online!");
            }

        }

        public static async Task NotifyGMs(string message)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.NotifyGMs.BuildCommand(message));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task RevivePlayer(string playerName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.RevivePlayer.BuildCommand(playerName));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task ForceCharRename(string playerName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.ForceCharRename.BuildCommand(playerName));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task BanCharacter(string playerName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.BanCharacter.BuildCommand(playerName));
            //TODO: else

        }

        public static async Task DeleteCharacter(string playerName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.DeleteCharacter.BuildCommand(playerName));
            //TODO: else

        }

        public static async Task ModifyAccountLevel(string playerName, int newLevel)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.ModifyPlayerLevel.BuildCommand(playerName, newLevel.ToString()));
            //TODO: else

        }

        public static async Task RenameCharacter(string oldName, string newName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.RenameCharacter.BuildCommand(oldName, newName));
            //TODO: else

        }

        public static async Task CustomizeCharacter(string playerName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.CustomizeCharacter.BuildCommand(playerName));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task MutePlayer(string playerName, int timeInMin, string reason = "")
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.MutePlayer.BuildCommand(playerName, timeInMin.ToString(), reason));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task UnmutePlayer(string playerName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.UnmutePlayer.BuildCommand(playerName));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task UnstuckPlayer(string playerName, UnstuckLocation location)
        {

            string loc;

            if (location == UnstuckLocation.Graveyard)
                loc = "graveyard";
            else if (location == UnstuckLocation.Inn)
                loc = "inn";
            else if (location == UnstuckLocation.StartZone)
                loc = "startzone";
            else
                loc = String.Empty;

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.UnstuckPlayer.BuildCommand(playerName, loc));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task StopCombatForPlayer(string playerName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.StopCombatForPlayer.BuildCommand(playerName));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task RepairCharacterItems(string playerName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.RepairCharacterItems.BuildCommand(playerName));
            else
                throw new Exception("Server is not online");

        }

        public static async Task SaveAllPlayers()
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.SaveAll.BuildCommand());
            else
                throw new Exception("Server is not online!");

        }

        public static async Task CreateGuild(string guildName, string leaderName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.CreateGuild.BuildCommand("\"" + guildName + "\"", leaderName));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task DeleteGuild(string guildName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.DeleteGuild.BuildCommand("\"" + guildName + "\""));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task InviteToGuild(string playerName, string guildName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.GuildInvite.BuildCommand(playerName, "\"" + guildName + "\""));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task UninviteFromGuild(string playerName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.GuildUninvite.BuildCommand(playerName));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task SetPlayerGuildRank(string playerName, int rank)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.SetGuildRank.BuildCommand(playerName, rank.ToString()));
            else
                throw new Exception("Server is not online!");

        }

        public static async Task RenameGuild(string oldGuildName, string newGuildName)
        {

            if (_tcm.Online)
                await GetClient().SendMessage(TCCommand.RenameGuild.BuildCommand("\"" + oldGuildName + "\"", "\"" + newGuildName + "\""));
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

    public class MailItem
    {

        public int ItemId { get; set; }

        public int Count { get; set; }

    }

    public enum AccountLockType
    {
        Country,
        Ip
    }

    public enum UnstuckLocation
    {
        Inn,
        Graveyard,
        StartZone
    }

}
