namespace TrinityCore_Manager
{
    partial class AddAccountBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountBan));
            this.accountAddBanLabel = new DevComponents.DotNetBar.LabelX();
            this.accListComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.banButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.banReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.banTimeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.accBanSuperTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.SuspendLayout();
            // 
            // accountAddBanLabel
            // 
            // 
            // 
            // 
            this.accountAddBanLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountAddBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.accountAddBanLabel.Location = new System.Drawing.Point(44, 27);
            this.accountAddBanLabel.Name = "accountAddBanLabel";
            this.accountAddBanLabel.Size = new System.Drawing.Size(66, 22);
            this.accountAddBanLabel.TabIndex = 0;
            this.accountAddBanLabel.Text = "Account:";
            // 
            // accListComboBox
            // 
            this.accListComboBox.DisplayMember = "Text";
            this.accListComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.accListComboBox.ForeColor = System.Drawing.Color.White;
            this.accListComboBox.FormattingEnabled = true;
            this.accListComboBox.ItemHeight = 14;
            this.accListComboBox.Location = new System.Drawing.Point(116, 29);
            this.accListComboBox.Name = "accListComboBox";
            this.accListComboBox.Size = new System.Drawing.Size(224, 20);
            this.accListComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.accListComboBox.TabIndex = 1;
            // 
            // banButton
            // 
            this.banButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.banButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.banButton.Location = new System.Drawing.Point(282, 150);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(103, 33);
            this.banButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.banButton.TabIndex = 2;
            this.banButton.Text = "Ban!";
            this.banButton.TextColor = System.Drawing.Color.Tomato;
            this.banButton.Click += new System.EventHandler(this.banButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(12, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 33);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.banReasonTextBox.Location = new System.Drawing.Point(116, 96);
            this.banReasonTextBox.Name = "banReasonTextBox";
            this.banReasonTextBox.Size = new System.Drawing.Size(224, 20);
            this.accBanSuperTooltip.SetSuperTooltip(this.banReasonTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Reason for banning this Account. It will get stored in the \'banreason\' column, in" +
            " the \'account_banned\' table.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.banReasonTextBox.TabIndex = 7;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(16, 91);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 26);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Ban Reason:";
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
            this.banTimeTextBox.Location = new System.Drawing.Point(116, 63);
            this.banTimeTextBox.Name = "banTimeTextBox";
            this.banTimeTextBox.Size = new System.Drawing.Size(224, 20);
            this.accBanSuperTooltip.SetSuperTooltip(this.banTimeTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Using a negative value (-1) mean it will be a permanent ban.\r\n\r\nFor a specified b" +
            "an time, use this format: #d#h#s\r\n\r\nExample: 4d20h30s - the ban will last for 4 " +
            "days 20 hours and 30 seconds.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.banTimeTextBox.TabIndex = 9;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX2.Location = new System.Drawing.Point(34, 58);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(76, 26);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Ban Time:";
            // 
            // accBanSuperTooltip
            // 
            this.accBanSuperTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // AddAccountBan
            // 
            this.AcceptButton = this.banButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 194);
            this.Controls.Add(this.banTimeTextBox);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.banReasonTextBox);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.accListComboBox);
            this.Controls.Add(this.accountAddBanLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 233);
            this.Name = "AddAccountBan";
            this.Text = "Add Account Ban";
            this.Load += new System.EventHandler(this.AddAccountBan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX accountAddBanLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx accListComboBox;
        private DevComponents.DotNetBar.ButtonX banButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.Controls.TextBoxX banReasonTextBox;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX banTimeTextBox;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.SuperTooltip accBanSuperTooltip;
    }
}