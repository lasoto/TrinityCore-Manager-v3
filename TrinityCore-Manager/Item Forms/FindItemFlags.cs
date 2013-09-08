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
    public partial class FindItemFlags : DevComponents.DotNetBar.Office2007Form
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
                    soulboundCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    conjuredCheckBox.Checked = true;
                }
                if ((flags & 4) == 4)
                {
                    lootableCheckBox.Checked = true;
                }
                if ((flags & 8) == 8)
                {
                    heroicCheckBox.Checked = true;
                }
                if ((flags & 16) == 16)
                {
                    deprecatedItemCheckBox.Checked = true;
                }
                if ((flags & 32) == 32)
                {
                    totemCheckBox.Checked = true;
                }
                if ((flags & 64) == 64)
                {
                    activateWithRightClickCheckBox.Checked = true;
                }
                if ((flags & 256) == 256)
                {
                    wrapperCheckBox.Checked = true;
                }
                if ((flags & 1024) == 1024)
                {
                    giftsCheckBox.Checked = true;
                }
                if ((flags & 2048) == 2048)
                {
                    itemIsPartyLootCheckBox.Checked = true;
                }
                if ((flags & 4096) == 4096)
                {
                    itemIsRefundableCheckBox.Checked = true;
                }
                if ((flags & 8192) == 8192)
                {
                    charterCheckBox.Checked = true;
                }
                if ((flags & 32768) == 32768)
                {
                    pvpRewardItemCheckBox.Checked = true;
                }
                if ((flags & 524288) == 524288)
                {
                    uniqueEquippedCheckBox.Checked = true;
                }
                if ((flags & 4194304) == 4194304)
                {
                    throwableCheckBox.Checked = true;
                }
                if ((flags & 8388608) == 8388608)
                {
                    specialUseCheckBox.Checked = true;
                }
                if ((flags & 134221824) == 134221824)
                {
                    bindOnAccountCheckBox.Checked = true;
                }
                if ((flags & 268435456) == 268435456)
                {
                    forEnchantScrollsCheckBox.Checked = true;
                }
                if ((flags & 536870912) == 536870912)
                {
                    millableCheckBox.Checked = true;
                }
                if ((flags & 2147483648) == 2147483648)
                {
                    bindOnPickupCheckBox.Checked = true;
                }
            }
        }
        public FindItemFlags()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (soulboundCheckBox.Checked)
                _flags += 1;
            if (conjuredCheckBox.Checked)
                _flags += 2;
            if (lootableCheckBox.Checked)
                _flags += 4;
            if (heroicCheckBox.Checked)
                _flags += 8;
            if (deprecatedItemCheckBox.Checked)
                _flags += 16;
            if (totemCheckBox.Checked)
                _flags += 32;
            if (activateWithRightClickCheckBox.Checked)
                _flags += 64;
            if (wrapperCheckBox.Checked)
                _flags += 256;
            if (giftsCheckBox.Checked)
                _flags += 1024;
            if (itemIsPartyLootCheckBox.Checked)
                _flags += 2048;
            if (itemIsRefundableCheckBox.Checked)
                _flags += 4096;
            if (charterCheckBox.Checked)
                _flags += 8192;
            if (pvpRewardItemCheckBox.Checked)
                _flags += 32768;
            if (uniqueEquippedCheckBox.Checked)
                _flags += 524288;
            if (throwableCheckBox.Checked)
                _flags += 4194304;
            if (specialUseCheckBox.Checked)
                _flags += 8388608;
            if (bindOnAccountCheckBox.Checked)
                _flags += 134221824;
            if (forEnchantScrollsCheckBox.Checked)
                _flags += 268435456;
            if (millableCheckBox.Checked)
                _flags += 536870912;
            if (bindOnPickupCheckBox.Checked)
                _flags += 2147483648;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            soulboundCheckBox.Checked = true;
            conjuredCheckBox.Checked = true;
            lootableCheckBox.Checked = true;
            heroicCheckBox.Checked = true;
            deprecatedItemCheckBox.Checked = true;
            totemCheckBox.Checked = true;
            activateWithRightClickCheckBox.Checked = true;
            wrapperCheckBox.Checked = true;
            giftsCheckBox.Checked = true;
            itemIsPartyLootCheckBox.Checked = true;
            itemIsRefundableCheckBox.Checked = true;
            charterCheckBox.Checked = true;
            pvpRewardItemCheckBox.Checked = true;
            uniqueEquippedCheckBox.Checked = true;
            throwableCheckBox.Checked = true;
            specialUseCheckBox.Checked = true;
            bindOnAccountCheckBox.Checked = true;
            forEnchantScrollsCheckBox.Checked = true;
            millableCheckBox.Checked = true;
            bindOnPickupCheckBox.Checked = true;
        }
    }
}
