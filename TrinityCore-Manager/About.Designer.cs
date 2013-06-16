namespace TrinityCore_Manager
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.aboutSuperTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Image = ((System.Drawing.Image)(resources.GetObject("labelX2.Image")));
            this.labelX2.Location = new System.Drawing.Point(12, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(140, 140);
            this.aboutSuperTooltip.SetSuperTooltip(this.labelX2, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "No! You may not have my cookie! Back off!", null, null, DevComponents.DotNetBar.eTooltipColor.Orange, false, false, new System.Drawing.Size(0, 0)));
            this.labelX2.TabIndex = 1;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Image = ((System.Drawing.Image)(resources.GetObject("labelX3.Image")));
            this.labelX3.Location = new System.Drawing.Point(163, 0);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(140, 140);
            this.aboutSuperTooltip.SetSuperTooltip(this.labelX3, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "\"Crazy ferret!!! What the heck are you doing?\"\r\n\r\nrawrawrawrawr..... I\'m gonna bi" +
            "te you!\r\n\r\n\"AAAaaaAAaaAa\"", null, null, DevComponents.DotNetBar.eTooltipColor.Red, false, false, new System.Drawing.Size(0, 0)));
            this.labelX3.TabIndex = 2;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX4.Location = new System.Drawing.Point(47, 146);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Mitch528";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX5.Location = new System.Drawing.Point(202, 146);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(66, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Hobbilis";
            // 
            // textBoxX1
            // 
            this.textBoxX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.ForeColor = System.Drawing.Color.White;
            this.textBoxX1.Location = new System.Drawing.Point(12, 175);
            this.textBoxX1.MaximumSize = new System.Drawing.Size(291, 131);
            this.textBoxX1.MinimumSize = new System.Drawing.Size(291, 131);
            this.textBoxX1.Multiline = true;
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.Size = new System.Drawing.Size(291, 131);
            this.textBoxX1.TabIndex = 5;
            this.textBoxX1.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.textBoxX1.WatermarkColor = System.Drawing.Color.Gray;
            this.textBoxX1.WatermarkText = resources.GetString("textBoxX1.WatermarkText");
            // 
            // aboutSuperTooltip
            // 
            this.aboutSuperTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 318);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(331, 356);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(331, 356);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.SuperTooltip aboutSuperTooltip;
    }
}