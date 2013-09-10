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
using TrinityCore_Manager.TCM;

namespace TrinityCore_Manager
{
    public partial class AddAccount : TCMForm
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            accLevelComboBox.SelectedIndex = 0;
            accAddonComboBox.SelectedIndex = 0;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text) || accLevelComboBox.SelectedIndex == -1 || accAddonComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "All fields are requried to be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            StartLoading();

            TCManager.Instance.AuthDatabase.CreateAccount(usernameTextBox.Text, passwordTextBox.Text, accLevelComboBox.SelectedIndex, accAddonComboBox.SelectedIndex).ContinueWith(task =>
            {

                Invoke((MethodInvoker)StopLoading);

                if (task.Result)
                {
                    Invoke((MethodInvoker)Close);
                }
                else
                {
                    Invoke((MethodInvoker)(() => MessageBoxEx.Show(this, "That username already exists in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)));
                }
            });

        }

        private void AddAccount_KeyDown(object sender, KeyEventArgs e)
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
