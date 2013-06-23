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

        private async void banButton_Click(object sender, EventArgs e)
        {

            string ipa = ipAddressBanInput.Value;
            string reason = banReasonTextBox.Text;
            DateTime banTime = banTimeDateTimeInput.Value;
            DateTime unbanTime = unbanTimeInput.Value;

            if (string.IsNullOrEmpty(ipa) || string.IsNullOrEmpty(reason) || banTimeDateTimeInput.IsEmpty || unbanTimeInput.IsEmpty)
            {

                MessageBoxEx.Show(this, "Everything must be filled out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            
            }

            if (permanentBanCheckBox.Checked)
                await TCManager.Instance.AuthDatabase.BanIp(ipAddressBanInput.Value, Convert.ToInt32(banTime.ToUnixTimestamp()), -1, "Admin", reason);
            else
                await TCManager.Instance.AuthDatabase.BanIp(ipAddressBanInput.Value, Convert.ToInt32(banTime.ToUnixTimestamp()), Convert.ToInt32(unbanTime.ToUnixTimestamp()), "Admin", reason);

            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void permanentBanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            unbanTimeInput.Enabled = !permanentBanCheckBox.Checked;
        }

    }
}
