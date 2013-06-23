namespace TrinityCore_Manager
{
    partial class CreateGuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGuild));
            this.guildNameLabel = new DevComponents.DotNetBar.LabelX();
            this.nameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.leaderNameLabel = new DevComponents.DotNetBar.LabelX();
            this.leaderComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.createButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // guildNameLabel
            // 
            // 
            // 
            // 
            this.guildNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.guildNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.guildNameLabel.Location = new System.Drawing.Point(36, 38);
            this.guildNameLabel.Name = "guildNameLabel";
            this.guildNameLabel.Size = new System.Drawing.Size(86, 23);
            this.guildNameLabel.TabIndex = 0;
            this.guildNameLabel.Text = "Guild Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.nameTextBox.Border.Class = "TextBoxBorder";
            this.nameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(128, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(232, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // leaderNameLabel
            // 
            // 
            // 
            // 
            this.leaderNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.leaderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.leaderNameLabel.Location = new System.Drawing.Point(30, 84);
            this.leaderNameLabel.Name = "leaderNameLabel";
            this.leaderNameLabel.Size = new System.Drawing.Size(92, 23);
            this.leaderNameLabel.TabIndex = 2;
            this.leaderNameLabel.Text = "Guild Leader:";
            // 
            // leaderComboBox
            // 
            this.leaderComboBox.DisplayMember = "Text";
            this.leaderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.leaderComboBox.ForeColor = System.Drawing.Color.White;
            this.leaderComboBox.FormattingEnabled = true;
            this.leaderComboBox.ItemHeight = 14;
            this.leaderComboBox.Location = new System.Drawing.Point(128, 88);
            this.leaderComboBox.Name = "leaderComboBox";
            this.leaderComboBox.Size = new System.Drawing.Size(232, 20);
            this.leaderComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.leaderComboBox.TabIndex = 3;
            this.leaderComboBox.SelectedIndexChanged += new System.EventHandler(this.leaderComboBox_SelectedIndexChanged);
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
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            // 
            // createButton
            // 
            this.createButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.createButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.createButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createButton.Location = new System.Drawing.Point(300, 150);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(85, 33);
            this.createButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.TextColor = System.Drawing.Color.Chartreuse;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // CreateGuild
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(393, 191);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.leaderComboBox);
            this.Controls.Add(this.leaderNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.guildNameLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 233);
            this.Name = "CreateGuild";
            this.Text = "Create Guild";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX guildNameLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX nameTextBox;
        private DevComponents.DotNetBar.LabelX leaderNameLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx leaderComboBox;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX createButton;
    }
}