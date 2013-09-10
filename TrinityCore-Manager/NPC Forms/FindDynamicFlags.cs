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
    public partial class FindDynamicFlags : Office2007Form
    {

        private int _flags;

        public int Flags
        {
            get
            {
                return _flags;
            }
            set
            {
                int flags = value;

                if ((flags & 0) == 0)
                {
                    noneCheckBox.Checked = true;
                }
                if ((flags & 1) == 1)
                {
                    lootableCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    trackUnitCheckBox.Checked = true;
                }
                if ((flags & 4) == 4)
                {
                    tappedCheckBox.Checked = true;
                }
                if ((flags & 8) == 8)
                {
                    tappedByPlayerCheckBox.Checked = true;
                }
                if ((flags & 16) == 16)
                {
                    specialInfoCheckBox.Checked = true;
                }
                if ((flags & 32) == 32)
                {
                    deadCheckBox.Checked = true;
                }
                if ((flags & 64) == 64)
                {
                    referAFriendCheckBox.Checked = true;
                }
                if ((flags & 128) == 128)
                {
                    tappedByAllThreatListCheckBox.Checked = true;
                }
            }
        }


        public FindDynamicFlags()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (noneCheckBox.Checked)
                _flags += 0;
            if (lootableCheckBox.Checked)
                _flags += 1;
            if (trackUnitCheckBox.Checked)
                _flags += 2;
            if (tappedCheckBox.Checked)
                _flags += 4;
            if (tappedByPlayerCheckBox.Checked)
                _flags += 8;
            if (specialInfoCheckBox.Checked)
                _flags += 16;
            if (deadCheckBox.Checked)
                _flags += 32;
            if (referAFriendCheckBox.Checked)
                _flags += 64;
            if (tappedByAllThreatListCheckBox.Checked)
                _flags += 128;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            noneCheckBox.Checked = true;
            lootableCheckBox.Checked = true;
            trackUnitCheckBox.Checked = true;
            tappedCheckBox.Checked = true;
            tappedByPlayerCheckBox.Checked = true;
            specialInfoCheckBox.Checked = true;
            deadCheckBox.Checked = true;
            referAFriendCheckBox.Checked = true;
            tappedByAllThreatListCheckBox.Checked = true;
        }

        private void FindDynamicFlags_KeyDown(object sender, KeyEventArgs e)
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
