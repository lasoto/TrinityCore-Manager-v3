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
using TrinityCore_Manager.Misc;
using TrinityCore_Manager.TCM;
using TrinityCore_Manager.Database.Classes;

namespace TrinityCore_Manager
{
    public partial class DeleteGuild : TCMForm
    {

        private List<Guild> _guilds;

        public DeleteGuild()
        {
            InitializeComponent();
        }

        private async void DeleteGuild_Load(object sender, EventArgs e)
        {
            StartLoading();

            await RefreshGuilds();

            StopLoading();
        }

        private async Task RefreshGuilds()
        {

            _guilds = await TCManager.Instance.CharDatabase.GetGuilds();

            guildComboBox.Items.Clear();

            foreach (Guild guild in _guilds)
            {
                guildComboBox.Items.Add(guild.Name);
            }

        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {

            if (guildComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "No guild selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (_guilds == null)
                return;

            Guild guild = _guilds.SingleOrDefault(p => p.Name.Equals(guildComboBox.Items[guildComboBox.SelectedIndex].ToString()));

            if (guild == null)
            {

                MessageBoxEx.Show(this, "Could not find guild in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            await TCManager.Instance.CharDatabase.DeleteGuild(guild.Guildid);
            await RefreshGuilds();
        }
   
    }
}
