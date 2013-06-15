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
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.factionComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.repIntegerInput = new DevComponents.Editors.IntegerInput();
            ((System.ComponentModel.ISupportInitialize)(this.repIntegerInput)).BeginInit();
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
            // repIntegerInput
            // 
            // 
            // 
            // 
            this.repIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.repIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.repIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.repIntegerInput.Location = new System.Drawing.Point(158, 160);
            this.repIntegerInput.Name = "repIntegerInput";
            this.repIntegerInput.ShowUpDown = true;
            this.repIntegerInput.Size = new System.Drawing.Size(217, 20);
            this.repIntegerInput.TabIndex = 16;
            // 
            // CharacterSetReputation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 263);
            this.Controls.Add(this.repIntegerInput);
            this.Controls.Add(this.factionComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.repIntegerInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX characterLabel;
        private DevComponents.DotNetBar.LabelX factionLabel;
        private DevComponents.DotNetBar.LabelX factionStandingLabel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.ComboBoxEx factionComboBox;
        private DevComponents.Editors.IntegerInput repIntegerInput;
    }
}