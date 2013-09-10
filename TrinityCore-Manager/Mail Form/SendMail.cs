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
    public partial class SendMail : Office2007Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void findItemButton_Click(object sender, EventArgs e)
        {
            FindItem fi = new FindItem();
            fi.ShowDialog();  
        }

        private void SendMail_KeyDown(object sender, KeyEventArgs e)
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
