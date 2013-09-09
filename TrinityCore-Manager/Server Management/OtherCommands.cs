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
using System.Text.RegularExpressions;

namespace TrinityCore_Manager
{
    public partial class OtherCommands : DevComponents.DotNetBar.Office2007Form
    {
        public OtherCommands()
        {
            InitializeComponent();
        }

        private void OtherCommands_Load(object sender, EventArgs e)
        {
            switchButton.Enabled = TCManager.Instance.WorldClient == null || !TCManager.Instance.WorldClient.IsOnline;
        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            if (serverLimitIntegerInput.Value > 0)
                await TCAction.SetPlayerLimit(serverLimitIntegerInput.Value);

            if (!String.IsNullOrEmpty(motdTextBox.Text))
                await TCAction.SetServerMotd(Regex.Replace(motdTextBox.Text, "\r\n", "\\r\\n"));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
