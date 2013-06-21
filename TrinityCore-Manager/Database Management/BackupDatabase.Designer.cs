namespace TrinityCore_Manager.Database_Management
{
    partial class BackupDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupDatabase));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.backupButton = new DevComponents.DotNetBar.ButtonX();
            this.worldCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.charCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.authCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.integerInput1 = new DevComponents.Editors.IntegerInput();
            this.integerInput2 = new DevComponents.Editors.IntegerInput();
            this.integerInput3 = new DevComponents.Editors.IntegerInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(74, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "Database:";
            // 
            // backupButton
            // 
            this.backupButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.backupButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.backupButton.Location = new System.Drawing.Point(202, 156);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(89, 37);
            this.backupButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.backupButton.TabIndex = 9;
            this.backupButton.Text = "Backup";
            this.backupButton.TextColor = System.Drawing.Color.Chartreuse;
            // 
            // worldCheckBox
            // 
            // 
            // 
            // 
            this.worldCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.worldCheckBox.Location = new System.Drawing.Point(380, 12);
            this.worldCheckBox.Name = "worldCheckBox";
            this.worldCheckBox.Size = new System.Drawing.Size(53, 23);
            this.worldCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.worldCheckBox.TabIndex = 16;
            this.worldCheckBox.Text = "World";
            // 
            // charCheckBox
            // 
            // 
            // 
            // 
            this.charCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.charCheckBox.Location = new System.Drawing.Point(271, 12);
            this.charCheckBox.Name = "charCheckBox";
            this.charCheckBox.Size = new System.Drawing.Size(79, 23);
            this.charCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.charCheckBox.TabIndex = 15;
            this.charCheckBox.Text = "Characters";
            // 
            // authCheckBox
            // 
            // 
            // 
            // 
            this.authCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.authCheckBox.Location = new System.Drawing.Point(176, 12);
            this.authCheckBox.Name = "authCheckBox";
            this.authCheckBox.Size = new System.Drawing.Size(44, 23);
            this.authCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.authCheckBox.TabIndex = 14;
            this.authCheckBox.Text = "Auth";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX2.Location = new System.Drawing.Point(45, 98);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(104, 23);
            this.labelX2.TabIndex = 17;
            this.labelX2.Text = "Backup Every:";
            // 
            // integerInput1
            // 
            // 
            // 
            // 
            this.integerInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput1.Location = new System.Drawing.Point(155, 101);
            this.integerInput1.Name = "integerInput1";
            this.integerInput1.ShowUpDown = true;
            this.integerInput1.Size = new System.Drawing.Size(88, 20);
            this.integerInput1.TabIndex = 18;
            // 
            // integerInput2
            // 
            // 
            // 
            // 
            this.integerInput2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput2.Location = new System.Drawing.Point(262, 101);
            this.integerInput2.Name = "integerInput2";
            this.integerInput2.ShowUpDown = true;
            this.integerInput2.Size = new System.Drawing.Size(88, 20);
            this.integerInput2.TabIndex = 19;
            // 
            // integerInput3
            // 
            // 
            // 
            // 
            this.integerInput3.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInput3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInput3.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInput3.Location = new System.Drawing.Point(368, 101);
            this.integerInput3.Name = "integerInput3";
            this.integerInput3.ShowUpDown = true;
            this.integerInput3.Size = new System.Drawing.Size(90, 20);
            this.integerInput3.TabIndex = 20;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX3.Location = new System.Drawing.Point(176, 72);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(44, 23);
            this.labelX3.TabIndex = 21;
            this.labelX3.Text = "Days";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX4.Location = new System.Drawing.Point(280, 72);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(47, 23);
            this.labelX4.TabIndex = 22;
            this.labelX4.Text = "Hours";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX5.Location = new System.Drawing.Point(380, 72);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(53, 23);
            this.labelX5.TabIndex = 23;
            this.labelX5.Text = "Minutes";
            // 
            // BackupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 205);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.integerInput3);
            this.Controls.Add(this.integerInput2);
            this.Controls.Add(this.integerInput1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.worldCheckBox);
            this.Controls.Add(this.charCheckBox);
            this.Controls.Add(this.authCheckBox);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.backupButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 243);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 243);
            this.Name = "BackupDatabase";
            this.Text = "Backup Database";
            ((System.ComponentModel.ISupportInitialize)(this.integerInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInput3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX backupButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX worldCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX charCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX authCheckBox;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput integerInput1;
        private DevComponents.Editors.IntegerInput integerInput2;
        private DevComponents.Editors.IntegerInput integerInput3;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}