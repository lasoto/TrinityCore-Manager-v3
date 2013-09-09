using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TrinityCore_Manager.Properties;

namespace TrinityCore_Manager
{
    public partial class SettingsForm : Office2007Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void TCMSettings_Load(object sender, EventArgs e)
        {
            themeComboBox.SelectedIndex = Settings.Default.ColorTheme;
            checkBoxXAutoSave.Checked = Settings.Default.AutoSaveSettings;
        }

        private void SaveSettings()
        {
            Settings.Default.ColorTheme = themeComboBox.SelectedIndex;
            Settings.Default.AutoSaveSettings = checkBoxXAutoSave.Checked;
            Settings.Default.Save();

            ((MainForm)Owner).InitStyle();
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
            if (checkBoxXAutoSave.Checked)
            {
                Settings.Default.AutoSaveSettings = true;
                SaveSettings();
                return;
            }

            //! If all settings remain the same there is no need to ask if the user is sure he wants to exit without saving.
            if (Settings.Default.ColorTheme == themeComboBox.SelectedIndex && Settings.Default.AutoSaveSettings == checkBoxXAutoSave.Checked)
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
