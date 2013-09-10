namespace TrinityCore_Manager
{
    partial class FindItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindItem));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.itemFindDisplayIdTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.loadingProgress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.findItemListView = new BrightIdeasSoftware.FastObjectListView();
            this.imageColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.idColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.searchButton = new DevComponents.DotNetBar.ButtonX();
            this.nextButton = new DevComponents.DotNetBar.ButtonX();
            this.prevPageButton = new DevComponents.DotNetBar.ButtonX();
            this.labelXPageOfPages = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.findItemListView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(296, 495);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(376, 495);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 19;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // itemFindDisplayIdTextBox
            // 
            this.itemFindDisplayIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.itemFindDisplayIdTextBox.Border.Class = "TextBoxBorder";
            this.itemFindDisplayIdTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemFindDisplayIdTextBox.ForeColor = System.Drawing.Color.White;
            this.itemFindDisplayIdTextBox.Location = new System.Drawing.Point(8, 12);
            this.itemFindDisplayIdTextBox.Name = "itemFindDisplayIdTextBox";
            this.itemFindDisplayIdTextBox.Size = new System.Drawing.Size(366, 20);
            this.itemFindDisplayIdTextBox.TabIndex = 16;
            this.itemFindDisplayIdTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.itemFindDisplayIdTextBox_KeyUp);
            // 
            // loadingProgress
            // 
            // 
            // 
            // 
            this.loadingProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.loadingProgress.Location = new System.Drawing.Point(6, 495);
            this.loadingProgress.Name = "loadingProgress";
            this.loadingProgress.ProgressColor = System.Drawing.Color.White;
            this.loadingProgress.Size = new System.Drawing.Size(41, 23);
            this.loadingProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.loadingProgress.TabIndex = 21;
            this.loadingProgress.Visible = false;
            // 
            // findItemListView
            // 
            this.findItemListView.AllColumns.Add(this.imageColumn);
            this.findItemListView.AllColumns.Add(this.idColumn);
            this.findItemListView.AllColumns.Add(this.nameColumn);
            this.findItemListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.findItemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.imageColumn,
            this.idColumn,
            this.nameColumn});
            this.findItemListView.ForeColor = System.Drawing.Color.White;
            this.findItemListView.FullRowSelect = true;
            this.findItemListView.Location = new System.Drawing.Point(8, 38);
            this.findItemListView.MultiSelect = false;
            this.findItemListView.Name = "findItemListView";
            this.findItemListView.ShowGroups = false;
            this.findItemListView.Size = new System.Drawing.Size(443, 446);
            this.findItemListView.TabIndex = 22;
            this.findItemListView.UseCompatibleStateImageBehavior = false;
            this.findItemListView.View = System.Windows.Forms.View.Details;
            this.findItemListView.VirtualMode = true;
            // 
            // imageColumn
            // 
            this.imageColumn.AspectName = "ItemImage";
            this.imageColumn.CellPadding = null;
            this.imageColumn.ImageAspectName = "";
            this.imageColumn.Text = "";
            this.imageColumn.Width = 55;
            // 
            // idColumn
            // 
            this.idColumn.AspectName = "ItemId";
            this.idColumn.CellPadding = null;
            this.idColumn.Text = "Item Id";
            this.idColumn.Width = 65;
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "ItemName";
            this.nameColumn.CellPadding = null;
            this.nameColumn.Text = "Item Name";
            this.nameColumn.Width = 300;
            // 
            // searchButton
            // 
            this.searchButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.searchButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.searchButton.Location = new System.Drawing.Point(376, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 20);
            this.searchButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.searchButton.TabIndex = 23;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.nextButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.nextButton.Location = new System.Drawing.Point(137, 495);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(64, 23);
            this.nextButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.nextButton.TabIndex = 24;
            this.nextButton.Text = "Next -->";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevPageButton
            // 
            this.prevPageButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.prevPageButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.prevPageButton.Location = new System.Drawing.Point(46, 495);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(64, 23);
            this.prevPageButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.prevPageButton.TabIndex = 25;
            this.prevPageButton.Text = "<-- Prev";
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // labelXPageOfPages
            // 
            // 
            // 
            // 
            this.labelXPageOfPages.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXPageOfPages.Location = new System.Drawing.Point(206, 497);
            this.labelXPageOfPages.Name = "labelXPageOfPages";
            this.labelXPageOfPages.Size = new System.Drawing.Size(84, 19);
            this.labelXPageOfPages.TabIndex = 26;
            this.labelXPageOfPages.Text = "Page 0 of 0";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(113, 495);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(21, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 27;
            this.buttonX1.Text = "...";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // FindItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(461, 524);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelXPageOfPages);
            this.Controls.Add(this.prevPageButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.findItemListView);
            this.Controls.Add(this.loadingProgress);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.itemFindDisplayIdTextBox);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindItem";
            this.Text = "Find Item";
            this.Load += new System.EventHandler(this.FindItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindItem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.findItemListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.Controls.TextBoxX itemFindDisplayIdTextBox;
        private DevComponents.DotNetBar.Controls.CircularProgress loadingProgress;
        private BrightIdeasSoftware.FastObjectListView findItemListView;
        private BrightIdeasSoftware.OLVColumn imageColumn;
        private BrightIdeasSoftware.OLVColumn idColumn;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private DevComponents.DotNetBar.ButtonX searchButton;
        private DevComponents.DotNetBar.ButtonX nextButton;
        private DevComponents.DotNetBar.ButtonX prevPageButton;
        private DevComponents.DotNetBar.LabelX labelXPageOfPages;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}