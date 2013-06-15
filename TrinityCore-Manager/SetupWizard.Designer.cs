namespace TrinityCore_Manager
{
    partial class SetupWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupWizard));
            this.wizard1 = new DevComponents.DotNetBar.Wizard();
            this.wizardPage1 = new DevComponents.DotNetBar.WizardPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wizardPage2 = new DevComponents.DotNetBar.WizardPage();
            this.typeLabel = new DevComponents.DotNetBar.LabelX();
            this.wizardPage3 = new DevComponents.DotNetBar.WizardPage();
            this.browseButton = new DevComponents.DotNetBar.ButtonX();
            this.folderTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.wizardPage4 = new DevComponents.DotNetBar.WizardPage();
            this.passwordTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.usernameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.hostTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.raInfoLabelX = new DevComponents.DotNetBar.LabelX();
            this.passwordLabelX = new DevComponents.DotNetBar.LabelX();
            this.usernameLabelX = new DevComponents.DotNetBar.LabelX();
            this.portIntegerInput = new DevComponents.Editors.IntegerInput();
            this.portLabelX = new DevComponents.DotNetBar.LabelX();
            this.hostLabelX = new DevComponents.DotNetBar.LabelX();
            this.wizardPage5 = new DevComponents.DotNetBar.WizardPage();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.mySqlPassTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.mySqlUsernameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.mySqlHostTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.mySqlConnectionProgressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.dbTypeComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.newDBComboItem = new DevComponents.Editors.ComboItem();
            this.existDBComboItem = new DevComponents.Editors.ComboItem();
            this.MySQLPasswordLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLUsernameLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLSettingsLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLIntegerInputX = new DevComponents.Editors.IntegerInput();
            this.MySQLPortLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLHostLabelX = new DevComponents.DotNetBar.LabelX();
            this.wizardPage6 = new DevComponents.DotNetBar.WizardPage();
            this.MySQLPercentLabelX = new DevComponents.DotNetBar.LabelX();
            this.downloadProgressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.downloadGitRepoButtonX = new DevComponents.DotNetBar.ButtonX();
            this.wizardPage7 = new DevComponents.DotNetBar.WizardPage();
            this.worldDBTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.charactersDBTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.authDBTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.MySQLWorldDBLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLCharDBLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLAuthDBLabelX = new DevComponents.DotNetBar.LabelX();
            this.setupSuperTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.remoteCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.localCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.autoConnectCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.wizardPage8 = new DevComponents.DotNetBar.WizardPage();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.wizard1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            this.wizardPage2.SuspendLayout();
            this.wizardPage3.SuspendLayout();
            this.wizardPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portIntegerInput)).BeginInit();
            this.wizardPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MySQLIntegerInputX)).BeginInit();
            this.wizardPage6.SuspendLayout();
            this.wizardPage7.SuspendLayout();
            this.wizardPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard1
            // 
            this.wizard1.CancelButtonText = "Cancel";
            this.wizard1.Cursor = System.Windows.Forms.Cursors.Default;
            this.wizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizard1.FinishButtonTabIndex = 3;
            // 
            // 
            // 
            this.wizard1.FooterStyle.BackColor = System.Drawing.SystemColors.Control;
            this.wizard1.FooterStyle.BackColorGradientAngle = 90;
            this.wizard1.FooterStyle.BorderBottomWidth = 1;
            this.wizard1.FooterStyle.BorderColor = System.Drawing.SystemColors.Control;
            this.wizard1.FooterStyle.BorderLeftWidth = 1;
            this.wizard1.FooterStyle.BorderRightWidth = 1;
            this.wizard1.FooterStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.wizard1.FooterStyle.BorderTopColor = System.Drawing.SystemColors.Control;
            this.wizard1.FooterStyle.BorderTopWidth = 1;
            this.wizard1.FooterStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizard1.FooterStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.wizard1.FooterStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.wizard1.HeaderCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizard1.HeaderDescriptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wizard1.HeaderDescriptionIndent = 16;
            // 
            // 
            // 
            this.wizard1.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.wizard1.HeaderStyle.BackColorGradientAngle = 90;
            this.wizard1.HeaderStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.wizard1.HeaderStyle.BorderBottomWidth = 1;
            this.wizard1.HeaderStyle.BorderColor = System.Drawing.SystemColors.Control;
            this.wizard1.HeaderStyle.BorderLeftWidth = 1;
            this.wizard1.HeaderStyle.BorderRightWidth = 1;
            this.wizard1.HeaderStyle.BorderTopWidth = 1;
            this.wizard1.HeaderStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizard1.HeaderStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.wizard1.HeaderStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.wizard1.HelpButtonVisible = false;
            this.wizard1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.wizard1.Location = new System.Drawing.Point(0, 0);
            this.wizard1.Name = "wizard1";
            this.wizard1.Size = new System.Drawing.Size(823, 632);
            this.wizard1.TabIndex = 0;
            this.wizard1.WizardPages.AddRange(new DevComponents.DotNetBar.WizardPage[] {
            this.wizardPage1,
            this.wizardPage2,
            this.wizardPage3,
            this.wizardPage4,
            this.wizardPage5,
            this.wizardPage6,
            this.wizardPage7,
            this.wizardPage8});
            // 
            // wizardPage1
            // 
            this.wizardPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage1.BackColor = System.Drawing.Color.White;
            this.wizardPage1.Controls.Add(this.label1);
            this.wizardPage1.Controls.Add(this.label2);
            this.wizardPage1.Controls.Add(this.label3);
            this.wizardPage1.InteriorPage = false;
            this.wizardPage1.Location = new System.Drawing.Point(0, 0);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(823, 586);
            // 
            // 
            // 
            this.wizardPage1.Style.BackColor = System.Drawing.Color.White;
            this.wizardPage1.Style.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wizardPage1.Style.BackgroundImage")));
            this.wizardPage1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft;
            this.wizardPage1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(210, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Setup Wizard";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(210, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(598, 454);
            this.label2.TabIndex = 1;
            this.label2.Text = "This wizard will guide you through the process of setting a server environment fo" +
    "r TrinityCore Manager v 3.0\r\n\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(210, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To continue, click Next.";
            // 
            // wizardPage2
            // 
            this.wizardPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage2.AntiAlias = false;
            this.wizardPage2.BackColor = System.Drawing.Color.Transparent;
            this.wizardPage2.Controls.Add(this.localCheckBox);
            this.wizardPage2.Controls.Add(this.remoteCheckBox);
            this.wizardPage2.Controls.Add(this.typeLabel);
            this.wizardPage2.Location = new System.Drawing.Point(7, 72);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.PageTitle = "Initial Setting";
            this.wizardPage2.Size = new System.Drawing.Size(809, 502);
            // 
            // 
            // 
            this.wizardPage2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage2.TabIndex = 8;
            // 
            // typeLabel
            // 
            // 
            // 
            // 
            this.typeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.typeLabel.Location = new System.Drawing.Point(224, 176);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(387, 20);
            this.typeLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "How would you like to connect to your TrinityCore server?";
            // 
            // wizardPage3
            // 
            this.wizardPage3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage3.AntiAlias = false;
            this.wizardPage3.BackColor = System.Drawing.Color.Transparent;
            this.wizardPage3.Controls.Add(this.browseButton);
            this.wizardPage3.Controls.Add(this.folderTextBox);
            this.wizardPage3.Controls.Add(this.labelX1);
            this.wizardPage3.Location = new System.Drawing.Point(7, 72);
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.PageTitle = "Local Setup";
            this.wizardPage3.Size = new System.Drawing.Size(809, 502);
            // 
            // 
            // 
            this.wizardPage3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage3.TabIndex = 9;
            // 
            // browseButton
            // 
            this.browseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.browseButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.browseButton.Location = new System.Drawing.Point(349, 262);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(101, 36);
            this.browseButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse for folder";
            // 
            // folderTextBox
            // 
            this.folderTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.folderTextBox.Border.Class = "TextBoxBorder";
            this.folderTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.folderTextBox.ForeColor = System.Drawing.Color.White;
            this.folderTextBox.Location = new System.Drawing.Point(257, 222);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(293, 20);
            this.folderTextBox.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(257, 183);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(293, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Please locate your TrinityCore server folder.";
            // 
            // wizardPage4
            // 
            this.wizardPage4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage4.AntiAlias = false;
            this.wizardPage4.BackColor = System.Drawing.Color.Transparent;
            this.wizardPage4.Controls.Add(this.autoConnectCheckBox);
            this.wizardPage4.Controls.Add(this.passwordTextBox);
            this.wizardPage4.Controls.Add(this.usernameTextBox);
            this.wizardPage4.Controls.Add(this.hostTextBox);
            this.wizardPage4.Controls.Add(this.labelX2);
            this.wizardPage4.Controls.Add(this.raInfoLabelX);
            this.wizardPage4.Controls.Add(this.passwordLabelX);
            this.wizardPage4.Controls.Add(this.usernameLabelX);
            this.wizardPage4.Controls.Add(this.portIntegerInput);
            this.wizardPage4.Controls.Add(this.portLabelX);
            this.wizardPage4.Controls.Add(this.hostLabelX);
            this.wizardPage4.Location = new System.Drawing.Point(7, 72);
            this.wizardPage4.Name = "wizardPage4";
            this.wizardPage4.PageTitle = "Remote Access Setup";
            this.wizardPage4.Size = new System.Drawing.Size(809, 502);
            // 
            // 
            // 
            this.wizardPage4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage4.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.passwordTextBox.Border.Class = "TextBoxBorder";
            this.passwordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(316, 280);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(210, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.passwordTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Account password", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.passwordTextBox.TabIndex = 31;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.usernameTextBox.Border.Class = "TextBoxBorder";
            this.usernameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(316, 240);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(208, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.usernameTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Account username", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.usernameTextBox.TabIndex = 30;
            // 
            // hostTextBox
            // 
            this.hostTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.hostTextBox.Border.Class = "TextBoxBorder";
            this.hostTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hostTextBox.ForeColor = System.Drawing.Color.White;
            this.hostTextBox.Location = new System.Drawing.Point(314, 145);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(210, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.hostTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "e.g. server.examplename.com", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.hostTextBox.TabIndex = 29;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(198, 413);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(423, 24);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX2.TabIndex = 28;
            this.labelX2.Text = "Note: Remote Access Details can be found in your worldserver.conf file.";
            // 
            // raInfoLabelX
            // 
            // 
            // 
            // 
            this.raInfoLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.raInfoLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.raInfoLabelX.Location = new System.Drawing.Point(243, 56);
            this.raInfoLabelX.Name = "raInfoLabelX";
            this.raInfoLabelX.Size = new System.Drawing.Size(309, 24);
            this.raInfoLabelX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.raInfoLabelX.TabIndex = 27;
            this.raInfoLabelX.Text = "Please provide your Remote Access Details";
            // 
            // passwordLabelX
            // 
            // 
            // 
            // 
            this.passwordLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.passwordLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabelX.Location = new System.Drawing.Point(241, 276);
            this.passwordLabelX.Name = "passwordLabelX";
            this.passwordLabelX.Size = new System.Drawing.Size(69, 23);
            this.passwordLabelX.TabIndex = 21;
            this.passwordLabelX.Text = "Password";
            // 
            // usernameLabelX
            // 
            // 
            // 
            // 
            this.usernameLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.usernameLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabelX.Location = new System.Drawing.Point(239, 236);
            this.usernameLabelX.Name = "usernameLabelX";
            this.usernameLabelX.Size = new System.Drawing.Size(71, 23);
            this.usernameLabelX.TabIndex = 19;
            this.usernameLabelX.Text = "Username";
            // 
            // portIntegerInput
            // 
            // 
            // 
            // 
            this.portIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.portIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.portIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.portIntegerInput.ForeColor = System.Drawing.Color.White;
            this.portIntegerInput.Location = new System.Drawing.Point(316, 191);
            this.portIntegerInput.Name = "portIntegerInput";
            this.portIntegerInput.ShowUpDown = true;
            this.portIntegerInput.Size = new System.Drawing.Size(80, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.portIntegerInput, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Default: 3443", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.portIntegerInput.TabIndex = 18;
            // 
            // portLabelX
            // 
            // 
            // 
            // 
            this.portLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.portLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabelX.Location = new System.Drawing.Point(280, 189);
            this.portLabelX.Name = "portLabelX";
            this.portLabelX.Size = new System.Drawing.Size(29, 23);
            this.portLabelX.TabIndex = 17;
            this.portLabelX.Text = "Port";
            // 
            // hostLabelX
            // 
            // 
            // 
            // 
            this.hostLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hostLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostLabelX.Location = new System.Drawing.Point(270, 142);
            this.hostLabelX.Name = "hostLabelX";
            this.hostLabelX.Size = new System.Drawing.Size(38, 23);
            this.hostLabelX.TabIndex = 15;
            this.hostLabelX.Text = "Host";
            // 
            // wizardPage5
            // 
            this.wizardPage5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage5.AntiAlias = false;
            this.wizardPage5.BackColor = System.Drawing.Color.Transparent;
            this.wizardPage5.Controls.Add(this.labelX3);
            this.wizardPage5.Controls.Add(this.mySqlPassTextBox);
            this.wizardPage5.Controls.Add(this.mySqlUsernameTextBox);
            this.wizardPage5.Controls.Add(this.mySqlHostTextBox);
            this.wizardPage5.Controls.Add(this.mySqlConnectionProgressBar);
            this.wizardPage5.Controls.Add(this.dbTypeComboBox);
            this.wizardPage5.Controls.Add(this.MySQLPasswordLabelX);
            this.wizardPage5.Controls.Add(this.MySQLUsernameLabelX);
            this.wizardPage5.Controls.Add(this.MySQLSettingsLabelX);
            this.wizardPage5.Controls.Add(this.MySQLIntegerInputX);
            this.wizardPage5.Controls.Add(this.MySQLPortLabelX);
            this.wizardPage5.Controls.Add(this.MySQLHostLabelX);
            this.wizardPage5.Location = new System.Drawing.Point(7, 72);
            this.wizardPage5.Name = "wizardPage5";
            this.wizardPage5.PageTitle = "MySQL Settings";
            this.wizardPage5.Size = new System.Drawing.Size(809, 502);
            // 
            // 
            // 
            this.wizardPage5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage5.TabIndex = 11;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(260, 302);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(69, 23);
            this.labelX3.TabIndex = 35;
            this.labelX3.Text = "Database";
            // 
            // mySqlPassTextBox
            // 
            this.mySqlPassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.mySqlPassTextBox.Border.Class = "TextBoxBorder";
            this.mySqlPassTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mySqlPassTextBox.ForeColor = System.Drawing.Color.White;
            this.mySqlPassTextBox.Location = new System.Drawing.Point(335, 257);
            this.mySqlPassTextBox.Name = "mySqlPassTextBox";
            this.mySqlPassTextBox.Size = new System.Drawing.Size(213, 20);
            this.mySqlPassTextBox.TabIndex = 34;
            // 
            // mySqlUsernameTextBox
            // 
            this.mySqlUsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.mySqlUsernameTextBox.Border.Class = "TextBoxBorder";
            this.mySqlUsernameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mySqlUsernameTextBox.ForeColor = System.Drawing.Color.White;
            this.mySqlUsernameTextBox.Location = new System.Drawing.Point(335, 217);
            this.mySqlUsernameTextBox.Name = "mySqlUsernameTextBox";
            this.mySqlUsernameTextBox.Size = new System.Drawing.Size(213, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.mySqlUsernameTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Default: root", null, null, DevComponents.DotNetBar.eTooltipColor.Blue));
            this.mySqlUsernameTextBox.TabIndex = 33;
            // 
            // mySqlHostTextBox
            // 
            this.mySqlHostTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.mySqlHostTextBox.Border.Class = "TextBoxBorder";
            this.mySqlHostTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mySqlHostTextBox.ForeColor = System.Drawing.Color.White;
            this.mySqlHostTextBox.Location = new System.Drawing.Point(335, 127);
            this.mySqlHostTextBox.Name = "mySqlHostTextBox";
            this.mySqlHostTextBox.Size = new System.Drawing.Size(213, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.mySqlHostTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Default: localhost", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.mySqlHostTextBox.TabIndex = 32;
            // 
            // mySqlConnectionProgressBar
            // 
            // 
            // 
            // 
            this.mySqlConnectionProgressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mySqlConnectionProgressBar.Location = new System.Drawing.Point(114, 420);
            this.mySqlConnectionProgressBar.Name = "mySqlConnectionProgressBar";
            this.mySqlConnectionProgressBar.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
            this.mySqlConnectionProgressBar.Size = new System.Drawing.Size(588, 39);
            this.mySqlConnectionProgressBar.TabIndex = 31;
            this.mySqlConnectionProgressBar.Visible = false;
            // 
            // dbTypeComboBox
            // 
            this.dbTypeComboBox.DisplayMember = "Text";
            this.dbTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dbTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.dbTypeComboBox.FormattingEnabled = true;
            this.dbTypeComboBox.ItemHeight = 14;
            this.dbTypeComboBox.Items.AddRange(new object[] {
            this.newDBComboItem,
            this.existDBComboItem});
            this.dbTypeComboBox.Location = new System.Drawing.Point(335, 305);
            this.dbTypeComboBox.Name = "dbTypeComboBox";
            this.dbTypeComboBox.Size = new System.Drawing.Size(80, 20);
            this.dbTypeComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dbTypeComboBox.TabIndex = 22;
            // 
            // newDBComboItem
            // 
            this.newDBComboItem.Text = "New Database";
            // 
            // existDBComboItem
            // 
            this.existDBComboItem.Text = "Existing Database";
            // 
            // MySQLPasswordLabelX
            // 
            // 
            // 
            // 
            this.MySQLPasswordLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLPasswordLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySQLPasswordLabelX.Location = new System.Drawing.Point(260, 253);
            this.MySQLPasswordLabelX.Name = "MySQLPasswordLabelX";
            this.MySQLPasswordLabelX.Size = new System.Drawing.Size(69, 23);
            this.MySQLPasswordLabelX.TabIndex = 29;
            this.MySQLPasswordLabelX.Text = "Password";
            // 
            // MySQLUsernameLabelX
            // 
            // 
            // 
            // 
            this.MySQLUsernameLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLUsernameLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySQLUsernameLabelX.Location = new System.Drawing.Point(258, 213);
            this.MySQLUsernameLabelX.Name = "MySQLUsernameLabelX";
            this.MySQLUsernameLabelX.Size = new System.Drawing.Size(71, 23);
            this.MySQLUsernameLabelX.TabIndex = 28;
            this.MySQLUsernameLabelX.Text = "Username";
            // 
            // MySQLSettingsLabelX
            // 
            // 
            // 
            // 
            this.MySQLSettingsLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLSettingsLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MySQLSettingsLabelX.Location = new System.Drawing.Point(308, 71);
            this.MySQLSettingsLabelX.Name = "MySQLSettingsLabelX";
            this.MySQLSettingsLabelX.Size = new System.Drawing.Size(240, 24);
            this.MySQLSettingsLabelX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.MySQLSettingsLabelX.TabIndex = 25;
            this.MySQLSettingsLabelX.Text = "Please provide your MySQL Details";
            // 
            // MySQLIntegerInputX
            // 
            // 
            // 
            // 
            this.MySQLIntegerInputX.BackgroundStyle.Class = "DateTimeInputBackground";
            this.MySQLIntegerInputX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLIntegerInputX.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.MySQLIntegerInputX.Location = new System.Drawing.Point(335, 173);
            this.MySQLIntegerInputX.Name = "MySQLIntegerInputX";
            this.MySQLIntegerInputX.ShowUpDown = true;
            this.MySQLIntegerInputX.Size = new System.Drawing.Size(80, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.MySQLIntegerInputX, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Default: 3306", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.MySQLIntegerInputX.TabIndex = 19;
            // 
            // MySQLPortLabelX
            // 
            // 
            // 
            // 
            this.MySQLPortLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLPortLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySQLPortLabelX.Location = new System.Drawing.Point(303, 171);
            this.MySQLPortLabelX.Name = "MySQLPortLabelX";
            this.MySQLPortLabelX.Size = new System.Drawing.Size(29, 23);
            this.MySQLPortLabelX.TabIndex = 24;
            this.MySQLPortLabelX.Text = "Port";
            // 
            // MySQLHostLabelX
            // 
            // 
            // 
            // 
            this.MySQLHostLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLHostLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySQLHostLabelX.Location = new System.Drawing.Point(294, 125);
            this.MySQLHostLabelX.Name = "MySQLHostLabelX";
            this.MySQLHostLabelX.Size = new System.Drawing.Size(38, 23);
            this.MySQLHostLabelX.TabIndex = 23;
            this.MySQLHostLabelX.Text = "Host";
            // 
            // wizardPage6
            // 
            this.wizardPage6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage6.AntiAlias = false;
            this.wizardPage6.BackColor = System.Drawing.Color.Transparent;
            this.wizardPage6.Controls.Add(this.MySQLPercentLabelX);
            this.wizardPage6.Controls.Add(this.downloadProgressBar);
            this.wizardPage6.Controls.Add(this.downloadGitRepoButtonX);
            this.wizardPage6.Location = new System.Drawing.Point(7, 72);
            this.wizardPage6.Name = "wizardPage6";
            this.wizardPage6.PageTitle = "TrinityCore Database Setup";
            this.wizardPage6.Size = new System.Drawing.Size(809, 502);
            // 
            // 
            // 
            this.wizardPage6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage6.TabIndex = 12;
            // 
            // MySQLPercentLabelX
            // 
            // 
            // 
            // 
            this.MySQLPercentLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLPercentLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MySQLPercentLabelX.Location = new System.Drawing.Point(382, 353);
            this.MySQLPercentLabelX.Name = "MySQLPercentLabelX";
            this.MySQLPercentLabelX.Size = new System.Drawing.Size(42, 23);
            this.MySQLPercentLabelX.TabIndex = 5;
            this.MySQLPercentLabelX.Text = "0%";
            this.MySQLPercentLabelX.Visible = false;
            // 
            // downloadProgressBar
            // 
            // 
            // 
            // 
            this.downloadProgressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.downloadProgressBar.Location = new System.Drawing.Point(78, 382);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(642, 48);
            this.downloadProgressBar.TabIndex = 4;
            this.downloadProgressBar.Visible = false;
            // 
            // downloadGitRepoButtonX
            // 
            this.downloadGitRepoButtonX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.downloadGitRepoButtonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadGitRepoButtonX.Location = new System.Drawing.Point(288, 177);
            this.downloadGitRepoButtonX.Name = "downloadGitRepoButtonX";
            this.downloadGitRepoButtonX.Size = new System.Drawing.Size(213, 68);
            this.downloadGitRepoButtonX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.downloadGitRepoButtonX.TabIndex = 3;
            this.downloadGitRepoButtonX.Text = "Download and Create Databases";
            // 
            // wizardPage7
            // 
            this.wizardPage7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage7.AntiAlias = false;
            this.wizardPage7.BackColor = System.Drawing.Color.Transparent;
            this.wizardPage7.Controls.Add(this.worldDBTextBox);
            this.wizardPage7.Controls.Add(this.charactersDBTextBox);
            this.wizardPage7.Controls.Add(this.authDBTextBox);
            this.wizardPage7.Controls.Add(this.MySQLWorldDBLabelX);
            this.wizardPage7.Controls.Add(this.MySQLCharDBLabelX);
            this.wizardPage7.Controls.Add(this.MySQLAuthDBLabelX);
            this.wizardPage7.Location = new System.Drawing.Point(7, 72);
            this.wizardPage7.Name = "wizardPage7";
            this.wizardPage7.PageTitle = "Existing TrinityCore Databases";
            this.wizardPage7.Size = new System.Drawing.Size(809, 502);
            // 
            // 
            // 
            this.wizardPage7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage7.TabIndex = 13;
            // 
            // worldDBTextBox
            // 
            this.worldDBTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.worldDBTextBox.Border.Class = "TextBoxBorder";
            this.worldDBTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.worldDBTextBox.ForeColor = System.Drawing.Color.White;
            this.worldDBTextBox.Location = new System.Drawing.Point(302, 266);
            this.worldDBTextBox.Name = "worldDBTextBox";
            this.worldDBTextBox.Size = new System.Drawing.Size(274, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.worldDBTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "e.g. world", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.worldDBTextBox.TabIndex = 39;
            // 
            // charactersDBTextBox
            // 
            this.charactersDBTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.charactersDBTextBox.Border.Class = "TextBoxBorder";
            this.charactersDBTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.charactersDBTextBox.ForeColor = System.Drawing.Color.White;
            this.charactersDBTextBox.Location = new System.Drawing.Point(302, 226);
            this.charactersDBTextBox.Name = "charactersDBTextBox";
            this.charactersDBTextBox.Size = new System.Drawing.Size(274, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.charactersDBTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "e.g. characters", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.charactersDBTextBox.TabIndex = 38;
            // 
            // authDBTextBox
            // 
            this.authDBTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.authDBTextBox.Border.Class = "TextBoxBorder";
            this.authDBTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.authDBTextBox.ForeColor = System.Drawing.Color.White;
            this.authDBTextBox.Location = new System.Drawing.Point(302, 185);
            this.authDBTextBox.Name = "authDBTextBox";
            this.authDBTextBox.Size = new System.Drawing.Size(274, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.authDBTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "e.g. auth", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.authDBTextBox.TabIndex = 37;
            // 
            // MySQLWorldDBLabelX
            // 
            // 
            // 
            // 
            this.MySQLWorldDBLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLWorldDBLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySQLWorldDBLabelX.Location = new System.Drawing.Point(227, 263);
            this.MySQLWorldDBLabelX.Name = "MySQLWorldDBLabelX";
            this.MySQLWorldDBLabelX.Size = new System.Drawing.Size(69, 23);
            this.MySQLWorldDBLabelX.TabIndex = 36;
            this.MySQLWorldDBLabelX.Text = "World DB";
            // 
            // MySQLCharDBLabelX
            // 
            // 
            // 
            // 
            this.MySQLCharDBLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLCharDBLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySQLCharDBLabelX.Location = new System.Drawing.Point(194, 222);
            this.MySQLCharDBLabelX.Name = "MySQLCharDBLabelX";
            this.MySQLCharDBLabelX.Size = new System.Drawing.Size(102, 23);
            this.MySQLCharDBLabelX.TabIndex = 34;
            this.MySQLCharDBLabelX.Text = "Characters DB";
            // 
            // MySQLAuthDBLabelX
            // 
            // 
            // 
            // 
            this.MySQLAuthDBLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLAuthDBLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySQLAuthDBLabelX.Location = new System.Drawing.Point(237, 182);
            this.MySQLAuthDBLabelX.Name = "MySQLAuthDBLabelX";
            this.MySQLAuthDBLabelX.Size = new System.Drawing.Size(59, 23);
            this.MySQLAuthDBLabelX.TabIndex = 32;
            this.MySQLAuthDBLabelX.Text = "Auth DB";
            // 
            // setupSuperTooltip
            // 
            this.setupSuperTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // remoteCheckBox
            // 
            // 
            // 
            // 
            this.remoteCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.remoteCheckBox.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.remoteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.remoteCheckBox.Location = new System.Drawing.Point(366, 248);
            this.remoteCheckBox.Name = "remoteCheckBox";
            this.remoteCheckBox.Size = new System.Drawing.Size(86, 23);
            this.remoteCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.remoteCheckBox.TabIndex = 3;
            this.remoteCheckBox.Text = "Remotely";
            // 
            // localCheckBox
            // 
            // 
            // 
            // 
            this.localCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.localCheckBox.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.localCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.localCheckBox.Location = new System.Drawing.Point(366, 297);
            this.localCheckBox.Name = "localCheckBox";
            this.localCheckBox.Size = new System.Drawing.Size(86, 23);
            this.localCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.localCheckBox.TabIndex = 4;
            this.localCheckBox.Text = "Locally";
            // 
            // autoConnectCheckBox
            // 
            // 
            // 
            // 
            this.autoConnectCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.autoConnectCheckBox.Location = new System.Drawing.Point(367, 333);
            this.autoConnectCheckBox.Name = "autoConnectCheckBox";
            this.autoConnectCheckBox.Size = new System.Drawing.Size(100, 23);
            this.autoConnectCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.autoConnectCheckBox.TabIndex = 32;
            this.autoConnectCheckBox.Text = "Auto Connect";
            // 
            // wizardPage8
            // 
            this.wizardPage8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage8.AntiAlias = false;
            this.wizardPage8.BackColor = System.Drawing.Color.Transparent;
            this.wizardPage8.Controls.Add(this.labelX4);
            this.wizardPage8.Location = new System.Drawing.Point(7, 72);
            this.wizardPage8.Name = "wizardPage8";
            this.wizardPage8.PageTitle = "Setup Done";
            this.wizardPage8.Size = new System.Drawing.Size(809, 502);
            // 
            // 
            // 
            this.wizardPage8.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage8.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage8.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage8.TabIndex = 14;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelX4.Location = new System.Drawing.Point(179, 221);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(467, 27);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "You have successfully completed your server setup.";
            // 
            // SetupWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 632);
            this.Controls.Add(this.wizard1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(839, 670);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(839, 670);
            this.Name = "SetupWizard";
            this.Text = "Setup Wizard";
            this.wizard1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage2.ResumeLayout(false);
            this.wizardPage3.ResumeLayout(false);
            this.wizardPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portIntegerInput)).EndInit();
            this.wizardPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MySQLIntegerInputX)).EndInit();
            this.wizardPage6.ResumeLayout(false);
            this.wizardPage7.ResumeLayout(false);
            this.wizardPage8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Wizard wizard1;
        private DevComponents.DotNetBar.WizardPage wizardPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.WizardPage wizardPage2;
        private DevComponents.DotNetBar.LabelX typeLabel;
        private DevComponents.DotNetBar.WizardPage wizardPage3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX folderTextBox;
        private DevComponents.DotNetBar.ButtonX browseButton;
        private DevComponents.DotNetBar.Controls.TextBoxX hostTextBox;
        private DevComponents.DotNetBar.WizardPage wizardPage4;
        private DevComponents.DotNetBar.Controls.TextBoxX passwordTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX usernameTextBox;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX raInfoLabelX;
        private DevComponents.DotNetBar.LabelX passwordLabelX;
        private DevComponents.DotNetBar.LabelX usernameLabelX;
        private DevComponents.Editors.IntegerInput portIntegerInput;
        private DevComponents.DotNetBar.LabelX portLabelX;
        private DevComponents.DotNetBar.LabelX hostLabelX;
        private DevComponents.DotNetBar.SuperTooltip setupSuperTooltip;
        private DevComponents.DotNetBar.WizardPage wizardPage5;
        private DevComponents.DotNetBar.Controls.ProgressBarX mySqlConnectionProgressBar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx dbTypeComboBox;
        private DevComponents.Editors.ComboItem newDBComboItem;
        private DevComponents.Editors.ComboItem existDBComboItem;
        private DevComponents.DotNetBar.LabelX MySQLPasswordLabelX;
        private DevComponents.DotNetBar.LabelX MySQLUsernameLabelX;
        private DevComponents.DotNetBar.LabelX MySQLSettingsLabelX;
        private DevComponents.Editors.IntegerInput MySQLIntegerInputX;
        private DevComponents.DotNetBar.LabelX MySQLPortLabelX;
        private DevComponents.DotNetBar.LabelX MySQLHostLabelX;
        private DevComponents.DotNetBar.Controls.TextBoxX mySqlPassTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX mySqlUsernameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX mySqlHostTextBox;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.WizardPage wizardPage6;
        private DevComponents.DotNetBar.LabelX MySQLPercentLabelX;
        private DevComponents.DotNetBar.Controls.ProgressBarX downloadProgressBar;
        private DevComponents.DotNetBar.ButtonX downloadGitRepoButtonX;
        private DevComponents.DotNetBar.WizardPage wizardPage7;
        private DevComponents.DotNetBar.Controls.TextBoxX worldDBTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX charactersDBTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX authDBTextBox;
        private DevComponents.DotNetBar.LabelX MySQLWorldDBLabelX;
        private DevComponents.DotNetBar.LabelX MySQLCharDBLabelX;
        private DevComponents.DotNetBar.LabelX MySQLAuthDBLabelX;
        private DevComponents.DotNetBar.Controls.CheckBoxX remoteCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX localCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX autoConnectCheckBox;
        private DevComponents.DotNetBar.WizardPage wizardPage8;
        private DevComponents.DotNetBar.LabelX labelX4;

    }
}