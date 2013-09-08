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
    public partial class FindNPCFlagsExtra : DevComponents.DotNetBar.Office2007Form
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
                    instanceBindCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    civilianCheckBox.Checked = true;
                }
                if ((flags & 4) == 4)
                {
                    noParryCheckBox.Checked = true;
                }
                if ((flags & 8) == 8)
                {
                    noParryHastenCheckBox.Checked = true;
                }
                if ((flags & 16) == 16)
                {
                    noBlockCheckBox.Checked = true;
                }
                if ((flags & 32) == 32)
                {
                    noCrushCheckBox.Checked = true;
                }
                if ((flags & 64) == 64)
                {
                    noXpAtKillCheckBox.Checked = true;
                }
                if ((flags & 128) == 128)
                {
                    triggerCheckBox.Checked = true;
                }
                if ((flags & 256) == 256)
                {
                    noTauntCheckBox.Checked = true;
                }
                if ((flags & 16384) == 16384)
                {
                    worldeventCheckBox.Checked = true;
                }
                if ((flags & 32768) == 32768)
                {
                    guardCheckBox.Checked = true;
                }
                if ((flags & 131072) == 131072)
                {
                    noCritCheckBox.Checked = true;
                }
                if ((flags & 262144) == 262144)
                {
                    noSkillgainCheckBox.Checked = true;
                }
                if ((flags & 524288) == 524288)
                {
                    tauntDiminishCheckBox.Checked = true;
                }
                if ((flags & 1048576) == 1048576)
                {
                    allDiminishCheckBox.Checked = true;
                }
                if ((flags & 2097152) == 2097152)
                {
                    dungeonBossCheckBox.Checked = true;
                }
            }
        }

        public FindNPCFlagsExtra()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (instanceBindCheckBox.Checked)
                _flags += 1;
            if (civilianCheckBox.Checked)
                _flags += 2;
            if (noParryCheckBox.Checked)
                _flags += 4;
            if (noParryHastenCheckBox.Checked)
                _flags += 8;
            if (noBlockCheckBox.Checked)
                _flags += 16;
            if (noCrushCheckBox.Checked)
                _flags += 32;
            if (noXpAtKillCheckBox.Checked)
                _flags += 64;
            if (triggerCheckBox.Checked)
                _flags += 128;
            if (noTauntCheckBox.Checked)
                _flags += 256;
            if (worldeventCheckBox.Checked)
                _flags += 16384;
            if (guardCheckBox.Checked)
                _flags += 32768;
            if (noCritCheckBox.Checked)
                _flags += 131072;
            if (noSkillgainCheckBox.Checked)
                _flags += 262144;
            if (tauntDiminishCheckBox.Checked)
                _flags += 524288;
            if (allDiminishCheckBox.Checked)
                _flags += 1048576;
            if (dungeonBossCheckBox.Checked)
                _flags += 2097152;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            instanceBindCheckBox.Checked = true;
            civilianCheckBox.Checked = true;
            noParryCheckBox.Checked = true;
            noParryHastenCheckBox.Checked = true;
            noBlockCheckBox.Checked = true;
            noCrushCheckBox.Checked = true;
            noXpAtKillCheckBox.Checked = true;
            triggerCheckBox.Checked = true;
            noTauntCheckBox.Checked = true;
            worldeventCheckBox.Checked = true;
            guardCheckBox.Checked = true;
            noCritCheckBox.Checked = true;
            noSkillgainCheckBox.Checked = true;
            tauntDiminishCheckBox.Checked = true;
            allDiminishCheckBox.Checked = true;
            dungeonBossCheckBox.Checked = true;
        }
   }
}
