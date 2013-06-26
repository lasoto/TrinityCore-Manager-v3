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
using TrinityCore_Manager.CustomForms;
using TrinityCore_Manager.Extensions;
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager
{
    public partial class AddAccountBan : TCMForm
    {
        public AddAccountBan()
        {
            InitializeComponent();
        }

        private async void AddAccountBan_Load(object sender, EventArgs e)
        {

            var bannedAccts = await TCManager.Instance.AuthDatabase.GetAccounts();

            foreach (var acct in bannedAccts)
            {
                accListComboBox.Items.Add(acct.Username);
            }

            if (accListComboBox.Items.Count > 0)
                accListComboBox.SelectedIndex = 0;

        }

        private async void banButton_Click(object sender, EventArgs e)
        {

            if (accListComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "No user selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            string username = accListComboBox.Items[accListComboBox.SelectedIndex].ToString();
            int unix = (int)banTimeDateTimeInput.Value.ToUnixTimestamp();
            string reason = banReasonTextBox.Text;

            StartLoading();

            await TCAction.BanAccount(username, unix, "Admin", reason);

            StopLoading();

            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void permanentBanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            banTimeDateTimeInput.Enabled = !permanentBanCheckBox.Checked;
        }
    }
}
