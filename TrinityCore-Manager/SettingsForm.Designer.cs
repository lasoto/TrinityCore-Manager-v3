namespace TrinityCore_Manager
{
    partial class SettingsForm
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.themeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.darkItem = new DevComponents.Editors.ComboItem();
            this.blueItem = new DevComponents.Editors.ComboItem();
            this.lightItem = new DevComponents.Editors.ComboItem();
            this.blackItem = new DevComponents.Editors.ComboItem();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(6, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Theme";
            // 
            // themeComboBox
            // 
            this.themeComboBox.DisplayMember = "Text";
            this.themeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeComboBox.ForeColor = System.Drawing.Color.Black;
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.ItemHeight = 14;
            this.themeComboBox.Items.AddRange(new object[] {
            this.darkItem,
            this.blueItem,
            this.lightItem,
            this.blackItem});
            this.themeComboBox.Location = new System.Drawing.Point(72, 12);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(146, 20);
            this.themeComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.themeComboBox.TabIndex = 1;
            // 
            // darkItem
            // 
            this.darkItem.Text = "Dark";
            // 
            // blueItem
            // 
            this.blueItem.Text = "Blue";
            // 
            // lightItem
            // 
            this.lightItem.Text = "Light";
            // 
            // blackItem
            // 
            this.blackItem.Text = "Black";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(398, 186);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(103, 33);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.TextColor = System.Drawing.Color.SpringGreen;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(12, 186);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 33);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextColor = System.Drawing.Color.Tomato;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(513, 231);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.themeComboBox);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.TCMSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx themeComboBox;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.Editors.ComboItem darkItem;
        private DevComponents.Editors.ComboItem blueItem;
        private DevComponents.Editors.ComboItem lightItem;
        private DevComponents.Editors.ComboItem blackItem;
    }
}