using System.Text;
using TrinityCore_Manager.Database;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.Security;

namespace TrinityCore_Manager.TCM
{
    class TCManager
    {

        private static object _lock = new object();

        private static TCManager _instance;

        public static TCManager Instance
        {
            get
            {
                lock (_lock)
                {

                    if (_instance == null)
                    {
                        _instance = new TCManager();
                    }

                    return _instance;

                }
            }
        }

        public TCMClient AuthClient { get; set; }
        public TCMClient WorldClient { get; set; }

        public TCMClient RAClient { get; set; }

        public AuthDatabase AuthDatabase { get; set; }
        public CharDatabase CharDatabase { get; set; }
        public WorldDatabase WorldDatabase { get; set; }

        public TCManager()
        {

            var set = Settings.Default;

            AuthDatabase = new AuthDatabase(set.DBHost, set.DBPort, set.DBUsername, set.DBPassword.DecryptString(Encoding.Unicode.GetBytes(Settings.Default.Entropy)).ToInsecureString(), set.DBAuthName);
            CharDatabase = new CharDatabase(set.DBHost, set.DBPort, set.DBUsername, set.DBPassword.DecryptString(Encoding.Unicode.GetBytes(Settings.Default.Entropy)).ToInsecureString(), set.DBCharName);
            WorldDatabase = new WorldDatabase(set.DBHost, set.DBPort, set.DBUsername, set.DBPassword.DecryptString(Encoding.Unicode.GetBytes(Settings.Default.Entropy)).ToInsecureString(), set.DBWorldName);

        }

    }
}
