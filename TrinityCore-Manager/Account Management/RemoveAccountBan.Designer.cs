namespace TrinityCore_Manager
{
    partial class RemoveAccountBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveAccountBan));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.banButton = new DevComponents.DotNetBar.ButtonX();
            this.accountListComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.accountAddBanLabel = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(12, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 33);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            // 
            // banButton
            // 
            this.banButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.banButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.banButton.Location = new System.Drawing.Point(282, 150);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(103, 33);
            this.banButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.banButton.TabIndex = 7;
            this.banButton.Text = "Remove";
            this.banButton.TextColor = System.Drawing.Color.Chartreuse;
            // 
            // accountListComboBox
            // 
            this.accountListComboBox.DisplayMember = "Text";
            this.accountListComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.accountListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountListComboBox.ForeColor = System.Drawing.Color.White;
            this.accountListComboBox.FormattingEnabled = true;
            this.accountListComboBox.ItemHeight = 14;
            this.accountListComboBox.Location = new System.Drawing.Point(98, 71);
            this.accountListComboBox.Name = "accountListComboBox";
            this.accountListComboBox.Size = new System.Drawing.Size(189, 20);
            this.accountListComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.accountListComboBox.TabIndex = 6;
            // 
            // accountAddBanLabel
            // 
            // 
            // 
            // 
            this.accountAddBanLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountAddBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.accountAddBanLabel.Location = new System.Drawing.Point(129, 43);
            this.accountAddBanLabel.Name = "accountAddBanLabel";
            this.accountAddBanLabel.Size = new System.Drawing.Size(127, 22);
            this.accountAddBanLabel.TabIndex = 5;
            this.accountAddBanLabel.Text = "Banned Accounts:";
            // 
            // RemoveAccountBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 195);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.accountListComboBox);
            this.Controls.Add(this.accountAddBanLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 233);
            this.Name = "RemoveAccountBan";
            this.Text = "Remove Account Ban";
            this.Load += new System.EventHandler(this.RemoveAccountBan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX banButton;
        private DevComponents.DotNetBar.Controls.ComboBoxEx accountListComboBox;
        private DevComponents.DotNetBar.LabelX accountAddBanLabel;
    }
}