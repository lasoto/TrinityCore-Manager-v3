namespace TrinityCore_Manager
{
    partial class FindItemFlagsExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindItemFlagsExtra));
            this.checkAllButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.needRollDisabledCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.extendedCostCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.allianceCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.hordeCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.eitherTeamCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
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
            this.checkAllButton.TabIndex = 87;
            this.checkAllButton.Text = "Check All";
            this.checkAllButton.TextColor = System.Drawing.Color.Green;
            this.checkAllButton.Click += new System.EventHandler(this.checkAllButton_Click);
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(437, 506);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 86;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // needRollDisabledCheckBox
            // 
            // 
            // 
            // 
            this.needRollDisabledCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.needRollDisabledCheckBox.Location = new System.Drawing.Point(193, 297);
            this.needRollDisabledCheckBox.Name = "needRollDisabledCheckBox";
            this.needRollDisabledCheckBox.Size = new System.Drawing.Size(239, 23);
            this.needRollDisabledCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.needRollDisabledCheckBox.TabIndex = 92;
            this.needRollDisabledCheckBox.Text = "NEED ROLL FOR THIS ITEM IS DISABLED";
            // 
            // extendedCostCheckBox
            // 
            // 
            // 
            // 
            this.extendedCostCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.extendedCostCheckBox.Location = new System.Drawing.Point(193, 262);
            this.extendedCostCheckBox.Name = "extendedCostCheckBox";
            this.extendedCostCheckBox.Size = new System.Drawing.Size(266, 29);
            this.extendedCostCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.extendedCostCheckBox.TabIndex = 91;
            this.extendedCostCheckBox.Text = "<div align=\"center\">WHEN ITEM USES ExtendedCost IN npc_vendor<br/>GOLD IS ALSO RE" +
    "QUIRED</div>";
            // 
            // allianceCheckBox
            // 
            // 
            // 
            // 
            this.allianceCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.allianceCheckBox.Location = new System.Drawing.Point(193, 233);
            this.allianceCheckBox.Name = "allianceCheckBox";
            this.allianceCheckBox.Size = new System.Drawing.Size(133, 23);
            this.allianceCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.allianceCheckBox.TabIndex = 90;
            this.allianceCheckBox.Text = "ALLIANCE";
            // 
            // hordeCheckBox
            // 
            // 
            // 
            // 
            this.hordeCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hordeCheckBox.Location = new System.Drawing.Point(193, 204);
            this.hordeCheckBox.Name = "hordeCheckBox";
            this.hordeCheckBox.Size = new System.Drawing.Size(133, 23);
            this.hordeCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.hordeCheckBox.TabIndex = 89;
            this.hordeCheckBox.Text = "HORDE";
            // 
            // eitherTeamCheckBox
            // 
            // 
            // 
            // 
            this.eitherTeamCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.eitherTeamCheckBox.Location = new System.Drawing.Point(193, 175);
            this.eitherTeamCheckBox.Name = "eitherTeamCheckBox";
            this.eitherTeamCheckBox.Size = new System.Drawing.Size(133, 23);
            this.eitherTeamCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.eitherTeamCheckBox.TabIndex = 88;
            this.eitherTeamCheckBox.Text = "EITHER TEAM";
            // 
            // FindItemFlagsExtra
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 553);
            this.Controls.Add(this.needRollDisabledCheckBox);
            this.Controls.Add(this.extendedCostCheckBox);
            this.Controls.Add(this.allianceCheckBox);
            this.Controls.Add(this.hordeCheckBox);
            this.Controls.Add(this.eitherTeamCheckBox);
            this.Controls.Add(this.checkAllButton);
            this.Controls.Add(this.okButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 591);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(571, 591);
            this.Name = "FindItemFlagsExtra";
            this.Text = "FindItemFlagsExtra";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX checkAllButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX needRollDisabledCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX extendedCostCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX allianceCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX hordeCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX eitherTeamCheckBox;
    }
}