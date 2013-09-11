namespace TrinityCore_Manager
{
    partial class MainForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm2));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.homeRibbonTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.startButton = new System.Windows.Forms.RibbonButton();
            this.stopButton = new System.Windows.Forms.RibbonButton();
            this.openConfigButton = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.consoleTabPage = new System.Windows.Forms.TabPage();
            this.outputTabPage = new System.Windows.Forms.TabPage();
            this.ribbonTextBox1 = new System.Windows.Forms.RibbonTextBox();
            this.execCmdButton = new System.Windows.Forms.RibbonButton();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbVisible = false;
            this.ribbon1.Size = new System.Drawing.Size(1121, 179);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.homeRibbonTab);
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            // 
            // homeRibbonTab
            // 
            this.homeRibbonTab.Panels.Add(this.ribbonPanel1);
            this.homeRibbonTab.Text = "Server Management";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreEnabled = false;
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.startButton);
            this.ribbonPanel1.Items.Add(this.stopButton);
            this.ribbonPanel1.Items.Add(this.openConfigButton);
            this.ribbonPanel1.Text = "Server Panel";
            // 
            // startButton
            // 
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.startButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("startButton.SmallImage")));
            this.startButton.Text = "Start Server";
            // 
            // stopButton
            // 
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.stopButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("stopButton.SmallImage")));
            this.stopButton.Text = "Stop Server";
            // 
            // openConfigButton
            // 
            this.openConfigButton.Image = ((System.Drawing.Image)(resources.GetObject("openConfigButton.Image")));
            this.openConfigButton.MinimumSize = new System.Drawing.Size(150, 0);
            this.openConfigButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("openConfigButton.SmallImage")));
            this.openConfigButton.Text = "Open Config FIle";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Text = "Communications";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1113, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1113, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.consoleTabPage);
            this.mainTabControl.Controls.Add(this.outputTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 179);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1121, 526);
            this.mainTabControl.TabIndex = 1;
            // 
            // consoleTabPage
            // 
            this.consoleTabPage.Location = new System.Drawing.Point(4, 22);
            this.consoleTabPage.Name = "consoleTabPage";
            this.consoleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.consoleTabPage.Size = new System.Drawing.Size(1113, 500);
            this.consoleTabPage.TabIndex = 0;
            this.consoleTabPage.Text = "Console";
            this.consoleTabPage.UseVisualStyleBackColor = true;
            // 
            // outputTabPage
            // 
            this.outputTabPage.Location = new System.Drawing.Point(4, 22);
            this.outputTabPage.Name = "outputTabPage";
            this.outputTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.outputTabPage.Size = new System.Drawing.Size(1113, 500);
            this.outputTabPage.TabIndex = 1;
            this.outputTabPage.Text = "Output";
            this.outputTabPage.UseVisualStyleBackColor = true;
            // 
            // ribbonTextBox1
            // 
            this.ribbonTextBox1.Text = "";
            this.ribbonTextBox1.TextBoxText = "";
            this.ribbonTextBox1.TextBoxWidth = 300;
            // 
            // execCmdButton
            // 
            this.execCmdButton.Image = ((System.Drawing.Image)(resources.GetObject("execCmdButton.Image")));
            this.execCmdButton.MinimumSize = new System.Drawing.Size(150, 0);
            this.execCmdButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("execCmdButton.SmallImage")));
            this.execCmdButton.Text = "Execute Command";
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 705);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.ribbon1);
            this.Name = "MainForm2";
            this.Text = "MainForm2";
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab homeRibbonTab;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton startButton;
        private System.Windows.Forms.RibbonButton stopButton;
        private System.Windows.Forms.RibbonButton openConfigButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage consoleTabPage;
        private System.Windows.Forms.TabPage outputTabPage;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonTextBox ribbonTextBox1;
        private System.Windows.Forms.RibbonButton execCmdButton;
    }
}