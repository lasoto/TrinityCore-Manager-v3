namespace TrinityCore_Manager
{
    partial class FindDynamicFlags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindDynamicFlags));
            this.checkAllButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.tappedByAllThreatListCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.referAFriendCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.deadCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.specialInfoCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tappedByPlayerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tappedCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.trackUnitCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lootableCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.noneCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.dynamicFlagsSuperTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.SuspendLayout();
            // 
            // checkAllButton
            // 
            this.checkAllButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.checkAllButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.checkAllButton.Location = new System.Drawing.Point(12, 157);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Size = new System.Drawing.Size(106, 35);
            this.checkAllButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkAllButton.TabIndex = 37;
            this.checkAllButton.Text = "Check All";
            this.checkAllButton.TextColor = System.Drawing.Color.Green;
            this.checkAllButton.Click += new System.EventHandler(this.checkAllButton_Click);
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(257, 157);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 36;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tappedByAllThreatListCheckBox
            // 
            // 
            // 
            // 
            this.tappedByAllThreatListCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tappedByAllThreatListCheckBox.Location = new System.Drawing.Point(166, 99);
            this.tappedByAllThreatListCheckBox.Name = "tappedByAllThreatListCheckBox";
            this.tappedByAllThreatListCheckBox.Size = new System.Drawing.Size(192, 23);
            this.tappedByAllThreatListCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dynamicFlagsSuperTooltip.SetSuperTooltip(this.tappedByAllThreatListCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Lua_UnitIsTappedByAllThreatList", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.tappedByAllThreatListCheckBox.TabIndex = 46;
            this.tappedByAllThreatListCheckBox.Text = "TAPPED_BY_ALL_THREAT_LIST";
            // 
            // referAFriendCheckBox
            // 
            // 
            // 
            // 
            this.referAFriendCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.referAFriendCheckBox.Location = new System.Drawing.Point(166, 70);
            this.referAFriendCheckBox.Name = "referAFriendCheckBox";
            this.referAFriendCheckBox.Size = new System.Drawing.Size(192, 23);
            this.referAFriendCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.referAFriendCheckBox.TabIndex = 45;
            this.referAFriendCheckBox.Text = "REFER_A_FRIEND";
            // 
            // deadCheckBox
            // 
            // 
            // 
            // 
            this.deadCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.deadCheckBox.Location = new System.Drawing.Point(166, 41);
            this.deadCheckBox.Name = "deadCheckBox";
            this.deadCheckBox.Size = new System.Drawing.Size(192, 23);
            this.deadCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dynamicFlagsSuperTooltip.SetSuperTooltip(this.deadCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Makes the creature appear dead (this DOES NOT make the creatures name grey or not" +
            " attack players.)\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.deadCheckBox.TabIndex = 44;
            this.deadCheckBox.Text = "DEAD";
            // 
            // specialInfoCheckBox
            // 
            // 
            // 
            // 
            this.specialInfoCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.specialInfoCheckBox.Location = new System.Drawing.Point(166, 12);
            this.specialInfoCheckBox.Name = "specialInfoCheckBox";
            this.specialInfoCheckBox.Size = new System.Drawing.Size(192, 23);
            this.specialInfoCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.specialInfoCheckBox.TabIndex = 43;
            this.specialInfoCheckBox.Text = "SPECIAL_INFO";
            // 
            // tappedByPlayerCheckBox
            // 
            // 
            // 
            // 
            this.tappedByPlayerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tappedByPlayerCheckBox.Location = new System.Drawing.Point(12, 128);
            this.tappedByPlayerCheckBox.Name = "tappedByPlayerCheckBox";
            this.tappedByPlayerCheckBox.Size = new System.Drawing.Size(135, 23);
            this.tappedByPlayerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dynamicFlagsSuperTooltip.SetSuperTooltip(this.tappedByPlayerCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Lua_UnitIsTappedByPlayer usually used by (PCV\'s) Player Controlled Vehicle\'s\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.tappedByPlayerCheckBox.TabIndex = 42;
            this.tappedByPlayerCheckBox.Text = "TAPPED_BY_PLAYER";
            // 
            // tappedCheckBox
            // 
            // 
            // 
            // 
            this.tappedCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tappedCheckBox.Location = new System.Drawing.Point(12, 99);
            this.tappedCheckBox.Name = "tappedCheckBox";
            this.tappedCheckBox.Size = new System.Drawing.Size(135, 23);
            this.tappedCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dynamicFlagsSuperTooltip.SetSuperTooltip(this.tappedCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Makes creatures name appear grey (Lua_UnitIsTapped)\r\n", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.tappedCheckBox.TabIndex = 41;
            this.tappedCheckBox.Text = "TAPPED";
            // 
            // trackUnitCheckBox
            // 
            // 
            // 
            // 
            this.trackUnitCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.trackUnitCheckBox.Location = new System.Drawing.Point(12, 70);
            this.trackUnitCheckBox.Name = "trackUnitCheckBox";
            this.trackUnitCheckBox.Size = new System.Drawing.Size(135, 23);
            this.trackUnitCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dynamicFlagsSuperTooltip.SetSuperTooltip(this.trackUnitCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Creature\'s location will be seen as a small dot in the minimap", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.trackUnitCheckBox.TabIndex = 40;
            this.trackUnitCheckBox.Text = "TRACK_UNIT";
            // 
            // lootableCheckBox
            // 
            // 
            // 
            // 
            this.lootableCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lootableCheckBox.Location = new System.Drawing.Point(12, 41);
            this.lootableCheckBox.Name = "lootableCheckBox";
            this.lootableCheckBox.Size = new System.Drawing.Size(135, 23);
            this.lootableCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lootableCheckBox.TabIndex = 39;
            this.lootableCheckBox.Text = "LOOTABLE";
            // 
            // noneCheckBox
            // 
            // 
            // 
            // 
            this.noneCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.noneCheckBox.Location = new System.Drawing.Point(12, 12);
            this.noneCheckBox.Name = "noneCheckBox";
            this.noneCheckBox.Size = new System.Drawing.Size(135, 23);
            this.noneCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dynamicFlagsSuperTooltip.SetSuperTooltip(this.noneCheckBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.noneCheckBox.TabIndex = 38;
            this.noneCheckBox.Text = "NONE";
            // 
            // dynamicFlagsSuperTooltip
            // 
            this.dynamicFlagsSuperTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // FindDynamicFlags
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 204);
            this.Controls.Add(this.tappedByAllThreatListCheckBox);
            this.Controls.Add(this.referAFriendCheckBox);
            this.Controls.Add(this.deadCheckBox);
            this.Controls.Add(this.specialInfoCheckBox);
            this.Controls.Add(this.tappedByPlayerCheckBox);
            this.Controls.Add(this.tappedCheckBox);
            this.Controls.Add(this.trackUnitCheckBox);
            this.Controls.Add(this.lootableCheckBox);
            this.Controls.Add(this.noneCheckBox);
            this.Controls.Add(this.checkAllButton);
            this.Controls.Add(this.okButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindDynamicFlags";
            this.Text = "Find DynamicFlags";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX checkAllButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX tappedByAllThreatListCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX referAFriendCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX deadCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX specialInfoCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX tappedByPlayerCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX tappedCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX trackUnitCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX lootableCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX noneCheckBox;
        private DevComponents.DotNetBar.SuperTooltip dynamicFlagsSuperTooltip;
    }
}