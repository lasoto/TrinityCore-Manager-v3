using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;

namespace TrinityCore_Manager
{
    public class RestrictedForm : Office2007Form
    {

        protected override void OnLoad(EventArgs e)
        {

            //if TrinityCore-Manager has not been purchased

            this.Enabled = false;
            MessageBoxEx.Show("This feature is disabled in the free version of TrinityCore Manager!", "Restricted", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            this.Close();

            base.OnLoad(e);

        }

    }
}
