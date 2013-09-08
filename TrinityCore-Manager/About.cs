using System;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;

namespace TrinityCore_Manager
{
    public partial class About : DevComponents.DotNetBar.Office2007Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TryToOpenPage("https://github.com/Discover-");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TryToOpenPage("https://github.com/Hobbilis");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TryToOpenPage("https://github.com/Mitch528");
        }

        private void TryToOpenPage(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                MessageBox.Show("The webpage could not be opened!", "An error has occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
