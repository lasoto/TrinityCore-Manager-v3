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

namespace TrinityCore_Manager
{
    public partial class AddAccount : DevComponents.DotNetBar.Office2007Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {

            TCManager.Instance.AuthDatabase.CreateAccount(usernameTextBox.Text, passwordTextBox.Text, accLevelComboBox.SelectedIndex, accAddonComboBox.SelectedIndex);

            this.Close();

        }
    }
}
