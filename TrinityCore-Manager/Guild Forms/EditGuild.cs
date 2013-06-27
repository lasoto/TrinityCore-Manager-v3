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
    public partial class EditGuild : TCMForm
    {


        private List<Guild> _guilds;

        public EditGuild()
        {
            InitializeComponent();
        }

        private async void EditGuild_Load(object sender, EventArgs e)
        {

            StartLoading();
          
            _guilds = await TCManager.Instance.CharDatabase.GetGuilds();

            foreach (Guild guild in _guilds)
            {
                guildNameComboBox.Items.Add(guild.Name);
            }

            List<string> chars = await TCManager.Instance.CharDatabase.GetCharNamesNotInGuild();

            StopLoading();

        }

        private void guildNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (guildNameComboBox.SelectedIndex == -1)
                return;

            if (_guilds == null)
                return;

            Guild selectedGuild = _guilds.SingleOrDefault(p => p.Name == guildNameComboBox.Items[guildNameComboBox.SelectedIndex].ToString());

            if (selectedGuild == null)
                return;



        }
        /*
         private List<Guild> guilds;

        private async void EditGuild_Load(object sender, EventArgs e)
        {
            
            
            guilds = await TCManager.Instance.CharDatabase.GetGuilds();

            foreach (Guild guild in guilds)
            {
                guildNameComboBox.Items.Add(guild.name);
            }
           
           
        }

        private async void guildNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (guildNameComboBox.SelectedIndex == -1)
                return;

            if (guilds == null)
                return;

            Guild selectedGuild = guilds.SingleOrDefault(p => p.name == guildNameComboBox.Items[guildNameComboBox.SelectedIndex].ToString());

            if (selectedGuild == null)
                return;
             
           
        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            
             
            if (guildNameComboBox.SelectedIndex == -1 || guildLeaderComboBox.SelectedIndex == -1 || playerListComboBox.SelectedIndex == -1)
                return;

            Guild selectedGuild = guilds.SingleOrDefault(p => p.name == guildNameComboBox.Items[guildNameComboBox.SelectedIndex].ToString());

            if (selectedGuild == null)
                return;

            StartLoading();

            // Not finished, needs work
            await TCManager.Instance.AuthDatabase.ModifyAccount(selectedGuild.Id, passTextBox.Text, (GMLevel)accLevelComboBox.SelectedIndex + 1, (Expansion)accAddonComboBox.SelectedIndex);

            StopLoading();

            this.Close();
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playerListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This ComboBox should list only characters that are not in any guild
        }
         */
    }
}
