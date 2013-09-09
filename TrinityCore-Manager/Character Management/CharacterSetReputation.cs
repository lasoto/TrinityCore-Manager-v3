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
    public partial class CharacterSetReputation : Office2007Form
    {
        public CharacterSetReputation()
        {
            InitializeComponent();
        }

        private void factionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This dropdown list should display ONLY factions from the characters.character_reputation table that account under this GUID has.
        }
    }
}
