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
    public partial class EventStart : Office2007Form
    {
        public EventStart()
        {
            InitializeComponent();
        }

        private void findEventButton_Click(object sender, EventArgs e)
        {
            using (FindEvent fe = new FindEvent())
                fe.ShowDialog();
        }

        private void findHolidayButton_Click(object sender, EventArgs e)
        {
            using (FindHoliday fh = new FindHoliday())
                fh.ShowDialog();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            using (ConvertDaysToMinutes cdtm = new ConvertDaysToMinutes())
                cdtm.ShowDialog();
        }

        private void EventStart_KeyDown(object sender, KeyEventArgs e)
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
