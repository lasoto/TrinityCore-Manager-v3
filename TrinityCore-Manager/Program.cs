using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCore_Manager.Database;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.Security;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        
        }

    }
}
