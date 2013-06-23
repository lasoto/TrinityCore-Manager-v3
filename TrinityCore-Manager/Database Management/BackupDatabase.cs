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

namespace TrinityCore_Manager.Database_Management
{
    public partial class BackupDatabase : DevComponents.DotNetBar.Office2007Form
    {
        public BackupDatabase()
        {
            InitializeComponent();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            //BACKUP CAN OCCUR BOTH IF THE SERVER IS ONLINE AND OFFLINE
        }
    }
}
