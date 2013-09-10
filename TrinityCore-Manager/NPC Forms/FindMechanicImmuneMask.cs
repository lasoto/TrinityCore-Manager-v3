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
    public partial class FindMechanicImmuneMask : Office2007Form
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
                    charmCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    disorientedCheckBox.Checked = true;
                }
                if ((flags & 4) == 4)
                {
                    disarmCheckBox.Checked = true;
                }
                if ((flags & 8) == 8)
                {
                    distractCheckBox.Checked = true;
                }
                if ((flags & 16) == 16)
                {
                    fearCheckBox.Checked = true;
                }
                if ((flags & 32) == 32)
                {
                    gripCheckBox.Checked = true;
                }
                if ((flags & 64) == 64)
                {
                    rootCheckBox.Checked = true;
                }
                if ((flags & 128) == 128)
                {
                    pacifyCheckBox.Checked = true;
                }
                if ((flags & 256) == 256)
                {
                    silenceCheckBox.Checked = true;
                }
                if ((flags & 512) == 512)
                {
                    sleepCheckBox.Checked = true;
                }
                if ((flags & 1024) == 1024)
                {
                    snareCheckBox.Checked = true;
                }
                if ((flags & 2048) == 2048)
                {
                    stunCheckBox.Checked = true;
                }
                if ((flags & 4096) == 4096)
                {
                    freezeCheckBox.Checked = true;
                }
                if ((flags & 8192) == 8192)
                {
                    knockoutCheckBox.Checked = true;
                }
                if ((flags & 16384) == 16384)
                {
                    bleedCheckBox.Checked = true;
                }
                if ((flags & 32768) == 32768)
                {
                    bandageCheckBox.Checked = true;
                }
                if ((flags & 65536) == 65536)
                {
                    polymorphCheckBox.Checked = true;
                }
                if ((flags & 131072) == 131072)
                {
                    banishCheckBox.Checked = true;
                }
                if ((flags & 262144) == 262144)
                {
                    shieldCheckBox.Checked = true;
                }
                if ((flags & 524288) == 524288)
                {
                    shackleCheckBox.Checked = true;
                }
                if ((flags & 1048576) == 1048576)
                {
                    mountCheckBox.Checked = true;
                }
                if ((flags & 2097152) == 2097152)
                {
                    infectedCheckBox.Checked = true;
                }
                if ((flags & 4194304) == 4194304)
                {
                    turnCheckBox.Checked = true;
                }
                if ((flags & 8388608) == 8388608)
                {
                    horrorCheckBox.Checked = true;
                }
                if ((flags & 16777216) == 16777216)
                {
                    invulnCheckBox.Checked = true;
                }
                if ((flags & 33554432) == 33554432)
                {
                    interruptCheckBox.Checked = true;
                }
                if ((flags & 67108864) == 67108864)
                {
                    dazeCheckBox.Checked = true;
                }
                if ((flags & 134217728) == 134217728)
                {
                    discoveryCheckBox.Checked = true;
                }
                if ((flags & 268435456) == 268435456)
                {
                    immuneShieldCheckBox.Checked = true;
                }
                if ((flags & 536870912) == 536870912)
                {
                    sappedCheckBox.Checked = true;
                }
                if ((flags & 1073741824) == 1073741824)
                {
                    enragedCheckBox.Checked = true;
                }

            }
        }
        public FindMechanicImmuneMask()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (charmCheckBox.Checked)
                _flags += 1;
            if (disorientedCheckBox.Checked)
                _flags += 2;
            if (disarmCheckBox.Checked)
                _flags += 4;
            if (distractCheckBox.Checked)
                _flags += 8;
            if (fearCheckBox.Checked)
                _flags += 16;
            if (gripCheckBox.Checked)
                _flags += 32;
            if (rootCheckBox.Checked)
                _flags += 64;
            if (pacifyCheckBox.Checked)
                _flags += 128;
            if (silenceCheckBox.Checked)
                _flags += 256;
            if (sleepCheckBox.Checked)
                _flags += 512;
            if (snareCheckBox.Checked)
                _flags += 1024;
            if (stunCheckBox.Checked)
                _flags += 2048;
            if (freezeCheckBox.Checked)
                _flags += 4096;
            if (knockoutCheckBox.Checked)
                _flags += 8192;
            if (bleedCheckBox.Checked)
                _flags += 16384;
            if (bandageCheckBox.Checked)
                _flags += 32768;
            if (polymorphCheckBox.Checked)
                _flags += 65536;
            if (banishCheckBox.Checked)
                _flags += 131072;
            if (shieldCheckBox.Checked)
                _flags += 262144;
            if (shackleCheckBox.Checked)
                _flags += 524288;
            if (mountCheckBox.Checked)
                _flags += 1048576;
            if (infectedCheckBox.Checked)
                _flags += 2097152;
            if (turnCheckBox.Checked)
                _flags += 4194304;
            if (horrorCheckBox.Checked)
                _flags += 8388608;
            if (invulnCheckBox.Checked)
                _flags += 16777216;
            if (interruptCheckBox.Checked)
                _flags += 33554432;
            if (dazeCheckBox.Checked)
                _flags += 67108864;
            if (discoveryCheckBox.Checked)
                _flags += 134217728;
            if (immuneShieldCheckBox.Checked)
                _flags += 268435456;
            if (sappedCheckBox.Checked)
                _flags += 536870912;
            if (enragedCheckBox.Checked)
                _flags += 1073741824;

            DialogResult = DialogResult.OK;

            Close();

        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            charmCheckBox.Checked = true;
            disorientedCheckBox.Checked = true;
            disarmCheckBox.Checked = true;
            distractCheckBox.Checked = true;
            fearCheckBox.Checked = true;
            gripCheckBox.Checked = true;
            rootCheckBox.Checked = true;
            pacifyCheckBox.Checked = true;
            silenceCheckBox.Checked = true;
            sleepCheckBox.Checked = true;
            snareCheckBox.Checked = true;
            stunCheckBox.Checked = true;
            freezeCheckBox.Checked = true;
            knockoutCheckBox.Checked = true;
            bleedCheckBox.Checked = true;
            bandageCheckBox.Checked = true;
            polymorphCheckBox.Checked = true;
            banishCheckBox.Checked = true;
            shieldCheckBox.Checked = true;
            shackleCheckBox.Checked = true;
            mountCheckBox.Checked = true;
            infectedCheckBox.Checked = true;
            turnCheckBox.Checked = true;
            horrorCheckBox.Checked = true;
            invulnCheckBox.Checked = true;
            interruptCheckBox.Checked = true;
            dazeCheckBox.Checked = true;
            discoveryCheckBox.Checked = true;
            immuneShieldCheckBox.Checked = true;
            sappedCheckBox.Checked = true;
            enragedCheckBox.Checked = true;
        }

        private void FindMechanicImmuneMask_KeyDown(object sender, KeyEventArgs e)
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
