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
    public partial class CreateNPC : Office2007Form
    {
        public CreateNPC()
        {
            InitializeComponent();
        }

        private void unitFlagsButton_Click(object sender, EventArgs e)
        {
            FindUnitFlags fuf = new FindUnitFlags();
            if (!String.IsNullOrEmpty(unitFlagsTextBox.Text))
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
            if (!String.IsNullOrEmpty(unitFlags2TextBox.Text))
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
            if (!String.IsNullOrEmpty(npcFlagTextBox.Text))
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
            if (!String.IsNullOrEmpty(typeFlagsTextBox.Text))
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
            if (!String.IsNullOrEmpty(mechImmuneMaskTextBox.Text))
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
            if (!String.IsNullOrEmpty(flagsExtraTextBox.Text))
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

        private void importToDBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            /* This will get execute if importToDBCheckBox is checked
             * 
             * DELETE FROM `creature_template` WHERE `entry` = @entry;
             * INSERT INTO `creature_template` (`entry`, `difficulty_entry_1`, `difficulty_entry_2`, 
             * `difficulty_entry_3`, `KillCredit1`, `KillCredit2`, `modelid1`, `modelid2`, `modelid3`, 
             * `modelid4`, `name`, `subname`, `IconName`, `gossip_menu_id`, `minlevel`, `maxlevel`, `exp`, 
             * `faction_A`, `faction_H`, `npcflag`, `speed_walk`, `speed_run`, `scale`, `rank`, `mindmg`, 
             * `maxdmg`, `dmgschool`, `attackpower`, `dmg_multiplier`, `baseattacktime`, `rangeattacktime`, 
             * `unit_class`, `unit_flags`, `unit_flags2`, `dynamicflags`, `family`, `trainer_type`, `trainer_spell`, 
             * `trainer_class`, `trainer_race`, `minrangedmg`, `maxrangedmg`, `rangedattackpower`, `type`, 
             * `type_flags`, `lootid`, `pickpocketloot`, `skinloot`, `resistance1`, `resistance2`, `resistance3`, 
             * `resistance4`, `resistance5`, `resistance6`, `spell1`, `spell2`, `spell3`, `spell4`, `spell5`, `spell6`, 
             * `spell7`, `spell8`, `PetSpellDataId`, `VehicleId`, `mingold`, `maxgold`, `AIName`, `MovementType`, 
             * `InhabitType`, `HoverHeight`, `Health_mod`, `Mana_mod`, `Armor_mod`, `RacialLeader`, `questItem1`, 
             * `questItem2`, `questItem3`, `questItem4`, `questItem5`, `questItem6`, `movementId`, `RegenHealth`,
             * `mechanic_immune_mask`, `flags_extra`, `ScriptName`, `WDBVerified`)
             *  VALUES
             * (@entry, @difficulty_entry_1, @difficulty_entry_2, 
             * @difficulty_entry_3, @KillCredit1, @KillCredit2, @modelid1, @modelid2, @modelid3, 
             * @modelid4, @name, @subname, @IconName, @gossip_menu_id, @minlevel, @maxlevel, @exp, 
             * @faction_A, @faction_H, @npcflag, @speed_walk, @speed_run, @scale, @rank, @mindmg, 
             * @maxdmg, @dmgschool, @attackpower, @dmg_multiplier, @baseattacktime, @rangeattacktime, 
             * @unit_class, @unit_flags, @unit_flags2, @dynamicflags, @family, @trainer_type, @trainer_spell, 
             * @trainer_class, @trainer_race, @minrangedmg, @maxrangedmg, @rangedattackpower, @type, 
             * @type_flags, @lootid, @pickpocketloot, @skinloot, @resistance1, @resistance2, @resistance3, 
             * @resistance4, @resistance5, @resistance6, @spell1, @spell2, @spell3, @spell4, @spell5, @spell6, 
             * @spell7, @spell8, @PetSpellDataId, @VehicleId, @mingold, @maxgold, @AIName, @MovementType, 
             * @InhabitType, @HoverHeight, @Health_mod, @Mana_mod, @Armor_mod, @RacialLeader, @questItem1, 
             * @questItem2, @questItem3, @questItem4, @questItem5, @questItem6, @movementId, @RegenHealth,
             * @mechanic_immune_mask, @flags_extra, @ScriptName, @WDBVerified)
             *
             */
        }

        private void saveAsSqlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            /* This will get saved to .sql file if saveAsSqlCheckBox is checked
             * 
             * DELETE FROM `creature_template` WHERE `entry` = @entry;
             * INSERT INTO `creature_template` (`entry`, `difficulty_entry_1`, `difficulty_entry_2`, 
             * `difficulty_entry_3`, `KillCredit1`, `KillCredit2`, `modelid1`, `modelid2`, `modelid3`, 
             * `modelid4`, `name`, `subname`, `IconName`, `gossip_menu_id`, `minlevel`, `maxlevel`, `exp`, 
             * `faction_A`, `faction_H`, `npcflag`, `speed_walk`, `speed_run`, `scale`, `rank`, `mindmg`, 
             * `maxdmg`, `dmgschool`, `attackpower`, `dmg_multiplier`, `baseattacktime`, `rangeattacktime`, 
             * `unit_class`, `unit_flags`, `unit_flags2`, `dynamicflags`, `family`, `trainer_type`, `trainer_spell`, 
             * `trainer_class`, `trainer_race`, `minrangedmg`, `maxrangedmg`, `rangedattackpower`, `type`, 
             * `type_flags`, `lootid`, `pickpocketloot`, `skinloot`, `resistance1`, `resistance2`, `resistance3`, 
             * `resistance4`, `resistance5`, `resistance6`, `spell1`, `spell2`, `spell3`, `spell4`, `spell5`, `spell6`, 
             * `spell7`, `spell8`, `PetSpellDataId`, `VehicleId`, `mingold`, `maxgold`, `AIName`, `MovementType`, 
             * `InhabitType`, `HoverHeight`, `Health_mod`, `Mana_mod`, `Armor_mod`, `RacialLeader`, `questItem1`, 
             * `questItem2`, `questItem3`, `questItem4`, `questItem5`, `questItem6`, `movementId`, `RegenHealth`,
             * `mechanic_immune_mask`, `flags_extra`, `ScriptName`, `WDBVerified`)
             *  VALUES
             * (@entry, @difficulty_entry_1, @difficulty_entry_2, 
             * @difficulty_entry_3, @KillCredit1, @KillCredit2, @modelid1, @modelid2, @modelid3, 
             * @modelid4, @name, @subname, @IconName, @gossip_menu_id, @minlevel, @maxlevel, @exp, 
             * @faction_A, @faction_H, @npcflag, @speed_walk, @speed_run, @scale, @rank, @mindmg, 
             * @maxdmg, @dmgschool, @attackpower, @dmg_multiplier, @baseattacktime, @rangeattacktime, 
             * @unit_class, @unit_flags, @unit_flags2, @dynamicflags, @family, @trainer_type, @trainer_spell, 
             * @trainer_class, @trainer_race, @minrangedmg, @maxrangedmg, @rangedattackpower, @type, 
             * @type_flags, @lootid, @pickpocketloot, @skinloot, @resistance1, @resistance2, @resistance3, 
             * @resistance4, @resistance5, @resistance6, @spell1, @spell2, @spell3, @spell4, @spell5, @spell6, 
             * @spell7, @spell8, @PetSpellDataId, @VehicleId, @mingold, @maxgold, @AIName, @MovementType, 
             * @InhabitType, @HoverHeight, @Health_mod, @Mana_mod, @Armor_mod, @RacialLeader, @questItem1, 
             * @questItem2, @questItem3, @questItem4, @questItem5, @questItem6, @movementId, @RegenHealth,
             * @mechanic_immune_mask, @flags_extra, @ScriptName, @WDBVerified);
             *
             */
        }
    }
}
