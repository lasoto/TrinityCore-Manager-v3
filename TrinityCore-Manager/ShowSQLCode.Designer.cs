namespace TrinityCore_Manager
{
    partial class ShowSQLCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSQLCode));
            this.sqlCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.copyToClipboardButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // sqlCodeTextBox
            // 
            this.sqlCodeTextBox.AllowDrop = true;
            this.sqlCodeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.sqlCodeTextBox.Border.Class = "TextBoxBorder";
            this.sqlCodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sqlCodeTextBox.ForeColor = System.Drawing.Color.Chartreuse;
            this.sqlCodeTextBox.Location = new System.Drawing.Point(12, 0);
            this.sqlCodeTextBox.Multiline = true;
            this.sqlCodeTextBox.Name = "sqlCodeTextBox";
            this.sqlCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sqlCodeTextBox.Size = new System.Drawing.Size(715, 654);
            this.sqlCodeTextBox.TabIndex = 0;
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.copyToClipboardButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.copyToClipboardButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.copyToClipboardButton.Location = new System.Drawing.Point(279, 660);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(141, 31);
            this.copyToClipboardButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.copyToClipboardButton.TabIndex = 1;
            this.copyToClipboardButton.Text = "Copy to Clipboard";
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // ShowSQLCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 693);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.sqlCodeTextBox);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(770, 735);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(770, 735);
            this.Name = "ShowSQLCode";
            this.Text = "SQL Code";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX sqlCodeTextBox;
        private DevComponents.DotNetBar.ButtonX copyToClipboardButton;
    }
}