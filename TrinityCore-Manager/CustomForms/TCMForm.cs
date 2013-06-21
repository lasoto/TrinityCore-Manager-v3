using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace TrinityCore_Manager.CustomForms
{
    public class TCMForm : Office2007Form
    {

        private CircularProgress _loading;

        private void TCMForm_Load(object sender, EventArgs e)
        {
        }

        public void StartLoading()
        {

            if (_loading != null)
            {

                StopLoading();

                _loading.Dispose();

            }

            _loading = new CircularProgress();
            _loading.Size = new Size(128, 128);
            _loading.Location = new Point((this.Width / 2) - (_loading.Width / 2), (this.Height / 2) - (_loading.Height / 2));
            _loading.Visible = true;
            _loading.ProgressColor = Color.White;
            _loading.BackColor = Color.Transparent;
            _loading.IsRunning = true;

            this.Controls.Add(_loading);

            _loading.BringToFront();

            this.Enabled = false;

        }

        public void StopLoading()
        {

            this.Controls.Remove(_loading);

            this.Enabled = true;

        }

    }
}
