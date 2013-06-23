namespace TrinityCore_Manager
{
    partial class FindItemRequiredSpell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindItemRequiredSpell));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.itemRequiredSpellListView = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.requiredSpellIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requiredSpellNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.searchLabel = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(213, 493);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(294, 493);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(68, 23);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Ok";
            // 
            // itemRequiredSpellListView
            // 
            this.itemRequiredSpellListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.itemRequiredSpellListView.Border.Class = "ListViewBorder";
            this.itemRequiredSpellListView.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemRequiredSpellListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.requiredSpellIdColumnHeader,
            this.requiredSpellNameColumnHeader});
            this.itemRequiredSpellListView.ForeColor = System.Drawing.Color.White;
            this.itemRequiredSpellListView.Location = new System.Drawing.Point(1, 50);
            this.itemRequiredSpellListView.Name = "itemRequiredSpellListView";
            this.itemRequiredSpellListView.Size = new System.Drawing.Size(361, 437);
            this.itemRequiredSpellListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.itemRequiredSpellListView.TabIndex = 5;
            this.itemRequiredSpellListView.UseCompatibleStateImageBehavior = false;
            this.itemRequiredSpellListView.View = System.Windows.Forms.View.Details;
            // 
            // requiredSpellIdColumnHeader
            // 
            this.requiredSpellIdColumnHeader.Text = "Spell ID";
            this.requiredSpellIdColumnHeader.Width = 79;
            // 
            // requiredSpellNameColumnHeader
            // 
            this.requiredSpellNameColumnHeader.Text = "Spell Name";
            this.requiredSpellNameColumnHeader.Width = 254;
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
            this.searchTextBox.Location = new System.Drawing.Point(1, 24);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(361, 20);
            this.searchTextBox.TabIndex = 7;
            // 
            // searchLabel
            // 
            // 
            // 
            // 
            this.searchLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchLabel.Location = new System.Drawing.Point(1, 3);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(43, 23);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Search";
            // 
            // FindItemRequiredSpell
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(362, 518);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.itemRequiredSpellListView);
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
            this.Name = "FindItemRequiredSpell";
            this.Text = "Find Item Required Spell";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.ListViewEx itemRequiredSpellListView;
        private System.Windows.Forms.ColumnHeader requiredSpellIdColumnHeader;
        private System.Windows.Forms.ColumnHeader requiredSpellNameColumnHeader;
        private DevComponents.DotNetBar.Controls.TextBoxX searchTextBox;
        private DevComponents.DotNetBar.LabelX searchLabel;
    }
}