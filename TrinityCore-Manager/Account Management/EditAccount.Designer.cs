namespace TrinityCore_Manager
{
    partial class EditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccount));
            this.accountPermissionLabel = new DevComponents.DotNetBar.LabelX();
            this.accountUsernameLabel = new DevComponents.DotNetBar.LabelX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.accLevelComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.accLvl0ComboItem = new DevComponents.Editors.ComboItem();
            this.accLvl1ComboItem = new DevComponents.Editors.ComboItem();
            this.accLvl2ComboItem = new DevComponents.Editors.ComboItem();
            this.accLvl4ComboItem = new DevComponents.Editors.ComboItem();
            this.usernameComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.switchButton = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.accAddonComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.vanillaComboItem = new DevComponents.Editors.ComboItem();
            this.tbcComboItem = new DevComponents.Editors.ComboItem();
            this.wotlkComboItem = new DevComponents.Editors.ComboItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.passTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.editAccountSuperTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.accLvl3ComboItem = new DevComponents.Editors.ComboItem();
            this.SuspendLayout();
            // 
            // accountPermissionLabel
            // 
            // 
            // 
            // 
            this.accountPermissionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountPermissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.accountPermissionLabel.Location = new System.Drawing.Point(21, 80);
            this.accountPermissionLabel.Name = "accountPermissionLabel";
            this.accountPermissionLabel.Size = new System.Drawing.Size(181, 26);
            this.accountPermissionLabel.TabIndex = 14;
            this.accountPermissionLabel.Text = "Account Permission Level:";
            // 
            // accountUsernameLabel
            // 
            // 
            // 
            // 
            this.accountUsernameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.accountUsernameLabel.Location = new System.Drawing.Point(65, 16);
            this.accountUsernameLabel.Name = "accountUsernameLabel";
            this.accountUsernameLabel.Size = new System.Drawing.Size(137, 26);
            this.accountUsernameLabel.TabIndex = 12;
            this.accountUsernameLabel.Text = "Account Username:";
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
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(384, 216);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 10;
            this.okButton.Text = "Ok";
            this.okButton.TextColor = System.Drawing.Color.GreenYellow;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // accLevelComboBox
            // 
            this.accLevelComboBox.DisplayMember = "Text";
            this.accLevelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.accLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accLevelComboBox.ForeColor = System.Drawing.Color.White;
            this.accLevelComboBox.FormattingEnabled = true;
            this.accLevelComboBox.ItemHeight = 14;
            this.accLevelComboBox.Items.AddRange(new object[] {
            this.accLvl0ComboItem,
            this.accLvl1ComboItem,
            this.accLvl2ComboItem,
            this.accLvl3ComboItem,
            this.accLvl4ComboItem});
            this.accLevelComboBox.Location = new System.Drawing.Point(208, 86);
            this.accLevelComboBox.Name = "accLevelComboBox";
            this.accLevelComboBox.Size = new System.Drawing.Size(216, 20);
            this.accLevelComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.accLevelComboBox.TabIndex = 17;
            // 
            // accLvl0ComboItem
            // 
            this.accLvl0ComboItem.Text = "Player";
            // 
            // accLvl1ComboItem
            // 
            this.accLvl1ComboItem.Text = "Moderator";
            // 
            // accLvl2ComboItem
            // 
            this.accLvl2ComboItem.Text = "Game Master";
            // 
            // accLvl4ComboItem
            // 
            this.accLvl4ComboItem.Text = "Administrator";
            // 
            // usernameComboBox
            // 
            this.usernameComboBox.DisplayMember = "Text";
            this.usernameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.usernameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usernameComboBox.ForeColor = System.Drawing.Color.White;
            this.usernameComboBox.FormattingEnabled = true;
            this.usernameComboBox.ItemHeight = 14;
            this.usernameComboBox.Location = new System.Drawing.Point(208, 22);
            this.usernameComboBox.Name = "usernameComboBox";
            this.usernameComboBox.Size = new System.Drawing.Size(216, 20);
            this.usernameComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.usernameComboBox.TabIndex = 19;
            this.usernameComboBox.SelectedIndexChanged += new System.EventHandler(this.usernameComboBox_SelectedIndexChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(99, 149);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(103, 26);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Lock Account:";
            // 
            // switchButton
            // 
            // 
            // 
            // 
            this.switchButton.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton.Location = new System.Drawing.Point(267, 153);
            this.switchButton.Name = "switchButton";
            this.switchButton.OffText = "NO";
            this.switchButton.OffTextColor = System.Drawing.Color.Tomato;
            this.switchButton.OnText = "YES";
            this.switchButton.OnTextColor = System.Drawing.Color.Chartreuse;
            this.switchButton.Size = new System.Drawing.Size(66, 22);
            this.switchButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.editAccountSuperTooltip.SetSuperTooltip(this.switchButton, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Allow login only from currently used IP.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.switchButton.TabIndex = 21;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX2.Location = new System.Drawing.Point(90, 112);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(112, 26);
            this.labelX2.TabIndex = 22;
            this.labelX2.Text = "Account Addon:";
            // 
            // accAddonComboBox
            // 
            this.accAddonComboBox.DisplayMember = "Text";
            this.accAddonComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.accAddonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accAddonComboBox.ForeColor = System.Drawing.Color.White;
            this.accAddonComboBox.FormattingEnabled = true;
            this.accAddonComboBox.ItemHeight = 14;
            this.accAddonComboBox.Items.AddRange(new object[] {
            this.vanillaComboItem,
            this.tbcComboItem,
            this.wotlkComboItem});
            this.accAddonComboBox.Location = new System.Drawing.Point(208, 118);
            this.accAddonComboBox.Name = "accAddonComboBox";
            this.accAddonComboBox.Size = new System.Drawing.Size(216, 20);
            this.accAddonComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.accAddonComboBox.TabIndex = 23;
            // 
            // vanillaComboItem
            // 
            this.vanillaComboItem.Text = "VANILLA (ORIGINAL)";
            // 
            // tbcComboItem
            // 
            this.tbcComboItem.Text = "TBC";
            // 
            // wotlkComboItem
            // 
            this.wotlkComboItem.Text = "WOTLK";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX3.Location = new System.Drawing.Point(68, 48);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(134, 26);
            this.labelX3.TabIndex = 24;
            this.labelX3.Text = "Account Password:";
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.passTextBox.Border.Class = "TextBoxBorder";
            this.passTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.passTextBox.ForeColor = System.Drawing.Color.White;
            this.passTextBox.Location = new System.Drawing.Point(208, 53);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(216, 20);
            this.passTextBox.TabIndex = 25;
            // 
            // editAccountSuperTooltip
            // 
            this.editAccountSuperTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // accLvl3ComboItem
            // 
            this.accLvl3ComboItem.Text = "Head Game Master";
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 259);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.accAddonComboBox);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.usernameComboBox);
            this.Controls.Add(this.accLevelComboBox);
            this.Controls.Add(this.accountPermissionLabel);
            this.Controls.Add(this.accountUsernameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(518, 301);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(518, 301);
            this.Name = "EditAccount";
            this.Text = "Edit Account";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX accountPermissionLabel;
        private DevComponents.DotNetBar.LabelX accountUsernameLabel;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.ComboBoxEx accLevelComboBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx usernameComboBox;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton;
        private DevComponents.Editors.ComboItem accLvl0ComboItem;
        private DevComponents.Editors.ComboItem accLvl1ComboItem;
        private DevComponents.Editors.ComboItem accLvl2ComboItem;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx accAddonComboBox;
        private DevComponents.Editors.ComboItem vanillaComboItem;
        private DevComponents.Editors.ComboItem tbcComboItem;
        private DevComponents.Editors.ComboItem wotlkComboItem;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX passTextBox;
        private DevComponents.DotNetBar.SuperTooltip editAccountSuperTooltip;
        private DevComponents.Editors.ComboItem accLvl4ComboItem;
        private DevComponents.Editors.ComboItem accLvl3ComboItem;
    }
}