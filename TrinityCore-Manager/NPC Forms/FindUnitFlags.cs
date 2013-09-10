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
    public partial class FindUnitFlags : Office2007Form
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
                    serverControlledCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    nonAttackableCheckBox.Checked = true;
                }
                if ((flags & 4) == 4)
                {
                    disableMoveCheckBox.Checked = true;
                }
                if ((flags & 8) == 8)
                {
                    pvpAttackableCheckBox.Checked = true;
                }
                if ((flags & 16) == 16)
                {
                    renameCheckBox.Checked = true;
                }
                if ((flags & 32) == 32)
                {
                    preparationCheckBox.Checked = true;
                }
                if ((flags & 64) == 64)
                {
                    unk6CheckBox.Checked = true;
                }
                if ((flags & 128) == 128)
                {
                    notAttackable1CheckBox.Checked = true;
                }
                if ((flags & 256) == 256)
                {
                    immuneToPcCheckBox.Checked = true;
                }
                if ((flags & 512) == 512)
                {
                    immuneToNpcCheckBox.Checked = true;
                }
                if ((flags & 1024) == 1024)
                {
                    lootingCheckBox.Checked = true;
                }
                if ((flags & 2048) == 2048)
                {
                    petInCombatCheckBox.Checked = true;
                }
                if ((flags & 4096) == 4096)
                {
                    pvpCheckBox.Checked = true;
                }
                if ((flags & 8192) == 8192)
                {
                    silencedCheckBox.Checked = true;
                }
                if ((flags & 16384) == 16384)
                {
                    unk14CheckBox.Checked = true;
                }
                if ((flags & 32768) == 32768)
                {
                    unk15CheckBox.Checked = true;
                }
                if ((flags & 65536) == 65536)
                {
                    unk16CheckBox.Checked = true;
                }
                if ((flags & 131072) == 131072)
                {
                    pacifiedCheckBox.Checked = true;
                }
                if ((flags & 262144) == 262144)
                {
                    stunnedCheckBox.Checked = true;
                }
                if ((flags & 524288) == 524288)
                {
                    inCombatCheckBox.Checked = true;
                }
                if ((flags & 1048576) == 1048576)
                {
                    taxiFlightCheckBox.Checked = true;
                }
                if ((flags & 2097152) == 2097152)
                {
                    disarmedCheckBox.Checked = true;
                }
                if ((flags & 4194304) == 4194304)
                {
                    confusedCheckBox.Checked = true;
                }
                if ((flags & 8388608) == 8388608)
                {
                    fleeingCheckBox.Checked = true;
                }
                if ((flags & 16777216) == 16777216)
                {
                    playerControlledCheckBox.Checked = true;
                }
                if ((flags & 33554432) == 33554432)
                {
                    notSelectableCheckBox.Checked = true;
                }
                if ((flags & 67108864) == 67108864)
                {
                    skinnableCheckBox.Checked = true;
                }
                if ((flags & 134217728) == 134217728)
                {
                    mountCheckBox.Checked = true;
                }
                if ((flags & 268435456) == 268435456)
                {
                    unk28CheckBox.Checked = true;
                }
                if ((flags & 536870912) == 536870912)
                {
                    unk29CheckBox.Checked = true;
                }
                if ((flags & 1073741824) == 1073741824)
                {
                    sheatheCheckBox.Checked = true;
                }
                if ((flags & 2147483648) == 2147483648)
                {
                    unk31CheckBox.Checked = true;
                }
            }
        }

        public FindUnitFlags()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (serverControlledCheckBox.Checked)
                _flags += 1;
            if (nonAttackableCheckBox.Checked)
                _flags += 2;
            if (disableMoveCheckBox.Checked)
                _flags += 4;
            if (pvpAttackableCheckBox.Checked)
                _flags += 8;
            if (renameCheckBox.Checked)
                _flags += 16;
            if (preparationCheckBox.Checked)
                _flags += 32;
            if (unk6CheckBox.Checked)
                _flags += 64;
            if (notAttackable1CheckBox.Checked)
                _flags += 128;
            if (immuneToPcCheckBox.Checked)
                _flags += 256;
            if (immuneToNpcCheckBox.Checked)
                _flags += 512;
            if (lootingCheckBox.Checked)
                _flags += 1024;
            if (petInCombatCheckBox.Checked)
                _flags += 2048;
            if (pvpCheckBox.Checked)
                _flags += 4096;
            if (silencedCheckBox.Checked)
                _flags += 8192;
            if (unk14CheckBox.Checked)
                _flags += 16384;
            if (unk15CheckBox.Checked)
                _flags += 32768;
            if (unk16CheckBox.Checked)
                _flags += 65536;
            if (pacifiedCheckBox.Checked)
                _flags += 131072;
            if (stunnedCheckBox.Checked)
                _flags += 262144;
            if (inCombatCheckBox.Checked)
                _flags += 524288;
            if (taxiFlightCheckBox.Checked)
                _flags += 1048576;
            if (disarmedCheckBox.Checked)
                _flags += 2097152;
            if (confusedCheckBox.Checked)
                _flags += 4194304;
            if (fleeingCheckBox.Checked)
                _flags += 8388608;
            if (playerControlledCheckBox.Checked)
                _flags += 16777216;
            if (notSelectableCheckBox.Checked)
                _flags += 33554432;
            if (skinnableCheckBox.Checked)
                _flags += 67108864;
            if (mountCheckBox.Checked)
                _flags += 134217728;
            if (unk28CheckBox.Checked)
                _flags += 268435456;
            if (unk29CheckBox.Checked)
                _flags += 536870912;
            if (sheatheCheckBox.Checked)
                _flags += 1073741824;
            if (unk31CheckBox.Checked)
                _flags += 2147483648;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            serverControlledCheckBox.Checked = true;
            nonAttackableCheckBox.Checked = true;
            disableMoveCheckBox.Checked = true;
            pvpAttackableCheckBox.Checked = true;
            renameCheckBox.Checked = true;
            preparationCheckBox.Checked = true;
            unk6CheckBox.Checked = true;
            notAttackable1CheckBox.Checked = true;
            immuneToPcCheckBox.Checked = true;
            immuneToNpcCheckBox.Checked = true;
            lootingCheckBox.Checked = true;
            petInCombatCheckBox.Checked = true;
            pvpCheckBox.Checked = true;
            silencedCheckBox.Checked = true;
            unk14CheckBox.Checked = true;
            unk15CheckBox.Checked = true;
            unk16CheckBox.Checked = true;
            pacifiedCheckBox.Checked = true;
            stunnedCheckBox.Checked = true;
            inCombatCheckBox.Checked = true;
            taxiFlightCheckBox.Checked = true;
            disarmedCheckBox.Checked = true;
            confusedCheckBox.Checked = true;
            fleeingCheckBox.Checked = true;
            playerControlledCheckBox.Checked = true;
            notSelectableCheckBox.Checked = true;
            skinnableCheckBox.Checked = true;
            mountCheckBox.Checked = true;
            unk28CheckBox.Checked = true;
            unk29CheckBox.Checked = true;
            sheatheCheckBox.Checked = true;
            unk31CheckBox.Checked = true;
        }

        private void FindUnitFlags_KeyDown(object sender, KeyEventArgs e)
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
