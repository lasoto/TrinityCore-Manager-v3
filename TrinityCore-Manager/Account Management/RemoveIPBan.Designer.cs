namespace TrinityCore_Manager
{
    partial class RemoveIPBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveIPBan));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.removeBanButton = new DevComponents.DotNetBar.ButtonX();
            this.ipAddressBanLabel = new DevComponents.DotNetBar.LabelX();
            this.ipAddressComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(12, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 33);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            // 
            // removeBanButton
            // 
            this.removeBanButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.removeBanButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.removeBanButton.Location = new System.Drawing.Point(300, 150);
            this.removeBanButton.Name = "removeBanButton";
            this.removeBanButton.Size = new System.Drawing.Size(85, 33);
            this.removeBanButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.removeBanButton.TabIndex = 6;
            this.removeBanButton.Text = "Remove";
            this.removeBanButton.TextColor = System.Drawing.Color.Chartreuse;
            this.removeBanButton.Click += new System.EventHandler(this.removeBanButton_Click);
            // 
            // ipAddressBanLabel
            // 
            // 
            // 
            // 
            this.ipAddressBanLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipAddressBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ipAddressBanLabel.Location = new System.Drawing.Point(59, 55);
            this.ipAddressBanLabel.Name = "ipAddressBanLabel";
            this.ipAddressBanLabel.Size = new System.Drawing.Size(84, 26);
            this.ipAddressBanLabel.TabIndex = 4;
            this.ipAddressBanLabel.Text = "IP Address:";
            // 
            // ipAddressComboBox
            // 
            this.ipAddressComboBox.DisplayMember = "Text";
            this.ipAddressComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ipAddressComboBox.FormattingEnabled = true;
            this.ipAddressComboBox.ItemHeight = 14;
            this.ipAddressComboBox.Location = new System.Drawing.Point(150, 59);
            this.ipAddressComboBox.Name = "ipAddressComboBox";
            this.ipAddressComboBox.Size = new System.Drawing.Size(171, 20);
            this.ipAddressComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipAddressComboBox.TabIndex = 8;
            // 
            // RemoveIPBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 190);
            this.Controls.Add(this.ipAddressComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeBanButton);
            this.Controls.Add(this.ipAddressBanLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 233);
            this.Name = "RemoveIPBan";
            this.Text = "Remove IP Ban";
            this.Load += new System.EventHandler(this.RemoveIPBan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX removeBanButton;
        private DevComponents.DotNetBar.LabelX ipAddressBanLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ipAddressComboBox;
    }
}