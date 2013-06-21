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

        public static void AddAccount(string username, string password, int gmlevel)
        {

            TCMClient client = IsRA() ? _tcm.RAClient : _tcm.AuthClient;

            if (client == null)
                throw new NullReferenceException("client");

            client.SendMessage(TCCommand.CreateAccount.BuildCommand());

        }

        private static bool IsRA()
        {
            return Settings.Default.ServerType == (int)ServerType.RemoteAccess;
        }

    }
}
