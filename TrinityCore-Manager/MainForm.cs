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
using Microsoft.Win32;

namespace TrinityCore_Manager
{
    public partial class MainForm : Office2007RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void setLevelButton_Click(object sender, EventArgs e)
        {
            CharacterSetLevel Level = new CharacterSetLevel();
            Level.ShowDialog();
        }

        private void createItemButton_Click(object sender, EventArgs e)
        {
            CreateItem Item = new CreateItem();
            Item.ShowDialog();
        }

    }
}
