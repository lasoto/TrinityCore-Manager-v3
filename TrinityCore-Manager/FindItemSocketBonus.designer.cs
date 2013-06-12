namespace TrinityCore_Manager
{
    partial class FindItemSocketBonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindItemSocketBonus));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.itemSocketBonusListView = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.spellItemEnchantmentIdColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellItemEnchantmentNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.searchLabel = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(216, 484);
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
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(297, 484);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(68, 23);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Ok";
            // 
            // itemSocketBonusListView
            // 
            this.itemSocketBonusListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.itemSocketBonusListView.Border.Class = "ListViewBorder";
            this.itemSocketBonusListView.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemSocketBonusListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.spellItemEnchantmentIdColumnHeader,
            this.spellItemEnchantmentNameColumnHeader});
            this.itemSocketBonusListView.ForeColor = System.Drawing.Color.White;
            this.itemSocketBonusListView.Location = new System.Drawing.Point(4, 41);
            this.itemSocketBonusListView.Name = "itemSocketBonusListView";
            this.itemSocketBonusListView.Size = new System.Drawing.Size(361, 437);
            this.itemSocketBonusListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.itemSocketBonusListView.TabIndex = 5;
            this.itemSocketBonusListView.UseCompatibleStateImageBehavior = false;
            this.itemSocketBonusListView.View = System.Windows.Forms.View.Details;
            // 
            // spellItemEnchantmentIdColumnHeader
            // 
            this.spellItemEnchantmentIdColumnHeader.Text = "Spell ID";
            this.spellItemEnchantmentIdColumnHeader.Width = 68;
            // 
            // spellItemEnchantmentNameColumnHeader
            // 
            this.spellItemEnchantmentNameColumnHeader.Text = "Spell Name Name";
            this.spellItemEnchantmentNameColumnHeader.Width = 283;
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
            this.searchTextBox.Location = new System.Drawing.Point(4, 15);
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
            this.searchLabel.Location = new System.Drawing.Point(4, -6);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(43, 23);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Search";
            // 
            // FindItemSocketBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 522);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.itemSocketBonusListView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindItemSocketBonus";
            this.Text = "Find Item Socket Bonus";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.ListViewEx itemSocketBonusListView;
        private System.Windows.Forms.ColumnHeader spellItemEnchantmentIdColumnHeader;
        private System.Windows.Forms.ColumnHeader spellItemEnchantmentNameColumnHeader;
        private DevComponents.DotNetBar.Controls.TextBoxX searchTextBox;
        private DevComponents.DotNetBar.LabelX searchLabel;
    }
}