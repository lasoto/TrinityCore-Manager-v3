using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using TrinityCore_Manager.Database.Classes;
using TrinityCore_Manager.Extensions;
using TrinityCore_Manager.Database.Enums;

namespace TrinityCore_Manager.Database
{
    class CharDatabase : MySqlDatabase
    {
        public CharDatabase(string serverHost, int port, string username, string password, string dbName)
            : base(serverHost, port, username, password, dbName)
        {
        }

        public async Task AddGuildMember(int guildid, int guid, int rid)
        {

            await ExecuteNonQuery("INSERT INTO `guild_member` (guildid, guid, rank, pnote, offnote) VALUES (@guildid, @guid, @rank, @pnote, @offnote);",
                new MySqlParameter("@guildid", guildid), new MySqlParameter("@guid", guid), new MySqlParameter("@rank", rid), new MySqlParameter("@pnote", String.Empty),
                new MySqlParameter("@offnote", String.Empty));

        }

        public async Task RemoveGuildMember(int guid)
        {
            await ExecuteNonQuery("DELETE FROM `guild_member` WHERE guid = @guid", new MySqlParameter("@guid", guid));
        }

        public async Task CreateGuild(string name, int leaderguid)
        {

            object newGuid = await ExecuteScalar("SELECT MAX(guildid) FROM guild;");

            int max;

            if (newGuid == DBNull.Value)
                max = 0;
            else
                max = Convert.ToInt32((uint)newGuid);

            await ExecuteNonQuery("INSERT INTO `guild` (`guildid`, `name`, `leaderguid`, `info`, `motd`, `createdate`) VALUES (@guildid, @name, @leaderguid, @info, @motd, @createdate);",
                new MySqlParameter("@guildid", ++max), new MySqlParameter("@name", name), new MySqlParameter("@leaderguid", leaderguid), new MySqlParameter("@info", ""),
                new MySqlParameter("@motd", "No message set."),
                new MySqlParameter("@createdate", DateTime.Now.ToUnixTimestamp()));

            await ExecuteNonQuery("INSERT INTO `guild_rank` (guildid, rid, rname, rights, BankMoneyPerDay) VALUES (@guildid, @rid, @rname, @rights, @BankMoneyPerDay);",
                new MySqlParameter("@guildid", max), new MySqlParameter("@rid", (object)0), new MySqlParameter("@rname", "Guild Master"), new MySqlParameter("@rights", (int)GuildRanks.GR_RIGHT_ALL),
                new MySqlParameter("@BankMoneyPerDay", (object)0));

            await ExecuteNonQuery("INSERT INTO `guild_rank` (guildid, rid, rname, rights, BankMoneyPerDay) VALUES (@guildid, @rid, @rname, @rights, @BankMoneyPerDay);",
                new MySqlParameter("@guildid", max), new MySqlParameter("@rid", (object)1), new MySqlParameter("@rname", "Officer"), new MySqlParameter("@rights", (int)GuildRanks.GR_RIGHT_ALL),
                new MySqlParameter("@BankMoneyPerDay", (object)0));

            await ExecuteNonQuery("INSERT INTO `guild_rank` (guildid, rid, rname, rights, BankMoneyPerDay) VALUES (@guildid, @rid, @rname, @rights, @BankMoneyPerDay);",
                new MySqlParameter("@guildid", max), new MySqlParameter("@rid", (object)2), new MySqlParameter("@rname", "Veteran"), new MySqlParameter("@rights", 67),
                new MySqlParameter("@BankMoneyPerDay", (object)0));

            await ExecuteNonQuery("INSERT INTO `guild_rank` (guildid, rid, rname, rights, BankMoneyPerDay) VALUES (@guildid, @rid, @rname, @rights, @BankMoneyPerDay);",
                new MySqlParameter("@guildid", max), new MySqlParameter("@rid", (object)3), new MySqlParameter("@rname", "Member"), new MySqlParameter("@rights", 67),
                new MySqlParameter("@BankMoneyPerDay", (object)0));

            await ExecuteNonQuery("INSERT INTO `guild_rank` (guildid, rid, rname, rights, BankMoneyPerDay) VALUES (@guildid, @rid, @rname, @rights, @BankMoneyPerDay);",
                new MySqlParameter("@guildid", max), new MySqlParameter("@rid", (object)4), new MySqlParameter("@rname", "Initiate"), new MySqlParameter("@rights", 67),
                new MySqlParameter("@BankMoneyPerDay", (object)0));

            await AddGuildMember(max, leaderguid, 0);

        }

        public async Task RemoveGuild(int guildid)
        {
            await ExecuteNonQuery("DELETE FROM `guild` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_member` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_rank` WHERE guildid = @guildid;", new MySqlParameter(@"guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_bank_eventlog` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_bank_item` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_bank_right` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_bank_tab` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_eventlog` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
        }

        public async Task DeleteGuild(int guildid)
        {
            await ExecuteNonQuery("DELETE FROM `guild` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_member` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_rank` WHERE guildid = @guildid;", new MySqlParameter(@"guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_bank_eventlog` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_bank_item` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_bank_right` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_bank_tab` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
            await ExecuteNonQuery("DELETE FROM `guild_eventlog` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));
        }

        public async Task UpdateGuildRank(int guildid, int memberId, int rank)
        {
            await ExecuteNonQuery("UPDATE `guild_member` SET rank = @rank WHERE guid = @guid;", new MySqlParameter("@rank", rank), new MySqlParameter("@guid", memberId));
            await ExecuteNonQuery("UPDATE `guild` SET leaderguid = @leaderguid WHERE guildid = @guildid;", new MySqlParameter("@leaderguid", memberId), new MySqlParameter("@guildid", guildid));
        }

        public async Task CreateGuild(string name, string leaderName)
        {

            DataTable dt = await ExecuteQuery("SELECT `guid` FROM `characters` WHERE name = @name;", new MySqlParameter("@name", leaderName));

            if (dt.Rows.Count == 0)
                return;

            await CreateGuild(name, Convert.ToInt32((uint)dt.Rows[0]["guid"]));

        }

        private Guild BuildGuild(DataRow row)
        {

            Guild guild = new Guild();

            guild.Guildid = Convert.ToInt32((uint)row["guildid"]);
            guild.Name = (string)row["name"];
            guild.Leaderguid = Convert.ToInt32((uint)row["leaderguid"]);
            guild.EmblemStyle = (byte)row["EmblemStyle"];
            guild.EmblemColor = (byte)row["EmblemColor"];
            guild.BorderStyle = (byte)row["BorderStyle"];
            guild.BorderColor = (byte)row["BorderColor"];
            guild.BackgroundColor = (byte)row["BackgroundColor"];
            guild.Info = (string)row["info"];
            guild.Motd = (string)row["motd"];
            guild.CreateDate = Convert.ToInt64((uint)row["createdate"]).ToDateTime();
            guild.BankMoney = Convert.ToInt64((UInt64)row["BankMoney"]);

            return guild;

        }

        public async Task<List<Guild>> GetGuilds()
        {

            DataTable dt = await ExecuteQuery("SELECT * FROM `guild`");

            List<Guild> guilds = new List<Guild>();

            foreach (DataRow row in dt.Rows)
            {
                guilds.Add(BuildGuild(row));
            }

            return guilds;

        }

        public async Task<Guild> GetGuild(int guildid)
        {

            DataTable dt = await ExecuteQuery("SELECT * FROM `guild` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));

            if (dt.Rows.Count == 0)
                return null;

            return BuildGuild(dt.Rows[0]);

        }

        public async Task<Guild> GetGuild(string guildName)
        {

            DataTable dt = await ExecuteQuery("SELECT * FROM `guild` WHERE name = @name;", new MySqlParameter("@name", guildName));

            if (dt.Rows.Count == 0)
                return null;

            return BuildGuild(dt.Rows[0]);

        }

        private GuildMember BuildGuildMember(DataRow row)
        {

            GuildMember member = new GuildMember();

            member.GuildId = Convert.ToInt32((uint)row["guildid"]);
            member.Guid = Convert.ToInt32((uint)row["guid"]);
            member.Rank = Convert.ToInt32((byte)row["rank"]);
            member.Offnote = (string)row["offnote"];
            member.PNote = (string)row["pnote"];

            return member;

        }

        public async Task<List<GuildMember>> GetGuildMembers(int guildid)
        {

            DataTable dt = await ExecuteQuery("SELECT * FROM `guild_member` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));

            List<GuildMember> members = new List<GuildMember>();

            foreach (DataRow row in dt.Rows)
            {
                members.Add(BuildGuildMember(row));
            }

            return members;

        }

        public async Task<GuildMember> GetGuildMember(int guid)
        {

            DataTable dt = await ExecuteQuery("SELECT * FROM `guild_member` WHERE guid = @guid;", new MySqlParameter("@guid", guid));

            if (dt.Rows.Count == 0)
                return null;

            return BuildGuildMember(dt.Rows[0]);

        }

        public async Task<GuildMember> GetGuildMember(string charName)
        {

            DataTable dt = await ExecuteQuery("SELECT `guid` FROM `characters` WHERE name = @name;", new MySqlParameter("@name", charName));

            if (dt.Rows.Count == 0)
                return null;

            int guid = Convert.ToInt32((uint)dt.Rows[0]["guid"]);

            return await GetGuildMember(guid);

        }

        public async Task<string> GetCharacterName(int guid)
        {

            DataTable dt = await ExecuteQuery("SELECT `name` FROM `characters` WHERE guid = @guid;", new MySqlParameter("@guid", guid));

            if (dt.Rows.Count == 0)
                return null;

            return (string)dt.Rows[0]["name"];

        }

        private TCCharacter BuildCharacter(DataRow row)
        {

            TCCharacter character = new TCCharacter();
            character.Guid = Convert.ToInt32(row["guid"]);
            character.Account = Convert.ToInt32(row["account"]);
            character.Name = (string)row["name"];
            character.Race = CharacterRaceHelper.GetCharacterRace(Convert.ToInt32(row["race"]));
            character.Class = CharacterClassHelper.GetCharacterClass(Convert.ToInt32(row["class"]));
            character.Level = Convert.ToInt32(row["level"]);
            character.Money = Convert.ToInt32(row["money"]);
            character.Online = Convert.ToBoolean(row["online"]);

            return character;

        }

        public async Task<List<TCCharacter>> GetCharacters()
        {

            DataTable dt = await ExecuteQuery("SELECT `guid`, `account`, `name`, `race`, `class`, `level`, `money`, `online` FROM `characters`");

            List<TCCharacter> characters = new List<TCCharacter>();

            foreach (DataRow row in dt.Rows)
            {
                characters.Add(BuildCharacter(row));
            }

            return characters;

        }

        public async Task<int> GetCharacterGuid(string charName)
        {

            DataTable dt = await ExecuteQuery("SELECT `guid` FROM `characters` WHERE name = @name;", new MySqlParameter("@name", charName));

            if (dt.Rows.Count == 0)
                return -1;

            return Convert.ToInt32((uint)dt.Rows[0]["guid"]);

        }

        private MemberRank BuildMemberRank(DataRow row)
        {

            MemberRank rank = new MemberRank();
            rank.RankId = (byte)row["rid"];
            rank.RankName = (string)row["rname"];

            return rank;

        }

        public async Task<List<MemberRank>> GetMemberRanks(int guildid)
        {

            DataTable dt = await ExecuteQuery("SELECT `rid`, `rname` FROM `guild_rank` WHERE guildid = @guildid;", new MySqlParameter("@guildid", guildid));

            List<MemberRank> ranks = new List<MemberRank>();

            foreach (DataRow row in dt.Rows)
            {
                ranks.Add(BuildMemberRank(row));
            }

            return ranks;

        }

        //private PlayerInformation BuildPlayerInfo(DataRow row)
        //{



        //}

        //public async Task<PlayerInformation> GetPlayerInfo(string playerName)
        //{

        //    DataTable dt = await ExecuteQuery("SELECT `guid`, `account`, `name`, `race`, `class`, `gender`, `level`, `xp,`, `money`, `position_x`, `positio FROM `characters` WHERE name = @name", new MySqlParameter("@name", playerName));

        //    if (dt.Rows.Count == 0)
        //        return null;



        //}

        public async Task<List<string>> GetCharNamesNotInGuild()
        {

            DataTable dt = await ExecuteQuery("SELECT `guid` FROM `characters` WHERE `guid` NOT IN (SELECT `guid` FROM `guild_member`);");

            List<string> names = new List<string>();

            foreach (DataRow row in dt.Rows)
            {

                int guid = Convert.ToInt32((uint)row["guid"]);

                DataTable dt2 = await ExecuteQuery("SELECT `name` FROM `characters` WHERE guid = @guid;", new MySqlParameter("@guid", guid));

                if (dt2.Rows.Count == 0)
                    continue;

                names.Add((string)dt2.Rows[0]["name"]);

            }

            return names;

        }

    }
}
