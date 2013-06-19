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
    public partial class SendMail : DevComponents.DotNetBar.Office2007Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void findItemButton_Click(object sender, EventArgs e)
        {
            FindItem FindItem = new FindItem();
            FindItem.ShowDialog();
        }
    }
}
