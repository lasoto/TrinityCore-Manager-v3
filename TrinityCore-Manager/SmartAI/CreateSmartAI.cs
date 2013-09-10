using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;
using TrinityCore_Manager.CustomForms;

namespace TrinityCore_Manager.SmartAI
{
    public partial class CreateSmartAI : TCMForm
    {
        public CreateSmartAI()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://collab.kpsn.org/display/tc/smart_scripts");
        }

        private void CreateSmartAI_KeyDown(object sender, KeyEventArgs e)
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
