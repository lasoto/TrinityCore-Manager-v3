namespace TrinityCore_Manager
{
    partial class CharacterSetLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSetLevel));
            this.characterLabel = new DevComponents.DotNetBar.LabelX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.levelLabel = new DevComponents.DotNetBar.LabelX();
            this.levelIntegerInput = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.charLabel = new DevComponents.DotNetBar.LabelX();
            this.currLevelLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.levelIntegerInput)).BeginInit();
            this.SuspendLayout();
            // 
            // characterLabel
            // 
            // 
            // 
            // 
            this.characterLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.characterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.characterLabel.Location = new System.Drawing.Point(131, 46);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(72, 23);
            this.characterLabel.TabIndex = 0;
            this.characterLabel.Text = "Character:";
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
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(384, 216);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.TextColor = System.Drawing.Color.GreenYellow;
            // 
            // levelLabel
            // 
            // 
            // 
            // 
            this.levelLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.levelLabel.Location = new System.Drawing.Point(83, 135);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(120, 23);
            this.levelLabel.TabIndex = 6;
            this.levelLabel.Text = "Change Level To:";
            // 
            // levelIntegerInput
            // 
            // 
            // 
            // 
            this.levelIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.levelIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.levelIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.levelIntegerInput.Location = new System.Drawing.Point(209, 138);
            this.levelIntegerInput.MaxValue = 255;
            this.levelIntegerInput.MinValue = 0;
            this.levelIntegerInput.Name = "levelIntegerInput";
            this.levelIntegerInput.ShowUpDown = true;
            this.levelIntegerInput.Size = new System.Drawing.Size(89, 20);
            this.levelIntegerInput.TabIndex = 7;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(107, 91);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Current Level:";
            // 
            // charLabel
            // 
            // 
            // 
            // 
            this.charLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.charLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.charLabel.Location = new System.Drawing.Point(209, 46);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(230, 23);
            this.charLabel.TabIndex = 9;
            // 
            // currLevelLabel
            // 
            // 
            // 
            // 
            this.currLevelLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.currLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.currLevelLabel.Location = new System.Drawing.Point(209, 91);
            this.currLevelLabel.Name = "currLevelLabel";
            this.currLevelLabel.Size = new System.Drawing.Size(89, 23);
            this.currLevelLabel.TabIndex = 10;
            // 
            // CharacterSetLevel
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(502, 263);
            this.Controls.Add(this.currLevelLabel);
            this.Controls.Add(this.charLabel);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.levelIntegerInput);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.characterLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(518, 301);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(518, 301);
            this.Name = "CharacterSetLevel";
            this.Text = "Character Set Level";
            ((System.ComponentModel.ISupportInitialize)(this.levelIntegerInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX characterLabel;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.LabelX levelLabel;
        private DevComponents.Editors.IntegerInput levelIntegerInput;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX charLabel;
        private DevComponents.DotNetBar.LabelX currLevelLabel;

    }
}