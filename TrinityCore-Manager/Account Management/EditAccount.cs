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
using TrinityCore_Manager.Database.Enums;

namespace TrinityCore_Manager
{
    public partial class EditAccount : DevComponents.DotNetBar.Office2007Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        private List<Account> accounts;

        private async void EditAccount_Load(object sender, EventArgs e)
        {

            accounts = await TCManager.Instance.AuthDatabase.GetAccounts();

            foreach (Account account in accounts)
            {
                usernameComboBox.Items.Add(account.Username);
            }

        }

        private async void usernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (usernameComboBox.SelectedIndex == -1)
                return;

            if (accounts == null)
                return;

            Account selectedAccount = accounts.SingleOrDefault(p => p.Username == usernameComboBox.Items[usernameComboBox.SelectedIndex].ToString());

            if (selectedAccount == null)
                return;

            GMLevel level = await TCManager.Instance.AuthDatabase.GetAccountAccess(selectedAccount.Id);

            accLevelComboBox.SelectedIndex = ((int)level) - 1;
            accAddonComboBox.SelectedIndex = (int)selectedAccount.Exp;

            switchButton.Value = selectedAccount.Locked == 1;

        }
    }
}
