namespace TrinityCore_Manager.Commands
{
    public enum TCCommand
    {
        [TCCommand("account create", 2)]
        CreateAccount,

        [TCCommand("ban account", 3)]
        BanAccount,

        [TCCommand("account set gmlevel", 3)]
        SetGMLevel,

        [TCCommand("account set addon", 2)]
        SetPlayerExpansion,

        [TCCommand("account set password", 3)]
        SetPassword,

        [TCCommand("ban ip", 3)]
        BanIP,

        [TCCommand("unban ip", 1)]
        UnbanIP,

        [TCCommand("kick", 1)]
        KickPlayer,

        [TCCommand("server plimit", 1)]
        SetPlayerLimit,

        [TCCommand("server set motd", 1)]
        SetMOTD,

        [TCCommand("announce", 1)]
        ServerAnnouncement,

        [TCCommand("notify", 1)]
        ServerNotification,

        [TCCommand("send message", 2)]
        SendPlayerMessage,

        [TCCommand("gmnotify", 1)]
        NotifyGMs,

        [TCCommand("revive", 1)]
        RevivePlayer,

        [TCCommand("character rename", 1)]
        ForceCharRename,

        [TCCommand("ban character", 3)]
        BanCharacter,

        [TCCommand("account lock", 2)]
        AccountLock,

        [TCCommand("character erase", 1)]
        DeleteCharacter,

        [TCCommand("character level", 2)]
        ModifyPlayerLevel,

        [TCCommand("character rename", 2)]
        RenameCharacter,

        [TCCommand("character customize", 1)]
        CustomizeCharacter,

        [TCCommand("combatstop", 1)]
        StopCombatForPlayer,

        [TCCommand("repairitems", 1)]
        RepairCharacterItems,

        [TCCommand("mute", 3)]
        MutePlayer,

        [TCCommand("unmute", 1)]
        UnmutePlayer,

        [TCCommand("unstuck", 1)]
        UnstuckPlayer,

        [TCCommand("guild create", 2)]
        CreateGuild,

        [TCCommand("guild delete", 1)]
        DeleteGuild,

        [TCCommand("guild invite", 2)]
        GuildInvite,

        [TCCommand("guild uninvite", 1)]
        GuildUninvite,

        [TCCommand("guild rank", 2)]
        SetGuildRank,

        [TCCommand("guild rename", 2)]
        RenameGuild,

        [TCCommand("saveall", 0)]
        SaveAll,

        [TCCommand("send mail", 3)]
        SendMail,

        [TCCommand("send money", 4)]
        SendMoney,

        [TCCommand("send items", 4)]
        SendItems
    }
}
