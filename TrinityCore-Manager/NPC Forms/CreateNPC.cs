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
    public partial class CreateNPC : DevComponents.DotNetBar.Office2007Form
    {
        public CreateNPC()
        {
            InitializeComponent();
        }

        private void unitFlagsButton_Click(object sender, EventArgs e)
        {
            FindUnitFlags fuf = new FindUnitFlags();
            fuf.ShowDialog();
        }

        private void unitFlags2Button_Click(object sender, EventArgs e)
        {
            FindUnitFlags2 fuf2 = new FindUnitFlags2();
            fuf2.ShowDialog();
        }

        private void factionAButton_Click(object sender, EventArgs e)
        {
            FindFaction ff = new FindFaction();
            ff.ShowDialog();
        }

        private void factionHButton_Click(object sender, EventArgs e)
        {
            FindFaction ff = new FindFaction();
            ff.ShowDialog();
        }

        private void npcFlagButton_Click(object sender, EventArgs e)
        {
            FindNPCFlag fnf = new FindNPCFlag();
            fnf.ShowDialog();
        }

        private void typeFlagsButton_Click(object sender, EventArgs e)
        {
            FindTypeFlags ftf = new FindTypeFlags();
            ftf.ShowDialog();
        }

        private void dynamicFlagsButton_Click(object sender, EventArgs e)
        {
            FindDynamicFlags fdf = new FindDynamicFlags();
            fdf.ShowDialog();
        }

        private void mechImmuneMaskButton_Click(object sender, EventArgs e)
        {
            FindMechanicImmuneMask fmim = new FindMechanicImmuneMask();
            fmim.ShowDialog();
        }

        private void flagsExtraButton_Click(object sender, EventArgs e)
        {
            FindFlagsExtra ffe = new FindFlagsExtra();
            ffe.ShowDialog();
        }

        private void findSpellButton_Click(object sender, EventArgs e)
        {
            FindSpell fs = new FindSpell();
            fs.ShowDialog();
        }

        private void findRaceButton_Click(object sender, EventArgs e)
        {
            FindRace fr = new FindRace();
            fr.ShowDialog();
        }

        private void findClassButton_Click(object sender, EventArgs e)
        {
            FindClass fc = new FindClass();
            fc.ShowDialog();
        }

        private void findInhabitTypeButton_Click(object sender, EventArgs e)
        {
            FindInhabitType fit = new FindInhabitType();
            fit.ShowDialog();
        }
    }
}
