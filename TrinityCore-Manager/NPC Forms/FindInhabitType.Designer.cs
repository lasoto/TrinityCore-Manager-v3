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
            this.flyingCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.waterCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groundCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // checkAllButton
            // 
            this.checkAllButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.checkAllButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.checkAllButton.Location = new System.Drawing.Point(12, 99);
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
            this.okButton.Location = new System.Drawing.Point(134, 99);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 36;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // flyingCheckBox
            // 
            // 
            // 
            // 
            this.flyingCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.flyingCheckBox.Location = new System.Drawing.Point(86, 70);
            this.flyingCheckBox.Name = "flyingCheckBox";
            this.flyingCheckBox.Size = new System.Drawing.Size(62, 23);
            this.flyingCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.flyingCheckBox.TabIndex = 41;
            this.flyingCheckBox.Text = "FLYING";
            // 
            // waterCheckBox
            // 
            // 
            // 
            // 
            this.waterCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.waterCheckBox.Location = new System.Drawing.Point(86, 41);
            this.waterCheckBox.Name = "waterCheckBox";
            this.waterCheckBox.Size = new System.Drawing.Size(77, 23);
            this.waterCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.waterCheckBox.TabIndex = 40;
            this.waterCheckBox.Text = "WATER";
            // 
            // groundCheckBox
            // 
            // 
            // 
            // 
            this.groundCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groundCheckBox.Location = new System.Drawing.Point(86, 12);
            this.groundCheckBox.Name = "groundCheckBox";
            this.groundCheckBox.Size = new System.Drawing.Size(77, 23);
            this.groundCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groundCheckBox.TabIndex = 39;
            this.groundCheckBox.Text = "GROUND";
            // 
            // FindInhabitType
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 141);
            this.Controls.Add(this.flyingCheckBox);
            this.Controls.Add(this.waterCheckBox);
            this.Controls.Add(this.groundCheckBox);
            this.Controls.Add(this.checkAllButton);
            this.Controls.Add(this.okButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindInhabitType";
            this.Text = "Find Inhabit_Type";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX checkAllButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX flyingCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX waterCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX groundCheckBox;
    }
}