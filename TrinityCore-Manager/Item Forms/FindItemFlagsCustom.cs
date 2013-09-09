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

namespace TrinityCore_Manager.Item_Forms
{
    public partial class FindItemFlagsCustom : Office2007Form
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
                    durationRealTimeCheckBox.Checked = true;
                }
                if ((flags & 2) == 2)
                {
                    ignoreQuestStatusCheckBox.Checked = true;
                }
                if ((flags & 4) == 4)
                {
                    followLootRulesCheckBox.Checked = true;
                }
            }

        }
        public FindItemFlagsCustom()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _flags = 0;

            if (durationRealTimeCheckBox.Checked)
                _flags += 1;
            if (ignoreQuestStatusCheckBox.Checked)
                _flags += 2;
            if (followLootRulesCheckBox.Checked)
                _flags += 4;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            durationRealTimeCheckBox.Checked = true;
            ignoreQuestStatusCheckBox.Checked = true;
            followLootRulesCheckBox.Checked = true;
        }
    }
}
