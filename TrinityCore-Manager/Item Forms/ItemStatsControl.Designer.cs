namespace TrinityCore_Manager
{
    partial class ItemStatsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statTypeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.healthComboItem = new DevComponents.Editors.ComboItem();
            this.agilityComboItem = new DevComponents.Editors.ComboItem();
            this.strengthComboItem = new DevComponents.Editors.ComboItem();
            this.intellectComboItem = new DevComponents.Editors.ComboItem();
            this.spiritComboItem = new DevComponents.Editors.ComboItem();
            this.staminaComboItem = new DevComponents.Editors.ComboItem();
            this.defenseComboItem = new DevComponents.Editors.ComboItem();
            this.dodgeComboItem = new DevComponents.Editors.ComboItem();
            this.parryComboItem = new DevComponents.Editors.ComboItem();
            this.blockComboItem = new DevComponents.Editors.ComboItem();
            this.hitMeleeComboItem = new DevComponents.Editors.ComboItem();
            this.hitRangedComboItem = new DevComponents.Editors.ComboItem();
            this.critMeleeComboItem = new DevComponents.Editors.ComboItem();
            this.critRangedComboItem = new DevComponents.Editors.ComboItem();
            this.hitTakenMeleeComboItem = new DevComponents.Editors.ComboItem();
            this.hitTakenRangedComboItem = new DevComponents.Editors.ComboItem();
            this.hitTakenSpellComboItem = new DevComponents.Editors.ComboItem();
            this.critTakenMeleeComboItem = new DevComponents.Editors.ComboItem();
            this.critTakenRangedComboItem = new DevComponents.Editors.ComboItem();
            this.critTakenSpellComboItem = new DevComponents.Editors.ComboItem();
            this.hasteMeleeComboItem = new DevComponents.Editors.ComboItem();
            this.hasteRangedComboItem = new DevComponents.Editors.ComboItem();
            this.hasteSpellComboItem = new DevComponents.Editors.ComboItem();
            this.hitRatingComboItem = new DevComponents.Editors.ComboItem();
            this.critRatingComboItem = new DevComponents.Editors.ComboItem();
            this.hitTakenComboItem = new DevComponents.Editors.ComboItem();
            this.critTakenComboItem = new DevComponents.Editors.ComboItem();
            this.resilienceRatingComboItem = new DevComponents.Editors.ComboItem();
            this.hasteRatingComboItem = new DevComponents.Editors.ComboItem();
            this.expertiseRatingComboItem = new DevComponents.Editors.ComboItem();
            this.attackPowerComboItem = new DevComponents.Editors.ComboItem();
            this.rangedAttackPowerComboItem = new DevComponents.Editors.ComboItem();
            this.feralAttackPowerComboItem = new DevComponents.Editors.ComboItem();
            this.spellHealingDoneComboItem = new DevComponents.Editors.ComboItem();
            this.spellDamageDoneComboItem = new DevComponents.Editors.ComboItem();
            this.manaRegenComboItem = new DevComponents.Editors.ComboItem();
            this.armorPenetrationComboItem = new DevComponents.Editors.ComboItem();
            this.manaComboItem = new DevComponents.Editors.ComboItem();
            this.itemStatTypeLabel1 = new DevComponents.DotNetBar.LabelX();
            this.itemStatValueLabel1 = new DevComponents.DotNetBar.LabelX();
            this.itemStatsValueIntegerInput = new DevComponents.Editors.IntegerInput();
            this.spellPowerComboItem = new DevComponents.Editors.ComboItem();
            this.healthRegenComboItem = new DevComponents.Editors.ComboItem();
            this.spellPenetrationComboItem = new DevComponents.Editors.ComboItem();
            this.blockValueComboItem = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.itemStatsValueIntegerInput)).BeginInit();
            this.SuspendLayout();
            // 
            // statTypeComboBox
            // 
            this.statTypeComboBox.DisplayMember = "Text";
            this.statTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.statTypeComboBox.FormattingEnabled = true;
            this.statTypeComboBox.ItemHeight = 14;
            this.statTypeComboBox.Items.AddRange(new object[] {
            this.manaComboItem,
            this.healthComboItem,
            this.agilityComboItem,
            this.strengthComboItem,
            this.intellectComboItem,
            this.spiritComboItem,
            this.staminaComboItem,
            this.defenseComboItem,
            this.dodgeComboItem,
            this.parryComboItem,
            this.blockComboItem,
            this.hitMeleeComboItem,
            this.hitRangedComboItem,
            this.critMeleeComboItem,
            this.critRangedComboItem,
            this.hitTakenMeleeComboItem,
            this.hitTakenRangedComboItem,
            this.hitTakenSpellComboItem,
            this.critTakenMeleeComboItem,
            this.critTakenRangedComboItem,
            this.critTakenSpellComboItem,
            this.hasteMeleeComboItem,
            this.hasteRangedComboItem,
            this.hasteSpellComboItem,
            this.hitRatingComboItem,
            this.critRatingComboItem,
            this.hitTakenComboItem,
            this.critTakenComboItem,
            this.resilienceRatingComboItem,
            this.hasteRatingComboItem,
            this.expertiseRatingComboItem,
            this.attackPowerComboItem,
            this.rangedAttackPowerComboItem,
            this.feralAttackPowerComboItem,
            this.spellHealingDoneComboItem,
            this.spellDamageDoneComboItem,
            this.manaRegenComboItem,
            this.armorPenetrationComboItem,
            this.spellPowerComboItem,
            this.healthRegenComboItem,
            this.spellPenetrationComboItem,
            this.blockValueComboItem});
            this.statTypeComboBox.Location = new System.Drawing.Point(75, 3);
            this.statTypeComboBox.Name = "statTypeComboBox";
            this.statTypeComboBox.Size = new System.Drawing.Size(310, 20);
            this.statTypeComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.statTypeComboBox.TabIndex = 5;
            // 
            // healthComboItem
            // 
            this.healthComboItem.Text = "Health";
            // 
            // agilityComboItem
            // 
            this.agilityComboItem.Text = "Agility";
            // 
            // strengthComboItem
            // 
            this.strengthComboItem.Text = "Strength";
            // 
            // intellectComboItem
            // 
            this.intellectComboItem.Text = "Intellect";
            // 
            // spiritComboItem
            // 
            this.spiritComboItem.Text = "Spirit";
            // 
            // staminaComboItem
            // 
            this.staminaComboItem.Text = "Stamina";
            // 
            // defenseComboItem
            // 
            this.defenseComboItem.Text = "Defense Skill Rating";
            // 
            // dodgeComboItem
            // 
            this.dodgeComboItem.Text = "Dodge Rating";
            // 
            // parryComboItem
            // 
            this.parryComboItem.Text = "Parry Rating";
            // 
            // blockComboItem
            // 
            this.blockComboItem.Text = "Block Rating";
            // 
            // hitMeleeComboItem
            // 
            this.hitMeleeComboItem.Text = "Hit Melee Rating";
            // 
            // hitRangedComboItem
            // 
            this.hitRangedComboItem.Text = "Hit Ranged Rating";
            // 
            // critMeleeComboItem
            // 
            this.critMeleeComboItem.Text = "Crit Melee Rating";
            // 
            // critRangedComboItem
            // 
            this.critRangedComboItem.Text = "Crit Ranged Rating";
            // 
            // hitTakenMeleeComboItem
            // 
            this.hitTakenMeleeComboItem.Text = "Hit Taken Melee Rating";
            // 
            // hitTakenRangedComboItem
            // 
            this.hitTakenRangedComboItem.Text = "Hit Taken Ranged Rating";
            // 
            // hitTakenSpellComboItem
            // 
            this.hitTakenSpellComboItem.Text = "Hit Taken Spell Rating";
            // 
            // critTakenMeleeComboItem
            // 
            this.critTakenMeleeComboItem.Text = "Crit Taken Melee Rating";
            // 
            // critTakenRangedComboItem
            // 
            this.critTakenRangedComboItem.Text = "Crit Taken Ranged Rating";
            // 
            // critTakenSpellComboItem
            // 
            this.critTakenSpellComboItem.Text = "Crit Taken Spell Rating";
            // 
            // hasteMeleeComboItem
            // 
            this.hasteMeleeComboItem.Text = "Haste Melee Rating";
            // 
            // hasteRangedComboItem
            // 
            this.hasteRangedComboItem.Text = "Haste Ranged Rating";
            // 
            // hasteSpellComboItem
            // 
            this.hasteSpellComboItem.Text = "Haste Spell Rating";
            // 
            // hitRatingComboItem
            // 
            this.hitRatingComboItem.Text = "Hit Rating";
            // 
            // critRatingComboItem
            // 
            this.critRatingComboItem.Text = "Crit Rating";
            // 
            // hitTakenComboItem
            // 
            this.hitTakenComboItem.Text = "Hit Taken Rating";
            // 
            // critTakenComboItem
            // 
            this.critTakenComboItem.Text = "Crit Taken Rating";
            // 
            // resilienceRatingComboItem
            // 
            this.resilienceRatingComboItem.Text = "Resilience Rating";
            // 
            // hasteRatingComboItem
            // 
            this.hasteRatingComboItem.Text = "Haste Rating";
            // 
            // expertiseRatingComboItem
            // 
            this.expertiseRatingComboItem.Text = "Expertise Rating";
            // 
            // attackPowerComboItem
            // 
            this.attackPowerComboItem.Text = "Attack Power";
            // 
            // rangedAttackPowerComboItem
            // 
            this.rangedAttackPowerComboItem.Text = "Ranged Attack Power";
            // 
            // feralAttackPowerComboItem
            // 
            this.feralAttackPowerComboItem.Text = "Feral Attack Power (Not used as of v3.3)";
            // 
            // spellHealingDoneComboItem
            // 
            this.spellHealingDoneComboItem.Text = "Spell Healing Done";
            // 
            // spellDamageDoneComboItem
            // 
            this.spellDamageDoneComboItem.Text = "Spell Damage Done";
            // 
            // manaRegenComboItem
            // 
            this.manaRegenComboItem.Text = "Mana Regen";
            // 
            // armorPenetrationComboItem
            // 
            this.armorPenetrationComboItem.Text = "Armor Penetration";
            // 
            // manaComboItem
            // 
            this.manaComboItem.Text = "Mana";
            // 
            // itemStatTypeLabel1
            // 
            // 
            // 
            // 
            this.itemStatTypeLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemStatTypeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.itemStatTypeLabel1.Location = new System.Drawing.Point(7, 0);
            this.itemStatTypeLabel1.Name = "itemStatTypeLabel1";
            this.itemStatTypeLabel1.Size = new System.Drawing.Size(75, 23);
            this.itemStatTypeLabel1.TabIndex = 3;
            this.itemStatTypeLabel1.Text = "Stat Type:";
            // 
            // itemStatValueLabel1
            // 
            // 
            // 
            // 
            this.itemStatValueLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemStatValueLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.itemStatValueLabel1.Location = new System.Drawing.Point(415, 0);
            this.itemStatValueLabel1.Name = "itemStatValueLabel1";
            this.itemStatValueLabel1.Size = new System.Drawing.Size(43, 23);
            this.itemStatValueLabel1.TabIndex = 4;
            this.itemStatValueLabel1.Text = "Value";
            // 
            // itemStatsValueIntegerInput
            // 
            // 
            // 
            // 
            this.itemStatsValueIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itemStatsValueIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemStatsValueIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.itemStatsValueIntegerInput.ForeColor = System.Drawing.Color.White;
            this.itemStatsValueIntegerInput.Location = new System.Drawing.Point(464, 3);
            this.itemStatsValueIntegerInput.Name = "itemStatsValueIntegerInput";
            this.itemStatsValueIntegerInput.ShowUpDown = true;
            this.itemStatsValueIntegerInput.Size = new System.Drawing.Size(108, 20);
            this.itemStatsValueIntegerInput.TabIndex = 6;
            // 
            // spellPowerComboItem
            // 
            this.spellPowerComboItem.Text = "Spell Power";
            // 
            // healthRegenComboItem
            // 
            this.healthRegenComboItem.Text = "Health Regen";
            // 
            // spellPenetrationComboItem
            // 
            this.spellPenetrationComboItem.Text = "Spell Penetration";
            // 
            // blockValueComboItem
            // 
            this.blockValueComboItem.Text = "Block Value";
            // 
            // ItemStatsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.statTypeComboBox);
            this.Controls.Add(this.itemStatTypeLabel1);
            this.Controls.Add(this.itemStatValueLabel1);
            this.Controls.Add(this.itemStatsValueIntegerInput);
            this.Name = "ItemStatsControl";
            this.Size = new System.Drawing.Size(585, 30);
            ((System.ComponentModel.ISupportInitialize)(this.itemStatsValueIntegerInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx statTypeComboBox;
        private DevComponents.Editors.ComboItem healthComboItem;
        private DevComponents.Editors.ComboItem agilityComboItem;
        private DevComponents.Editors.ComboItem strengthComboItem;
        private DevComponents.Editors.ComboItem intellectComboItem;
        private DevComponents.Editors.ComboItem spiritComboItem;
        private DevComponents.Editors.ComboItem staminaComboItem;
        private DevComponents.Editors.ComboItem defenseComboItem;
        private DevComponents.Editors.ComboItem dodgeComboItem;
        private DevComponents.Editors.ComboItem parryComboItem;
        private DevComponents.Editors.ComboItem blockComboItem;
        private DevComponents.Editors.ComboItem hitMeleeComboItem;
        private DevComponents.Editors.ComboItem hitRangedComboItem;
        private DevComponents.Editors.ComboItem critMeleeComboItem;
        private DevComponents.Editors.ComboItem critRangedComboItem;
        private DevComponents.Editors.ComboItem hitTakenMeleeComboItem;
        private DevComponents.Editors.ComboItem hitTakenRangedComboItem;
        private DevComponents.Editors.ComboItem hitTakenSpellComboItem;
        private DevComponents.Editors.ComboItem critTakenMeleeComboItem;
        private DevComponents.Editors.ComboItem critTakenRangedComboItem;
        private DevComponents.Editors.ComboItem critTakenSpellComboItem;
        private DevComponents.Editors.ComboItem hasteMeleeComboItem;
        private DevComponents.Editors.ComboItem hasteRangedComboItem;
        private DevComponents.Editors.ComboItem hasteSpellComboItem;
        private DevComponents.Editors.ComboItem hitRatingComboItem;
        private DevComponents.Editors.ComboItem critRatingComboItem;
        private DevComponents.Editors.ComboItem hitTakenComboItem;
        private DevComponents.Editors.ComboItem critTakenComboItem;
        private DevComponents.Editors.ComboItem resilienceRatingComboItem;
        private DevComponents.Editors.ComboItem hasteRatingComboItem;
        private DevComponents.Editors.ComboItem expertiseRatingComboItem;
        private DevComponents.Editors.ComboItem attackPowerComboItem;
        private DevComponents.Editors.ComboItem rangedAttackPowerComboItem;
        private DevComponents.Editors.ComboItem feralAttackPowerComboItem;
        private DevComponents.Editors.ComboItem spellHealingDoneComboItem;
        private DevComponents.Editors.ComboItem spellDamageDoneComboItem;
        private DevComponents.Editors.ComboItem manaRegenComboItem;
        private DevComponents.Editors.ComboItem armorPenetrationComboItem;
        private DevComponents.DotNetBar.LabelX itemStatTypeLabel1;
        private DevComponents.DotNetBar.LabelX itemStatValueLabel1;
        private DevComponents.Editors.IntegerInput itemStatsValueIntegerInput;
        private DevComponents.Editors.ComboItem manaComboItem;
        private DevComponents.Editors.ComboItem spellPowerComboItem;
        private DevComponents.Editors.ComboItem healthRegenComboItem;
        private DevComponents.Editors.ComboItem spellPenetrationComboItem;
        private DevComponents.Editors.ComboItem blockValueComboItem;
    }
}
