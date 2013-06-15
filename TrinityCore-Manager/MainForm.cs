using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;
using Microsoft.Win32;

namespace TrinityCore_Manager
{
    public partial class MainForm : Office2007RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void otherCommandsButton_Click(object sender, EventArgs e)
        {
            OtherCommands otherCommands = new OtherCommands();
            otherCommands.ShowDialog();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.ShowDialog();
        }

        private void editAccountButton_Click(object sender, EventArgs e)
        {
            EditAccount editAccount = new EditAccount();
            editAccount.ShowDialog();
        }

        private void addAccountBanButton_Click(object sender, EventArgs e)
        {
            AddAccountBan addAccBan = new AddAccountBan();
            addAccBan.ShowDialog();
        }

        private void removeAccountBanButton_Click(object sender, EventArgs e)
        {
            RemoveAccountBan removeAccBan = new RemoveAccountBan();
            removeAccBan.ShowDialog();
        }

        private void addIpBanButton_Click(object sender, EventArgs e)
        {
            AddIPBan addIpBan = new AddIPBan();
            addIpBan.ShowDialog();
        }

        private void removeIpBanButton_Click(object sender, EventArgs e)
        {
            RemoveIPBan removeIpBan = new RemoveIPBan();
            removeIpBan.ShowDialog();
        }

        private void accountCleanupButton_Click(object sender, EventArgs e)
        {
            AccountCleanup accCleanup = new AccountCleanup();
            accCleanup.ShowDialog();
        }

        private void showPlayerInfoButton_Click(object sender, EventArgs e)
        {
            PlayerInformation playerInfo = new PlayerInformation();
            playerInfo.ShowDialog();
        }

        private void setLevelButton_Click(object sender, EventArgs e)
        {
            CharacterSetLevel setLevel = new CharacterSetLevel();
            setLevel.ShowDialog();
        }

        private void setReputationButton_Click(object sender, EventArgs e)
        {
            CharacterSetReputation setReputation = new CharacterSetReputation();
            setReputation.ShowDialog();
        }

        private void setSkillLevelButton_Click(object sender, EventArgs e)
        {
            CharacterSetSkillLevel setSkill = new CharacterSetSkillLevel();
            setSkill.ShowDialog();
        }

        private void createItemButton_Click(object sender, EventArgs e)
        {
            CreateItem createItem = new CreateItem();
            createItem.ShowDialog();
        }

        private void createNpcButton_Click(object sender, EventArgs e)
        {
            CreateNPC createNPC = new CreateNPC();
            createNPC.ShowDialog();
        }

        private void findFirstUnusedGuidForNpcButton_Click(object sender, EventArgs e)
        {
            FindGUID findGUID = new FindGUID();
            findGUID.ShowDialog();
        }

        private void findNpcButton_Click(object sender, EventArgs e)
        {
            FindNPC findNPC = new FindNPC();
            findNPC.ShowDialog();
        }

        private void findItemButton_Click(object sender, EventArgs e)
        {
            FindItem findItem = new FindItem();
            findItem.ShowDialog();
        }

        private void createGuildButton_Click(object sender, EventArgs e)
        {
            CreateGuild createGuild = new CreateGuild();
            createGuild.ShowDialog();
        }

        private void editGuildButton_Click(object sender, EventArgs e)
        {
            EditGuild editGuild = new EditGuild();
            editGuild.ShowDialog();
        }

        private void deleteGuildButton_Click(object sender, EventArgs e)
        {
            DeleteGuild deleteGuild = new DeleteGuild();
            deleteGuild.ShowDialog();
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            SendMail sendMail = new SendMail();
            sendMail.ShowDialog();
        }

        private void startEventButton_Click(object sender, EventArgs e)
        {
            EventStart eventStart = new EventStart();
            eventStart.ShowDialog();
        }

        private void eventActiveButton_Click(object sender, EventArgs e)
        {
            EventActiveList evActList = new EventActiveList();
            evActList.ShowDialog();
        }
    }
}