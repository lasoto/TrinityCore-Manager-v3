namespace TrinityCore_Manager
{
    partial class CharacterSetReputation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSetReputation));
            this.characterLabel = new DevComponents.DotNetBar.LabelX();
            this.factionLabel = new DevComponents.DotNetBar.LabelX();
            this.factionStandingLabel = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.setRankComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.factionComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // characterLabel
            // 
            // 
            // 
            // 
            this.characterLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.characterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.characterLabel.Location = new System.Drawing.Point(85, 12);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(369, 23);
            this.characterLabel.TabIndex = 1;
            this.characterLabel.Text = "Character:";
            // 
            // factionLabel
            // 
            // 
            // 
            // 
            this.factionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.factionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.factionLabel.Location = new System.Drawing.Point(99, 60);
            this.factionLabel.Name = "factionLabel";
            this.factionLabel.Size = new System.Drawing.Size(56, 23);
            this.factionLabel.TabIndex = 7;
            this.factionLabel.Text = "Faction:";
            // 
            // factionStandingLabel
            // 
            // 
            // 
            // 
            this.factionStandingLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.factionStandingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.factionStandingLabel.Location = new System.Drawing.Point(37, 106);
            this.factionStandingLabel.Name = "factionStandingLabel";
            this.factionStandingLabel.Size = new System.Drawing.Size(338, 23);
            this.factionStandingLabel.TabIndex = 9;
            this.factionStandingLabel.Text = "Faction Standing:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(76, 157);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(79, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "Change to:";
            // 
            // setRankComboBox
            // 
            this.setRankComboBox.DisplayMember = "Text";
            this.setRankComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.setRankComboBox.ForeColor = System.Drawing.Color.White;
            this.setRankComboBox.FormattingEnabled = true;
            this.setRankComboBox.ItemHeight = 14;
            this.setRankComboBox.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5,
            this.comboItem6,
            this.comboItem7,
            this.comboItem8});
            this.setRankComboBox.Location = new System.Drawing.Point(158, 160);
            this.setRankComboBox.Name = "setRankComboBox";
            this.setRankComboBox.Size = new System.Drawing.Size(217, 20);
            this.setRankComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.setRankComboBox.TabIndex = 12;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Hated";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Hostile";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Unfriendly";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Neutral";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "Friendly";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "Honored";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "Revered";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "Exalted";
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 216);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 35);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(384, 216);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 13;
            this.okButton.Text = "Ok";
            this.okButton.TextColor = System.Drawing.Color.GreenYellow;
            // 
            // factionComboBox
            // 
            this.factionComboBox.DisplayMember = "Text";
            this.factionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.factionComboBox.FormattingEnabled = true;
            this.factionComboBox.ItemHeight = 14;
            this.factionComboBox.Location = new System.Drawing.Point(158, 63);
            this.factionComboBox.Name = "factionComboBox";
            this.factionComboBox.Size = new System.Drawing.Size(217, 20);
            this.factionComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.factionComboBox.TabIndex = 15;
            // 
            // CharacterSetReputation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 263);
            this.Controls.Add(this.factionComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.setRankComboBox);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.factionStandingLabel);
            this.Controls.Add(this.factionLabel);
            this.Controls.Add(this.characterLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(518, 301);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(518, 301);
            this.Name = "CharacterSetReputation";
            this.Text = "Character Set Reputation";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX characterLabel;
        private DevComponents.DotNetBar.LabelX factionLabel;
        private DevComponents.DotNetBar.LabelX factionStandingLabel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx setRankComboBox;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.ComboBoxEx factionComboBox;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
    }
}