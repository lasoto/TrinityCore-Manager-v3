namespace TrinityCore_Manager
{
    partial class FindHoliday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindHoliday));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.findEventListView = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.holidayIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.holidayNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.searchLabel = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(215, 495);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(296, 495);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(68, 23);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 18;
            this.okButton.Text = "Ok";
            // 
            // findEventListView
            // 
            this.findEventListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.findEventListView.Border.Class = "ListViewBorder";
            this.findEventListView.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.findEventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.holidayIdColumnHeader,
            this.holidayNameColumnHeader});
            this.findEventListView.ForeColor = System.Drawing.Color.White;
            this.findEventListView.Location = new System.Drawing.Point(3, 52);
            this.findEventListView.Name = "findEventListView";
            this.findEventListView.Size = new System.Drawing.Size(361, 437);
            this.findEventListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.findEventListView.TabIndex = 15;
            this.findEventListView.UseCompatibleStateImageBehavior = false;
            this.findEventListView.View = System.Windows.Forms.View.Details;
            // 
            // holidayIdColumnHeader
            // 
            this.holidayIdColumnHeader.Text = "Holiday ID";
            this.holidayIdColumnHeader.Width = 79;
            // 
            // holidayNameColumnHeader
            // 
            this.holidayNameColumnHeader.Text = "Holiday Name";
            this.holidayNameColumnHeader.Width = 277;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.searchTextBox.Border.Class = "TextBoxBorder";
            this.searchTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchTextBox.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.Location = new System.Drawing.Point(3, 26);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(361, 20);
            this.searchTextBox.TabIndex = 17;
            // 
            // searchLabel
            // 
            // 
            // 
            // 
            this.searchLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchLabel.Location = new System.Drawing.Point(3, 5);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(43, 23);
            this.searchLabel.TabIndex = 16;
            this.searchLabel.Text = "Search";
            // 
            // FindHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 522);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.findEventListView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 560);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 560);
            this.Name = "FindHoliday";
            this.Text = "Find Holiday";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.ListViewEx findEventListView;
        private System.Windows.Forms.ColumnHeader holidayIdColumnHeader;
        private System.Windows.Forms.ColumnHeader holidayNameColumnHeader;
        private DevComponents.DotNetBar.Controls.TextBoxX searchTextBox;
        private DevComponents.DotNetBar.LabelX searchLabel;
    }
}