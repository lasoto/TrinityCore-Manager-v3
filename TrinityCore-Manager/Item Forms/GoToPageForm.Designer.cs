namespace TrinityCore_Manager.Item_Forms
{
    partial class GoToPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoToPageForm));
            this.textBoxXNewPage = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // textBoxXNewPage
            // 
            this.textBoxXNewPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.textBoxXNewPage.Border.Class = "TextBoxBorder";
            this.textBoxXNewPage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxXNewPage.ForeColor = System.Drawing.Color.White;
            this.textBoxXNewPage.Location = new System.Drawing.Point(8, 12);
            this.textBoxXNewPage.Name = "textBoxXNewPage";
            this.textBoxXNewPage.Size = new System.Drawing.Size(107, 20);
            this.textBoxXNewPage.TabIndex = 0;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(121, 12);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(38, 20);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "Done";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // GoToPageForm
            // 
            this.ClientSize = new System.Drawing.Size(165, 43);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.textBoxXNewPage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToPageForm";
            this.Text = "Navigate to page";
            this.Load += new System.EventHandler(this.GoToPageForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToPageForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.TextBoxX textBoxXNewPage;
        private DevComponents.DotNetBar.ButtonX buttonX1;

    }
}