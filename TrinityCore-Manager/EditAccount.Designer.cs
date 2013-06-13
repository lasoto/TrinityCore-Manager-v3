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
            this.accountPermissionLevelComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.accountUsernameComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // accountPermissionLabel
            // 
            // 
            // 
            // 
            this.accountPermissionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountPermissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.accountPermissionLabel.Location = new System.Drawing.Point(7, 136);
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
            this.accountUsernameLabel.Location = new System.Drawing.Point(49, 70);
            this.accountUsernameLabel.Name = "accountUsernameLabel";
            this.accountUsernameLabel.Size = new System.Drawing.Size(139, 26);
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
            // 
            // accountPermissionLevelComboBox
            // 
            this.accountPermissionLevelComboBox.DisplayMember = "Text";
            this.accountPermissionLevelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.accountPermissionLevelComboBox.FormattingEnabled = true;
            this.accountPermissionLevelComboBox.ItemHeight = 14;
            this.accountPermissionLevelComboBox.Location = new System.Drawing.Point(194, 142);
            this.accountPermissionLevelComboBox.Name = "accountPermissionLevelComboBox";
            this.accountPermissionLevelComboBox.Size = new System.Drawing.Size(216, 20);
            this.accountPermissionLevelComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.accountPermissionLevelComboBox.TabIndex = 17;
            // 
            // accountUsernameComboBox
            // 
            this.accountUsernameComboBox.DisplayMember = "Text";
            this.accountUsernameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.accountUsernameComboBox.FormattingEnabled = true;
            this.accountUsernameComboBox.ItemHeight = 14;
            this.accountUsernameComboBox.Location = new System.Drawing.Point(194, 76);
            this.accountUsernameComboBox.Name = "accountUsernameComboBox";
            this.accountUsernameComboBox.Size = new System.Drawing.Size(216, 20);
            this.accountUsernameComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.accountUsernameComboBox.TabIndex = 19;
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 263);
            this.Controls.Add(this.accountUsernameComboBox);
            this.Controls.Add(this.accountPermissionLevelComboBox);
            this.Controls.Add(this.accountPermissionLabel);
            this.Controls.Add(this.accountUsernameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(518, 301);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(518, 301);
            this.Name = "EditAccount";
            this.Text = "Edit Account";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX accountPermissionLabel;
        private DevComponents.DotNetBar.LabelX accountUsernameLabel;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.ComboBoxEx accountPermissionLevelComboBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx accountUsernameComboBox;
    }
}