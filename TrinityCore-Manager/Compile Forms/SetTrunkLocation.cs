using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;
using TrinityCore_Manager.CustomForms;
using TrinityCore_Manager.Properties;

namespace TrinityCore_Manager.Compile_Forms
{
    public partial class SetTrunkLocation : TCMForm
    {

        public string TrunkLocation { get; set; }

        public SetTrunkLocation()
        {
            InitializeComponent();
        }

        private void SetTrunkLocationForm_Load(object sender, EventArgs e)
        {
            trunkLocationTextBox.Text = Settings.Default.TrunkLocation;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (trunkLocationTextBox.Text.Length > 0 && Directory.Exists(trunkLocationTextBox.Text))
                    dialog.SelectedPath = trunkLocationTextBox.Text;

                if (dialog.ShowDialog() == DialogResult.OK)
                    trunkLocationTextBox.Text = dialog.SelectedPath;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(trunkLocationTextBox.Text))
            {

                MessageBoxEx.Show(this, "Trunk location required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            this.TrunkLocation = trunkLocationTextBox.Text;

            DialogResult = DialogResult.OK;

            Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
