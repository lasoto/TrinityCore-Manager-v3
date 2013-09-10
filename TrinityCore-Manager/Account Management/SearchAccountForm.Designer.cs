namespace TrinityCore_Manager.Character_Management
{
    partial class SearchAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAccountForm));
            this.nameLabel = new DevComponents.DotNetBar.LabelX();
            this.searchTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.accountsList = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.SearchButton = new DevComponents.DotNetBar.ButtonX();
            this.searchProgress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            // 
            // 
            // 
            this.nameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(14, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.searchTextBox.Border.Class = "TextBoxBorder";
            this.searchTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchTextBox.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.Location = new System.Drawing.Point(63, 22);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(182, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // accountsList
            // 
            this.accountsList.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.accountsList.Border.Class = "ListViewBorder";
            this.accountsList.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountsList.ForeColor = System.Drawing.Color.White;
            this.accountsList.Location = new System.Drawing.Point(12, 48);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(312, 153);
            this.accountsList.TabIndex = 2;
            this.accountsList.UseCompatibleStateImageBehavior = false;
            this.accountsList.View = System.Windows.Forms.View.List;
            // 
            // SearchButton
            // 
            this.SearchButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SearchButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.SearchButton.Location = new System.Drawing.Point(251, 22);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 20);
            this.SearchButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchProgress
            // 
            // 
            // 
            // 
            this.searchProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchProgress.Location = new System.Drawing.Point(144, 207);
            this.searchProgress.Name = "searchProgress";
            this.searchProgress.ProgressColor = System.Drawing.Color.White;
            this.searchProgress.Size = new System.Drawing.Size(46, 32);
            this.searchProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.searchProgress.TabIndex = 4;
            this.searchProgress.Visible = false;
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(249, 207);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 32);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(12, 207);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 32);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SearchAccountForm
            // 
            this.ClientSize = new System.Drawing.Size(344, 248);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.searchProgress);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.nameLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchAccountForm";
            this.Text = "Search for Account";
            this.Load += new System.EventHandler(this.SearchAccountForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchAccountForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX nameLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX searchTextBox;
        private DevComponents.DotNetBar.Controls.ListViewEx accountsList;
        private DevComponents.DotNetBar.ButtonX SearchButton;
        private DevComponents.DotNetBar.Controls.CircularProgress searchProgress;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
    }
}