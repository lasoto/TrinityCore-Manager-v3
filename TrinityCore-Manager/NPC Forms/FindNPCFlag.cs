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

namespace TrinityCore_Manager
{
    public partial class FindNPCFlag : DevComponents.DotNetBar.Office2007Form
    {

        private uint _flags;

        public uint Flags
        {
            get
            {
                return _flags;
            }
            set
            {
                uint flags = value;

                if ((flags & 1) == 1)
                {
                    gossipCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    questGiverCheckBox.Checked = true;
                }
                if ((flags & 16) == 16)
                {
                    trainerCheckBox.Checked = true;
                }
                if ((flags & 32) == 32)
                {
                    classTrainerCheckBox.Checked = true;
                }
                if ((flags & 64) == 64)
                {
                    professionTrainerCheckBox.Checked = true;
                }
                if ((flags & 128) == 128)
                {
                    vendorCheckBox.Checked = true;
                }
                if ((flags & 256) == 256)
                {
                    vendorAmmoCheckBox.Checked = true;
                }
                if ((flags & 512) == 512)
                {
                    vendorFoodCheckBox.Checked = true;
                }
                if ((flags & 1024) == 1024)
                {
                    vendorPoisonCheckBox.Checked = true;
                }
                if ((flags & 2048) == 2048)
                {
                    vendorReagentCheckBox.Checked = true;
                }
                if ((flags & 4096) == 4096)
                {
                    repairerCheckBox.Checked = true;
                }
                if ((flags & 8192) == 8192)
                {
                    flightMasterCheckBox.Checked = true;
                }
                if ((flags & 16384) == 16384)
                {
                    spiritHealerCheckBox.Checked = true;
                }
                if ((flags & 32768) == 32768)
                {
                    spiritGuideCheckBox.Checked = true;
                }
                if ((flags & 65536) == 65536)
                {
                    innkeeperCheckBox.Checked = true;
                }
                if ((flags & 131072) == 131072)
                {
                    bankerCheckBox.Checked = true;
                }
                if ((flags & 262144) == 262144)
                {
                    petitionerCheckBox.Checked = true;
                }
                if ((flags & 524288) == 524288)
                {
                    tabardDesignerCheckBox.Checked = true;
                }
                if ((flags & 1048576) == 1048576)
                {
                    battlemasterCheckBox.Checked = true;
                }
                if ((flags & 2097152) == 2097152)
                {
                    auctioneerCheckBox.Checked = true;
                }
                if ((flags & 4194304) == 4194304)
                {
                    stableMasterCheckBox.Checked = true;
                }
                if ((flags & 8388608) == 8388608)
                {
                    guildBankerCheckBox.Checked = true;
                }
                if ((flags & 16777216) == 16777216)
                {
                    spellclickCheckBox.Checked = true;
                }
                if ((flags & 67108864) == 67108864)
                {
                    mailboxCheckBox.Checked = true;
                }
            }
        }
        public FindNPCFlag()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (gossipCheckBox.Checked)
                _flags += 1;
            if (questGiverCheckBox.Checked)
                _flags += 2;
            if (trainerCheckBox.Checked)
                _flags += 16;
            if (classTrainerCheckBox.Checked)
                _flags += 32;
            if (professionTrainerCheckBox.Checked)
                _flags += 64;
            if (vendorCheckBox.Checked)
                _flags += 128;
            if (vendorAmmoCheckBox.Checked)
                _flags += 256;
            if (vendorFoodCheckBox.Checked)
                _flags += 512;
            if (vendorPoisonCheckBox.Checked)
                _flags += 1024;
            if (vendorReagentCheckBox.Checked)
                _flags += 2048;
            if (repairerCheckBox.Checked)
                _flags += 4096;
            if (flightMasterCheckBox.Checked)
                _flags += 8196;
            if (spiritHealerCheckBox.Checked)
                _flags += 16384;
            if (spiritGuideCheckBox.Checked)
                _flags += 32768;
            if (innkeeperCheckBox.Checked)
                _flags += 65536;
            if (bankerCheckBox.Checked)
                _flags += 131072;
            if (petitionerCheckBox.Checked)
                _flags += 262144;
            if (tabardDesignerCheckBox.Checked)
                _flags += 524288;
            if (battlemasterCheckBox.Checked)
                _flags += 1048576;
            if (auctioneerCheckBox.Checked)
                _flags += 2097152;
            if (stableMasterCheckBox.Checked)
                _flags += 4194304;
            if (guildBankerCheckBox.Checked)
                _flags += 8388608;
            if (spellclickCheckBox.Checked)
                _flags += 16777216;
            if (mailboxCheckBox.Checked)
                _flags += 67108864;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            gossipCheckBox.Checked = true;
            questGiverCheckBox.Checked = true;
            trainerCheckBox.Checked = true;
            classTrainerCheckBox.Checked = true;
            professionTrainerCheckBox.Checked = true;
            vendorCheckBox.Checked = true;
            vendorAmmoCheckBox.Checked = true;
            vendorFoodCheckBox.Checked = true;
            vendorPoisonCheckBox.Checked = true;
            vendorReagentCheckBox.Checked = true;
            repairerCheckBox.Checked = true;
            flightMasterCheckBox.Checked = true;
            spiritHealerCheckBox.Checked = true;
            spiritGuideCheckBox.Checked = true;
            innkeeperCheckBox.Checked = true;
            bankerCheckBox.Checked = true;
            petitionerCheckBox.Checked = true;
            tabardDesignerCheckBox.Checked = true;
            battlemasterCheckBox.Checked = true;
            auctioneerCheckBox.Checked = true;
            stableMasterCheckBox.Checked = true;
            guildBankerCheckBox.Checked = true;
            spellclickCheckBox.Checked = true;
            mailboxCheckBox.Checked = true;
        }
    }
}
