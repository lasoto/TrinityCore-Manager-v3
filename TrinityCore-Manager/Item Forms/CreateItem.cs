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
using TrinityCore_Manager.Item_Forms;

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

        private void findSkillButton_Click(object sender, EventArgs e)
        {
            FindSkill Skill = new FindSkill();
            Skill.ShowDialog();
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
            using (FindItemMap ItemMap = new FindItemMap(mapIntegerInput.Value != 0 ? mapIntegerInput.Value : -1))
            {

                ItemMap.FormClosing += (s, args) =>
                {
                    mapIntegerInput.Value = ItemMap.IdSelected;
                };

                ItemMap.ShowDialog();

            }
        }

        private void findStartQuestButton_Click(object sender, EventArgs e)
        {
            FindItemQuest ItemQuest = new FindItemQuest();
            ItemQuest.ShowDialog();
        }

        private void flagsCustomButton_Click(object sender, EventArgs e)
        {
            FindItemFlagsCustom fifc = new FindItemFlagsCustom();
            if (fifc.ShowDialog() == DialogResult.OK)
            {
                flagsCustomIntegerInput.Value = fifc.Flags;
            }
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

            if (ctr >= 10)
                return;

            addStatsButton.Location = new Point(addStatsButton.Location.X, 56 + (ctr * 37));

            ItemStatsControl ctrl = new ItemStatsControl();
            ctrl.Name = "itemstats_" + ctr;
            ctrl.Location = new Point(33, 6 + (ctr * 37));
            itemStatsGroupPanel.Controls.Add(ctrl);
        }

        private void addSpellButton_Click(object sender, EventArgs e)
        {

            int ctr = 0;

            foreach (Control control in itemSpellGroupPanel.Controls)
            {
                if (control is ItemSpellControl)
                {
                    ctr++;
                }
            }

            if (ctr >= 5)
                return;

            addSpellButton.Location = new Point(addSpellButton.Location.X, 56 + (ctr * 75));

            ItemSpellControl ctrl = new ItemSpellControl();
            ctrl.Name = "itemspells_" + ctr;
            ctrl.Location = new Point(1, 6 + (ctr * 75));
            itemSpellGroupPanel.Controls.Add(ctrl);
        }

        private void importToDBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            /* This will get execute if importToDBCheckBox is checked
             * 
             * 
             * DELETE FROM `item_template` WHERE `entry` = @entry;
             * INSERT INTO `item_template` (`entry`, `class`, `subclass`, `name`, 
             * `displayid`, `Quality`, `Flags`, `FlagsExtra`, `BuyCount`, `BuyPrice`, 
             * `SellPrice`, `InventoryType`, `AllowableClass`, `AllowableRace`, `ItemLevel`, 
             * `RequiredLevel`, `RequiredSkill`, `RequiredSkillRank`, `requiredspell`, 
             * `requiredhonorrank`, `RequiredCityRank`, `RequiredReputationFaction`, `RequiredReputationRank`, 
             * `maxcount`, `stackable`, `ContainerSlots`, `StatsCount`, `stat_type1`, `stat_value1`, `stat_type2`, 
             * `stat_value2`, `stat_type3`, `stat_value3`, `stat_type4`, `stat_value4`, `stat_type5`, `stat_value5`, 
             * `stat_type6`, `stat_value6`, `stat_type7`, `stat_value7`, `stat_type8`, `stat_value8`, `stat_type9`, 
             * `stat_value9`, `stat_type10`, `stat_value10`, `ScalingStatDistribution`, `ScalingStatValue`, `dmg_min1`, 
             * `dmg_max1`, `dmg_type1`, `dmg_min2`, `dmg_max2`, `dmg_type2`, `armor`, `holy_res`, `fire_res`, `nature_res`, 
             * `frost_res`, `shadow_res`, `arcane_res`, `delay`, `ammo_type`, `RangedModRange`, `spellid_1`, `spelltrigger_1`, 
             * `spellcharges_1`, `spellppmRate_1`, `spellcooldown_1`, `spellcategory_1`, `spellcategorycooldown_1`, `spellid_2`, 
             * `spelltrigger_2`, `spellcharges_2`, `spellppmRate_2`, `spellcooldown_2`, `spellcategory_2`, 
             * `spellcategorycooldown_2`, `spellid_3`, `spelltrigger_3`, `spellcharges_3`, `spellppmRate_3`, 
             * `spellcooldown_3`, `spellcategory_3`, `spellcategorycooldown_3`, `spellid_4`, `spelltrigger_4`, 
             * `spellcharges_4`, `spellppmRate_4`, `spellcooldown_4`, `spellcategory_4`, `spellcategorycooldown_4`, 
             * `spellid_5`, `spelltrigger_5`, `spellcharges_5`, `spellppmRate_5`, `spellcooldown_5`, `spellcategory_5`, 
             * `spellcategorycooldown_5`, `bonding`, `description`, `PageText`, `LanguageID`, `PageMaterial`, 
             * `startquest`, `lockid`, `Material`, `sheath`, `RandomProperty`, `RandomSuffix`, `block`, `itemset`,
             * `MaxDurability`, `area`, `Map`, `BagFamily`, `TotemCategory`, `socketColor_1`, `socketContent_1`, 
             * `socketColor_2`, `socketContent_2`, `socketColor_3`, `socketContent_3`, `socketBonus`, `GemProperties`, 
             * `RequiredDisenchantSkill`, `ArmorDamageModifier`, `duration`, `ItemLimitCategory`, `HolidayId`, `ScriptName`, 
             * `DisenchantID`, `FoodType`, `minMoneyLoot`, `maxMoneyLoot`, `flagsCustom`, `WDBVerified`) 
             *  VALUES
             * (@entry, @class, @subclass, @name, @displayid, @Quality, @Flags, @FlagsExtra, @BuyCount, @BuyPrice,
             * @SellPrice, @InventoryType, @AllowableClass, @AllowableRace, @ItemLevel, @RequiredLevel, @RequiredSkill,
             * @RequiredSkillRank, @requiredSpell, @requiredhonorrank, @RequiredCityRank, @RequiredReputationFaction, @RequiredReputationRank, 
             * @maxcount, @stackable, @ContainerSlots, @StatsCount, @stat_type1, @stat_value1, @stat_type2, 
             * @stat_value2, @stat_type3, @stat_value3, @stat_type4, @stat_value4, @stat_type5, @stat_value5, 
             * @stat_type6, @stat_value6, @stat_type7, @stat_value7, @stat_type8, @stat_value8, @stat_type9, 
             * @stat_value9, @stat_type10, @stat_value10, @ScalingStatDistribution, @ScalingStatValue, @dmg_min1, 
             * @dmg_max1, @dmg_type1, @dmg_min2, @dmg_max2, @dmg_type2, @armor, @holy_res, @fire_res, @nature_res, 
             * @frost_res, @shadow_res, @arcane_res, @delay, @ammo_type, @RangedModRange, @spellid_1, @spelltrigger_1, 
             * @spellcharges_1, @spellppmRate_1, @spellcooldown_1, @spellcategory_1, @spellcategorycooldown_1, @spellid_2, 
             * @spelltrigger_2, @spellcharges_2, @spellppmRate_2, @spellcooldown_2, @spellcategory_2, 
             * @spellcategorycooldown_2, @spellid_3, @spelltrigger_3, @spellcharges_3, @spellppmRate_3, 
             * @spellcooldown_3, @spellcategory_3, @spellcategorycooldown_3, @spellid_4, @spelltrigger_4, 
             * @spellcharges_4, @spellppmRate_4, @spellcooldown_4, @spellcategory_4, @spellcategorycooldown_4, 
             * @spellid_5, @spelltrigger_5, @spellcharges_5, @spellppmRate_5, @spellcooldown_5, @spellcategory_5, 
             * @spellcategorycooldown_5, @bonding, @description, @PageText, @LanguageID, @PageMaterial, 
             * @startquest, @lockid, @Material, @sheath, @RandomProperty, @RandomSuffix, @block, @itemset,
             * @MaxDurability, @area, @Map, @BagFamily, @TotemCategory, @socketColor_1, @socketContent_1, 
             * @socketColor_2, @socketContent_2, @socketColor_3, @socketContent_3, @socketBonus, @GemProperties, 
             * @RequiredDisenchantSkill, @ArmorDamageModifier, @duration, @ItemLimitCategory, @HolidayId, @ScriptName, 
             * @DisenchantID, @FoodType, @minMoneyLoot, @maxMoneyLoot, @flagsCustom, @WDBVerified);
             * 
             */
        }

        private void saveAsSqlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            /* This will get saved to .sql file if savelAsSqlFileCheckBox is checked
            * 
            * 
            * DELETE FROM `item_template` WHERE `entry` = @entry;
            * INSERT INTO `item_template` (`entry`, `class`, `subclass`, `name`, 
            * `displayid`, `Quality`, `Flags`, `FlagsExtra`, `BuyCount`, `BuyPrice`, 
            * `SellPrice`, `InventoryType`, `AllowableClass`, `AllowableRace`, `ItemLevel`, 
            * `RequiredLevel`, `RequiredSkill`, `RequiredSkillRank`, `requiredspell`, 
            * `requiredhonorrank`, `RequiredCityRank`, `RequiredReputationFaction`, `RequiredReputationRank`, 
            * `maxcount`, `stackable`, `ContainerSlots`, `StatsCount`, `stat_type1`, `stat_value1`, `stat_type2`, 
            * `stat_value2`, `stat_type3`, `stat_value3`, `stat_type4`, `stat_value4`, `stat_type5`, `stat_value5`, 
            * `stat_type6`, `stat_value6`, `stat_type7`, `stat_value7`, `stat_type8`, `stat_value8`, `stat_type9`, 
            * `stat_value9`, `stat_type10`, `stat_value10`, `ScalingStatDistribution`, `ScalingStatValue`, `dmg_min1`, 
            * `dmg_max1`, `dmg_type1`, `dmg_min2`, `dmg_max2`, `dmg_type2`, `armor`, `holy_res`, `fire_res`, `nature_res`, 
            * `frost_res`, `shadow_res`, `arcane_res`, `delay`, `ammo_type`, `RangedModRange`, `spellid_1`, `spelltrigger_1`, 
            * `spellcharges_1`, `spellppmRate_1`, `spellcooldown_1`, `spellcategory_1`, `spellcategorycooldown_1`, `spellid_2`, 
            * `spelltrigger_2`, `spellcharges_2`, `spellppmRate_2`, `spellcooldown_2`, `spellcategory_2`, 
            * `spellcategorycooldown_2`, `spellid_3`, `spelltrigger_3`, `spellcharges_3`, `spellppmRate_3`, 
            * `spellcooldown_3`, `spellcategory_3`, `spellcategorycooldown_3`, `spellid_4`, `spelltrigger_4`, 
            * `spellcharges_4`, `spellppmRate_4`, `spellcooldown_4`, `spellcategory_4`, `spellcategorycooldown_4`, 
            * `spellid_5`, `spelltrigger_5`, `spellcharges_5`, `spellppmRate_5`, `spellcooldown_5`, `spellcategory_5`, 
            * `spellcategorycooldown_5`, `bonding`, `description`, `PageText`, `LanguageID`, `PageMaterial`, 
            * `startquest`, `lockid`, `Material`, `sheath`, `RandomProperty`, `RandomSuffix`, `block`, `itemset`,
            * `MaxDurability`, `area`, `Map`, `BagFamily`, `TotemCategory`, `socketColor_1`, `socketContent_1`, 
            * `socketColor_2`, `socketContent_2`, `socketColor_3`, `socketContent_3`, `socketBonus`, `GemProperties`, 
            * `RequiredDisenchantSkill`, `ArmorDamageModifier`, `duration`, `ItemLimitCategory`, `HolidayId`, `ScriptName`, 
            * `DisenchantID`, `FoodType`, `minMoneyLoot`, `maxMoneyLoot`, `flagsCustom`, `WDBVerified`) 
            *  VALUES
            * (@entry, @class, @subclass, @name, @displayid, @Quality, @Flags, @FlagsExtra, @BuyCount, @BuyPrice,
            * @SellPrice, @InventoryType, @AllowableClass, @AllowableRace, @ItemLevel, @RequiredLevel, @RequiredSkill,
            * @RequiredSkillRank, @requiredSpell, @requiredhonorrank, @RequiredCityRank, @RequiredReputationFaction, @RequiredReputationRank, 
            * @maxcount, @stackable, @ContainerSlots, @StatsCount, @stat_type1, @stat_value1, @stat_type2, 
            * @stat_value2, @stat_type3, @stat_value3, @stat_type4, @stat_value4, @stat_type5, @stat_value5, 
            * @stat_type6, @stat_value6, @stat_type7, @stat_value7, @stat_type8, @stat_value8, @stat_type9, 
            * @stat_value9, @stat_type10, @stat_value10, @ScalingStatDistribution, @ScalingStatValue, @dmg_min1, 
            * @dmg_max1, @dmg_type1, @dmg_min2, @dmg_max2, @dmg_type2, @armor, @holy_res, @fire_res, @nature_res, 
            * @frost_res, @shadow_res, @arcane_res, @delay, @ammo_type, @RangedModRange, @spellid_1, @spelltrigger_1, 
            * @spellcharges_1, @spellppmRate_1, @spellcooldown_1, @spellcategory_1, @spellcategorycooldown_1, @spellid_2, 
            * @spelltrigger_2, @spellcharges_2, @spellppmRate_2, @spellcooldown_2, @spellcategory_2, 
            * @spellcategorycooldown_2, @spellid_3, @spelltrigger_3, @spellcharges_3, @spellppmRate_3, 
            * @spellcooldown_3, @spellcategory_3, @spellcategorycooldown_3, @spellid_4, @spelltrigger_4, 
            * @spellcharges_4, @spellppmRate_4, @spellcooldown_4, @spellcategory_4, @spellcategorycooldown_4, 
            * @spellid_5, @spelltrigger_5, @spellcharges_5, @spellppmRate_5, @spellcooldown_5, @spellcategory_5, 
            * @spellcategorycooldown_5, @bonding, @description, @PageText, @LanguageID, @PageMaterial, 
            * @startquest, @lockid, @Material, @sheath, @RandomProperty, @RandomSuffix, @block, @itemset,
            * @MaxDurability, @area, @Map, @BagFamily, @TotemCategory, @socketColor_1, @socketContent_1, 
            * @socketColor_2, @socketContent_2, @socketColor_3, @socketContent_3, @socketBonus, @GemProperties, 
            * @RequiredDisenchantSkill, @ArmorDamageModifier, @duration, @ItemLimitCategory, @HolidayId, @ScriptName, 
            * @DisenchantID, @FoodType, @minMoneyLoot, @maxMoneyLoot, @flagsCustom, @WDBVerified);
            * 
            */
        }
    }
}
