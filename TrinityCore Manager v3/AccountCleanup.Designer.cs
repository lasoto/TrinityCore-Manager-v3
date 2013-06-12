namespace TrinityCore_Manager_v3
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.deleteAccountsDateTimeInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.createButton = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAccountsDateTimeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(156, 77);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(193, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Delete Accounts Older Then";
            // 
            // deleteAccountsDateTimeInput
            // 
            // 
            // 
            // 
            this.deleteAccountsDateTimeInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.deleteAccountsDateTimeInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.deleteAccountsDateTimeInput.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.deleteAccountsDateTimeInput.ButtonDropDown.Visible = true;
            this.deleteAccountsDateTimeInput.IsPopupCalendarOpen = false;
            this.deleteAccountsDateTimeInput.Location = new System.Drawing.Point(156, 125);
            // 
            // 
            // 
            this.deleteAccountsDateTimeInput.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.deleteAccountsDateTimeInput.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.deleteAccountsDateTimeInput.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.deleteAccountsDateTimeInput.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.deleteAccountsDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.deleteAccountsDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.deleteAccountsDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.deleteAccountsDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.deleteAccountsDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.deleteAccountsDateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.deleteAccountsDateTimeInput.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.deleteAccountsDateTimeInput.MonthCalendar.DisplayMonth = new System.DateTime(2013, 6, 1, 0, 0, 0, 0);
            this.deleteAccountsDateTimeInput.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.deleteAccountsDateTimeInput.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.deleteAccountsDateTimeInput.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.deleteAccountsDateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.deleteAccountsDateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.deleteAccountsDateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.deleteAccountsDateTimeInput.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.deleteAccountsDateTimeInput.MonthCalendar.TodayButtonVisible = true;
            this.deleteAccountsDateTimeInput.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.deleteAccountsDateTimeInput.Name = "deleteAccountsDateTimeInput";
            this.deleteAccountsDateTimeInput.Size = new System.Drawing.Size(193, 20);
            this.deleteAccountsDateTimeInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.deleteAccountsDateTimeInput.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(6, 216);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 35);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            // 
            // createButton
            // 
            this.createButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.createButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.createButton.Location = new System.Drawing.Point(384, 216);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(106, 35);
            this.createButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Delete";
            this.createButton.TextColor = System.Drawing.Color.Chartreuse;
            // 
            // AccountCleanup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 263);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.deleteAccountsDateTimeInput);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountCleanup";
            this.Text = "Database Account Cleanup";
            ((System.ComponentModel.ISupportInitialize)(this.deleteAccountsDateTimeInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput deleteAccountsDateTimeInput;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.ButtonX createButton;
    }
}