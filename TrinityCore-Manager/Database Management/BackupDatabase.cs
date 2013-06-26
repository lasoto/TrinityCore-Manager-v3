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
using TrinityCore_Manager.Properties;

namespace TrinityCore_Manager.Database_Management
{
    public partial class BackupDatabase : DevComponents.DotNetBar.Office2007Form
    {

        private readonly string BackupLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TCM", "Backups");

        public BackupDatabase()
        {
            InitializeComponent();
        }

        private void BackupDatabase_Load(object sender, EventArgs e)
        {

            if (!Directory.Exists(BackupLocation))
                Directory.CreateDirectory(BackupLocation);

            if (Settings.Default.BackupScheduleEnabled)
            {
                daysIntegerInput.Enabled = true;
                hoursIntegerInput.Enabled = true;
                minIntegerInput.Enabled = true;
            }

            daysIntegerInput.Value = Settings.Default.BackupDays;
            hoursIntegerInput.Value = Settings.Default.BackupHours;
            minIntegerInput.Value = Settings.Default.BackupMinutes;

        }

        private void backupButton_Click(object sender, EventArgs e)
        {

            bool auth = authCheckBox.Checked;
            bool characters = charCheckBox.Checked;
            bool world = worldCheckBox.Checked;

        }

        private void scheduleBackupsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            daysIntegerInput.Enabled = scheduleBackupsCheckbox.Checked;
            hoursIntegerInput.Enabled = scheduleBackupsCheckbox.Checked;
            minIntegerInput.Enabled = scheduleBackupsCheckbox.Checked;
        }

    }
}
