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
    public partial class SettingsForm : DevComponents.DotNetBar.OfficeForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void TCMSettings_Load(object sender, EventArgs e)
        {
            themeComboBox.SelectedIndex = Settings.Default.ColorTheme;
        }

        private void SaveSettings()
        {
            Settings.Default.ColorTheme = themeComboBox.SelectedIndex;
            Settings.Default.Save();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            PromptSaveSettingsOnClose();
            Close();
        }

        void PromptSaveSettingsOnClose()
        {
            //! If all settings remain the same there is no need to ask if the user is sure he wants to exit without saving.
            if (Settings.Default.ColorTheme == themeComboBox.SelectedIndex)
                return;

            if (MessageBox.Show("Do you wish to save the edited settings?", "Save settings?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                SaveSettings();
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                PromptSaveSettingsOnClose();
        }

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    PromptSaveSettingsOnClose();
                    Close();
                    break;
            }
        }

    }
}
