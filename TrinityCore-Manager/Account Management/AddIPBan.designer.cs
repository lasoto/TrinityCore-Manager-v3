namespace TrinityCore_Manager
{
    partial class AddIPBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIPBan));
            this.ipAddressBanLabel = new DevComponents.DotNetBar.LabelX();
            this.ipAddressBanInput = new DevComponents.Editors.IpAddressInput();
            this.banButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.banReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.banTimeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ipBanSuperTooltip = new DevComponents.DotNetBar.SuperTooltip();
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressBanInput)).BeginInit();
            this.SuspendLayout();
            // 
            // ipAddressBanLabel
            // 
            // 
            // 
            // 
            this.ipAddressBanLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipAddressBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ipAddressBanLabel.Location = new System.Drawing.Point(43, 16);
            this.ipAddressBanLabel.Name = "ipAddressBanLabel";
            this.ipAddressBanLabel.Size = new System.Drawing.Size(84, 26);
            this.ipAddressBanLabel.TabIndex = 0;
            this.ipAddressBanLabel.Text = "IP Address:";
            // 
            // ipAddressBanInput
            // 
            this.ipAddressBanInput.AutoOverwrite = true;
            // 
            // 
            // 
            this.ipAddressBanInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ipAddressBanInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipAddressBanInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ipAddressBanInput.ButtonFreeText.Visible = true;
            this.ipAddressBanInput.Location = new System.Drawing.Point(133, 22);
            this.ipAddressBanInput.Name = "ipAddressBanInput";
            this.ipAddressBanInput.Size = new System.Drawing.Size(195, 20);
            this.ipAddressBanInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipAddressBanInput.TabIndex = 1;
            // 
            // banButton
            // 
            this.banButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.banButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.banButton.Location = new System.Drawing.Point(300, 150);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(85, 33);
            this.banButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.banButton.TabIndex = 2;
            this.banButton.Text = "Ban!";
            this.banButton.TextColor = System.Drawing.Color.Tomato;
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(12, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 33);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(32, 95);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 26);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Ban Reason:";
            // 
            // banReasonTextBox
            // 
            this.banReasonTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.banReasonTextBox.Border.Class = "TextBoxBorder";
            this.banReasonTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.banReasonTextBox.ForeColor = System.Drawing.Color.White;
            this.banReasonTextBox.Location = new System.Drawing.Point(133, 100);
            this.banReasonTextBox.Name = "banReasonTextBox";
            this.banReasonTextBox.Size = new System.Drawing.Size(195, 20);
            this.ipBanSuperTooltip.SetSuperTooltip(this.banReasonTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Reason for banning this Ip. It will get stored in the \'banreason\' column, in the " +
            "\'ip_banned\' table.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.banReasonTextBox.TabIndex = 5;
            // 
            // banTimeTextBox
            // 
            this.banTimeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.banTimeTextBox.Border.Class = "TextBoxBorder";
            this.banTimeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.banTimeTextBox.ForeColor = System.Drawing.Color.White;
            this.banTimeTextBox.Location = new System.Drawing.Point(133, 62);
            this.banTimeTextBox.Name = "banTimeTextBox";
            this.banTimeTextBox.Size = new System.Drawing.Size(195, 20);
            this.ipBanSuperTooltip.SetSuperTooltip(this.banTimeTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Using a negative value (-1) mean it will be a permanent ban.\r\n\r\nFor a specified b" +
            "an time, use this format: #d#h#s\r\n\r\nExample: 4d20h30s - the ban will last for 4 " +
            "days 20 hours and 30 seconds.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.banTimeTextBox.TabIndex = 12;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX2.Location = new System.Drawing.Point(50, 57);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(71, 26);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Ban Time:";
            // 
            // ipBanSuperTooltip
            // 
            this.ipBanSuperTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // AddIPBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 195);
            this.Controls.Add(this.banTimeTextBox);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.banReasonTextBox);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.ipAddressBanInput);
            this.Controls.Add(this.ipAddressBanLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 233);
            this.Name = "AddIPBan";
            this.Text = "Add IP Ban";
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressBanInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX ipAddressBanLabel;
        private DevComponents.Editors.IpAddressInput ipAddressBanInput;
        private DevComponents.DotNetBar.ButtonX banButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX banReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX banTimeTextBox;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.SuperTooltip ipBanSuperTooltip;
    }
}