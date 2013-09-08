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
    public partial class FindItemFlagsExtra : DevComponents.DotNetBar.Office2007Form
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

                if ((flags & 0) == 0)
                {
                    eitherTeamCheckBox.Checked = true;
                }
                if ((flags & 1) == 1)
                {
                    hordeCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    allianceCheckBox.Checked = true;
                }
                if ((flags & 4) == 4)
                {
                    extendedCostCheckBox.Checked = true;
                }
                if ((flags & 256) == 256)
                {
                    needRollDisabledCheckBox.Checked = true;
                }
            }
        }
        public FindItemFlagsExtra()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (eitherTeamCheckBox.Checked)
                _flags += 0;
            if (hordeCheckBox.Checked)
                _flags += 1;
            if (allianceCheckBox.Checked)
                _flags += 2;
            if (extendedCostCheckBox.Checked)
                _flags += 4;
            if (needRollDisabledCheckBox.Checked)
                _flags += 256;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            eitherTeamCheckBox.Checked = true;
            hordeCheckBox.Checked = true;
            allianceCheckBox.Checked = true;
            extendedCostCheckBox.Checked = true;
            needRollDisabledCheckBox.Checked = true;
        }
    }
}
