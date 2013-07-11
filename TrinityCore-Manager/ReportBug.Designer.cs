namespace TrinityCore_Manager
{
    partial class ReportBug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBug));
            this.reportBugSuperTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.useUserSMTPCheckbox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.enableSSLCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.passwordTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.smtpTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.sendButton = new DevComponents.DotNetBar.ButtonX();
            this.messageTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.subjectTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.emailTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // reportBugSuperTooltip
            // 
            this.reportBugSuperTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // useUserSMTPCheckbox
            // 
            // 
            // 
            // 
            this.useUserSMTPCheckbox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.useUserSMTPCheckbox.Checked = true;
            this.useUserSMTPCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useUserSMTPCheckbox.CheckValue = "Y";
            this.useUserSMTPCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.useUserSMTPCheckbox.Location = new System.Drawing.Point(288, 175);
            this.useUserSMTPCheckbox.Name = "useUserSMTPCheckbox";
            this.useUserSMTPCheckbox.Size = new System.Drawing.Size(134, 23);
            this.useUserSMTPCheckbox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.useUserSMTPCheckbox.TabIndex = 6;
            this.useUserSMTPCheckbox.Text = "Use Your SMTP Server";
            this.useUserSMTPCheckbox.CheckedChanged += new System.EventHandler(this.useUserSMTPCheckbox_CheckedChanged);
            // 
            // enableSSLCheckBox
            // 
            // 
            // 
            // 
            this.enableSSLCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.enableSSLCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.enableSSLCheckBox.Location = new System.Drawing.Point(507, 135);
            this.enableSSLCheckBox.Name = "enableSSLCheckBox";
            this.enableSSLCheckBox.Size = new System.Drawing.Size(111, 23);
            this.enableSSLCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.reportBugSuperTooltip.SetSuperTooltip(this.enableSSLCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", resources.GetString("enableSSLCheckBox.SuperTooltip"), null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.enableSSLCheckBox.TabIndex = 5;
            this.enableSSLCheckBox.Text = "Enable SSL?";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.passwordTextBox.Border.Class = "TextBoxBorder";
            this.passwordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(231, 54);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(270, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX6.Location = new System.Drawing.Point(146, 51);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(79, 23);
            this.labelX6.TabIndex = 14;
            this.labelX6.Text = "Password";
            // 
            // smtpTextBox
            // 
            this.smtpTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.smtpTextBox.Border.Class = "TextBoxBorder";
            this.smtpTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.smtpTextBox.ForeColor = System.Drawing.Color.White;
            this.smtpTextBox.Location = new System.Drawing.Point(231, 137);
            this.smtpTextBox.Name = "smtpTextBox";
            this.smtpTextBox.Size = new System.Drawing.Size(270, 20);
            this.reportBugSuperTooltip.SetSuperTooltip(this.smtpTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", resources.GetString("smtpTextBox.SuperTooltip"), null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.smtpTextBox.TabIndex = 4;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX4.Location = new System.Drawing.Point(127, 134);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(98, 23);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "SMTP Server";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(12, 575);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(101, 35);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 9;
            this.buttonX2.Text = "Cancel";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // sendButton
            // 
            this.sendButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.sendButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.sendButton.Location = new System.Drawing.Point(585, 575);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(101, 35);
            this.sendButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Send";
            this.sendButton.TextColor = System.Drawing.Color.Chartreuse;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.AllowDrop = true;
            this.messageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.messageTextBox.Border.Class = "TextBoxBorder";
            this.messageTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.messageTextBox.ForeColor = System.Drawing.Color.White;
            this.messageTextBox.Location = new System.Drawing.Point(12, 224);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(674, 346);
            this.messageTextBox.TabIndex = 7;
            this.messageTextBox.WatermarkColor = System.Drawing.Color.DimGray;
            this.messageTextBox.WatermarkText = "If you have any crash or error logs please copy/paste them in here along with you" +
    "r message.\r\n\r\nThis software <u>DOES NOT</u> store any information you will enter" +
    " here. It is perfectly safe to use.";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX3.Location = new System.Drawing.Point(12, 195);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(68, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Message";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.subjectTextBox.Border.Class = "TextBoxBorder";
            this.subjectTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.subjectTextBox.ForeColor = System.Drawing.Color.White;
            this.subjectTextBox.Location = new System.Drawing.Point(231, 95);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(270, 20);
            this.subjectTextBox.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX2.Location = new System.Drawing.Point(169, 92);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Subject";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(144, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(81, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Your e-mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.emailTextBox.Border.Class = "TextBoxBorder";
            this.emailTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.emailTextBox.ForeColor = System.Drawing.Color.White;
            this.emailTextBox.Location = new System.Drawing.Point(231, 12);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(270, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // ReportBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 615);
            this.Controls.Add(this.useUserSMTPCheckbox);
            this.Controls.Add(this.enableSSLCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.smtpTextBox);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.emailTextBox);
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report a Bug";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX emailTextBox;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX messageTextBox;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX subjectTextBox;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX sendButton;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.TextBoxX smtpTextBox;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX passwordTextBox;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.SuperTooltip reportBugSuperTooltip;
        private DevComponents.DotNetBar.Controls.CheckBoxX enableSSLCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX useUserSMTPCheckbox;
    }
}