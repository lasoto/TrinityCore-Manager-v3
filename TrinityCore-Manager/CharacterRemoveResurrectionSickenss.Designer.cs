namespace TrinityCore_Manager_v3
{
    partial class CharacterRemoveResurrectionSickenss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterRemoveResurrectionSickenss));
            this.refreshButton = new DevComponents.DotNetBar.ButtonX();
            this.charRemoveResSicknessComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.charRemoveResSicknessLabel = new DevComponents.DotNetBar.LabelX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.refreshButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.refreshButton.Location = new System.Drawing.Point(379, 89);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(77, 31);
            this.refreshButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            // 
            // charRemoveResSicknessComboBox
            // 
            this.charRemoveResSicknessComboBox.DisplayMember = "Text";
            this.charRemoveResSicknessComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.charRemoveResSicknessComboBox.FormattingEnabled = true;
            this.charRemoveResSicknessComboBox.ItemHeight = 14;
            this.charRemoveResSicknessComboBox.Location = new System.Drawing.Point(174, 92);
            this.charRemoveResSicknessComboBox.Name = "charRemoveResSicknessComboBox";
            this.charRemoveResSicknessComboBox.Size = new System.Drawing.Size(178, 20);
            this.charRemoveResSicknessComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.charRemoveResSicknessComboBox.TabIndex = 4;
            // 
            // charRemoveResSicknessLabel
            // 
            // 
            // 
            // 
            this.charRemoveResSicknessLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.charRemoveResSicknessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.charRemoveResSicknessLabel.Location = new System.Drawing.Point(93, 89);
            this.charRemoveResSicknessLabel.Name = "charRemoveResSicknessLabel";
            this.charRemoveResSicknessLabel.Size = new System.Drawing.Size(75, 23);
            this.charRemoveResSicknessLabel.TabIndex = 3;
            this.charRemoveResSicknessLabel.Text = "Character:";
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
            this.cancelButton.TabIndex = 7;
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
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ok";
            this.okButton.TextColor = System.Drawing.Color.GreenYellow;
            // 
            // CharacterRemoveResurrectionSickenss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 263);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.charRemoveResSicknessComboBox);
            this.Controls.Add(this.charRemoveResSicknessLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterRemoveResurrectionSickenss";
            this.Text = "Remove Resurrection Sickenss";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX refreshButton;
        private DevComponents.DotNetBar.Controls.ComboBoxEx charRemoveResSicknessComboBox;
        private DevComponents.DotNetBar.LabelX charRemoveResSicknessLabel;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;


    }
}