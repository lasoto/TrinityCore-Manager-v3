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
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager
{
    public partial class AddIPBan : TCMForm
    {
        public AddIPBan()
        {
            InitializeComponent();
        }

        private void AddIPBan_Load(object sender, EventArgs e)
        {

        }

        private async void banButton_Click(object sender, EventArgs e)
        {

            string ipa = ipAddressBanInput.Value;
            string reason = banReasonTextBox.Text;
            DateTime banTime = DateTime.Now;
            DateTime unbanTime = banTimeDateTimeInput.Value;

            if (String.IsNullOrEmpty(ipa) || String.IsNullOrEmpty(reason) || banTimeDateTimeInput.IsEmpty)
            {

                MessageBoxEx.Show(this, "Everything must be filled out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            StartLoading();

            if (permanentBanCheckBox.Checked)
                await TCAction.BanIPAddress(ipAddressBanInput.Value, Convert.ToInt32(banTime.ToUnixTimestamp()), -1, "Admin", reason);
            else
                await TCAction.BanIPAddress(ipAddressBanInput.Value, Convert.ToInt32(banTime.ToUnixTimestamp()), Convert.ToInt32(unbanTime.ToUnixTimestamp()), "Admin", reason);

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

        private void AddIPBan_KeyDown(object sender, KeyEventArgs e)
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
