namespace TrinityCore_Manager_v3
{
    partial class AddAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.applicationButton2 = new DevComponents.DotNetBar.ApplicationButton();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer6 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer7 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem16 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem17 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem18 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem19 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem20 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem14 = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer2 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.createButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.accountUsernameLabel = new DevComponents.DotNetBar.LabelX();
            this.accountPasswordLabel = new DevComponents.DotNetBar.LabelX();
            this.accountPermissionLabel = new DevComponents.DotNetBar.LabelX();
            this.accountCreateUsernameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.accountCreatePasswordTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.accountPermissionLevelComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // applicationButton2
            // 
            this.applicationButton2.AutoExpandOnClick = true;
            this.applicationButton2.CanCustomize = false;
            this.applicationButton2.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.applicationButton2.Image = ((System.Drawing.Image)(resources.GetObject("applicationButton2.Image")));
            this.applicationButton2.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.applicationButton2.ImagePaddingHorizontal = 0;
            this.applicationButton2.ImagePaddingVertical = 0;
            this.applicationButton2.Name = "applicationButton2";
            this.applicationButton2.ShowSubItems = false;
            this.applicationButton2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer5});
            this.applicationButton2.Text = "&File";
            // 
            // itemContainer5
            // 
            // 
            // 
            // 
            this.itemContainer5.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer5.Name = "itemContainer5";
            this.itemContainer5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer6});
            // 
            // 
            // 
            this.itemContainer5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer6
            // 
            // 
            // 
            // 
            this.itemContainer6.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer6.ItemSpacing = 0;
            this.itemContainer6.Name = "itemContainer6";
            this.itemContainer6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer7});
            // 
            // 
            // 
            this.itemContainer6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer7
            // 
            // 
            // 
            // 
            this.itemContainer7.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer7.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer7.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer7.Name = "itemContainer7";
            this.itemContainer7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem15,
            this.buttonItem16,
            this.buttonItem17,
            this.buttonItem18,
            this.buttonItem19,
            this.buttonItem20});
            // 
            // 
            // 
            this.itemContainer7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem15
            // 
            this.buttonItem15.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem15.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem15.Image")));
            this.buttonItem15.Name = "buttonItem15";
            this.buttonItem15.SubItemsExpandWidth = 24;
            this.buttonItem15.Text = "&New";
            // 
            // buttonItem16
            // 
            this.buttonItem16.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem16.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem16.Image")));
            this.buttonItem16.Name = "buttonItem16";
            this.buttonItem16.SubItemsExpandWidth = 24;
            this.buttonItem16.Text = "&Open...";
            // 
            // buttonItem17
            // 
            this.buttonItem17.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem17.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem17.Image")));
            this.buttonItem17.Name = "buttonItem17";
            this.buttonItem17.SubItemsExpandWidth = 24;
            this.buttonItem17.Text = "&Save...";
            // 
            // buttonItem18
            // 
            this.buttonItem18.BeginGroup = true;
            this.buttonItem18.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem18.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem18.Image")));
            this.buttonItem18.Name = "buttonItem18";
            this.buttonItem18.SubItemsExpandWidth = 24;
            this.buttonItem18.Text = "S&hare...";
            // 
            // buttonItem19
            // 
            this.buttonItem19.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem19.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem19.Image")));
            this.buttonItem19.Name = "buttonItem19";
            this.buttonItem19.SubItemsExpandWidth = 24;
            this.buttonItem19.Text = "&Print...";
            // 
            // buttonItem20
            // 
            this.buttonItem20.BeginGroup = true;
            this.buttonItem20.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem20.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem20.Image")));
            this.buttonItem20.Name = "buttonItem20";
            this.buttonItem20.SubItemsExpandWidth = 24;
            this.buttonItem20.Text = "&Close";
            // 
            // buttonItem14
            // 
            this.buttonItem14.Name = "buttonItem14";
            this.buttonItem14.Text = "buttonItem14";
            // 
            // galleryContainer2
            // 
            // 
            // 
            // 
            this.galleryContainer2.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer2.EnableGalleryPopup = false;
            this.galleryContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer2.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer2.MultiLine = false;
            this.galleryContainer2.Name = "galleryContainer2";
            this.galleryContainer2.PopupUsesStandardScrollbars = false;
            // 
            // 
            // 
            this.galleryContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelItem1
            // 
            this.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem1.CanCustomize = false;
            this.labelItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelItem1.Name = "labelItem1";
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // createButton
            // 
            this.createButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.createButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.createButton.Location = new System.Drawing.Point(384, 224);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(106, 35);
            this.createButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.TextColor = System.Drawing.Color.GreenYellow;
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(6, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 35);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            // 
            // accountUsernameLabel
            // 
            // 
            // 
            // 
            this.accountUsernameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.accountUsernameLabel.Location = new System.Drawing.Point(102, 36);
            this.accountUsernameLabel.Name = "accountUsernameLabel";
            this.accountUsernameLabel.Size = new System.Drawing.Size(139, 26);
            this.accountUsernameLabel.TabIndex = 4;
            this.accountUsernameLabel.Text = "Account Username:";
            // 
            // accountPasswordLabel
            // 
            // 
            // 
            // 
            this.accountPasswordLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.accountPasswordLabel.Location = new System.Drawing.Point(102, 81);
            this.accountPasswordLabel.Name = "accountPasswordLabel";
            this.accountPasswordLabel.Size = new System.Drawing.Size(139, 26);
            this.accountPasswordLabel.TabIndex = 5;
            this.accountPasswordLabel.Text = "Account  Password:";
            // 
            // accountPermissionLabel
            // 
            // 
            // 
            // 
            this.accountPermissionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountPermissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.accountPermissionLabel.Location = new System.Drawing.Point(60, 124);
            this.accountPermissionLabel.Name = "accountPermissionLabel";
            this.accountPermissionLabel.Size = new System.Drawing.Size(181, 26);
            this.accountPermissionLabel.TabIndex = 6;
            this.accountPermissionLabel.Text = "Account Permission Level:";
            // 
            // accountCreateUsernameTextBox
            // 
            this.accountCreateUsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.accountCreateUsernameTextBox.Border.Class = "TextBoxBorder";
            this.accountCreateUsernameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountCreateUsernameTextBox.ForeColor = System.Drawing.Color.White;
            this.accountCreateUsernameTextBox.Location = new System.Drawing.Point(247, 41);
            this.accountCreateUsernameTextBox.Name = "accountCreateUsernameTextBox";
            this.accountCreateUsernameTextBox.Size = new System.Drawing.Size(216, 20);
            this.accountCreateUsernameTextBox.TabIndex = 7;
            // 
            // accountCreatePasswordTextBox
            // 
            this.accountCreatePasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.accountCreatePasswordTextBox.Border.Class = "TextBoxBorder";
            this.accountCreatePasswordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountCreatePasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.accountCreatePasswordTextBox.Location = new System.Drawing.Point(247, 86);
            this.accountCreatePasswordTextBox.Name = "accountCreatePasswordTextBox";
            this.accountCreatePasswordTextBox.Size = new System.Drawing.Size(216, 20);
            this.accountCreatePasswordTextBox.TabIndex = 8;
            // 
            // accountPermissionLevelComboBox
            // 
            this.accountPermissionLevelComboBox.DisplayMember = "Text";
            this.accountPermissionLevelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.accountPermissionLevelComboBox.FormattingEnabled = true;
            this.accountPermissionLevelComboBox.ItemHeight = 14;
            this.accountPermissionLevelComboBox.Location = new System.Drawing.Point(247, 130);
            this.accountPermissionLevelComboBox.Name = "accountPermissionLevelComboBox";
            this.accountPermissionLevelComboBox.Size = new System.Drawing.Size(216, 20);
            this.accountPermissionLevelComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.accountPermissionLevelComboBox.TabIndex = 9;
            // 
            // AddAccount
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(502, 263);
            this.Controls.Add(this.accountPermissionLevelComboBox);
            this.Controls.Add(this.accountCreatePasswordTextBox);
            this.Controls.Add(this.accountCreateUsernameTextBox);
            this.Controls.Add(this.accountPermissionLabel);
            this.Controls.Add(this.accountPasswordLabel);
            this.Controls.Add(this.accountUsernameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccount";
            this.Text = "Add Account";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ApplicationButton applicationButton2;
        private DevComponents.DotNetBar.ItemContainer itemContainer5;
        private DevComponents.DotNetBar.ItemContainer itemContainer6;
        private DevComponents.DotNetBar.ItemContainer itemContainer7;
        private DevComponents.DotNetBar.ButtonItem buttonItem15;
        private DevComponents.DotNetBar.ButtonItem buttonItem16;
        private DevComponents.DotNetBar.ButtonItem buttonItem17;
        private DevComponents.DotNetBar.ButtonItem buttonItem18;
        private DevComponents.DotNetBar.ButtonItem buttonItem19;
        private DevComponents.DotNetBar.ButtonItem buttonItem20;
        private DevComponents.DotNetBar.ButtonItem buttonItem14;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer2;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private DevComponents.DotNetBar.ButtonX createButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.LabelX accountUsernameLabel;
        private DevComponents.DotNetBar.LabelX accountPasswordLabel;
        private DevComponents.DotNetBar.LabelX accountPermissionLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX accountCreateUsernameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX accountCreatePasswordTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx accountPermissionLevelComboBox;
    }
}