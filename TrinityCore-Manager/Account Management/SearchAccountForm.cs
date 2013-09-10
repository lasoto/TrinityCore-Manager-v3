using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager.Character_Management
{
    public partial class SearchAccountForm : Office2007Form
    {
        public string AccountName { get; private set; }
        
        public SearchAccountForm()
        {
            InitializeComponent();
        }

        private void SearchAccountForm_Load(object sender, EventArgs e)
        {

        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            accountsList.Items.Clear();
            searchProgress.Visible = true;
            var accounts = await TCManager.Instance.AuthDatabase.SearchForAccount(searchTextBox.Text);

            foreach (var account in accounts)
                accountsList.Items.Add(account.Username);

            searchProgress.Visible = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            if (accountsList.SelectedItems.Count == 0)
            {

                MessageBoxEx.Show(this, "No account selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            AccountName = accountsList.SelectedItems[0].Text;

            DialogResult = DialogResult.OK;

            Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchAccountForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchButton.PerformClick();
        }
    }
}
