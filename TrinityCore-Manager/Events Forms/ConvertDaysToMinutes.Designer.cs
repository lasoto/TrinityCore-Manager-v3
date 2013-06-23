namespace TrinityCore_Manager
{
    partial class ConvertDaysToMinutes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertDaysToMinutes));
            this.label1 = new System.Windows.Forms.Label();
            this.daysIntegerInput = new DevComponents.Editors.IntegerInput();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.inMinutesLabel = new DevComponents.DotNetBar.LabelX();
            this.copyToClipboardButton = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.daysIntegerInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(97, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days:";
            // 
            // daysIntegerInput
            // 
            // 
            // 
            // 
            this.daysIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.daysIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.daysIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.daysIntegerInput.Location = new System.Drawing.Point(149, 59);
            this.daysIntegerInput.MaxValue = 3600;
            this.daysIntegerInput.MinValue = 0;
            this.daysIntegerInput.Name = "daysIntegerInput";
            this.daysIntegerInput.ShowUpDown = true;
            this.daysIntegerInput.Size = new System.Drawing.Size(101, 20);
            this.daysIntegerInput.TabIndex = 2;
            this.daysIntegerInput.ValueChanged += new System.EventHandler(this.daysIntegerInput_ValueChanged);
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(300, 226);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(74, 24);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(12, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 24);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(77, 116);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(66, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Minutes:";
            // 
            // inMinutesLabel
            // 
            // 
            // 
            // 
            this.inMinutesLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.inMinutesLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.inMinutesLabel.Location = new System.Drawing.Point(149, 116);
            this.inMinutesLabel.Name = "inMinutesLabel";
            this.inMinutesLabel.Size = new System.Drawing.Size(225, 23);
            this.inMinutesLabel.TabIndex = 7;
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.copyToClipboardButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.copyToClipboardButton.Location = new System.Drawing.Point(149, 162);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(101, 30);
            this.copyToClipboardButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.copyToClipboardButton.TabIndex = 8;
            this.copyToClipboardButton.Text = "Copy to Clipboard";
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // ConvertDaysToMinutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 262);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.inMinutesLabel);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.daysIntegerInput);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(402, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(402, 300);
            this.Name = "ConvertDaysToMinutes";
            this.Text = "Convert Days To Minutes";
            ((System.ComponentModel.ISupportInitialize)(this.daysIntegerInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.IntegerInput daysIntegerInput;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX inMinutesLabel;
        private DevComponents.DotNetBar.ButtonX copyToClipboardButton;
    }
}