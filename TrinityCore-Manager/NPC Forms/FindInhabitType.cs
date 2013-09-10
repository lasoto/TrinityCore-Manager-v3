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
    public partial class FindInhabitType : Office2007Form
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

                if ((flags & 1) == 1)
                {
                    groundCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    waterCheckBox.Checked = true;
                }
                if ((flags & 4) == 4)
                {
                    flyingCheckBox.Checked = true;
                }
            }
        }

        public FindInhabitType()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (groundCheckBox.Checked)
                _flags += 1;
            if (waterCheckBox.Checked)
                _flags += 2;
            if (flyingCheckBox.Checked)
                _flags += 4;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            groundCheckBox.Checked = true;
            waterCheckBox.Checked = true;
            flyingCheckBox.Checked = true;
        }

        private void FindInhabitType_KeyDown(object sender, KeyEventArgs e)
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
