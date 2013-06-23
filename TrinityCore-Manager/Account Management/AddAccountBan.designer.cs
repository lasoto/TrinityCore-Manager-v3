namespace TrinityCore_Manager
{
    partial class AddAccountBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountBan));
            this.accBanSuperTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.banButton = new DevComponents.DotNetBar.ButtonX();
            this.permanentBanCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.banTimeDateTimeInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.banReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.accListComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.accountAddBanLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.banTimeDateTimeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // accBanSuperTooltip
            // 
            this.accBanSuperTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // banButton
            // 
            this.banButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.banButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.banButton.Location = new System.Drawing.Point(282, 150);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(103, 33);
            this.banButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.banButton.TabIndex = 2;
            this.banButton.Text = "Ban!";
            this.banButton.TextColor = System.Drawing.Color.Tomato;
            this.banButton.Click += new System.EventHandler(this.banButton_Click);
            // 
            // permanentBanCheckBox
            // 
            // 
            // 
            // 
            this.permanentBanCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.permanentBanCheckBox.Location = new System.Drawing.Point(152, 115);
            this.permanentBanCheckBox.Name = "permanentBanCheckBox";
            this.permanentBanCheckBox.Size = new System.Drawing.Size(100, 23);
            this.permanentBanCheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.permanentBanCheckBox.TabIndex = 10;
            this.permanentBanCheckBox.Text = "Permanent Ban";
            this.permanentBanCheckBox.CheckedChanged += new System.EventHandler(this.permanentBanCheckBox_CheckedChanged);
            // 
            // banTimeDateTimeInput
            // 
            // 
            // 
            // 
            this.banTimeDateTimeInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.banTimeDateTimeInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.banTimeDateTimeInput.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.banTimeDateTimeInput.ButtonDropDown.Visible = true;
            this.banTimeDateTimeInput.CustomFormat = "yyyy-MM-dd hh:MM:ss";
            this.banTimeDateTimeInput.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.banTimeDateTimeInput.IsPopupCalendarOpen = false;
            this.banTimeDateTimeInput.Location = new System.Drawing.Point(116, 47);
            // 
            // 
            // 
            this.banTimeDateTimeInput.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.banTimeDateTimeInput.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.banTimeDateTimeInput.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.banTimeDateTimeInput.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.banTimeDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.banTimeDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.banTimeDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.banTimeDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.banTimeDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.banTimeDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.banTimeDateTimeInput.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.banTimeDateTimeInput.MonthCalendar.DisplayMonth = new System.DateTime(2013, 6, 1, 0, 0, 0, 0);
            this.banTimeDateTimeInput.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.banTimeDateTimeInput.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.banTimeDateTimeInput.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.banTimeDateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.banTimeDateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.banTimeDateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.banTimeDateTimeInput.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.banTimeDateTimeInput.MonthCalendar.TodayButtonVisible = true;
            this.banTimeDateTimeInput.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.banTimeDateTimeInput.Name = "banTimeDateTimeInput";
            this.banTimeDateTimeInput.Size = new System.Drawing.Size(224, 20);
            this.banTimeDateTimeInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.banTimeDateTimeInput.TabIndex = 9;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX2.Location = new System.Drawing.Point(34, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(76, 26);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Ban Time:";
            // 
            // banReasonTextBox
            // 
            this.banReasonTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.banReasonTextBox.Border.Class = "TextBoxBorder";
            this.banReasonTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.banReasonTextBox.ForeColor = System.Drawing.Color.White;
            this.banReasonTextBox.Location = new System.Drawing.Point(116, 79);
            this.banReasonTextBox.Name = "banReasonTextBox";
            this.banReasonTextBox.Size = new System.Drawing.Size(224, 20);
            this.accBanSuperTooltip.SetSuperTooltip(this.banReasonTextBox, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "Reason for banning this Account. It will get stored in the \'banreason\' column, in" +
            " the \'account_banned\' table.", null, null, DevComponents.DotNetBar.eTooltipColor.Blue, false, false, new System.Drawing.Size(0, 0)));
            this.banReasonTextBox.TabIndex = 7;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(16, 74);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 26);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Ban Reason:";
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(12, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 33);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // accListComboBox
            // 
            this.accListComboBox.DisplayMember = "Text";
            this.accListComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.accListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accListComboBox.ForeColor = System.Drawing.Color.White;
            this.accListComboBox.FormattingEnabled = true;
            this.accListComboBox.ItemHeight = 14;
            this.accListComboBox.Location = new System.Drawing.Point(116, 12);
            this.accListComboBox.Name = "accListComboBox";
            this.accListComboBox.Size = new System.Drawing.Size(224, 20);
            this.accListComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.accListComboBox.TabIndex = 1;
            // 
            // accountAddBanLabel
            // 
            // 
            // 
            // 
            this.accountAddBanLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.accountAddBanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.accountAddBanLabel.Location = new System.Drawing.Point(44, 10);
            this.accountAddBanLabel.Name = "accountAddBanLabel";
            this.accountAddBanLabel.Size = new System.Drawing.Size(66, 22);
            this.accountAddBanLabel.TabIndex = 0;
            this.accountAddBanLabel.Text = "Account:";
            // 
            // AddAccountBan
            // 
            this.AcceptButton = this.banButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 194);
            this.Controls.Add(this.permanentBanCheckBox);
            this.Controls.Add(this.banTimeDateTimeInput);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.banReasonTextBox);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.accListComboBox);
            this.Controls.Add(this.accountAddBanLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 233);
            this.Name = "AddAccountBan";
            this.Text = "Add Account Ban";
            this.Load += new System.EventHandler(this.AddAccountBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banTimeDateTimeInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX accountAddBanLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx accListComboBox;
        private DevComponents.DotNetBar.ButtonX banButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.Controls.TextBoxX banReasonTextBox;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.SuperTooltip accBanSuperTooltip;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput banTimeDateTimeInput;
        private DevComponents.DotNetBar.Controls.CheckBoxX permanentBanCheckBox;
    }
}