namespace TrinityCore_Manager.Item_Forms
{
    partial class FindItemFlagsCustom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindItemFlagsCustom));
            this.checkAllButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.followLootRulesCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ignoreQuestStatusCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.durationRealTimeCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // checkAllButton
            // 
            this.checkAllButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.checkAllButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.checkAllButton.Location = new System.Drawing.Point(12, 506);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Size = new System.Drawing.Size(106, 35);
            this.checkAllButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkAllButton.TabIndex = 39;
            this.checkAllButton.Text = "Check All";
            this.checkAllButton.TextColor = System.Drawing.Color.Green;
            this.checkAllButton.Click += new System.EventHandler(this.checkAllButton_Click);
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(437, 506);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 38;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // followLootRulesCheckBox
            // 
            // 
            // 
            // 
            this.followLootRulesCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.followLootRulesCheckBox.Location = new System.Drawing.Point(200, 268);
            this.followLootRulesCheckBox.Name = "followLootRulesCheckBox";
            this.followLootRulesCheckBox.Size = new System.Drawing.Size(164, 23);
            this.followLootRulesCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.followLootRulesCheckBox.TabIndex = 42;
            this.followLootRulesCheckBox.Text = "FOLLOW_LOOT_RULES";
            // 
            // ignoreQuestStatusCheckBox
            // 
            // 
            // 
            // 
            this.ignoreQuestStatusCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ignoreQuestStatusCheckBox.Location = new System.Drawing.Point(200, 239);
            this.ignoreQuestStatusCheckBox.Name = "ignoreQuestStatusCheckBox";
            this.ignoreQuestStatusCheckBox.Size = new System.Drawing.Size(164, 23);
            this.ignoreQuestStatusCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ignoreQuestStatusCheckBox.TabIndex = 41;
            this.ignoreQuestStatusCheckBox.Text = "IGNORE_QUEST_STATUS";
            // 
            // durationRealTimeCheckBox
            // 
            // 
            // 
            // 
            this.durationRealTimeCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.durationRealTimeCheckBox.Location = new System.Drawing.Point(200, 210);
            this.durationRealTimeCheckBox.Name = "durationRealTimeCheckBox";
            this.durationRealTimeCheckBox.Size = new System.Drawing.Size(164, 23);
            this.durationRealTimeCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.durationRealTimeCheckBox.TabIndex = 40;
            this.durationRealTimeCheckBox.Text = "DURATION_REAL_TIME";
            // 
            // FindItemFlagsCustom
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 549);
            this.Controls.Add(this.followLootRulesCheckBox);
            this.Controls.Add(this.ignoreQuestStatusCheckBox);
            this.Controls.Add(this.durationRealTimeCheckBox);
            this.Controls.Add(this.checkAllButton);
            this.Controls.Add(this.okButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 591);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(571, 591);
            this.Name = "FindItemFlagsCustom";
            this.Text = "Find Item Flags Custom";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindItemFlagsCustom_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX checkAllButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX followLootRulesCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX ignoreQuestStatusCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX durationRealTimeCheckBox;
    }
}