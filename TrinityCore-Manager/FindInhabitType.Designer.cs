namespace TrinityCore_Manager
{
    partial class FindInhabitType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindInhabitType));
            this.checkAllButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.trainerCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.questGiverCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.gossipCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // checkAllButton
            // 
            this.checkAllButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.checkAllButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.checkAllButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.checkAllButton.Location = new System.Drawing.Point(12, 506);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Size = new System.Drawing.Size(106, 35);
            this.checkAllButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkAllButton.TabIndex = 37;
            this.checkAllButton.Text = "Check All";
            this.checkAllButton.TextColor = System.Drawing.Color.Green;
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(437, 506);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 36;
            this.okButton.Text = "Ok";
            // 
            // trainerCheckBox
            // 
            // 
            // 
            // 
            this.trainerCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.trainerCheckBox.Location = new System.Drawing.Point(214, 251);
            this.trainerCheckBox.Name = "trainerCheckBox";
            this.trainerCheckBox.Size = new System.Drawing.Size(232, 23);
            this.trainerCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.trainerCheckBox.TabIndex = 41;
            this.trainerCheckBox.Text = "AIR";
            // 
            // questGiverCheckBox
            // 
            // 
            // 
            // 
            this.questGiverCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.questGiverCheckBox.Location = new System.Drawing.Point(214, 222);
            this.questGiverCheckBox.Name = "questGiverCheckBox";
            this.questGiverCheckBox.Size = new System.Drawing.Size(232, 23);
            this.questGiverCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.questGiverCheckBox.TabIndex = 40;
            this.questGiverCheckBox.Text = "WATER";
            // 
            // gossipCheckBox
            // 
            // 
            // 
            // 
            this.gossipCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gossipCheckBox.Checked = true;
            this.gossipCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gossipCheckBox.CheckValue = "Y";
            this.gossipCheckBox.Location = new System.Drawing.Point(214, 193);
            this.gossipCheckBox.Name = "gossipCheckBox";
            this.gossipCheckBox.Size = new System.Drawing.Size(232, 23);
            this.gossipCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gossipCheckBox.TabIndex = 39;
            this.gossipCheckBox.Text = "GROUND";
            // 
            // FindInhabitType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 553);
            this.Controls.Add(this.trainerCheckBox);
            this.Controls.Add(this.questGiverCheckBox);
            this.Controls.Add(this.gossipCheckBox);
            this.Controls.Add(this.checkAllButton);
            this.Controls.Add(this.okButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 591);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(571, 591);
            this.Name = "FindInhabitType";
            this.Text = "Find Inhabit_Type";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX checkAllButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX trainerCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX questGiverCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX gossipCheckBox;
    }
}