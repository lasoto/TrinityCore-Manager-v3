namespace TrinityCore_Manager
{
    partial class SearchDatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDatabaseForm));
            this.listViewXDatabases = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // listViewXDatabases
            // 
            this.listViewXDatabases.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.listViewXDatabases.Border.Class = "ListViewBorder";
            this.listViewXDatabases.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewXDatabases.ForeColor = System.Drawing.Color.Black;
            this.listViewXDatabases.FullRowSelect = true;
            this.listViewXDatabases.Location = new System.Drawing.Point(12, 12);
            this.listViewXDatabases.MultiSelect = false;
            this.listViewXDatabases.Name = "listViewXDatabases";
            this.listViewXDatabases.Size = new System.Drawing.Size(229, 204);
            this.listViewXDatabases.TabIndex = 0;
            this.listViewXDatabases.UseCompatibleStateImageBehavior = false;
            this.listViewXDatabases.View = System.Windows.Forms.View.Details;
            this.listViewXDatabases.SelectedIndexChanged += new System.EventHandler(this.listViewXDatabases_SelectedIndexChanged);
            this.listViewXDatabases.DoubleClick += new System.EventHandler(this.listViewXDatabases_DoubleClick);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonX1.Enabled = false;
            this.buttonX1.Location = new System.Drawing.Point(12, 226);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "Continue";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonX2.Location = new System.Drawing.Point(166, 226);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 0;
            this.buttonX2.Text = "Cancel";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // SearchDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 259);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.listViewXDatabases);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchDatabaseForm";
            this.Text = "Search databases";
            this.Load += new System.EventHandler(this.SearchDatabaseForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchDatabaseForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx listViewXDatabases;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}