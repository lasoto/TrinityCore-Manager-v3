using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TrinityCore_Manager.Misc.Enums;
using TrinityCore_Manager.Properties;

namespace TrinityCore_Manager
{
    public partial class TCMSettings : DevComponents.DotNetBar.OfficeForm
    {
        public TCMSettings()
        {
            InitializeComponent();
        }

        private void TCMSettings_Load(object sender, EventArgs e)
        {
            themeComboBox.SelectedIndex = Settings.Default.TCMTheme;
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            Settings set = Settings.Default;

            set.TCMTheme = themeComboBox.SelectedIndex;

            set.Save();

            Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}