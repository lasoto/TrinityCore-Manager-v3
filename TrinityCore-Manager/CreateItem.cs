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

        private void CreateItem_Load(object sender, EventArgs e)
        {
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.itemFlagsComboBox, new SuperTooltipInfo("", "", Properties.Resources.FlagsDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.buyCountIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.BuyCountDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.sellGoldIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.SellGoldDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.sellSilverIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.SellGoldDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.sellCopperIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.SellGoldDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.stackableIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.StackableDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.containerSlotsIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ContainerSlotsDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.statsCountIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.StatsCountDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.scalingStatDistributionIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ScalingStatDistDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.scalingStatValueIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ScalingStatValueDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.delayIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.DelayDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.ammoTypeComboBox, new SuperTooltipInfo("", "", Properties.Resources.AmmoTypeDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.rangedModDamageIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.RangedModDamageDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.spellIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.SpellIdDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.spellTriggerComboBox, new SuperTooltipInfo("", "", Properties.Resources.SpellTriggerDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.spellChargesIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.SpellChargesDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.spellPpmIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.SpellPpmRateDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.spellCooldownIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.SpellCdDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.spellCategoryIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.SpellCatDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.itemDescriptionTextBox, new SuperTooltipInfo("", "", Properties.Resources.DescriptionDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.pageTextIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.PageTextDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.languageIdComboBox, new SuperTooltipInfo("", "", Properties.Resources.LanguageIdDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.pageMatComboBox, new SuperTooltipInfo("", "", Properties.Resources.PageMatDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.startQuestIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.StartQuestDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.lockIdIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.LockIdDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.materialComboBox, new SuperTooltipInfo("", "", Properties.Resources.MatDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.sheathComboBox, new SuperTooltipInfo("", "", Properties.Resources.SheathDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.randomPropIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.RandomPropDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.randomSuffixIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.RandomSuffixDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.itemSetIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ItemSetDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.areaIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.AreaDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.mapIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.MapDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.bagFamilyComboBox, new SuperTooltipInfo("", "", Properties.Resources.BagFamilyDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.totemCategoryComboBox, new SuperTooltipInfo("", "", Properties.Resources.TotemCatDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.socketComboBox, new SuperTooltipInfo("", "", Properties.Resources.SocketColorDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.reqDisenchantSkillIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ReqDisenchSkillDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.randomArmorDmgModIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.RandomArmorDmgModDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.durationIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.DurationDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.scriptNameIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ScriptNameDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.disenchantIdIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.DisenchantIdDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.foodTypeComboBox, new SuperTooltipInfo("", "", Properties.Resources.FoodTypeDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.minMoneyLootIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.MinMoneyLootDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.maxMoneyLootIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.MaxMoneyLootDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.reqLevelIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ReqLevelDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.reqSkillComboBox, new SuperTooltipInfo("", "", Properties.Resources.ReqSkillDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.reqSkillRankIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ReqSkillRankDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.reqSpellIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ReqSpellDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.reqHonorRankIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ReqHonorRankDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.reqRepFactionIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ReqRepFactionDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.reqRepFactionIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.ReqRepFactionDesc, null, null, eTooltipColor.Blue));
            this.itemCreatorSuperTooltip.SetSuperTooltip(this.maxCountIntegerInput, new SuperTooltipInfo("", "", Properties.Resources.MaxCountDesc, null, null, eTooltipColor.Blue));
        }

        private void itemDetailsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://collab.kpsn.org/display/tc/Item+template+tc2");

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
            FindItemSpell ItemSpell = new FindItemSpell();
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
