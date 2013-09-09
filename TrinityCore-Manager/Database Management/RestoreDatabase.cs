using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TrinityCore_Manager.TCM;
using TrinityCore_Manager.Database;

namespace TrinityCore_Manager.Database_Management
{
    public partial class RestoreDatabase : DevComponents.DotNetBar.Office2007Form
    {

        private readonly Regex _dtRegex = new Regex("[0-9]{2}-[0-9]{2}-[0-9]{2}-[0-9]{2}-[0-9]{2}-[0-9]{2}", RegexOptions.Compiled);

        private List<Backup> _backups;

        public RestoreDatabase()
        {
            InitializeComponent();
        }

        private void RestoreDatabase_Load(object sender, EventArgs e)
        {

            if (!Directory.Exists(TCManager.BackupLocation))
                Directory.CreateDirectory(TCManager.BackupLocation);

            Init();

        }

        private void Init()
        {

            string[] files = Directory.GetFiles(TCManager.BackupLocation);

            const string format = "MM-dd-yy-hh-mm-ss";

            _backups = new List<Backup>();

            foreach (string file in files)
            {

                string fileName = Path.GetFileName(file);

                DateTime dt;

                string dtStr = Path.GetFileNameWithoutExtension(fileName);

                if (String.IsNullOrEmpty(dtStr))
                    continue;

                Match mat = _dtRegex.Match(dtStr);

                if (!mat.Success)
                    continue;

                if (!DateTime.TryParseExact(mat.Value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                    continue;

                string typeSub = dtStr.Substring(dtStr.LastIndexOf("-", StringComparison.Ordinal) + 1);

                BackupType bType = BackupType.Auth;

                switch (typeSub)
                {

                    case "auth":

                        bType = BackupType.Auth;

                        break;

                    case "char":

                        bType = BackupType.Character;

                        break;

                    case "world":

                        bType = BackupType.World;

                        break;

                    default:

                        bType = BackupType.Error;

                        break;

                }

                if (bType == BackupType.Error)
                    continue;

                _backups.Add(new Backup() { FileName = fileName, BackupType = bType, BackedUpOn = dt });

            }

            restoreListComboBox.Items.Clear();

            _backups.Sort((x, y) => y.CompareTo(x));

            foreach (Backup backup in _backups)
            {

                string type;

                switch (backup.BackupType)
                {

                    case BackupType.Auth:

                        type = "Auth Database";

                        break;

                    case BackupType.Character:

                        type = "Character Database";

                        break;

                    case BackupType.World:

                        type = "World Database";

                        break;

                    default:

                        type = "ERROR";

                        break;

                }

                backup.BackupText = String.Format("{0} - {1}", backup.BackedUpOn.ToString(CultureInfo.InvariantCulture), type);

                restoreListComboBox.Items.Add(backup.BackupText);

            }

        }

        private async void restoreButton_Click(object sender, EventArgs e)
        {

            if (restoreListComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "No backup selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            string selected = restoreListComboBox.Items[restoreListComboBox.SelectedIndex].ToString();

            var backup = _backups.FirstOrDefault(p => p.BackupText == selected);

            if (backup == null)
            {

                MessageBoxEx.Show(this, "An error has occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            string fName = Path.Combine(TCManager.BackupLocation, backup.FileName);

            if (!File.Exists(fName))
            {

                MessageBoxEx.Show(this, "Could not find backup file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            restoreProgressBar.Visible = true;
            restoreProgressBar.TextVisible = true;

            restoreButton.Enabled = false;

            Progress<int> progress = new Progress<int>(prog =>
            {

                if (restoreProgressBar.ProgressType == eProgressItemType.Marquee)
                    restoreProgressBar.ProgressType = eProgressItemType.Standard;

                restoreProgressBar.Value = prog;
                restoreProgressBar.Text = prog + "%";

            });

            CancellationTokenSource cts = new CancellationTokenSource();

            switch (backup.BackupType)
            {

                case BackupType.Auth:

                    await TCManager.Instance.AuthDatabase.Restore(fName, progress, cts.Token);
                    
                    break;

                case BackupType.Character:

                    await TCManager.Instance.CharDatabase.Restore(fName, progress, cts.Token);

                    break;

                case BackupType.World:

                    await TCManager.Instance.WorldDatabase.Restore(fName, progress, cts.Token);

                    break;


            }

            restoreProgressBar.Visible = false;

            restoreButton.Enabled = true;

            MessageBoxEx.Show(this, "Restore completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        class Backup : IComparable<Backup>
        {

            public string FileName { get; set; }

            public BackupType BackupType { get; set; }

            public DateTime BackedUpOn { get; set; }

            public string BackupText { get; set; }

            public int CompareTo(Backup other)
            {
                return BackedUpOn.CompareTo(other.BackedUpOn);
            }
        }

        enum BackupType
        {
            Auth,
            Character,
            World,
            Error
        }

        private void deleteBackupButton_Click(object sender, EventArgs e)
        {

            if (restoreListComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "No backup selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            string selected = restoreListComboBox.Items[restoreListComboBox.SelectedIndex].ToString();

            var backup = _backups.FirstOrDefault(p => p.BackupText == selected);

            if (backup == null)
            {

                MessageBoxEx.Show(this, "An error has occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            string fName = Path.Combine(TCManager.BackupLocation, backup.FileName);

            if (!File.Exists(fName))
            {

                MessageBoxEx.Show(this, "Could not find backup file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            File.Delete(fName);

            Init();

        }

    }
}
