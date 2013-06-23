namespace TrinityCore_Manager
{
    partial class AccountCleanup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountCleanup));
            this.deleteAccOlderThenLabel = new DevComponents.DotNetBar.LabelX();
            this.dateTimeInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.deleteButton = new DevComponents.DotNetBar.ButtonX();
            this.timeInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteAccOlderThenLabel
            // 
            // 
            // 
            // 
            this.deleteAccOlderThenLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.deleteAccOlderThenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.deleteAccOlderThenLabel.Location = new System.Drawing.Point(106, 36);
            this.deleteAccOlderThenLabel.Name = "deleteAccOlderThenLabel";
            this.deleteAccOlderThenLabel.Size = new System.Drawing.Size(193, 23);
            this.deleteAccOlderThenLabel.TabIndex = 0;
            this.deleteAccOlderThenLabel.Text = "Delete Accounts Older Then";
            // 
            // dateTimeInput
            // 
            // 
            // 
            // 
            this.dateTimeInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput.ButtonDropDown.Visible = true;
            this.dateTimeInput.CustomFormat = "yyyy-MM-dd";
            this.dateTimeInput.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dateTimeInput.IsPopupCalendarOpen = false;
            this.dateTimeInput.Location = new System.Drawing.Point(106, 65);
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInput.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput.MonthCalendar.DisplayMonth = new System.DateTime(2013, 6, 1, 0, 0, 0, 0);
            this.dateTimeInput.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateTimeInput.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInput.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput.Name = "dateTimeInput";
            this.dateTimeInput.Size = new System.Drawing.Size(193, 20);
            this.dateTimeInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 148);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 35);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            // 
            // deleteButton
            // 
            this.deleteButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.deleteButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.deleteButton.Location = new System.Drawing.Point(279, 148);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(106, 35);
            this.deleteButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextColor = System.Drawing.Color.Chartreuse;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // timeInput
            // 
            // 
            // 
            // 
            this.timeInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.timeInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.timeInput.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.timeInput.ButtonDropDown.Visible = true;
            this.timeInput.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime;
            this.timeInput.IsPopupCalendarOpen = false;
            this.timeInput.Location = new System.Drawing.Point(106, 91);
            // 
            // 
            // 
            this.timeInput.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.timeInput.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.timeInput.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.timeInput.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.timeInput.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.timeInput.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.timeInput.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.timeInput.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.timeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.timeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.timeInput.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.timeInput.MonthCalendar.DisplayMonth = new System.DateTime(2013, 6, 1, 0, 0, 0, 0);
            this.timeInput.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.timeInput.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.timeInput.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.timeInput.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.timeInput.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.timeInput.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.timeInput.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.timeInput.MonthCalendar.TodayButtonVisible = true;
            this.timeInput.MonthCalendar.Visible = false;
            this.timeInput.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(193, 20);
            this.timeInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.timeInput.TabIndex = 6;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(61, 62);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(39, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Date:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX2.Location = new System.Drawing.Point(59, 88);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(41, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Time:";
            // 
            // AccountCleanup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 202);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dateTimeInput);
            this.Controls.Add(this.deleteAccOlderThenLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 233);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 233);
            this.Name = "AccountCleanup";
            this.Text = "Database Account Cleanup";
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX deleteAccOlderThenLabel;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX deleteButton;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput timeInput;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}