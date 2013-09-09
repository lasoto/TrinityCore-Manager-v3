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
using TrinityCore_Manager.CustomForms;
using TrinityCore_Manager.TCM;
using TrinityCore_Manager.Database.Classes;

namespace TrinityCore_Manager
{
    public partial class CreateItem : TCMForm
    {

        private TCItem _item;

        private int _itemId = -1;

        public CreateItem()
        {
            InitializeComponent();
        }

        public CreateItem(int id)
        {

            _itemId = id;

            InitializeComponent();

        }

        private void CreateItem_Load(object sender, EventArgs e)
        {
            Init();
        }

        private async void Init()
        {

            if (_item == null)
            {

                itemClassComboBox.SelectedIndex = 0;

            }
            else
            {

                StartLoading();

                loadingLabel.Visible = true;
                loadingProgressBar.Visible = true;

                createWeaponWizardPage.NextButtonEnabled = eWizardButtonState.False;

                _item = await TCManager.Instance.WorldDatabase.GetItem(_itemId);

                Populate();

                StopLoading();

            }

        }

        private void Populate()
        {

            if (_item == null)
                return;



        }

        private void itemDetailsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://collab.kpsn.org/display/tc/Item+template+tc2");

        }

        private void findFlagsButton_Click(object sender, EventArgs e)
        {
            FindItemFlags fif = new FindItemFlags();
            if (!String.IsNullOrEmpty(flagsTextBox.Text))
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
            if (!String.IsNullOrEmpty(flagsExtraTextBox.Text))
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
            using (FindItemDisplayID DisplayID = new FindItemDisplayID())
                DisplayID.ShowDialog();
        }

        private void findItemSetButton_Click(object sender, EventArgs e)
        {
            using (FindItemSet ItemSet = new FindItemSet())
                ItemSet.ShowDialog();
        }

        private void findFactionButton_Click(object sender, EventArgs e)
        {
            using (FindFaction Faction = new FindFaction())
                Faction.ShowDialog();
        }

        private void findSkillButton_Click(object sender, EventArgs e)
        {
            using (FindSkill Skill = new FindSkill())
                Skill.ShowDialog();
        }

        private void findReqSpellButton_Click(object sender, EventArgs e)
        {
            using (FindItemRequiredSpell RequiredSpell = new FindItemRequiredSpell())
                RequiredSpell.ShowDialog();
        }

        private void findSocketBonusButton_Click(object sender, EventArgs e)
        {
            using (FindItemSocketBonus SocketBonus = new FindItemSocketBonus())
                SocketBonus.ShowDialog();
        }

        private void findGemPropButton_Click(object sender, EventArgs e)
        {
            using (FindItemGemProperties GemProperties = new FindItemGemProperties())
                GemProperties.ShowDialog();
        }

        private void findSpellForItemButton_Click(object sender, EventArgs e)
        {
            using (FindSpell ItemSpell = new FindSpell())
                ItemSpell.ShowDialog();
        }

        private void findAreaButton_Click(object sender, EventArgs e)
        {
            using (FindItemArea ItemArea = new FindItemArea())
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
            using (FindItemQuest ItemQuest = new FindItemQuest())
                ItemQuest.ShowDialog();
        }

        private void flagsCustomButton_Click(object sender, EventArgs e)
        {
            using (FindItemFlagsCustom fifc = new FindItemFlagsCustom())
            {
                if (fifc.ShowDialog() == DialogResult.OK)
                {
                    flagsCustomIntegerInput.Value = fifc.Flags;
                }
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

        private void itemCreatorWizard_WizardPageChanging(object sender, WizardCancelPageChangeEventArgs e)
        {

            if (e.OldPage == itemDetailsWizardPage)
            {

                //if (String.IsNullOrEmpty(itemNameTextBox.Text) || String.IsNullOrEmpty(

            }

        }

        private void itemCreatorWizard_FinishButtonClick(object sender, CancelEventArgs e)
        {

            string name = itemNameTextBox.Text;
            string desc = itemDescriptionTextBox.Text;
            int itemClass = itemClassComboBox.SelectedIndex;

        }

        private void itemClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            itemSubClassComboBox.Items.Clear();

            string[] toAdd = null;

            switch (itemClassComboBox.SelectedIndex)
            {

                case 0: // Consumable

                    toAdd = new string[]  {
                        "Consumable",
                        "Potion",
                        "Elixir",
                        "Flask",
                        "Scroll",
                        "Food & Drink",
                        "Item Enhancement",
                        "Bandage",
                        "Other"
                    };

                    break;

                case 1: //Container

                    toAdd = new string[] { 
                        "Bag",
                        "Soul Bag",
                        "Herb Bag",
                        "Enchanting Bag",
                        "Engineering Bag",
                        "Gem Bag",
                        "Mining Bag",
                        "Leatherworking Bag",
                        "Inscription Bag"
                    };

                    break;

                case 2:

                    toAdd = new string[] {
                        "Axe (One handed)",
                        "Axe (Two handed)",
                        "Bow",
                        "Gun",
                        "Mace (One handed)",
                        "Mace (Two handed)",
                        "Polearm",
                        "Sword (One handed)",
                        "Sword (Two handed)",
                        "Obsolete",
                        "Staff",
                        "Exotic",
                        "Exotic",
                        "Fist Weapon",
                        "Miscellaneous",
                        "Dagger",
                        "Thrown",
                        "Spear",
                        "Crowwbow",
                        "Wand",
                        "Fishing Pole",
                    };

                    break;

                case 3:

                    toAdd = new string[] {
                        "Red",
                        "Blue",
                        "Yellow",
                        "Purple",
                        "Green",
                        "Orange",
                        "Meta",
                        "Simple",
                        "Prismatic"
                    };

                    break;

                case 4:

                    toAdd = new string[] {
                        "Miscellaneous",
                        "Cloth",
                        "Leather",
                        "Mail",
                        "Plate",
                        "Buckler (OBSOLETE)",
                        "Shield",
                        "Libram",
                        "Idol",
                        "Totem",
                        "Sigil"
                    };

                    break;

                case 5:

                    toAdd = new string[] {
                        "Reagent"
                    };

                    break;

                case 6:

                    toAdd = new string[] {
                        "Wand (OBSOLETE)",
                        "Bolt (OBSOLETE)",
                        "Arrow",
                        "Bullet",
                        "Thrown (OBSOLETE)",

                    };

                    break;

                case 7:

                    toAdd = new string[] {
                        "Trade Goods",
                        "Parts",
                        "Explosives",
                        "Devices",
                        "Jewelcrafting",
                        "Cloth",
                        "Leather",
                        "Metal & Stone",
                        "Meat",
                        "Herb",
                        "Elemental",
                        "Other",
                        "Enchanting",
                        "Materials",
                        "Armor Enchantment",
                        "Weapon Enchantment",
                    };

                    break;

                case 8:

                    toAdd = new string[] {
                        "Generic (OBSOLETE)"
                    };

                    break;

                case 9:

                    toAdd = new string[] {
                        "Book",
                        "Leatherworking",
                        "Tailoring",
                        "Engineering",
                        "Blacksmithing",
                        "Cooking",
                        "Alchemy",
                        "First Aid",
                        "Enchanting",
                        "Fishing",
                        "Jewelcrafting"
                    };

                    break;

                case 10:

                    toAdd = new string[] {
                        "Money (OBSOLETE)"
                    };

                    break;

                case 11:

                    toAdd = new string[] {
                        "Quiver (OBSOLETE)",
                        "Quiver (OBSOLETE)",
                        "Quiver",
                        "Ammo Pouch",
                    };

                    break;

                case 12:

                    toAdd = new string[] {
                        "Quest"
                    };

                    break;

                case 13:

                    toAdd = new string[] {
                        "Key",
                        "Lockpick"
                    };

                    break;

                case 14:

                    toAdd = new string[] {
                        "Permanent"
                    };

                    break;

                case 15:

                    toAdd = new string[] {
                        "Junk",
                        "Reagent",
                        "Pet",
                        "Holiday",
                        "Other",
                        "Mount"
                    };

                    break;

                case 16:

                    toAdd = new string[] {
                        "Warrior",
                        "Paladin",
                        "Hunter",
                        "Rogue",
                        "Priest",
                        "Death Knight",
                        "Shaman",
                        "Mage",
                        "Warlock",
                        "Druid"
                    };

                    break;

                default:

                    toAdd = new string[0];

                    break;

            }

            itemSubClassComboBox.Items.AddRange(toAdd);

            if (itemSubClassComboBox.Items.Count > 0)
                itemSubClassComboBox.SelectedIndex = 0;

        }


    }
}
