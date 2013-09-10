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
using TrinityCore_Manager.Character_Management;

namespace TrinityCore_Manager
{
    public partial class EditAccount : TCMForm
    {
        public EditAccount()
        {
            InitializeComponent();
        }

      //private async void EditAccount_Load(object sender, EventArgs e)
        private void EditAccount_Load(object sender, EventArgs e)
        {

        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            Account selectedAccount = await TCManager.Instance.AuthDatabase.GetAccount(accountNameTextBox.Text);

            if (selectedAccount == null)
                return;

            StartLoading();
            await TCManager.Instance.AuthDatabase.SetAccountLock(selectedAccount.Id, switchButton.Value);
            await TCAction.SetPlayerPassword(selectedAccount.Username, passTextBox.Text);
            await TCAction.SetPlayerExpansion(selectedAccount.Username, (Expansion)accAddonComboBox.SelectedIndex);
            await TCAction.SetGMLevel(selectedAccount.Username, (GMLevel)accLevelComboBox.SelectedIndex + 1, -1);
            StopLoading();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditAccount_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            using (SearchAccountForm saf = new SearchAccountForm())
                if (saf.ShowDialog() == DialogResult.OK)
                    accountNameTextBox.Text = saf.AccountName;
        }

        private async void accountNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Account selectedAccount = await TCManager.Instance.AuthDatabase.GetAccount(accountNameTextBox.Text);
            GMLevel level = await TCManager.Instance.AuthDatabase.GetAccountAccess(selectedAccount.Id);

            accLevelComboBox.SelectedIndex = ((int)level) - 1;
            accAddonComboBox.SelectedIndex = (int)selectedAccount.Exp;
            switchButton.Value = selectedAccount.Locked == 1;
        }
    }
}
