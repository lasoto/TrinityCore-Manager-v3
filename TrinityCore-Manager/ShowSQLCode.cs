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
    public partial class ShowSQLCode : DevComponents.DotNetBar.Office2007Form
    {
        public ShowSQLCode()
        {
            InitializeComponent();
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sqlCodeTextBox.Text))
                Clipboard.SetText(sqlCodeTextBox.Text);
        }
      
    }
}
