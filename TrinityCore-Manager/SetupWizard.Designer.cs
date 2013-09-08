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
            this.welcomePage = new DevComponents.DotNetBar.WizardPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectOptionPage = new DevComponents.DotNetBar.WizardPage();
            this.localCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.remoteCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.typeLabel = new DevComponents.DotNetBar.LabelX();
            this.trinitySFolderPage = new DevComponents.DotNetBar.WizardPage();
            this.browseButton = new DevComponents.DotNetBar.ButtonX();
            this.folderTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.raDetailsPage = new DevComponents.DotNetBar.WizardPage();
            this.autoConnectCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
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
            this.mysqlDetailsPage = new DevComponents.DotNetBar.WizardPage();
            this.mySqlPassTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.mySqlUsernameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.mySqlHostTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.mySqlConnectionProgressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.MySQLPasswordLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLUsernameLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLSettingsLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLIntegerInputX = new DevComponents.Editors.IntegerInput();
            this.MySQLPortLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLHostLabelX = new DevComponents.DotNetBar.LabelX();
            this.createDBsPage = new DevComponents.DotNetBar.WizardPage();
            this.MySQLPercentLabelX = new DevComponents.DotNetBar.LabelX();
            this.downloadProgressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.downloadCreateDBButton = new DevComponents.DotNetBar.ButtonX();
            this.dbDetailsPage = new DevComponents.DotNetBar.WizardPage();
            this.worldDBTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.charactersDBTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.authDBTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.MySQLWorldDBLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLCharDBLabelX = new DevComponents.DotNetBar.LabelX();
            this.MySQLAuthDBLabelX = new DevComponents.DotNetBar.LabelX();
            this.serverCompletedPage = new DevComponents.DotNetBar.WizardPage();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.setupSuperTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.mySqlConnectionProgressBar2 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.downloadProgressBar2 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.wizard1.SuspendLayout();
            this.welcomePage.SuspendLayout();
            this.connectOptionPage.SuspendLayout();
            this.trinitySFolderPage.SuspendLayout();
            this.raDetailsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portIntegerInput)).BeginInit();
            this.mysqlDetailsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MySQLIntegerInputX)).BeginInit();
            this.createDBsPage.SuspendLayout();
            this.dbDetailsPage.SuspendLayout();
            this.serverCompletedPage.SuspendLayout();
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
            this.wizard1.FormCancelButton = DevComponents.DotNetBar.eWizardFormCancelButton.None;
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
            this.wizard1.Size = new System.Drawing.Size(737, 392);
            this.wizard1.TabIndex = 0;
            this.wizard1.WizardPages.AddRange(new DevComponents.DotNetBar.WizardPage[] {
            this.welcomePage,
            this.connectOptionPage,
            this.trinitySFolderPage,
            this.raDetailsPage,
            this.mysqlDetailsPage,
            this.createDBsPage,
            this.dbDetailsPage,
            this.serverCompletedPage});
            this.wizard1.FinishButtonClick += new System.ComponentModel.CancelEventHandler(this.wizard1_FinishButtonClick);
            this.wizard1.CancelButtonClick += new System.ComponentModel.CancelEventHandler(this.wizard1_CancelButtonClick);
            this.wizard1.WizardPageChanging += new DevComponents.DotNetBar.WizardCancelPageChangeEventHandler(this.wizard1_WizardPageChanging);
            // 
            // welcomePage
            // 
            this.welcomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomePage.BackColor = System.Drawing.Color.White;
            this.welcomePage.Controls.Add(this.label1);
            this.welcomePage.Controls.Add(this.label2);
            this.welcomePage.Controls.Add(this.label3);
            this.welcomePage.InteriorPage = false;
            this.welcomePage.Location = new System.Drawing.Point(0, 0);
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.Size = new System.Drawing.Size(737, 346);
            // 
            // 
            // 
            this.welcomePage.Style.BackColor = System.Drawing.Color.White;
            this.welcomePage.Style.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomePage.Style.BackgroundImage")));
            this.welcomePage.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft;
            this.welcomePage.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.welcomePage.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.welcomePage.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.welcomePage.TabIndex = 7;
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
            this.label1.Size = new System.Drawing.Size(513, 66);
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
            this.label2.Size = new System.Drawing.Size(512, 214);
            this.label2.TabIndex = 1;
            this.label2.Text = "This wizard will guide you through the process of setting a server environment fo" +
    "r TrinityCore Manager v 3.0\r\n\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(210, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To continue, click Next.";
            // 
            // connectOptionPage
            // 
            this.connectOptionPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectOptionPage.AntiAlias = false;
            this.connectOptionPage.BackColor = System.Drawing.Color.Transparent;
            this.connectOptionPage.Controls.Add(this.localCheckBox);
            this.connectOptionPage.Controls.Add(this.remoteCheckBox);
            this.connectOptionPage.Controls.Add(this.typeLabel);
            this.connectOptionPage.Location = new System.Drawing.Point(7, 72);
            this.connectOptionPage.Name = "connectOptionPage";
            this.connectOptionPage.PageTitle = "Initial Setting";
            this.connectOptionPage.Size = new System.Drawing.Size(723, 262);
            // 
            // 
            // 
            this.connectOptionPage.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.connectOptionPage.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.connectOptionPage.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.connectOptionPage.TabIndex = 8;
            // 
            // localCheckBox
            // 
            // 
            // 
            // 
            this.localCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.localCheckBox.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.localCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.localCheckBox.Location = new System.Drawing.Point(313, 170);
            this.localCheckBox.Name = "localCheckBox";
            this.localCheckBox.Size = new System.Drawing.Size(86, 23);
            this.localCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.localCheckBox.TabIndex = 4;
            this.localCheckBox.Text = "Locally";
            // 
            // remoteCheckBox
            // 
            // 
            // 
            // 
            this.remoteCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.remoteCheckBox.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.remoteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.remoteCheckBox.Location = new System.Drawing.Point(313, 121);
            this.remoteCheckBox.Name = "remoteCheckBox";
            this.remoteCheckBox.Size = new System.Drawing.Size(86, 23);
            this.remoteCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.remoteCheckBox.TabIndex = 3;
            this.remoteCheckBox.Text = "Remotely";
            // 
            // typeLabel
            // 
            // 
            // 
            // 
            this.typeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.typeLabel.Location = new System.Drawing.Point(171, 49);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(387, 20);
            this.typeLabel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "How would you like to connect to your TrinityCore server?";
            // 
            // trinitySFolderPage
            // 
            this.trinitySFolderPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trinitySFolderPage.AntiAlias = false;
            this.trinitySFolderPage.BackColor = System.Drawing.Color.Transparent;
            this.trinitySFolderPage.Controls.Add(this.browseButton);
            this.trinitySFolderPage.Controls.Add(this.folderTextBox);
            this.trinitySFolderPage.Controls.Add(this.labelX1);
            this.trinitySFolderPage.Location = new System.Drawing.Point(7, 72);
            this.trinitySFolderPage.Name = "trinitySFolderPage";
            this.trinitySFolderPage.PageTitle = "Local Setup";
            this.trinitySFolderPage.Size = new System.Drawing.Size(723, 262);
            // 
            // 
            // 
            this.trinitySFolderPage.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.trinitySFolderPage.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.trinitySFolderPage.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.trinitySFolderPage.TabIndex = 9;
            // 
            // browseButton
            // 
            this.browseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.browseButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.browseButton.Location = new System.Drawing.Point(318, 153);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(101, 36);
            this.browseButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse for folder";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // folderTextBox
            // 
            this.folderTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.folderTextBox.Border.Class = "TextBoxBorder";
            this.folderTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.folderTextBox.ForeColor = System.Drawing.Color.White;
            this.folderTextBox.Location = new System.Drawing.Point(165, 113);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.ReadOnly = true;
            this.folderTextBox.Size = new System.Drawing.Size(413, 20);
            this.folderTextBox.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(226, 74);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(293, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Please locate your TrinityCore server folder (the folder containing the executabl" +
    "es).";
            // 
            // raDetailsPage
            // 
            this.raDetailsPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.raDetailsPage.AntiAlias = false;
            this.raDetailsPage.BackColor = System.Drawing.Color.Transparent;
            this.raDetailsPage.Controls.Add(this.autoConnectCheckBox);
            this.raDetailsPage.Controls.Add(this.passwordTextBox);
            this.raDetailsPage.Controls.Add(this.usernameTextBox);
            this.raDetailsPage.Controls.Add(this.hostTextBox);
            this.raDetailsPage.Controls.Add(this.labelX2);
            this.raDetailsPage.Controls.Add(this.raInfoLabelX);
            this.raDetailsPage.Controls.Add(this.passwordLabelX);
            this.raDetailsPage.Controls.Add(this.usernameLabelX);
            this.raDetailsPage.Controls.Add(this.portIntegerInput);
            this.raDetailsPage.Controls.Add(this.portLabelX);
            this.raDetailsPage.Controls.Add(this.hostLabelX);
            this.raDetailsPage.Location = new System.Drawing.Point(7, 72);
            this.raDetailsPage.Name = "raDetailsPage";
            this.raDetailsPage.PageTitle = "Remote Access Setup";
            this.raDetailsPage.Size = new System.Drawing.Size(723, 262);
            // 
            // 
            // 
            this.raDetailsPage.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.raDetailsPage.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.raDetailsPage.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.raDetailsPage.TabIndex = 10;
            // 
            // autoConnectCheckBox
            // 
            // 
            // 
            // 
            this.autoConnectCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.autoConnectCheckBox.Location = new System.Drawing.Point(397, 203);
            this.autoConnectCheckBox.Name = "autoConnectCheckBox";
            this.autoConnectCheckBox.Size = new System.Drawing.Size(100, 23);
            this.autoConnectCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.autoConnectCheckBox.TabIndex = 32;
            this.autoConnectCheckBox.Text = "Auto Connect";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.passwordTextBox.Border.Class = "TextBoxBorder";
            this.passwordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(274, 177);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(210, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.passwordTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Account password", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.usernameTextBox.Border.Class = "TextBoxBorder";
            this.usernameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(274, 137);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(208, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.usernameTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Account username", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.usernameTextBox.TabIndex = 3;
            // 
            // hostTextBox
            // 
            this.hostTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.hostTextBox.Border.Class = "TextBoxBorder";
            this.hostTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hostTextBox.ForeColor = System.Drawing.Color.White;
            this.hostTextBox.Location = new System.Drawing.Point(272, 42);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(210, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.hostTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "e.g. server.examplename.com", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.hostTextBox.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(168, 238);
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
            this.raInfoLabelX.Location = new System.Drawing.Point(199, 0);
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
            this.passwordLabelX.Location = new System.Drawing.Point(199, 173);
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
            this.usernameLabelX.Location = new System.Drawing.Point(197, 133);
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
            this.portIntegerInput.Location = new System.Drawing.Point(272, 89);
            this.portIntegerInput.MinValue = 0;
            this.portIntegerInput.Name = "portIntegerInput";
            this.portIntegerInput.ShowUpDown = true;
            this.portIntegerInput.Size = new System.Drawing.Size(80, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.portIntegerInput, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Default: 3443", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.portIntegerInput.TabIndex = 2;
            this.portIntegerInput.Value = 3443;
            // 
            // portLabelX
            // 
            // 
            // 
            // 
            this.portLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.portLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabelX.Location = new System.Drawing.Point(239, 86);
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
            this.hostLabelX.Location = new System.Drawing.Point(230, 38);
            this.hostLabelX.Name = "hostLabelX";
            this.hostLabelX.Size = new System.Drawing.Size(38, 23);
            this.hostLabelX.TabIndex = 15;
            this.hostLabelX.Text = "Host";
            // 
            // mysqlDetailsPage
            // 
            this.mysqlDetailsPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mysqlDetailsPage.AntiAlias = false;
            this.mysqlDetailsPage.BackColor = System.Drawing.Color.Transparent;
            this.mysqlDetailsPage.Controls.Add(this.mySqlConnectionProgressBar2);
            this.mysqlDetailsPage.Controls.Add(this.mySqlPassTextBox);
            this.mysqlDetailsPage.Controls.Add(this.mySqlUsernameTextBox);
            this.mysqlDetailsPage.Controls.Add(this.mySqlHostTextBox);
            this.mysqlDetailsPage.Controls.Add(this.mySqlConnectionProgressBar);
            this.mysqlDetailsPage.Controls.Add(this.MySQLPasswordLabelX);
            this.mysqlDetailsPage.Controls.Add(this.MySQLUsernameLabelX);
            this.mysqlDetailsPage.Controls.Add(this.MySQLSettingsLabelX);
            this.mysqlDetailsPage.Controls.Add(this.MySQLIntegerInputX);
            this.mysqlDetailsPage.Controls.Add(this.MySQLPortLabelX);
            this.mysqlDetailsPage.Controls.Add(this.MySQLHostLabelX);
            this.mysqlDetailsPage.Location = new System.Drawing.Point(7, 72);
            this.mysqlDetailsPage.Name = "mysqlDetailsPage";
            this.mysqlDetailsPage.PageTitle = "MySQL Settings";
            this.mysqlDetailsPage.Size = new System.Drawing.Size(723, 262);
            // 
            // 
            // 
            this.mysqlDetailsPage.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mysqlDetailsPage.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.mysqlDetailsPage.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mysqlDetailsPage.TabIndex = 11;
            this.mysqlDetailsPage.Click += new System.EventHandler(this.mysqlDetailsPage_Click);
            // 
            // mySqlPassTextBox
            // 
            this.mySqlPassTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.mySqlPassTextBox.Border.Class = "TextBoxBorder";
            this.mySqlPassTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mySqlPassTextBox.ForeColor = System.Drawing.Color.White;
            this.mySqlPassTextBox.Location = new System.Drawing.Point(280, 183);
            this.mySqlPassTextBox.Name = "mySqlPassTextBox";
            this.mySqlPassTextBox.Size = new System.Drawing.Size(213, 20);
            this.mySqlPassTextBox.TabIndex = 4;
            this.mySqlPassTextBox.UseSystemPasswordChar = true;
            // 
            // mySqlUsernameTextBox
            // 
            this.mySqlUsernameTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.mySqlUsernameTextBox.Border.Class = "TextBoxBorder";
            this.mySqlUsernameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mySqlUsernameTextBox.ForeColor = System.Drawing.Color.White;
            this.mySqlUsernameTextBox.Location = new System.Drawing.Point(280, 143);
            this.mySqlUsernameTextBox.Name = "mySqlUsernameTextBox";
            this.mySqlUsernameTextBox.Size = new System.Drawing.Size(213, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.mySqlUsernameTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Default: root", null, null, DevComponents.DotNetBar.eTooltipColor.Blue));
            this.mySqlUsernameTextBox.TabIndex = 3;
            // 
            // mySqlHostTextBox
            // 
            this.mySqlHostTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.mySqlHostTextBox.Border.Class = "TextBoxBorder";
            this.mySqlHostTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mySqlHostTextBox.ForeColor = System.Drawing.Color.White;
            this.mySqlHostTextBox.Location = new System.Drawing.Point(280, 53);
            this.mySqlHostTextBox.Name = "mySqlHostTextBox";
            this.mySqlHostTextBox.Size = new System.Drawing.Size(213, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.mySqlHostTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Default: localhost", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.mySqlHostTextBox.TabIndex = 1;
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
            // MySQLPasswordLabelX
            // 
            // 
            // 
            // 
            this.MySQLPasswordLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLPasswordLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySQLPasswordLabelX.Location = new System.Drawing.Point(205, 179);
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
            this.MySQLUsernameLabelX.Location = new System.Drawing.Point(203, 139);
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
            this.MySQLSettingsLabelX.Location = new System.Drawing.Point(253, -3);
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
            this.MySQLIntegerInputX.Location = new System.Drawing.Point(280, 99);
            this.MySQLIntegerInputX.MinValue = 0;
            this.MySQLIntegerInputX.Name = "MySQLIntegerInputX";
            this.MySQLIntegerInputX.ShowUpDown = true;
            this.MySQLIntegerInputX.Size = new System.Drawing.Size(80, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.MySQLIntegerInputX, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Default: 3306", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.MySQLIntegerInputX.TabIndex = 2;
            this.MySQLIntegerInputX.Value = 3306;
            // 
            // MySQLPortLabelX
            // 
            // 
            // 
            // 
            this.MySQLPortLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLPortLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MySQLPortLabelX.Location = new System.Drawing.Point(248, 97);
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
            this.MySQLHostLabelX.Location = new System.Drawing.Point(239, 51);
            this.MySQLHostLabelX.Name = "MySQLHostLabelX";
            this.MySQLHostLabelX.Size = new System.Drawing.Size(38, 23);
            this.MySQLHostLabelX.TabIndex = 23;
            this.MySQLHostLabelX.Text = "Host";
            // 
            // createDBsPage
            // 
            this.createDBsPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createDBsPage.AntiAlias = false;
            this.createDBsPage.BackColor = System.Drawing.Color.Transparent;
            this.createDBsPage.Controls.Add(this.downloadProgressBar2);
            this.createDBsPage.Controls.Add(this.MySQLPercentLabelX);
            this.createDBsPage.Controls.Add(this.downloadProgressBar);
            this.createDBsPage.Controls.Add(this.downloadCreateDBButton);
            this.createDBsPage.Location = new System.Drawing.Point(7, 72);
            this.createDBsPage.Name = "createDBsPage";
            this.createDBsPage.PageTitle = "TrinityCore Database Setup";
            this.createDBsPage.Size = new System.Drawing.Size(723, 262);
            // 
            // 
            // 
            this.createDBsPage.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.createDBsPage.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.createDBsPage.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.createDBsPage.TabIndex = 12;
            // 
            // MySQLPercentLabelX
            // 
            // 
            // 
            // 
            this.MySQLPercentLabelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MySQLPercentLabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MySQLPercentLabelX.Location = new System.Drawing.Point(398, 353);
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
            this.downloadProgressBar.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
            this.downloadProgressBar.Size = new System.Drawing.Size(642, 48);
            this.downloadProgressBar.TabIndex = 4;
            this.downloadProgressBar.Visible = false;
            // 
            // downloadCreateDBButton
            // 
            this.downloadCreateDBButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.downloadCreateDBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCreateDBButton.Location = new System.Drawing.Point(259, 91);
            this.downloadCreateDBButton.Name = "downloadCreateDBButton";
            this.downloadCreateDBButton.Size = new System.Drawing.Size(213, 68);
            this.downloadCreateDBButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.downloadCreateDBButton.TabIndex = 3;
            this.downloadCreateDBButton.Text = "Download and Create Databases";
            this.downloadCreateDBButton.Click += new System.EventHandler(this.downloadCreateDBButton_Click);
            // 
            // dbDetailsPage
            // 
            this.dbDetailsPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbDetailsPage.AntiAlias = false;
            this.dbDetailsPage.BackColor = System.Drawing.Color.Transparent;
            this.dbDetailsPage.Controls.Add(this.worldDBTextBox);
            this.dbDetailsPage.Controls.Add(this.charactersDBTextBox);
            this.dbDetailsPage.Controls.Add(this.authDBTextBox);
            this.dbDetailsPage.Controls.Add(this.MySQLWorldDBLabelX);
            this.dbDetailsPage.Controls.Add(this.MySQLCharDBLabelX);
            this.dbDetailsPage.Controls.Add(this.MySQLAuthDBLabelX);
            this.dbDetailsPage.Location = new System.Drawing.Point(7, 72);
            this.dbDetailsPage.Name = "dbDetailsPage";
            this.dbDetailsPage.PageTitle = "Existing TrinityCore Databases";
            this.dbDetailsPage.Size = new System.Drawing.Size(723, 262);
            // 
            // 
            // 
            this.dbDetailsPage.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dbDetailsPage.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dbDetailsPage.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dbDetailsPage.TabIndex = 13;
            // 
            // worldDBTextBox
            // 
            this.worldDBTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.worldDBTextBox.Border.Class = "TextBoxBorder";
            this.worldDBTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.worldDBTextBox.ForeColor = System.Drawing.Color.White;
            this.worldDBTextBox.Location = new System.Drawing.Point(264, 152);
            this.worldDBTextBox.Name = "worldDBTextBox";
            this.worldDBTextBox.Size = new System.Drawing.Size(274, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.worldDBTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "e.g. world", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.worldDBTextBox.TabIndex = 39;
            // 
            // charactersDBTextBox
            // 
            this.charactersDBTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.charactersDBTextBox.Border.Class = "TextBoxBorder";
            this.charactersDBTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.charactersDBTextBox.ForeColor = System.Drawing.Color.White;
            this.charactersDBTextBox.Location = new System.Drawing.Point(264, 112);
            this.charactersDBTextBox.Name = "charactersDBTextBox";
            this.charactersDBTextBox.Size = new System.Drawing.Size(274, 20);
            this.setupSuperTooltip.SetSuperTooltip(this.charactersDBTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "e.g. characters", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.charactersDBTextBox.TabIndex = 38;
            // 
            // authDBTextBox
            // 
            this.authDBTextBox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.authDBTextBox.Border.Class = "TextBoxBorder";
            this.authDBTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.authDBTextBox.ForeColor = System.Drawing.Color.White;
            this.authDBTextBox.Location = new System.Drawing.Point(264, 71);
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
            this.MySQLWorldDBLabelX.Location = new System.Drawing.Point(189, 149);
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
            this.MySQLCharDBLabelX.Location = new System.Drawing.Point(156, 108);
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
            this.MySQLAuthDBLabelX.Location = new System.Drawing.Point(199, 68);
            this.MySQLAuthDBLabelX.Name = "MySQLAuthDBLabelX";
            this.MySQLAuthDBLabelX.Size = new System.Drawing.Size(59, 23);
            this.MySQLAuthDBLabelX.TabIndex = 32;
            this.MySQLAuthDBLabelX.Text = "Auth DB";
            // 
            // serverCompletedPage
            // 
            this.serverCompletedPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverCompletedPage.AntiAlias = false;
            this.serverCompletedPage.BackColor = System.Drawing.Color.Transparent;
            this.serverCompletedPage.Controls.Add(this.labelX4);
            this.serverCompletedPage.Location = new System.Drawing.Point(7, 72);
            this.serverCompletedPage.Name = "serverCompletedPage";
            this.serverCompletedPage.PageTitle = "Setup Done";
            this.serverCompletedPage.Size = new System.Drawing.Size(723, 262);
            // 
            // 
            // 
            this.serverCompletedPage.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.serverCompletedPage.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.serverCompletedPage.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.serverCompletedPage.TabIndex = 14;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelX4.Location = new System.Drawing.Point(133, 103);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(467, 27);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "You have successfully completed your server setup.";
            // 
            // setupSuperTooltip
            // 
            this.setupSuperTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // mySqlConnectionProgressBar2
            // 
            // 
            // 
            // 
            this.mySqlConnectionProgressBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mySqlConnectionProgressBar2.Location = new System.Drawing.Point(84, 223);
            this.mySqlConnectionProgressBar2.Name = "mySqlConnectionProgressBar2";
            this.mySqlConnectionProgressBar2.Size = new System.Drawing.Size(553, 36);
            this.mySqlConnectionProgressBar2.TabIndex = 32;
            this.mySqlConnectionProgressBar2.Text = "progressBarX1";
            this.mySqlConnectionProgressBar2.Visible = false;
            // 
            // downloadProgressBar2
            // 
            // 
            // 
            // 
            this.downloadProgressBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.downloadProgressBar2.Location = new System.Drawing.Point(78, 217);
            this.downloadProgressBar2.Name = "downloadProgressBar2";
            this.downloadProgressBar2.Size = new System.Drawing.Size(563, 42);
            this.downloadProgressBar2.TabIndex = 6;
            this.downloadProgressBar2.Text = "progressBarX1";
            this.downloadProgressBar2.Visible = false;
            // 
            // SetupWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 392);
            this.Controls.Add(this.wizard1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupWizard";
            this.Text = "Setup Wizard";
            this.Load += new System.EventHandler(this.SetupWizard_Load);
            this.wizard1.ResumeLayout(false);
            this.welcomePage.ResumeLayout(false);
            this.connectOptionPage.ResumeLayout(false);
            this.trinitySFolderPage.ResumeLayout(false);
            this.raDetailsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portIntegerInput)).EndInit();
            this.mysqlDetailsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MySQLIntegerInputX)).EndInit();
            this.createDBsPage.ResumeLayout(false);
            this.dbDetailsPage.ResumeLayout(false);
            this.serverCompletedPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Wizard wizard1;
        private DevComponents.DotNetBar.WizardPage welcomePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.WizardPage connectOptionPage;
        private DevComponents.DotNetBar.LabelX typeLabel;
        private DevComponents.DotNetBar.WizardPage trinitySFolderPage;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX folderTextBox;
        private DevComponents.DotNetBar.ButtonX browseButton;
        private DevComponents.DotNetBar.Controls.TextBoxX hostTextBox;
        private DevComponents.DotNetBar.WizardPage raDetailsPage;
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
        private DevComponents.DotNetBar.WizardPage mysqlDetailsPage;
        private DevComponents.DotNetBar.Controls.ProgressBarX mySqlConnectionProgressBar;
        private DevComponents.DotNetBar.LabelX MySQLPasswordLabelX;
        private DevComponents.DotNetBar.LabelX MySQLUsernameLabelX;
        private DevComponents.DotNetBar.LabelX MySQLSettingsLabelX;
        private DevComponents.Editors.IntegerInput MySQLIntegerInputX;
        private DevComponents.DotNetBar.LabelX MySQLPortLabelX;
        private DevComponents.DotNetBar.LabelX MySQLHostLabelX;
        private DevComponents.DotNetBar.Controls.TextBoxX mySqlPassTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX mySqlUsernameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX mySqlHostTextBox;
        private DevComponents.DotNetBar.WizardPage createDBsPage;
        private DevComponents.DotNetBar.LabelX MySQLPercentLabelX;
        private DevComponents.DotNetBar.ButtonX downloadCreateDBButton;
        private DevComponents.DotNetBar.WizardPage dbDetailsPage;
        private DevComponents.DotNetBar.Controls.TextBoxX worldDBTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX charactersDBTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX authDBTextBox;
        private DevComponents.DotNetBar.LabelX MySQLWorldDBLabelX;
        private DevComponents.DotNetBar.LabelX MySQLCharDBLabelX;
        private DevComponents.DotNetBar.LabelX MySQLAuthDBLabelX;
        private DevComponents.DotNetBar.Controls.CheckBoxX remoteCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX localCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX autoConnectCheckBox;
        private DevComponents.DotNetBar.WizardPage serverCompletedPage;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ProgressBarX downloadProgressBar;
        private DevComponents.DotNetBar.Controls.ProgressBarX mySqlConnectionProgressBar2;
        private DevComponents.DotNetBar.Controls.ProgressBarX downloadProgressBar2;

    }
}