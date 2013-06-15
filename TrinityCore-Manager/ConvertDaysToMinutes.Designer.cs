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
            this.label2 = new System.Windows.Forms.Label();
            this.daysIntegerInput = new DevComponents.Editors.IntegerInput();
            this.minutesIntegerInput = new DevComponents.Editors.IntegerInput();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.daysIntegerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesIntegerInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minutes:";
            // 
            // daysIntegerInput
            // 
            // 
            // 
            // 
            this.daysIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.daysIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.daysIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.daysIntegerInput.Location = new System.Drawing.Point(82, 58);
            this.daysIntegerInput.MinValue = 0;
            this.daysIntegerInput.Name = "daysIntegerInput";
            this.daysIntegerInput.ShowUpDown = true;
            this.daysIntegerInput.Size = new System.Drawing.Size(173, 20);
            this.daysIntegerInput.TabIndex = 2;
            // 
            // minutesIntegerInput
            // 
            // 
            // 
            // 
            this.minutesIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.minutesIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.minutesIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.minutesIntegerInput.Location = new System.Drawing.Point(82, 128);
            this.minutesIntegerInput.MinValue = 0;
            this.minutesIntegerInput.Name = "minutesIntegerInput";
            this.minutesIntegerInput.ShowUpDown = true;
            this.minutesIntegerInput.Size = new System.Drawing.Size(173, 20);
            this.minutesIntegerInput.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(198, 204);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(74, 46);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(12, 204);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 46);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            // 
            // ConvertDaysToMinutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.minutesIntegerInput);
            this.Controls.Add(this.daysIntegerInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "ConvertDaysToMinutes";
            this.Text = "Convert Days To Minutes";
            ((System.ComponentModel.ISupportInitialize)(this.daysIntegerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesIntegerInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.IntegerInput daysIntegerInput;
        private DevComponents.Editors.IntegerInput minutesIntegerInput;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
    }
}