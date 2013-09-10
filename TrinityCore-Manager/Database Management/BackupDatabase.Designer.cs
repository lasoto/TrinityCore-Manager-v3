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
            this.daysIntegerInput = new DevComponents.Editors.IntegerInput();
            this.hoursIntegerInput = new DevComponents.Editors.IntegerInput();
            this.minIntegerInput = new DevComponents.Editors.IntegerInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.scheduleBackupsCheckbox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.backupProgressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.saveButton = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.daysIntegerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursIntegerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIntegerInput)).BeginInit();
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
            this.backupButton.Location = new System.Drawing.Point(155, 183);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(89, 37);
            this.backupButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.backupButton.TabIndex = 9;
            this.backupButton.Text = "Backup";
            this.backupButton.TextColor = System.Drawing.Color.Chartreuse;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
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
            // daysIntegerInput
            // 
            // 
            // 
            // 
            this.daysIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.daysIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.daysIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.daysIntegerInput.Enabled = false;
            this.daysIntegerInput.Location = new System.Drawing.Point(155, 101);
            this.daysIntegerInput.MinValue = 0;
            this.daysIntegerInput.Name = "daysIntegerInput";
            this.daysIntegerInput.ShowUpDown = true;
            this.daysIntegerInput.Size = new System.Drawing.Size(88, 20);
            this.daysIntegerInput.TabIndex = 18;
            // 
            // hoursIntegerInput
            // 
            // 
            // 
            // 
            this.hoursIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.hoursIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hoursIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.hoursIntegerInput.Enabled = false;
            this.hoursIntegerInput.Location = new System.Drawing.Point(262, 101);
            this.hoursIntegerInput.MinValue = 0;
            this.hoursIntegerInput.Name = "hoursIntegerInput";
            this.hoursIntegerInput.ShowUpDown = true;
            this.hoursIntegerInput.Size = new System.Drawing.Size(88, 20);
            this.hoursIntegerInput.TabIndex = 19;
            // 
            // minIntegerInput
            // 
            // 
            // 
            // 
            this.minIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.minIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.minIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.minIntegerInput.Enabled = false;
            this.minIntegerInput.Location = new System.Drawing.Point(368, 101);
            this.minIntegerInput.MinValue = 0;
            this.minIntegerInput.Name = "minIntegerInput";
            this.minIntegerInput.ShowUpDown = true;
            this.minIntegerInput.Size = new System.Drawing.Size(90, 20);
            this.minIntegerInput.TabIndex = 20;
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
            // scheduleBackupsCheckbox
            // 
            // 
            // 
            // 
            this.scheduleBackupsCheckbox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.scheduleBackupsCheckbox.Location = new System.Drawing.Point(217, 43);
            this.scheduleBackupsCheckbox.Name = "scheduleBackupsCheckbox";
            this.scheduleBackupsCheckbox.Size = new System.Drawing.Size(133, 23);
            this.scheduleBackupsCheckbox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.scheduleBackupsCheckbox.TabIndex = 24;
            this.scheduleBackupsCheckbox.Text = "Schedule Backups";
            this.scheduleBackupsCheckbox.CheckedChanged += new System.EventHandler(this.scheduleBackupsCheckbox_CheckedChanged);
            // 
            // backupProgressBar
            // 
            // 
            // 
            // 
            this.backupProgressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.backupProgressBar.Location = new System.Drawing.Point(45, 141);
            this.backupProgressBar.Name = "backupProgressBar";
            this.backupProgressBar.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
            this.backupProgressBar.Size = new System.Drawing.Size(413, 23);
            this.backupProgressBar.TabIndex = 25;
            this.backupProgressBar.TextVisible = true;
            this.backupProgressBar.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.saveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.saveButton.Location = new System.Drawing.Point(250, 183);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 37);
            this.saveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Save";
            this.saveButton.TextColor = System.Drawing.Color.Chartreuse;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // BackupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 232);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backupProgressBar);
            this.Controls.Add(this.scheduleBackupsCheckbox);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.minIntegerInput);
            this.Controls.Add(this.hoursIntegerInput);
            this.Controls.Add(this.daysIntegerInput);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.worldCheckBox);
            this.Controls.Add(this.charCheckBox);
            this.Controls.Add(this.authCheckBox);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.backupButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 274);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 274);
            this.Name = "BackupDatabase";
            this.Text = "Backup Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackupDatabase_FormClosing);
            this.Load += new System.EventHandler(this.BackupDatabase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackupDatabase_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.daysIntegerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursIntegerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIntegerInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX backupButton;
        private DevComponents.DotNetBar.Controls.CheckBoxX worldCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX charCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX authCheckBox;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput daysIntegerInput;
        private DevComponents.Editors.IntegerInput hoursIntegerInput;
        private DevComponents.Editors.IntegerInput minIntegerInput;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.CheckBoxX scheduleBackupsCheckbox;
        private DevComponents.DotNetBar.Controls.ProgressBarX backupProgressBar;
        private DevComponents.DotNetBar.ButtonX saveButton;
    }
}