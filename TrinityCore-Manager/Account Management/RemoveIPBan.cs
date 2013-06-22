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
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager
{
    public partial class RemoveIPBan : DevComponents.DotNetBar.Office2007Form
    {
        public RemoveIPBan()
        {
            InitializeComponent();
        }

        private async void banButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(ipAddressBanInput.Value))
            {

                MessageBoxEx.Show(this, "IP Address required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            await TCManager.Instance.AuthDatabase.RemoveIpBan(ipAddressBanInput.Value);

            this.Close();
        
        }
    }
}
