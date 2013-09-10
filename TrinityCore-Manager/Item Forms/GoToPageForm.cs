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
            int atPage = ((FindItem)Owner).atPage;
            textBoxXNewPage.Text = atPage.ToString();
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
                MessageBoxEx.Show(this, String.Format("The given page ({0}) does not exit. Total pages: {1}.", textBoxXNewPage.Text, ((FindItem)Owner).totalPages), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
