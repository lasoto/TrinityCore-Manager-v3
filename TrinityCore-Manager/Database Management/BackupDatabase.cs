using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TrinityCore_Manager.Database;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager.Database_Management
{
    public partial class BackupDatabase : DevComponents.DotNetBar.Office2007Form
    {

        public BackupDatabase()
        {
            InitializeComponent();
        }

        private void BackupDatabase_Load(object sender, EventArgs e)
        {

            if (!Directory.Exists(TCManager.BackupLocation))
                Directory.CreateDirectory(TCManager.BackupLocation);

            var set = Settings.Default;

            if (set.BackupScheduleAuth || set.BackupScheduleChar || set.BackupScheduleWorld)
            {

                authCheckBox.Checked = set.BackupScheduleAuth;
                charCheckBox.Checked = set.BackupScheduleChar;
                worldCheckBox.Checked = set.BackupScheduleWorld;

                daysIntegerInput.Enabled = true;
                hoursIntegerInput.Enabled = true;
                minIntegerInput.Enabled = true;

                scheduleBackupsCheckbox.Checked = true;

            }

            daysIntegerInput.Value = set.BackupDays;
            hoursIntegerInput.Value = set.BackupHours;
            minIntegerInput.Value = set.BackupMinutes;

        }

        private async void backupButton_Click(object sender, EventArgs e)
        {

            bool auth = authCheckBox.Checked;
            bool characters = charCheckBox.Checked;
            bool world = worldCheckBox.Checked;

            Progress<int> progress = new Progress<int>(prog =>
            {

                if (backupProgressBar.ProgressType == eProgressItemType.Marquee)
                    backupProgressBar.ProgressType = eProgressItemType.Standard;

                backupProgressBar.Value = prog;
                backupProgressBar.Text = prog + "%";


            });

            string format = "MM-dd-yy-hh-mm-ss";

            backupButton.Enabled = false;
            saveButton.Enabled = false;

            backupProgressBar.Visible = true;
            backupProgressBar.TextVisible = true;

            CancellationTokenSource cts = new CancellationTokenSource();

            if (auth)
            {
                await TCManager.Instance.AuthDatabase.BackupDatabase(Path.Combine(TCManager.BackupLocation, String.Format("{0}-auth.sql", DateTime.Now.ToString(format))), progress, cts.Token);
            }

            if (characters)
            {
                await TCManager.Instance.CharDatabase.BackupDatabase(Path.Combine(TCManager.BackupLocation, String.Format("{0}-char.sql", DateTime.Now.ToString(format))), progress, cts.Token);
            }

            if (world)
            {
                await TCManager.Instance.WorldDatabase.BackupDatabase(Path.Combine(TCManager.BackupLocation, String.Format("{0}-world.sql", DateTime.Now.ToString(format))), progress, cts.Token);
            }

            backupProgressBar.TextVisible = false;
            backupProgressBar.Visible = false;
            backupProgressBar.ProgressType = eProgressItemType.Marquee;

            backupButton.Enabled = true;
            saveButton.Enabled = true;

            MessageBoxEx.Show(this, "Finished!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void scheduleBackupsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            daysIntegerInput.Enabled = scheduleBackupsCheckbox.Checked;
            hoursIntegerInput.Enabled = scheduleBackupsCheckbox.Checked;
            minIntegerInput.Enabled = scheduleBackupsCheckbox.Checked;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            var set = Settings.Default;

            if (scheduleBackupsCheckbox.Checked)
            {

                set.BackupDays = daysIntegerInput.Value;
                set.BackupHours = hoursIntegerInput.Value;
                set.BackupMinutes = minIntegerInput.Value;

                set.BackupScheduleAuth = authCheckBox.Checked;
                set.BackupScheduleChar = charCheckBox.Checked;
                set.BackupScheduleWorld = worldCheckBox.Checked;

                set.Save();

                TCManager.Instance.ScheduleBackups();

            }
            else
            {

                set.BackupScheduleAuth = false;
                set.BackupScheduleChar = false;
                set.BackupScheduleWorld = false;

                set.Save();

                TCManager.Instance.StopScheduledBackups();
            
            }


            this.Close();

        }

    }
}
