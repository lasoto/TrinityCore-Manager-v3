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
            this.expertiseComboItem = new DevComponents.Editors.ComboItem();
            this.resilienceComboItem = new DevComponents.Editors.ComboItem();
            this.healingBonusComboItem = new DevComponents.Editors.ComboItem();
            this.damageBonusComboItem = new DevComponents.Editors.ComboItem();
            this.manaperfivesecComboItem = new DevComponents.Editors.ComboItem();
            this.blockValueComboItem = new DevComponents.Editors.ComboItem();
            this.healthRegenComboItem = new DevComponents.Editors.ComboItem();
            this.spellPenetrationComboItem = new DevComponents.Editors.ComboItem();
            this.armorPenetrationComboItem = new DevComponents.Editors.ComboItem();
            this.attackPowerComboItem = new DevComponents.Editors.ComboItem();
            this.hitRatingComboItem = new DevComponents.Editors.ComboItem();
            this.hitAvoidComboItem = new DevComponents.Editors.ComboItem();
            this.hitCritRatingComboItem = new DevComponents.Editors.ComboItem();
            this.hitCritAvoidComboItem = new DevComponents.Editors.ComboItem();
            this.hitHasteComboItem = new DevComponents.Editors.ComboItem();
            this.meleeHitComboItem = new DevComponents.Editors.ComboItem();
            this.meleeCritComboItem = new DevComponents.Editors.ComboItem();
            this.meleeHitAvoidComboItem = new DevComponents.Editors.ComboItem();
            this.meleeCritAvoidComboItem = new DevComponents.Editors.ComboItem();
            this.meleeHasteComboItem = new DevComponents.Editors.ComboItem();
            this.rangedAttackPwrComboItem = new DevComponents.Editors.ComboItem();
            this.rangedHitComboItem = new DevComponents.Editors.ComboItem();
            this.rangedCritComboItem = new DevComponents.Editors.ComboItem();
            this.rangedHitAvoidComboItem = new DevComponents.Editors.ComboItem();
            this.rangedCritAvoidComboItem = new DevComponents.Editors.ComboItem();
            this.rangedHasteComboItem = new DevComponents.Editors.ComboItem();
            this.spellHitComboItem = new DevComponents.Editors.ComboItem();
            this.spellCritComboItem = new DevComponents.Editors.ComboItem();
            this.spellHitAvoidComboItem = new DevComponents.Editors.ComboItem();
            this.spellCritAvoidComboItem = new DevComponents.Editors.ComboItem();
            this.spellHasteComboItem = new DevComponents.Editors.ComboItem();
            this.spellPowerComboItem = new DevComponents.Editors.ComboItem();
            this.feralAttackPwrComboItem = new DevComponents.Editors.ComboItem();
            this.itemStatTypeLabel1 = new DevComponents.DotNetBar.LabelX();
            this.itemStatValueLabel1 = new DevComponents.DotNetBar.LabelX();
            this.itemStatsValueIntegerInput = new DevComponents.Editors.IntegerInput();
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
            this.expertiseComboItem,
            this.resilienceComboItem,
            this.healingBonusComboItem,
            this.damageBonusComboItem,
            this.manaperfivesecComboItem,
            this.blockValueComboItem,
            this.healthRegenComboItem,
            this.spellPenetrationComboItem,
            this.armorPenetrationComboItem,
            this.attackPowerComboItem,
            this.hitRatingComboItem,
            this.hitAvoidComboItem,
            this.hitCritRatingComboItem,
            this.hitCritAvoidComboItem,
            this.hitHasteComboItem,
            this.meleeHitComboItem,
            this.meleeCritComboItem,
            this.meleeHitAvoidComboItem,
            this.meleeCritAvoidComboItem,
            this.meleeHasteComboItem,
            this.rangedAttackPwrComboItem,
            this.rangedHitComboItem,
            this.rangedCritComboItem,
            this.rangedHitAvoidComboItem,
            this.rangedCritAvoidComboItem,
            this.rangedHasteComboItem,
            this.spellHitComboItem,
            this.spellCritComboItem,
            this.spellHitAvoidComboItem,
            this.spellCritAvoidComboItem,
            this.spellHasteComboItem,
            this.spellPowerComboItem,
            this.feralAttackPwrComboItem});
            this.statTypeComboBox.Location = new System.Drawing.Point(74, 19);
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
            this.defenseComboItem.Text = "Defense";
            // 
            // dodgeComboItem
            // 
            this.dodgeComboItem.Text = "Dodge";
            // 
            // parryComboItem
            // 
            this.parryComboItem.Text = "Parry";
            // 
            // blockComboItem
            // 
            this.blockComboItem.Text = "Block";
            // 
            // expertiseComboItem
            // 
            this.expertiseComboItem.Text = "Expertise";
            // 
            // resilienceComboItem
            // 
            this.resilienceComboItem.Text = "Resilience";
            // 
            // healingBonusComboItem
            // 
            this.healingBonusComboItem.Text = "Healing Bonus";
            // 
            // damageBonusComboItem
            // 
            this.damageBonusComboItem.Text = "Damage Bonus";
            // 
            // manaperfivesecComboItem
            // 
            this.manaperfivesecComboItem.Text = "Mana Per 5 Sec";
            // 
            // blockValueComboItem
            // 
            this.blockValueComboItem.Text = "Block Value";
            // 
            // healthRegenComboItem
            // 
            this.healthRegenComboItem.Text = "Health Regeneration";
            // 
            // spellPenetrationComboItem
            // 
            this.spellPenetrationComboItem.Text = "Spell Penetration";
            // 
            // armorPenetrationComboItem
            // 
            this.armorPenetrationComboItem.Text = "Armor Penetration";
            // 
            // attackPowerComboItem
            // 
            this.attackPowerComboItem.Text = "Attack Power";
            // 
            // hitRatingComboItem
            // 
            this.hitRatingComboItem.Text = "Hit Rating";
            // 
            // hitAvoidComboItem
            // 
            this.hitAvoidComboItem.Text = "Hit Avoidance";
            // 
            // hitCritRatingComboItem
            // 
            this.hitCritRatingComboItem.Text = "Hit Crit Rating";
            // 
            // hitCritAvoidComboItem
            // 
            this.hitCritAvoidComboItem.Text = "Hit Crit Avoidance";
            // 
            // hitHasteComboItem
            // 
            this.hitHasteComboItem.Text = "Hit Haste Rating";
            // 
            // meleeHitComboItem
            // 
            this.meleeHitComboItem.Text = "Melee Hit Rating";
            // 
            // meleeCritComboItem
            // 
            this.meleeCritComboItem.Text = "Melee Crit Rating";
            // 
            // meleeHitAvoidComboItem
            // 
            this.meleeHitAvoidComboItem.Text = "Melee Hit Avoidance";
            // 
            // meleeCritAvoidComboItem
            // 
            this.meleeCritAvoidComboItem.Text = "Melee Crit Avoidance";
            // 
            // meleeHasteComboItem
            // 
            this.meleeHasteComboItem.Text = "Melee Haste Rating";
            // 
            // rangedAttackPwrComboItem
            // 
            this.rangedAttackPwrComboItem.Text = "Ranged Attack Power";
            // 
            // rangedHitComboItem
            // 
            this.rangedHitComboItem.Text = "Ranged Hit Rating";
            // 
            // rangedCritComboItem
            // 
            this.rangedCritComboItem.Text = "Ranged Crit Rating";
            // 
            // rangedHitAvoidComboItem
            // 
            this.rangedHitAvoidComboItem.Text = "Ranged Hit Avoidance";
            // 
            // rangedCritAvoidComboItem
            // 
            this.rangedCritAvoidComboItem.Text = "Ranged Crit Avoidance";
            // 
            // rangedHasteComboItem
            // 
            this.rangedHasteComboItem.Text = "Ranged Haste Rating";
            // 
            // spellHitComboItem
            // 
            this.spellHitComboItem.Text = "Spell Hit Rating";
            // 
            // spellCritComboItem
            // 
            this.spellCritComboItem.Text = "Spell Crit Rating";
            // 
            // spellHitAvoidComboItem
            // 
            this.spellHitAvoidComboItem.Text = "Spell Hit Avoidance";
            // 
            // spellCritAvoidComboItem
            // 
            this.spellCritAvoidComboItem.Text = "Spell Crit Avoidance";
            // 
            // spellHasteComboItem
            // 
            this.spellHasteComboItem.Text = "Spell Haste Rating";
            // 
            // spellPowerComboItem
            // 
            this.spellPowerComboItem.Text = "Spell Power";
            // 
            // feralAttackPwrComboItem
            // 
            this.feralAttackPwrComboItem.Text = "Feral Attack Power";
            // 
            // itemStatTypeLabel1
            // 
            // 
            // 
            // 
            this.itemStatTypeLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemStatTypeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.itemStatTypeLabel1.Location = new System.Drawing.Point(6, 16);
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
            this.itemStatValueLabel1.Location = new System.Drawing.Point(414, 16);
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
            this.itemStatsValueIntegerInput.Location = new System.Drawing.Point(463, 19);
            this.itemStatsValueIntegerInput.Name = "itemStatsValueIntegerInput";
            this.itemStatsValueIntegerInput.ShowUpDown = true;
            this.itemStatsValueIntegerInput.Size = new System.Drawing.Size(108, 20);
            this.itemStatsValueIntegerInput.TabIndex = 6;
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
            this.Size = new System.Drawing.Size(585, 56);
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
        private DevComponents.Editors.ComboItem expertiseComboItem;
        private DevComponents.Editors.ComboItem resilienceComboItem;
        private DevComponents.Editors.ComboItem healingBonusComboItem;
        private DevComponents.Editors.ComboItem damageBonusComboItem;
        private DevComponents.Editors.ComboItem manaperfivesecComboItem;
        private DevComponents.Editors.ComboItem blockValueComboItem;
        private DevComponents.Editors.ComboItem healthRegenComboItem;
        private DevComponents.Editors.ComboItem spellPenetrationComboItem;
        private DevComponents.Editors.ComboItem armorPenetrationComboItem;
        private DevComponents.Editors.ComboItem attackPowerComboItem;
        private DevComponents.Editors.ComboItem hitRatingComboItem;
        private DevComponents.Editors.ComboItem hitAvoidComboItem;
        private DevComponents.Editors.ComboItem hitCritRatingComboItem;
        private DevComponents.Editors.ComboItem hitCritAvoidComboItem;
        private DevComponents.Editors.ComboItem hitHasteComboItem;
        private DevComponents.Editors.ComboItem meleeHitComboItem;
        private DevComponents.Editors.ComboItem meleeCritComboItem;
        private DevComponents.Editors.ComboItem meleeHitAvoidComboItem;
        private DevComponents.Editors.ComboItem meleeCritAvoidComboItem;
        private DevComponents.Editors.ComboItem meleeHasteComboItem;
        private DevComponents.Editors.ComboItem rangedAttackPwrComboItem;
        private DevComponents.Editors.ComboItem rangedHitComboItem;
        private DevComponents.Editors.ComboItem rangedCritComboItem;
        private DevComponents.Editors.ComboItem rangedHitAvoidComboItem;
        private DevComponents.Editors.ComboItem rangedCritAvoidComboItem;
        private DevComponents.Editors.ComboItem rangedHasteComboItem;
        private DevComponents.Editors.ComboItem spellHitComboItem;
        private DevComponents.Editors.ComboItem spellCritComboItem;
        private DevComponents.Editors.ComboItem spellHitAvoidComboItem;
        private DevComponents.Editors.ComboItem spellCritAvoidComboItem;
        private DevComponents.Editors.ComboItem spellHasteComboItem;
        private DevComponents.Editors.ComboItem spellPowerComboItem;
        private DevComponents.Editors.ComboItem feralAttackPwrComboItem;
        private DevComponents.DotNetBar.LabelX itemStatTypeLabel1;
        private DevComponents.DotNetBar.LabelX itemStatValueLabel1;
        private DevComponents.Editors.IntegerInput itemStatsValueIntegerInput;
    }
}
