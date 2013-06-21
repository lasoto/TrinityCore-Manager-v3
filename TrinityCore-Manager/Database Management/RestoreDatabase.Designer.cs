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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.restoreListComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.authCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.charCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.worldCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // restoreButton
            // 
            this.restoreButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.restoreButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.restoreButton.Location = new System.Drawing.Point(207, 97);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(89, 37);
            this.restoreButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.restoreButton.TabIndex = 6;
            this.restoreButton.Text = "Restore";
            this.restoreButton.TextColor = System.Drawing.Color.Chartreuse;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(69, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Database:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX2.Location = new System.Drawing.Point(52, 55);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(92, 23);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Restore List:";
            // 
            // restoreListComboBox
            // 
            this.restoreListComboBox.DisplayMember = "Text";
            this.restoreListComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.restoreListComboBox.ForeColor = System.Drawing.Color.White;
            this.restoreListComboBox.FormattingEnabled = true;
            this.restoreListComboBox.ItemHeight = 14;
            this.restoreListComboBox.Location = new System.Drawing.Point(150, 58);
            this.restoreListComboBox.Name = "restoreListComboBox";
            this.restoreListComboBox.Size = new System.Drawing.Size(266, 20);
            this.restoreListComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.restoreListComboBox.TabIndex = 10;
            // 
            // authCheckBox
            // 
            // 
            // 
            // 
            this.authCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.authCheckBox.Location = new System.Drawing.Point(150, 9);
            this.authCheckBox.Name = "authCheckBox";
            this.authCheckBox.Size = new System.Drawing.Size(65, 23);
            this.authCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.authCheckBox.TabIndex = 11;
            this.authCheckBox.Text = "Auth";
            // 
            // charCheckBox
            // 
            // 
            // 
            // 
            this.charCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.charCheckBox.Location = new System.Drawing.Point(237, 9);
            this.charCheckBox.Name = "charCheckBox";
            this.charCheckBox.Size = new System.Drawing.Size(75, 23);
            this.charCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.charCheckBox.TabIndex = 12;
            this.charCheckBox.Text = "Characters";
            // 
            // worldCheckBox
            // 
            // 
            // 
            // 
            this.worldCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.worldCheckBox.Location = new System.Drawing.Point(340, 9);
            this.worldCheckBox.Name = "worldCheckBox";
            this.worldCheckBox.Size = new System.Drawing.Size(54, 23);
            this.worldCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.worldCheckBox.TabIndex = 13;
            this.worldCheckBox.Text = "World";
            // 
            // RestoreDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 149);
            this.Controls.Add(this.worldCheckBox);
            this.Controls.Add(this.charCheckBox);
            this.Controls.Add(this.authCheckBox);
            this.Controls.Add(this.restoreListComboBox);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.restoreButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 187);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 187);
            this.Name = "RestoreDatabase";
            this.Text = "Restore Database";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX restoreButton;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx restoreListComboBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX authCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX charCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX worldCheckBox;
    }
}