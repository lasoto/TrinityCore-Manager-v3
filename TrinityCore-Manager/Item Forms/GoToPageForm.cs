using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TrinityCore_Manager.Item_Forms
{
    public partial class GoToPageForm : Office2007Form
    {
        public GoToPageForm()
        {
            InitializeComponent();
        }

        private void GoToPageForm_Load(object sender, EventArgs e)
        {
            textBoxXNewPage.Text = ((FindItem)Owner).atPage.ToString();
        }

        private void GoToPageForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxXNewPage.Text) > ((FindItem)Owner).totalPages)
            {
                MessageBoxEx.Show(this, "The page is higher than the total pages!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
