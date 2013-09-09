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
using TrinityCore_Manager.Database.Classes;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager
{
    public partial class RemoveIPBan : Office2007Form
    {
        public RemoveIPBan()
        {
            InitializeComponent();
        }

        private async void RemoveIPBan_Load(object sender, EventArgs e)
        {

            List<IPBan> ipBans = await TCManager.Instance.AuthDatabase.GetIPBans();

            foreach (var ipBan in ipBans)
            {
                ipAddressComboBox.Items.Add(ipBan);
            }

        }

        private async void removeBanButton_Click(object sender, EventArgs e)
        {

            if (ipAddressComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "You must select an ip address to unban!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            await TCAction.UnbanIPAddress(ipAddressComboBox.Items[ipAddressComboBox.SelectedIndex].ToString());

        }



    }
}
