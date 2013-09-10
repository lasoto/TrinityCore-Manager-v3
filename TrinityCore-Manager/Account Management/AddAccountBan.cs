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
using TrinityCore_Manager.Character_Management;
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
        }

        private async void banButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(accountNameTextBox.Text))
            {

                MessageBoxEx.Show(this, "No user selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            string username = accountNameTextBox.Text;
            int unix = (int)banTimeDateTimeInput.Value.ToUnixTimestamp();
            string reason = banReasonTextBox.Text;

            StartLoading();

            await TCAction.BanAccount(username, unix, "Admin", reason);

            StopLoading();

            Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void permanentBanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            banTimeDateTimeInput.Enabled = !permanentBanCheckBox.Checked;
        }

        private void searchAccountButton_Click(object sender, EventArgs e)
        {

            using (SearchAccountForm saf = new SearchAccountForm())
            {

                if (saf.ShowDialog() == DialogResult.OK)
                {
                    accountNameTextBox.Text = saf.AccountName;
                }

            }

        }

        private void AddAccountBan_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
