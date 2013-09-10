namespace TrinityCore_Manager
{
    partial class DeleteGuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteGuild));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.deleteButton = new DevComponents.DotNetBar.ButtonX();
            this.guildComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.guildNameLabel = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 33);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            // 
            // deleteButton
            // 
            this.deleteButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.deleteButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.deleteButton.Location = new System.Drawing.Point(300, 150);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 33);
            this.deleteButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextColor = System.Drawing.Color.Tomato;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // guildComboBox
            // 
            this.guildComboBox.DisplayMember = "Text";
            this.guildComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guildComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guildComboBox.ForeColor = System.Drawing.Color.White;
            this.guildComboBox.FormattingEnabled = true;
            this.guildComboBox.ItemHeight = 14;
            this.guildComboBox.Location = new System.Drawing.Point(96, 64);
            this.guildComboBox.Name = "guildComboBox";
            this.guildComboBox.Size = new System.Drawing.Size(209, 20);
            this.guildComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.guildComboBox.TabIndex = 9;
            // 
            // guildNameLabel
            // 
            // 
            // 
            // 
            this.guildNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.guildNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.guildNameLabel.Location = new System.Drawing.Point(48, 61);
            this.guildNameLabel.Name = "guildNameLabel";
            this.guildNameLabel.Size = new System.Drawing.Size(42, 23);
            this.guildNameLabel.TabIndex = 6;
            this.guildNameLabel.Text = "Guild:";
            // 
            // DeleteGuild
            // 
            this.AcceptButton = this.deleteButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(393, 191);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.guildComboBox);
            this.Controls.Add(this.guildNameLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 233);
            this.Name = "DeleteGuild";
            this.Text = "Delete Guild";
            this.Load += new System.EventHandler(this.DeleteGuild_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeleteGuild_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX deleteButton;
        private DevComponents.DotNetBar.Controls.ComboBoxEx guildComboBox;
        private DevComponents.DotNetBar.LabelX guildNameLabel;
    }
}