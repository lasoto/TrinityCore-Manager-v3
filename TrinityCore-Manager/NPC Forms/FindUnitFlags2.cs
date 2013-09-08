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
    public partial class FindUnitFlags2 : DevComponents.DotNetBar.Office2007Form
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
                    feignDeathCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    unk1CheckBox.Checked = true;
                }
                if ((flags & 4) == 4)
                {
                    ignoreReputationCheckBox.Checked = true;
                }
                if ((flags & 8) == 8)
                {
                    comprehendLangCheckBox.Checked = true;
                }
                if ((flags & 16) == 16)
                {
                    mirrorImageCheckBox.Checked = true;
                }
                if ((flags & 64) == 64)
                {
                    forceMoveCheckBox.Checked = true;
                }
                if ((flags & 128) == 128)
                {
                    disarmOffhandCheckBox.Checked = true;
                }
                if ((flags & 1024) == 1024)
                {
                    disarmRangedCheckBox.Checked = true;
                }
                if ((flags & 2048) == 2048)
                {
                    regeneratePowerCheckBox.Checked = true;
                }
                if ((flags & 16384) == 16384)
                {
                    allowEnemyIntCheckBox.Checked = true;
                }
                if ((flags & 262144) == 262144)
                {
                    allowCheatSpellsCheckBox.Checked = true;
                }
            }
        }

        public FindUnitFlags2()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (feignDeathCheckBox.Checked)
                _flags += 1;
            if (unk1CheckBox.Checked)
                _flags += 2;
            if (ignoreReputationCheckBox.Checked)
                _flags += 4;
            if (comprehendLangCheckBox.Checked)
                _flags += 8;
            if (mirrorImageCheckBox.Checked)
                _flags += 16;
            if (forceMoveCheckBox.Checked)
                _flags += 64;
            if (disarmOffhandCheckBox.Checked)
                _flags += 128;
            if (disarmRangedCheckBox.Checked)
                _flags += 1024;
            if (regeneratePowerCheckBox.Checked)
                _flags += 2048;
            if (allowEnemyIntCheckBox.Checked)
                _flags += 16384;
            if (allowCheatSpellsCheckBox.Checked)
                _flags += 262144;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            feignDeathCheckBox.Checked = true;
            unk1CheckBox.Checked = true;
            ignoreReputationCheckBox.Checked = true;
            comprehendLangCheckBox.Checked = true;
            mirrorImageCheckBox.Checked = true;
            forceMoveCheckBox.Checked = true;
            disarmOffhandCheckBox.Checked = true;
            disarmRangedCheckBox.Checked = true;
            regeneratePowerCheckBox.Checked = true;
            allowEnemyIntCheckBox.Checked = true;
            allowCheatSpellsCheckBox.Checked = true;
        }

    }
}
