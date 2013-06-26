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
using TrinityCore_Manager.CustomForms;

namespace TrinityCore_Manager
{
    public partial class EditAccount : TCMForm
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

        private async void okButton_Click(object sender, EventArgs e)
        {

            if (usernameComboBox.SelectedIndex == -1 || accLevelComboBox.SelectedIndex == -1 || accAddonComboBox.SelectedIndex == -1)
                return;

            Account selectedAccount = accounts.SingleOrDefault(p => p.Username == usernameComboBox.Items[usernameComboBox.SelectedIndex].ToString());

            if (selectedAccount == null)
                return;

            StartLoading();

            await TCAction.SetPlayerPassword(selectedAccount.Username, passTextBox.Text);
            await TCAction.SetPlayerExpansion(selectedAccount.Username, (Expansion)accAddonComboBox.SelectedIndex);
            await TCAction.SetGMLevel(selectedAccount.Username, (GMLevel)accLevelComboBox.SelectedIndex + 1, -1);

            StopLoading();

            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
