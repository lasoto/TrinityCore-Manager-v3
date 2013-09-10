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
using TrinityCore_Manager.CustomForms;
using TrinityCore_Manager.Database.Classes;

namespace TrinityCore_Manager
{
    public partial class CreateGuild : TCMForm
    {
        public CreateGuild()
        {
            InitializeComponent();
        }

        private async void CreateGuild_Load(object sender, EventArgs e)
        {

            StartLoading();

            List<string> chars = await TCManager.Instance.CharDatabase.GetCharNamesNotInGuild();

            StopLoading();

            foreach (string character in chars)
            {
                leaderComboBox.Items.Add(character);
            }

            if (leaderComboBox.Items.Count > 0)
                leaderComboBox.SelectedIndex = 0;

        }

        private async void createButton_Click(object sender, EventArgs e)
        {

            string guildName = nameTextBox.Text;

            if (String.IsNullOrEmpty(guildName))
            {

                MessageBoxEx.Show(this, "Guild name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (leaderComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "A guild leader must be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            StartLoading();

            string guildLeader = leaderComboBox.Items[leaderComboBox.SelectedIndex].ToString();

            await TCManager.Instance.CharDatabase.CreateGuild(guildName, leaderComboBox.Items[leaderComboBox.SelectedIndex].ToString());

            StopLoading();

            Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateGuild_KeyDown(object sender, KeyEventArgs e)
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
