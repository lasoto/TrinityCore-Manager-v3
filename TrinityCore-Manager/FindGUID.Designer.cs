namespace TrinityCore_Manager
{
    partial class FindGUID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindGUID));
            this.tableLabel = new DevComponents.DotNetBar.LabelX();
            this.tableComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.creatureTableComboItem = new DevComponents.Editors.ComboItem();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.findButton = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.guidIntegerInput = new DevComponents.Editors.IntegerInput();
            this.guidListView = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.numberComboHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.guidIntegerInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLabel
            // 
            // 
            // 
            // 
            this.tableLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tableLabel.Location = new System.Drawing.Point(109, 9);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(43, 23);
            this.tableLabel.TabIndex = 0;
            this.tableLabel.Text = "Table:";
            // 
            // tableComboBox
            // 
            this.tableComboBox.DisplayMember = "Text";
            this.tableComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tableComboBox.ForeColor = System.Drawing.Color.White;
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.ItemHeight = 14;
            this.tableComboBox.Items.AddRange(new object[] {
            this.creatureTableComboItem});
            this.tableComboBox.Location = new System.Drawing.Point(158, 12);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(145, 20);
            this.tableComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tableComboBox.TabIndex = 1;
            // 
            // creatureTableComboItem
            // 
            this.creatureTableComboItem.Text = "Creature";
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(12, 382);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 33);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            // 
            // findButton
            // 
            this.findButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.findButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.findButton.Location = new System.Drawing.Point(300, 382);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(85, 33);
            this.findButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Find";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(22, 48);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(130, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Number of GUIDs:";
            // 
            // guidIntegerInput
            // 
            // 
            // 
            // 
            this.guidIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.guidIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.guidIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.guidIntegerInput.Location = new System.Drawing.Point(158, 51);
            this.guidIntegerInput.MaxValue = 999;
            this.guidIntegerInput.MinValue = 0;
            this.guidIntegerInput.Name = "guidIntegerInput";
            this.guidIntegerInput.ShowUpDown = true;
            this.guidIntegerInput.Size = new System.Drawing.Size(145, 20);
            this.guidIntegerInput.TabIndex = 7;
            // 
            // guidListView
            // 
            this.guidListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.guidListView.Border.Class = "ListViewBorder";
            this.guidListView.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.guidListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numberComboHeader});
            this.guidListView.ForeColor = System.Drawing.Color.White;
            this.guidListView.Location = new System.Drawing.Point(12, 89);
            this.guidListView.Name = "guidListView";
            this.guidListView.Size = new System.Drawing.Size(373, 275);
            this.guidListView.TabIndex = 8;
            this.guidListView.UseCompatibleStateImageBehavior = false;
            this.guidListView.View = System.Windows.Forms.View.Details;
            // 
            // numberComboHeader
            // 
            this.numberComboHeader.Text = "Value";
            this.numberComboHeader.Width = 371;
            // 
            // FindGUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 427);
            this.Controls.Add(this.guidListView);
            this.Controls.Add(this.guidIntegerInput);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.tableComboBox);
            this.Controls.Add(this.tableLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindGUID";
            this.Text = "Find GUID";
            ((System.ComponentModel.ISupportInitialize)(this.guidIntegerInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX tableLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx tableComboBox;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX findButton;
        private DevComponents.Editors.ComboItem creatureTableComboItem;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput guidIntegerInput;
        private DevComponents.DotNetBar.Controls.ListViewEx guidListView;
        private System.Windows.Forms.ColumnHeader numberComboHeader;
    }
}