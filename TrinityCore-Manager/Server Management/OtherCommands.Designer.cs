namespace TrinityCore_Manager
{
    partial class OtherCommands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherCommands));
            this.setMotdLabel = new DevComponents.DotNetBar.LabelX();
            this.motdTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.playerLimitLabel = new DevComponents.DotNetBar.LabelX();
            this.serverLimitIntegerInput = new DevComponents.Editors.IntegerInput();
            this.allowConnLabel = new DevComponents.DotNetBar.LabelX();
            this.switchButton = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.otherServerCommandsSuperTooltip = new DevComponents.DotNetBar.SuperTooltip();
            ((System.ComponentModel.ISupportInitialize)(this.serverLimitIntegerInput)).BeginInit();
            this.SuspendLayout();
            // 
            // setMotdLabel
            // 
            // 
            // 
            // 
            this.setMotdLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.setMotdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.setMotdLabel.Location = new System.Drawing.Point(12, 12);
            this.setMotdLabel.Name = "setMotdLabel";
            this.setMotdLabel.Size = new System.Drawing.Size(190, 23);
            this.setMotdLabel.TabIndex = 0;
            this.setMotdLabel.Text = "Server Message of the Day:";
            // 
            // motdTextBox
            // 
            this.motdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.motdTextBox.Border.Class = "TextBoxBorder";
            this.motdTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.motdTextBox.ForeColor = System.Drawing.Color.White;
            this.motdTextBox.Location = new System.Drawing.Point(12, 41);
            this.motdTextBox.Multiline = true;
            this.motdTextBox.Name = "motdTextBox";
            this.motdTextBox.Size = new System.Drawing.Size(756, 160);
            this.otherServerCommandsSuperTooltip.SetSuperTooltip(this.motdTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Show server Message of the day.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.motdTextBox.TabIndex = 1;
            // 
            // playerLimitLabel
            // 
            // 
            // 
            // 
            this.playerLimitLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.playerLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.playerLimitLabel.Location = new System.Drawing.Point(253, 207);
            this.playerLimitLabel.Name = "playerLimitLabel";
            this.playerLimitLabel.Size = new System.Drawing.Size(139, 23);
            this.playerLimitLabel.TabIndex = 2;
            this.playerLimitLabel.Text = "Server Player Limit:";
            // 
            // serverLimitIntegerInput
            // 
            // 
            // 
            // 
            this.serverLimitIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.serverLimitIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.serverLimitIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.serverLimitIntegerInput.Location = new System.Drawing.Point(398, 210);
            this.serverLimitIntegerInput.MinValue = 0;
            this.serverLimitIntegerInput.Name = "serverLimitIntegerInput";
            this.serverLimitIntegerInput.ShowUpDown = true;
            this.serverLimitIntegerInput.Size = new System.Drawing.Size(172, 20);
            this.otherServerCommandsSuperTooltip.SetSuperTooltip(this.serverLimitIntegerInput, new DevComponents.DotNetBar.SuperTooltipInfo("", "", resources.GetString("serverLimitIntegerInput.SuperTooltip"), null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.serverLimitIntegerInput.TabIndex = 3;
            // 
            // allowConnLabel
            // 
            // 
            // 
            // 
            this.allowConnLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.allowConnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.allowConnLabel.Location = new System.Drawing.Point(260, 245);
            this.allowConnLabel.Name = "allowConnLabel";
            this.allowConnLabel.Size = new System.Drawing.Size(132, 23);
            this.allowConnLabel.TabIndex = 4;
            this.allowConnLabel.Text = "Allow connections?";
            // 
            // switchButton
            // 
            // 
            // 
            // 
            this.switchButton.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton.Enabled = false;
            this.switchButton.Location = new System.Drawing.Point(398, 246);
            this.switchButton.Name = "switchButton";
            this.switchButton.OffText = "NO";
            this.switchButton.OffTextColor = System.Drawing.Color.Tomato;
            this.switchButton.OnText = "YES";
            this.switchButton.OnTextColor = System.Drawing.Color.Chartreuse;
            this.switchButton.Size = new System.Drawing.Size(66, 22);
            this.switchButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.otherServerCommandsSuperTooltip.SetSuperTooltip(this.switchButton, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Sets whether the world accepts new client connections.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.switchButton.TabIndex = 5;
            this.switchButton.Value = true;
            this.switchButton.ValueObject = "Y";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(670, 277);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(98, 39);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Submit";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 277);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 39);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // otherServerCommandsSuperTooltip
            // 
            this.otherServerCommandsSuperTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // OtherCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(776, 323);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.allowConnLabel);
            this.Controls.Add(this.serverLimitIntegerInput);
            this.Controls.Add(this.playerLimitLabel);
            this.Controls.Add(this.motdTextBox);
            this.Controls.Add(this.setMotdLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(796, 366);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(796, 366);
            this.Name = "OtherCommands";
            this.Text = "Other Server Commands";
            this.Load += new System.EventHandler(this.OtherCommands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serverLimitIntegerInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX setMotdLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX motdTextBox;
        private DevComponents.DotNetBar.LabelX playerLimitLabel;
        private DevComponents.Editors.IntegerInput serverLimitIntegerInput;
        private DevComponents.DotNetBar.LabelX allowConnLabel;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.SuperTooltip otherServerCommandsSuperTooltip;
    }
}