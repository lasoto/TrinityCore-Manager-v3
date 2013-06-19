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
            if (!string.IsNullOrEmpty(unitFlagsTextBox.Text))
                fuf.Flags = uint.Parse(unitFlagsTextBox.Text);
            if (fuf.ShowDialog() == DialogResult.OK)
            {
                unitFlagsTextBox.Text = fuf.Flags.ToString();
            }
        }

        // Text box will only accepts numbers
        private void unitFlagsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void unitFlags2Button_Click(object sender, EventArgs e)
        {
            FindUnitFlags2 fuf2 = new FindUnitFlags2();
            if (!string.IsNullOrEmpty(unitFlags2TextBox.Text))
                fuf2.Flags = uint.Parse(unitFlags2TextBox.Text);
            if (fuf2.ShowDialog() == DialogResult.OK)
            {
                unitFlags2TextBox.Text = fuf2.Flags.ToString();
            }
        }

        // Text box will only accepts numbers
        private void unitFlags2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
            if (!string.IsNullOrEmpty(npcFlagTextBox.Text))
                fnf.Flags = uint.Parse(npcFlagTextBox.Text);
            if (fnf.ShowDialog() == DialogResult.OK)
            {
                npcFlagTextBox.Text = fnf.Flags.ToString();
            }
        }

        // Text box will only accepts numbers
        private void npcFlagTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void typeFlagsButton_Click(object sender, EventArgs e)
        {
            FindTypeFlags ftf = new FindTypeFlags();
            if (!string.IsNullOrEmpty(typeFlagsTextBox.Text))
                ftf.Flags = uint.Parse(typeFlagsTextBox.Text);
            if (ftf.ShowDialog() == DialogResult.OK)
            {
                typeFlagsTextBox.Text = ftf.Flags.ToString();
            }
        }

        // Text box will only accepts numbers
        private void typeFlagsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dynamicFlagsButton_Click(object sender, EventArgs e)
        {
            FindDynamicFlags fdf = new FindDynamicFlags();

            fdf.Flags = dynamicFlagsIntegerInput.Value;

            if (fdf.ShowDialog() == DialogResult.OK)
            {
                dynamicFlagsIntegerInput.Value = fdf.Flags;
            }
        }

        private void mechImmuneMaskButton_Click(object sender, EventArgs e)
        {
            FindMechanicImmuneMask fmim = new FindMechanicImmuneMask();
            if (!string.IsNullOrEmpty(mechImmuneMaskTextBox.Text))
                fmim.Flags = uint.Parse(mechImmuneMaskTextBox.Text);
            if (fmim.ShowDialog() == DialogResult.OK)
            {
                mechImmuneMaskTextBox.Text = fmim.Flags.ToString();
            }
        }

        // Text box will only accepts numbers
        private void mechImmuneMaskTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void flagsExtraButton_Click(object sender, EventArgs e)
        {
            FindNPCFlagsExtra ffe = new FindNPCFlagsExtra();
            if (!string.IsNullOrEmpty(flagsExtraTextBox.Text))
                ffe.Flags = uint.Parse(flagsExtraTextBox.Text);
            if (ffe.ShowDialog() == DialogResult.OK)
            {
                flagsExtraTextBox.Text = ffe.Flags.ToString();
            }
        }

        // Text box will only accepts numbers
        private void flagsExtraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
            if (fit.ShowDialog() == DialogResult.OK)
            {
                inhabitTypeIntegerInput.Value = fit.Flags;
            }
        }
    }
}
