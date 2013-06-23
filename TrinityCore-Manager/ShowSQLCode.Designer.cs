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
            this.sqlCodeTextBox.Location = new System.Drawing.Point(12, 12);
            this.sqlCodeTextBox.Multiline = true;
            this.sqlCodeTextBox.Name = "sqlCodeTextBox";
            this.sqlCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sqlCodeTextBox.Size = new System.Drawing.Size(730, 673);
            this.sqlCodeTextBox.TabIndex = 0;
            // 
            // ShowSQLCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 697);
            this.Controls.Add(this.sqlCodeTextBox);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
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
    }
}