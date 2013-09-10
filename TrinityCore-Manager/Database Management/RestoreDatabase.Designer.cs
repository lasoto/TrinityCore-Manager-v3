namespace TrinityCore_Manager.Database_Management
{
    partial class RestoreDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestoreDatabase));
            this.restoreButton = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.restoreListComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.restoreProgressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.deleteBackupButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // restoreButton
            // 
            this.restoreButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.restoreButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.restoreButton.Location = new System.Drawing.Point(206, 120);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(89, 37);
            this.restoreButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.restoreButton.TabIndex = 6;
            this.restoreButton.Text = "Restore";
            this.restoreButton.TextColor = System.Drawing.Color.Chartreuse;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX2.Location = new System.Drawing.Point(61, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(92, 23);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Restore List:";
            // 
            // restoreListComboBox
            // 
            this.restoreListComboBox.DisplayMember = "Text";
            this.restoreListComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.restoreListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restoreListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreListComboBox.ForeColor = System.Drawing.Color.White;
            this.restoreListComboBox.FormattingEnabled = true;
            this.restoreListComboBox.ItemHeight = 16;
            this.restoreListComboBox.Location = new System.Drawing.Point(159, 15);
            this.restoreListComboBox.Name = "restoreListComboBox";
            this.restoreListComboBox.Size = new System.Drawing.Size(292, 22);
            this.restoreListComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.restoreListComboBox.TabIndex = 10;
            // 
            // restoreProgressBar
            // 
            // 
            // 
            // 
            this.restoreProgressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.restoreProgressBar.Location = new System.Drawing.Point(61, 91);
            this.restoreProgressBar.Name = "restoreProgressBar";
            this.restoreProgressBar.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
            this.restoreProgressBar.Size = new System.Drawing.Size(364, 23);
            this.restoreProgressBar.TabIndex = 11;
            this.restoreProgressBar.Visible = false;
            // 
            // deleteBackupButton
            // 
            this.deleteBackupButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.deleteBackupButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.deleteBackupButton.Location = new System.Drawing.Point(206, 43);
            this.deleteBackupButton.Name = "deleteBackupButton";
            this.deleteBackupButton.Size = new System.Drawing.Size(89, 23);
            this.deleteBackupButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.deleteBackupButton.TabIndex = 12;
            this.deleteBackupButton.Text = "Delete Backup";
            this.deleteBackupButton.Click += new System.EventHandler(this.deleteBackupButton_Click);
            // 
            // RestoreDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 165);
            this.Controls.Add(this.deleteBackupButton);
            this.Controls.Add(this.restoreProgressBar);
            this.Controls.Add(this.restoreListComboBox);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.restoreButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 207);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 207);
            this.Name = "RestoreDatabase";
            this.Text = "Restore Database";
            this.Load += new System.EventHandler(this.RestoreDatabase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RestoreDatabase_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX restoreButton;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx restoreListComboBox;
        private DevComponents.DotNetBar.Controls.ProgressBarX restoreProgressBar;
        private DevComponents.DotNetBar.ButtonX deleteBackupButton;
    }
}