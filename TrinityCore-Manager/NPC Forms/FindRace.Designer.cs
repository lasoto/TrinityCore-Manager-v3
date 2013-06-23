namespace TrinityCore_Manager
{
    partial class FindRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindRace));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.findRaceListView = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.raceIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.raceNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.searchLabel = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(212, 491);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(293, 491);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(68, 23);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 13;
            this.okButton.Text = "Ok";
            // 
            // findRaceListView
            // 
            this.findRaceListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.findRaceListView.Border.Class = "ListViewBorder";
            this.findRaceListView.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.findRaceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.raceIdColumnHeader,
            this.raceNameColumnHeader});
            this.findRaceListView.ForeColor = System.Drawing.Color.White;
            this.findRaceListView.Location = new System.Drawing.Point(0, 48);
            this.findRaceListView.Name = "findRaceListView";
            this.findRaceListView.Size = new System.Drawing.Size(361, 437);
            this.findRaceListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.findRaceListView.TabIndex = 10;
            this.findRaceListView.UseCompatibleStateImageBehavior = false;
            this.findRaceListView.View = System.Windows.Forms.View.Details;
            // 
            // raceIdColumnHeader
            // 
            this.raceIdColumnHeader.Text = "Race ID";
            this.raceIdColumnHeader.Width = 79;
            // 
            // raceNameColumnHeader
            // 
            this.raceNameColumnHeader.Text = "Race Name";
            this.raceNameColumnHeader.Width = 277;
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
            this.searchTextBox.Location = new System.Drawing.Point(0, 22);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(361, 20);
            this.searchTextBox.TabIndex = 12;
            // 
            // searchLabel
            // 
            // 
            // 
            // 
            this.searchLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchLabel.Location = new System.Drawing.Point(0, 1);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(43, 23);
            this.searchLabel.TabIndex = 11;
            this.searchLabel.Text = "Search";
            // 
            // FindRace
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(366, 522);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.findRaceListView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 560);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 560);
            this.Name = "FindRace";
            this.Text = "Find Race";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.ListViewEx findRaceListView;
        private System.Windows.Forms.ColumnHeader raceIdColumnHeader;
        private System.Windows.Forms.ColumnHeader raceNameColumnHeader;
        private DevComponents.DotNetBar.Controls.TextBoxX searchTextBox;
        private DevComponents.DotNetBar.LabelX searchLabel;
    }
}