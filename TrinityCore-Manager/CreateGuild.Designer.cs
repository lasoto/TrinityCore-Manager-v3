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
            this.guildNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.leaderNameLabel = new DevComponents.DotNetBar.LabelX();
            this.guildLeaderComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
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
            // guildNameTextBox
            // 
            this.guildNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.guildNameTextBox.Border.Class = "TextBoxBorder";
            this.guildNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.guildNameTextBox.ForeColor = System.Drawing.Color.White;
            this.guildNameTextBox.Location = new System.Drawing.Point(128, 42);
            this.guildNameTextBox.Name = "guildNameTextBox";
            this.guildNameTextBox.Size = new System.Drawing.Size(232, 20);
            this.guildNameTextBox.TabIndex = 1;
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
            // guildLeaderComboBox
            // 
            this.guildLeaderComboBox.DisplayMember = "Text";
            this.guildLeaderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guildLeaderComboBox.ForeColor = System.Drawing.Color.White;
            this.guildLeaderComboBox.FormattingEnabled = true;
            this.guildLeaderComboBox.ItemHeight = 14;
            this.guildLeaderComboBox.Location = new System.Drawing.Point(128, 88);
            this.guildLeaderComboBox.Name = "guildLeaderComboBox";
            this.guildLeaderComboBox.Size = new System.Drawing.Size(232, 20);
            this.guildLeaderComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.guildLeaderComboBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
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
            this.createButton.Location = new System.Drawing.Point(300, 150);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(85, 33);
            this.createButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.TextColor = System.Drawing.Color.Chartreuse;
            // 
            // CreateGuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 195);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.guildLeaderComboBox);
            this.Controls.Add(this.leaderNameLabel);
            this.Controls.Add(this.guildNameTextBox);
            this.Controls.Add(this.guildNameLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
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
        private DevComponents.DotNetBar.Controls.TextBoxX guildNameTextBox;
        private DevComponents.DotNetBar.LabelX leaderNameLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx guildLeaderComboBox;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX createButton;
    }
}