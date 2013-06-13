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
    public partial class OtherCommands : DevComponents.DotNetBar.Office2007Form
    {
        public OtherCommands()
        {
            InitializeComponent();
        }

        private void OtherCommands_Load(object sender, EventArgs e)
        {
            this.superTooltip.SetSuperTooltip(this.switchButton, new SuperTooltipInfo("", "", Properties.Resources.AllowConnDesc, null, null, eTooltipColor.Blue));
        }
    }
}
