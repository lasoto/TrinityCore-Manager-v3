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
using System.Diagnostics;

namespace TrinityCore_Manager
{
    public partial class CreateItem : DevComponents.DotNetBar.Office2007Form
    {
        public CreateItem()
        {
            InitializeComponent();
        }

        private void itemDetailsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://collab.kpsn.org/display/tc/Item+template+tc2");

        }

        private void findFlagsButton_Click(object sender, EventArgs e)
        {
            FindItemFlags fif = new FindItemFlags();
            if (!string.IsNullOrEmpty(flagsTextBox.Text))
                fif.Flags = uint.Parse(flagsTextBox.Text);
            if (fif.ShowDialog() == DialogResult.OK)
            {
                flagsTextBox.Text = fif.Flags.ToString();
            }
        }

        // Text box will only accepts numbers
        private void flagsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void findFlagsExtraButton_Click(object sender, EventArgs e)
        {
            FindItemFlagsExtra fife = new FindItemFlagsExtra();
            if (!string.IsNullOrEmpty(flagsExtraTextBox.Text))
                fife.Flags = uint.Parse(flagsExtraTextBox.Text);
            if (fife.ShowDialog() == DialogResult.OK)
            {
                flagsExtraTextBox.Text = fife.Flags.ToString();
            }
        }

        // Text box will only accepts numbers
        private void flagsExtraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void findDisplayIdButton_Click(object sender, EventArgs e)
        {
            FindItemDisplayID DisplayID = new FindItemDisplayID();
            DisplayID.ShowDialog();
        }

        private void findItemSetButton_Click(object sender, EventArgs e)
        {
            FindItemSet ItemSet = new FindItemSet();
            ItemSet.ShowDialog();
        }

        private void findFactionButton_Click(object sender, EventArgs e)
        {
            FindFaction Faction = new FindFaction();
            Faction.ShowDialog();
        }

        private void findReqSpellButton_Click(object sender, EventArgs e)
        {
            FindItemRequiredSpell RequiredSpell = new FindItemRequiredSpell();
            RequiredSpell.ShowDialog();
        }

        private void findSocketBonusButton_Click(object sender, EventArgs e)
        {
            FindItemSocketBonus SocketBonus = new FindItemSocketBonus();
            SocketBonus.ShowDialog();
        }

        private void findGemPropButton_Click(object sender, EventArgs e)
        {
            FindItemGemProperties GemProperties = new FindItemGemProperties();
            GemProperties.ShowDialog();
        }

        private void findSpellForItemButton_Click(object sender, EventArgs e)
        {
            FindSpell ItemSpell = new FindSpell();
            ItemSpell.ShowDialog();
        }

        private void findAreaButton_Click(object sender, EventArgs e)
        {
            FindItemArea ItemArea = new FindItemArea();
            ItemArea.ShowDialog();
        }

        private void findMapButton_Click(object sender, EventArgs e)
        {
            FindItemMap ItemMap = new FindItemMap();
            ItemMap.ShowDialog();
        }

        private void findStartQuestButton_Click(object sender, EventArgs e)
        {
            FindItemQuest ItemQuest = new FindItemQuest();
            ItemQuest.ShowDialog();
        }

        private void addStatsButton_Click(object sender, EventArgs e)
        {

            int ctr = 0;

            foreach (Control control in itemStatsGroupPanel.Controls)
            {
                if (control is ItemStatsControl)
                {
                    ctr++;
                }
            }

            if (ctr >= 5)
                return;

            addStatsButton.Location = new Point(addStatsButton.Location.X, 56 + (ctr * 48));

            ItemStatsControl ctrl = new ItemStatsControl();
            ctrl.Name = "itemstats_" + ctr;
            ctrl.Location = new Point(33, 6 + (ctr * 48));
            itemStatsGroupPanel.Controls.Add(ctrl);

        }
    }
}
