namespace TrinityCore_Manager_v3
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
            this.accountBanComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.banButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.refreshButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // accountAddBanLabel
            // 
            // 
            // 
            // 
            this.accountAddBanLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountAddBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.accountAddBanLabel.Location = new System.Drawing.Point(65, 75);
            this.accountAddBanLabel.Name = "accountAddBanLabel";
            this.accountAddBanLabel.Size = new System.Drawing.Size(66, 22);
            this.accountAddBanLabel.TabIndex = 0;
            this.accountAddBanLabel.Text = "Account:";
            // 
            // accountBanComboBox
            // 
            this.accountBanComboBox.DisplayMember = "Text";
            this.accountBanComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.accountBanComboBox.FormattingEnabled = true;
            this.accountBanComboBox.ItemHeight = 14;
            this.accountBanComboBox.Location = new System.Drawing.Point(137, 77);
            this.accountBanComboBox.Name = "accountBanComboBox";
            this.accountBanComboBox.Size = new System.Drawing.Size(189, 20);
            this.accountBanComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.accountBanComboBox.TabIndex = 1;
            // 
            // banButton
            // 
            this.banButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.banButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.banButton.Location = new System.Drawing.Point(304, 168);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(103, 33);
            this.banButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.banButton.TabIndex = 2;
            this.banButton.Text = "Ban!";
            this.banButton.TextColor = System.Drawing.Color.Tomato;
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(12, 168);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 33);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            // 
            // refreshButton
            // 
            this.refreshButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.refreshButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.refreshButton.Location = new System.Drawing.Point(186, 103);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh List";
            // 
            // AddAccountBan
            // 
            this.AcceptButton = this.banButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 213);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.accountBanComboBox);
            this.Controls.Add(this.accountAddBanLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccountBan";
            this.Text = "Add Account Ban";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX accountAddBanLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx accountBanComboBox;
        private DevComponents.DotNetBar.ButtonX banButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX refreshButton;
    }
}