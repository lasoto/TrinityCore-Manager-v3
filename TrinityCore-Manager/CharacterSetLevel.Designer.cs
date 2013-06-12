namespace TrinityCore_Manager
{
    partial class CharacterSetLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSetLevel));
            this.charSetLevelLabel = new DevComponents.DotNetBar.LabelX();
            this.charSetLevelComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.refreshButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // charSetLevelLabel
            // 
            // 
            // 
            // 
            this.charSetLevelLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.charSetLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.charSetLevelLabel.Location = new System.Drawing.Point(85, 78);
            this.charSetLevelLabel.Name = "charSetLevelLabel";
            this.charSetLevelLabel.Size = new System.Drawing.Size(75, 23);
            this.charSetLevelLabel.TabIndex = 0;
            this.charSetLevelLabel.Text = "Character:";
            // 
            // charSetLevelComboBox
            // 
            this.charSetLevelComboBox.DisplayMember = "Text";
            this.charSetLevelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.charSetLevelComboBox.FormattingEnabled = true;
            this.charSetLevelComboBox.ItemHeight = 14;
            this.charSetLevelComboBox.Location = new System.Drawing.Point(166, 81);
            this.charSetLevelComboBox.Name = "charSetLevelComboBox";
            this.charSetLevelComboBox.Size = new System.Drawing.Size(178, 20);
            this.charSetLevelComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.charSetLevelComboBox.TabIndex = 1;
            // 
            // refreshButton
            // 
            this.refreshButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.refreshButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.refreshButton.Location = new System.Drawing.Point(371, 78);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(77, 31);
            this.refreshButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(6, 216);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 35);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(384, 216);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 35);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.TextColor = System.Drawing.Color.GreenYellow;
            // 
            // CharacterSetLevel
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(502, 263);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.charSetLevelComboBox);
            this.Controls.Add(this.charSetLevelLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterSetLevel";
            this.Text = "Character Set Level";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX charSetLevelLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx charSetLevelComboBox;
        private DevComponents.DotNetBar.ButtonX refreshButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;

    }
}