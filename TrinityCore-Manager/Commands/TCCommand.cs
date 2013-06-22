namespace TrinityCore_Manager.Commands
{
    public enum TCCommand
    {

        [TCCommand("account create", 2)]
        CreateAccount,
    
        [TCCommand("ban account", 3)]
        BanAccount,

        [TCCommand("account set gmlevel", 3)]
        SetGMLevel
    
    }
}
