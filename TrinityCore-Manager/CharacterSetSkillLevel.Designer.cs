namespace TrinityCore_Manager
{
    partial class CharacterSetSkillLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSetSkillLevel));
            this.characterLabel = new DevComponents.DotNetBar.LabelX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.skillLabel = new DevComponents.DotNetBar.LabelX();
            this.skillComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.skillLevelLabel = new DevComponents.DotNetBar.LabelX();
            this.changeLabel = new DevComponents.DotNetBar.LabelX();
            this.integerInput1 = new DevComponents.Editors.IntegerInput();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).BeginInit();
            this.SuspendLayout();
            // 
            // characterLabel
            // 
            // 
            // 
            // 
            this.characterLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.characterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.characterLabel.Location = new System.Drawing.Point(111, 12);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(296, 23);
            this.characterLabel.TabIndex = 1;
            this.characterLabel.Text = "Character:";
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 232);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 35);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(396, 232);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ok";
            this.okButton.TextColor = System.Drawing.Color.GreenYellow;
            // 
            // skillLabel
            // 
            // 
            // 
            // 
            this.skillLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.skillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.skillLabel.Location = new System.Drawing.Point(146, 56);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(36, 23);
            this.skillLabel.TabIndex = 8;
            this.skillLabel.Text = "Skill:";
            // 
            // skillComboBox
            // 
            this.skillComboBox.DisplayMember = "Text";
            this.skillComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skillComboBox.FormattingEnabled = true;
            this.skillComboBox.ItemHeight = 14;
            this.skillComboBox.Location = new System.Drawing.Point(188, 59);
            this.skillComboBox.Name = "skillComboBox";
            this.skillComboBox.Size = new System.Drawing.Size(219, 20);
            this.skillComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.skillComboBox.TabIndex = 9;
            // 
            // skillLevelLabel
            // 
            // 
            // 
            // 
            this.skillLevelLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.skillLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.skillLevelLabel.Location = new System.Drawing.Point(55, 105);
            this.skillLevelLabel.Name = "skillLevelLabel";
            this.skillLevelLabel.Size = new System.Drawing.Size(352, 23);
            this.skillLevelLabel.TabIndex = 10;
            this.skillLevelLabel.Text = "Current Skill Level:";
            // 
            // changeLabel
            // 
            // 
            // 
            // 
            this.changeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.changeLabel.Location = new System.Drawing.Point(81, 160);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(101, 23);
            this.changeLabel.TabIndex = 11;
            this.changeLabel.Text = "Set Skill Level:";
            // 
            // integerInput1
            // 
            // 
            // 
            // 
            this.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput1.Location = new System.Drawing.Point(188, 163);
            this.integerInput1.Name = "integerInput1";
            this.integerInput1.ShowUpDown = true;
            this.integerInput1.Size = new System.Drawing.Size(219, 20);
            this.integerInput1.TabIndex = 12;
            // 
            // CharacterSetSkillLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 279);
            this.Controls.Add(this.integerInput1);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.skillLevelLabel);
            this.Controls.Add(this.skillComboBox);
            this.Controls.Add(this.skillLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.characterLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 317);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 317);
            this.Name = "CharacterSetSkillLevel";
            this.Text = "Character Set Skill Level";
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX characterLabel;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.LabelX skillLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx skillComboBox;
        private DevComponents.DotNetBar.LabelX skillLevelLabel;
        private DevComponents.DotNetBar.LabelX changeLabel;
        private DevComponents.Editors.IntegerInput integerInput1;
    }
}