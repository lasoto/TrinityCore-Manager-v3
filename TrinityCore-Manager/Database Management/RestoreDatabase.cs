using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TrinityCore_Manager.Database_Management
{
    public partial class RestoreDatabase : DevComponents.DotNetBar.Office2007Form
    {

        private readonly string BackupLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TCM", "Backups");

        public RestoreDatabase()
        {
            InitializeComponent();
        }

        private void RestoreDatabase_Load(object sender, EventArgs e)
        {

            if (!Directory.Exists(BackupLocation))
                Directory.CreateDirectory(BackupLocation);

        }

    }
}
