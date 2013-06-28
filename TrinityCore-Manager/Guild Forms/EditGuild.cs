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

            await RefreshGuilds();
            await RefreshNewPlayersToAdd();

            StopLoading();

        }

        private async Task RefreshGuilds()
        {

            _guilds = await TCManager.Instance.CharDatabase.GetGuilds();

            guildNameComboBox.Items.Clear();

            foreach (Guild guild in _guilds)
            {
                guildNameComboBox.Items.Add(guild.Name);
            }

        }

        private async Task RefreshNewPlayersToAdd()
        {

            List<string> chars = await TCManager.Instance.CharDatabase.GetCharNamesNotInGuild();

            playerListComboBox.Items.Clear();
            playerListComboBox.Items.AddRange(chars.ToArray());

        }

        private async void guildNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (guildNameComboBox.SelectedIndex == -1)
                return;

            StartLoading();

            await RefreshMembers();
            await RefreshRanks();

            StopLoading();

        }

        private async Task RefreshRanks()
        {

            if (guildNameComboBox.SelectedIndex == -1)
            {

                ranksComboBox.Items.Clear();

                return;

            }

            if (_guilds == null)
                return;

            Guild selectedGuild = _guilds.SingleOrDefault(p => p.Name == guildNameComboBox.Items[guildNameComboBox.SelectedIndex].ToString());

            if (selectedGuild == null)
                return;

            List<MemberRank> ranks = await TCManager.Instance.CharDatabase.GetMemberRanks(selectedGuild.Guildid);

            ranksComboBox.Items.Clear();
            ranksComboBox.Items.AddRange(ranks.Select(p => p.RankName).ToArray());

        }

        private async Task RefreshMembers()
        {

            if (guildNameComboBox.SelectedIndex == -1)
            {

                guildListView.Items.Clear();
                guildLeaderComboBox.Items.Clear();

                return;

            }

            if (_guilds == null)
                return;

            Guild selectedGuild = _guilds.SingleOrDefault(p => p.Name == guildNameComboBox.Items[guildNameComboBox.SelectedIndex].ToString());

            if (selectedGuild == null)
                return;

            guildListView.Items.Clear();
            guildLeaderComboBox.Items.Clear();

            List<MemberRank> ranks = await TCManager.Instance.CharDatabase.GetMemberRanks(selectedGuild.Guildid);
            List<GuildMember> members = await TCManager.Instance.CharDatabase.GetGuildMembers(selectedGuild.Guildid);

            string leaderName = "";

            foreach (GuildMember member in members)
            {

                string memberName = await TCManager.Instance.CharDatabase.GetCharacterName(member.Guid);

                if (member.Guid == selectedGuild.Leaderguid)
                    leaderName = memberName;


                MemberRank memRank = ranks.SingleOrDefault(p => p.RankId == member.Rank);

                string rankName = "";

                if (memRank == null)
                    rankName = "Rank Not Found";
                else
                    rankName = memRank.RankName;


                guildListView.Items.Add(new ListViewItem(new[] { rankName, memberName }));
                guildLeaderComboBox.Items.Add(memberName);

            }

            for (int i = 0; i < guildLeaderComboBox.Items.Count; i++)
            {
                if (guildLeaderComboBox.Items[i].ToString().Equals(leaderName))
                {

                    if (guildLeaderComboBox.SelectedIndex == i)
                    {
                        break;
                    }

                    guildLeaderComboBox.SelectedIndex = i;

                    break;

                }
            }

        }

        private async void inviteButton_Click(object sender, EventArgs e)
        {

            if (guildNameComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "No guild selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (playerListComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "No character selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (ranksComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "No rank selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (_guilds == null)
                return;

            Guild selectedGuild = _guilds.SingleOrDefault(p => p.Name == guildNameComboBox.Items[guildNameComboBox.SelectedIndex].ToString());

            if (selectedGuild == null)
                return;

            string character = playerListComboBox.Items[playerListComboBox.SelectedIndex].ToString();

            int guid = await TCManager.Instance.CharDatabase.GetCharacterGuid(character);

            if (guid == -1)
                return;

            List<MemberRank> ranks = await TCManager.Instance.CharDatabase.GetMemberRanks(selectedGuild.Guildid);
            List<GuildMember> members = await TCManager.Instance.CharDatabase.GetGuildMembers(selectedGuild.Guildid);

            MemberRank gmRank = ranks.SingleOrDefault(p => p.RankName.Equals("Guild Master"));

            if (gmRank == null)
            {

                MessageBoxEx.Show(this, "Something went wrong! Could not find a Guild Master in this guild!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (members.Count(p => p.Rank == gmRank.RankId) > 0)
            {

                MessageBoxEx.Show(this, "You cannot have more than 1 Guild Master!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            MemberRank selectedRank = ranks.SingleOrDefault(p => p.RankName == ranksComboBox.Items[ranksComboBox.SelectedIndex].ToString());

            if (selectedRank == null)
            {

                MessageBoxEx.Show(this, "An error has occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            await TCManager.Instance.CharDatabase.AddGuildMember(selectedGuild.Guildid, guid, selectedRank.RankId);

            playerListComboBox.Items.Remove(character);

            await RefreshMembers();

        }

        private async void uninviteButton_Click(object sender, EventArgs e)
        {

            if (guildNameComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "No guild selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (_guilds == null)
                return;

            Guild selectedGuild = _guilds.SingleOrDefault(p => p.Name == guildNameComboBox.Items[guildNameComboBox.SelectedIndex].ToString());

            if (selectedGuild == null)
                return;

            if (guildListView.Items.Count == 1 || guildListView.SelectedItems.Count == guildListView.Items.Count)
            {

                if (MessageBoxEx.Show(this, "You cannot delete all members of the guild! Do you want to remove the guild?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    await TCManager.Instance.CharDatabase.RemoveGuild(selectedGuild.Guildid);

                    await RefreshGuilds();
                    await RefreshNewPlayersToAdd();
                    await RefreshMembers();
                    await RefreshRanks();

                    return;

                }

            }

            StartLoading();

            List<MemberRank> ranks = await TCManager.Instance.CharDatabase.GetMemberRanks(selectedGuild.Guildid);

            MemberRank gmRank = ranks.SingleOrDefault(p => p.RankName.Equals("Guild Master"));

            if (gmRank == null)
            {

                StopLoading();

                MessageBoxEx.Show(this, "Something went wrong! Could not find a Guild Master in this guild!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            foreach (ListViewItem item in guildListView.SelectedItems)
            {

                string memberName = item.SubItems[1].Text;

                int guid = await TCManager.Instance.CharDatabase.GetCharacterGuid(memberName);

                GuildMember member = await TCManager.Instance.CharDatabase.GetGuildMember(memberName);

                if (member == null)
                    continue;

                if (member.Rank == gmRank.RankId)
                    continue;

                await TCManager.Instance.CharDatabase.RemoveGuildMember(guid);

            }

            for (int i = 0; i < guildListView.SelectedItems.Count; i++)
            {

                ListViewItem item = guildListView.SelectedItems[i];

                guildListView.Items.Remove(item);

            }

            await RefreshMembers();

            StopLoading();

        }

        private async void guildLeaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (guildNameComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show(this, "No guild selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (guildLeaderComboBox.SelectedIndex == -1)
            {

                MessageBoxEx.Show("No player selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (_guilds == null)
                return;

            Guild selectedGuild = _guilds.SingleOrDefault(p => p.Name == guildNameComboBox.Items[guildNameComboBox.SelectedIndex].ToString());

            if (selectedGuild == null)
                return;

            string newLeaderName = guildLeaderComboBox.Items[guildLeaderComboBox.SelectedIndex].ToString();


            StartLoading();

            int guid = await TCManager.Instance.CharDatabase.GetCharacterGuid(newLeaderName);

            List<MemberRank> ranks = await TCManager.Instance.CharDatabase.GetMemberRanks(selectedGuild.Guildid);

            MemberRank gmRank = ranks.SingleOrDefault(p => p.RankName.Equals("Guild Master"));

            if (gmRank == null)
            {

                StopLoading();

                MessageBoxEx.Show(this, "Something went wrong! Could not find a Guild Master in this guild!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            MemberRank officerRank = ranks.SingleOrDefault(p => p.RankName.Equals("Officer"));

            if (officerRank == null)
            {

                MessageBoxEx.Show(this, "Something went wrong! Could not find the officer in this guild!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            List<GuildMember> members = await TCManager.Instance.CharDatabase.GetGuildMembers(selectedGuild.Guildid);
            List<GuildMember> gms = members.Where(p => p.Rank == gmRank.RankId).ToList();

            foreach (GuildMember gm in gms)
            {
                await TCManager.Instance.CharDatabase.UpdateGuildRank(selectedGuild.Guildid, gm.Guid, officerRank.RankId);
            }
 
            await TCManager.Instance.CharDatabase.UpdateGuildRank(selectedGuild.Guildid, guid, gmRank.RankId);

            await RefreshMembers();

            StopLoading();

        }
    }
}
