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
            this.banButton = new DevComponents.DotNetBar.ButtonX();
            this.ipAddressBanInput = new DevComponents.Editors.IpAddressInput();
            this.ipAddressBanLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressBanInput)).BeginInit();
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
            // banButton
            // 
            this.banButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.banButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.banButton.Location = new System.Drawing.Point(300, 150);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(85, 33);
            this.banButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.banButton.TabIndex = 6;
            this.banButton.Text = "Remove";
            this.banButton.TextColor = System.Drawing.Color.Chartreuse;
            // 
            // ipAddressBanInput
            // 
            this.ipAddressBanInput.AutoOverwrite = true;
            // 
            // 
            // 
            this.ipAddressBanInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ipAddressBanInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipAddressBanInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ipAddressBanInput.ButtonFreeText.Visible = true;
            this.ipAddressBanInput.Location = new System.Drawing.Point(160, 65);
            this.ipAddressBanInput.Name = "ipAddressBanInput";
            this.ipAddressBanInput.Size = new System.Drawing.Size(127, 20);
            this.ipAddressBanInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipAddressBanInput.TabIndex = 5;
            // 
            // ipAddressBanLabel
            // 
            // 
            // 
            // 
            this.ipAddressBanLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipAddressBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ipAddressBanLabel.Location = new System.Drawing.Point(70, 59);
            this.ipAddressBanLabel.Name = "ipAddressBanLabel";
            this.ipAddressBanLabel.Size = new System.Drawing.Size(84, 26);
            this.ipAddressBanLabel.TabIndex = 4;
            this.ipAddressBanLabel.Text = "IP Address:";
            // 
            // RemoveIPBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 195);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.ipAddressBanInput);
            this.Controls.Add(this.ipAddressBanLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 233);
            this.Name = "RemoveIPBan";
            this.Text = "Remove IP Ban";
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressBanInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX banButton;
        private DevComponents.Editors.IpAddressInput ipAddressBanInput;
        private DevComponents.DotNetBar.LabelX ipAddressBanLabel;
    }
}