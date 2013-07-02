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
        ForceCharRename

    }
}
