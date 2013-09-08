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
    public partial class ConvertDaysToMinutes : DevComponents.DotNetBar.Office2007Form
    {

        public ConvertDaysToMinutes()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void daysIntegerInput_ValueChanged(object sender, EventArgs e)
        {
            inMinutesLabel.Text = ((int)TimeSpan.FromDays(daysIntegerInput.Value).TotalMinutes).ToString();
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inMinutesLabel.Text))
                Clipboard.SetText(inMinutesLabel.Text);
        }

    }
}
