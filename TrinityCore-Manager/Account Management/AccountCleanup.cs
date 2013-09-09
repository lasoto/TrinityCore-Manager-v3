using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TrinityCore_Manager.Database;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.Security;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager
{
    public partial class AccountCleanup : Office2007Form
    {
        public AccountCleanup()
        {
            InitializeComponent();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {

            var database = TCManager.Instance.AuthDatabase;

            DateTime combined = dateTimeInput.Value.Date + timeInput.Value.TimeOfDay;

            await database.CleanupAccounts(combined);

            Close();
        
        }
    }
}
