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
    public partial class FindTypeFlags : Office2007Form
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
                    tameableCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    ghostCheckBox.Checked = true;
                }
                if ((flags & 4) == 4)
                {
                    unk3CheckBox.Checked = true;
                }
                if ((flags & 8) == 8)
                {
                    unk4CheckBox.Checked = true;
                }
                if ((flags & 16) == 16)
                {
                    unk5CheckBox.Checked = true;
                }
                if ((flags & 32) == 32)
                {
                    unk6CheckBox.Checked = true;
                }
                if ((flags & 64) == 64)
                {
                    unk7CheckBox.Checked = true;
                }
                if ((flags & 128) == 128)
                {
                    deadInteractCheckBox.Checked = true;
                }
                if ((flags & 256) == 256)
                {
                    herblootCheckBox.Checked = true;
                }
                if ((flags & 512) == 512)
                {
                    mininglootCheckBox.Checked = true;
                }
                if ((flags & 1024) == 1024)
                {
                    unk11CheckBox.Checked = true;
                }
                if ((flags & 2048) == 2048)
                {
                    mountedCombatCheckBox.Checked = true;
                }
                if ((flags & 4096) == 4096)
                {
                    aidPlayersCheckBox.Checked = true;
                }
                if ((flags & 8192) == 8192)
                {
                    unk14CheckBox.Checked = true;
                }
                if ((flags & 16384) == 16384)
                {
                    unk15CheckBox.Checked = true;
                }
                if ((flags & 32768) == 32768)
                {
                    engineerlootCheckBox.Checked = true;
                }
                if ((flags & 65536) == 65536)
                {
                    exoticCheckBox.Checked = true;
                }
                if ((flags & 131072) == 131072)
                {
                    unk18CheckBox.Checked = true;
                }
                if ((flags & 262144) == 262144)
                {
                    unk19CheckBox.Checked = true;
                }
                if ((flags & 524288) == 524288)
                {
                    unk20CheckBox.Checked = true;
                }
                if ((flags & 1048576) == 1048576)
                {
                    unk21CheckBox.Checked = true;
                }
                if ((flags & 2097152) == 2097152)
                {
                    unk22CheckBox.Checked = true;
                }
                if ((flags & 4194304) == 4194304)
                {
                    unk23CheckBox.Checked = true;
                }
                if ((flags & 8388608) == 8388608)
                {
                    unk24CheckBox.Checked = true;
                }
            }
        }
        public FindTypeFlags()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (tameableCheckBox.Checked)
                _flags += 1;
            if (ghostCheckBox.Checked)
                _flags += 2;
            if (unk3CheckBox.Checked)
                _flags += 4;
            if (unk4CheckBox.Checked)
                _flags += 8;
            if (unk5CheckBox.Checked)
                _flags += 16;
            if (unk6CheckBox.Checked)
                _flags += 32;
            if (unk7CheckBox.Checked)
                _flags += 64;
            if (deadInteractCheckBox.Checked)
                _flags += 128;
            if (herblootCheckBox.Checked)
                _flags += 256;
            if (mininglootCheckBox.Checked)
                _flags += 512;
            if (unk11CheckBox.Checked)
                _flags += 1024;
            if (mountedCombatCheckBox.Checked)
                _flags += 2048;
            if (aidPlayersCheckBox.Checked)
                _flags += 4096;
            if (unk14CheckBox.Checked)
                _flags += 8192;
            if (unk15CheckBox.Checked)
                _flags += 16384;
            if (engineerlootCheckBox.Checked)
                _flags += 32768;
            if (exoticCheckBox.Checked)
                _flags += 65536;
            if (unk18CheckBox.Checked)
                _flags += 131072;
            if (unk19CheckBox.Checked)
                _flags += 262144;
            if (unk20CheckBox.Checked)
                _flags += 524288;
            if (unk21CheckBox.Checked)
                _flags += 1048576;
            if (unk22CheckBox.Checked)
                _flags += 2097152;
            if (unk23CheckBox.Checked)
                _flags += 4194304;
            if (unk24CheckBox.Checked)
                _flags += 8388608;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            tameableCheckBox.Checked = true;
            ghostCheckBox.Checked = true;
            unk3CheckBox.Checked = true;
            unk4CheckBox.Checked = true;
            unk5CheckBox.Checked = true;
            unk6CheckBox.Checked = true;
            unk7CheckBox.Checked = true;
            deadInteractCheckBox.Checked = true;
            herblootCheckBox.Checked = true;
            mininglootCheckBox.Checked = true;
            unk11CheckBox.Checked = true;
            mountedCombatCheckBox.Checked = true;
            aidPlayersCheckBox.Checked = true;
            unk14CheckBox.Checked = true;
            unk15CheckBox.Checked = true;
            engineerlootCheckBox.Checked = true;
            exoticCheckBox.Checked = true;
            unk18CheckBox.Checked = true;
            unk19CheckBox.Checked = true;
            unk20CheckBox.Checked = true;
            unk21CheckBox.Checked = true;
            unk22CheckBox.Checked = true;
            unk23CheckBox.Checked = true;
            unk24CheckBox.Checked = true;
        }
    }
}
