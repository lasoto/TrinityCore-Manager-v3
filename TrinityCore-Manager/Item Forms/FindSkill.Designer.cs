namespace TrinityCore_Manager.Item_Forms
{
    partial class FindSkill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindSkill));
            this.findSkillListView = new BrightIdeasSoftware.FastObjectListView();
            this.idColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.searchLabel = new DevComponents.DotNetBar.LabelX();
            this.itemFindDisplayIdTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.findSkillListView)).BeginInit();
            this.SuspendLayout();
            // 
            // findSkillListView
            // 
            this.findSkillListView.AllColumns.Add(this.idColumn);
            this.findSkillListView.AllColumns.Add(this.nameColumn);
            this.findSkillListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.findSkillListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn});
            this.findSkillListView.ForeColor = System.Drawing.Color.White;
            this.findSkillListView.FullRowSelect = true;
            this.findSkillListView.Location = new System.Drawing.Point(1, 42);
            this.findSkillListView.Name = "findSkillListView";
            this.findSkillListView.ShowGroups = false;
            this.findSkillListView.Size = new System.Drawing.Size(361, 446);
            this.findSkillListView.TabIndex = 21;
            this.findSkillListView.UseCompatibleStateImageBehavior = false;
            this.findSkillListView.View = System.Windows.Forms.View.Details;
            this.findSkillListView.VirtualMode = true;
            // 
            // idColumn
            // 
            this.idColumn.AspectName = "Id";
            this.idColumn.CellPadding = null;
            this.idColumn.Text = "Skill ID";
            this.idColumn.Width = 89;
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "Name";
            this.nameColumn.CellPadding = null;
            this.nameColumn.Text = "Skill Name";
            this.nameColumn.Width = 259;
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(206, 494);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(287, 494);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 19;
            this.okButton.Text = "Ok";
            // 
            // searchLabel
            // 
            // 
            // 
            // 
            this.searchLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchLabel.Location = new System.Drawing.Point(1, -5);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(53, 20);
            this.searchLabel.TabIndex = 18;
            this.searchLabel.Text = "Search";
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
            this.itemFindDisplayIdTextBox.Location = new System.Drawing.Point(1, 16);
            this.itemFindDisplayIdTextBox.Name = "itemFindDisplayIdTextBox";
            this.itemFindDisplayIdTextBox.Size = new System.Drawing.Size(361, 20);
            this.itemFindDisplayIdTextBox.TabIndex = 17;
            // 
            // FindSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 517);
            this.Controls.Add(this.findSkillListView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.itemFindDisplayIdTextBox);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 560);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 560);
            this.Name = "FindSkill";
            this.Text = "Item Find Skill";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindSkill_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.findSkillListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView findSkillListView;
        private BrightIdeasSoftware.OLVColumn idColumn;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.LabelX searchLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX itemFindDisplayIdTextBox;
    }
}