namespace TrinityCore_Manager
{
    partial class SendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMail));
            this.onlinePlayersLabel = new DevComponents.DotNetBar.LabelX();
            this.offlinePlayersLabel = new DevComponents.DotNetBar.LabelX();
            this.onlinePlayersComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.offlinePlayersComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itemToSendLabel = new DevComponents.DotNetBar.LabelX();
            this.itemIdIntegerInput = new DevComponents.Editors.IntegerInput();
            this.findItemButton = new DevComponents.DotNetBar.ButtonX();
            this.subjectLabel = new DevComponents.DotNetBar.LabelX();
            this.subjectTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.messageLabel = new DevComponents.DotNetBar.LabelX();
            this.moneyLabel = new DevComponents.DotNetBar.LabelX();
            this.goldIntegerInput = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.silverIntegerInput = new DevComponents.Editors.IntegerInput();
            this.copperIntegerInput = new DevComponents.Editors.IntegerInput();
            this.sendButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.itemIdIntegerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldIntegerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverIntegerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copperIntegerInput)).BeginInit();
            this.SuspendLayout();
            // 
            // onlinePlayersLabel
            // 
            // 
            // 
            // 
            this.onlinePlayersLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.onlinePlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.onlinePlayersLabel.Location = new System.Drawing.Point(34, 30);
            this.onlinePlayersLabel.Name = "onlinePlayersLabel";
            this.onlinePlayersLabel.Size = new System.Drawing.Size(104, 23);
            this.onlinePlayersLabel.TabIndex = 0;
            this.onlinePlayersLabel.Text = "Online Players:";
            // 
            // offlinePlayersLabel
            // 
            // 
            // 
            // 
            this.offlinePlayersLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.offlinePlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.offlinePlayersLabel.Location = new System.Drawing.Point(397, 30);
            this.offlinePlayersLabel.Name = "offlinePlayersLabel";
            this.offlinePlayersLabel.Size = new System.Drawing.Size(104, 23);
            this.offlinePlayersLabel.TabIndex = 1;
            this.offlinePlayersLabel.Text = "Offline Players:";
            // 
            // onlinePlayersComboBox
            // 
            this.onlinePlayersComboBox.DisplayMember = "Text";
            this.onlinePlayersComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.onlinePlayersComboBox.ForeColor = System.Drawing.Color.White;
            this.onlinePlayersComboBox.FormattingEnabled = true;
            this.onlinePlayersComboBox.ItemHeight = 14;
            this.onlinePlayersComboBox.Location = new System.Drawing.Point(144, 33);
            this.onlinePlayersComboBox.Name = "onlinePlayersComboBox";
            this.onlinePlayersComboBox.Size = new System.Drawing.Size(218, 20);
            this.onlinePlayersComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.onlinePlayersComboBox.TabIndex = 2;
            // 
            // offlinePlayersComboBox
            // 
            this.offlinePlayersComboBox.DisplayMember = "Text";
            this.offlinePlayersComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.offlinePlayersComboBox.ForeColor = System.Drawing.Color.White;
            this.offlinePlayersComboBox.FormattingEnabled = true;
            this.offlinePlayersComboBox.ItemHeight = 14;
            this.offlinePlayersComboBox.Location = new System.Drawing.Point(507, 33);
            this.offlinePlayersComboBox.Name = "offlinePlayersComboBox";
            this.offlinePlayersComboBox.Size = new System.Drawing.Size(218, 20);
            this.offlinePlayersComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.offlinePlayersComboBox.TabIndex = 3;
            // 
            // itemToSendLabel
            // 
            // 
            // 
            // 
            this.itemToSendLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemToSendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.itemToSendLabel.Location = new System.Drawing.Point(187, 96);
            this.itemToSendLabel.Name = "itemToSendLabel";
            this.itemToSendLabel.Size = new System.Drawing.Size(90, 23);
            this.itemToSendLabel.TabIndex = 4;
            this.itemToSendLabel.Text = "Item to send:";
            // 
            // itemIdIntegerInput
            // 
            // 
            // 
            // 
            this.itemIdIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itemIdIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemIdIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.itemIdIntegerInput.Location = new System.Drawing.Point(283, 99);
            this.itemIdIntegerInput.Name = "itemIdIntegerInput";
            this.itemIdIntegerInput.ShowUpDown = true;
            this.itemIdIntegerInput.Size = new System.Drawing.Size(218, 20);
            this.itemIdIntegerInput.TabIndex = 5;
            // 
            // findItemButton
            // 
            this.findItemButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.findItemButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.findItemButton.Location = new System.Drawing.Point(346, 125);
            this.findItemButton.Name = "findItemButton";
            this.findItemButton.Size = new System.Drawing.Size(75, 23);
            this.findItemButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.findItemButton.TabIndex = 6;
            this.findItemButton.Text = "Find Item";
            this.findItemButton.Click += new System.EventHandler(this.findItemButton_Click);
            // 
            // subjectLabel
            // 
            // 
            // 
            // 
            this.subjectLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.subjectLabel.Location = new System.Drawing.Point(219, 166);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(58, 23);
            this.subjectLabel.TabIndex = 7;
            this.subjectLabel.Text = "Subject:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.subjectTextBox.Border.Class = "TextBoxBorder";
            this.subjectTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.subjectTextBox.ForeColor = System.Drawing.Color.White;
            this.subjectTextBox.Location = new System.Drawing.Point(283, 170);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(218, 20);
            this.subjectTextBox.TabIndex = 8;
            // 
            // textTextBox
            // 
            this.textTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.textTextBox.Border.Class = "TextBoxBorder";
            this.textTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textTextBox.ForeColor = System.Drawing.Color.White;
            this.textTextBox.Location = new System.Drawing.Point(12, 229);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(757, 253);
            this.textTextBox.TabIndex = 9;
            // 
            // messageLabel
            // 
            // 
            // 
            // 
            this.messageLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.messageLabel.Location = new System.Drawing.Point(12, 200);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(70, 23);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "Message:";
            // 
            // moneyLabel
            // 
            // 
            // 
            // 
            this.moneyLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.moneyLabel.Location = new System.Drawing.Point(155, 485);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(38, 23);
            this.moneyLabel.TabIndex = 11;
            this.moneyLabel.Text = "Gold:";
            // 
            // goldIntegerInput
            // 
            // 
            // 
            // 
            this.goldIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.goldIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.goldIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.goldIntegerInput.Location = new System.Drawing.Point(199, 488);
            this.goldIntegerInput.Name = "goldIntegerInput";
            this.goldIntegerInput.ShowUpDown = true;
            this.goldIntegerInput.Size = new System.Drawing.Size(92, 20);
            this.goldIntegerInput.TabIndex = 12;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX1.Location = new System.Drawing.Point(306, 485);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(46, 23);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "Silver:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelX2.Location = new System.Drawing.Point(468, 485);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(58, 23);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Copper:";
            // 
            // silverIntegerInput
            // 
            // 
            // 
            // 
            this.silverIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.silverIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.silverIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.silverIntegerInput.Location = new System.Drawing.Point(358, 488);
            this.silverIntegerInput.Name = "silverIntegerInput";
            this.silverIntegerInput.ShowUpDown = true;
            this.silverIntegerInput.Size = new System.Drawing.Size(92, 20);
            this.silverIntegerInput.TabIndex = 15;
            // 
            // copperIntegerInput
            // 
            // 
            // 
            // 
            this.copperIntegerInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.copperIntegerInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.copperIntegerInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.copperIntegerInput.Location = new System.Drawing.Point(532, 488);
            this.copperIntegerInput.Name = "copperIntegerInput";
            this.copperIntegerInput.ShowUpDown = true;
            this.copperIntegerInput.Size = new System.Drawing.Size(92, 20);
            this.copperIntegerInput.TabIndex = 16;
            // 
            // sendButton
            // 
            this.sendButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.sendButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.sendButton.Location = new System.Drawing.Point(659, 541);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(110, 42);
            this.sendButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sendButton.TabIndex = 17;
            this.sendButton.Text = "Send";
            this.sendButton.TextColor = System.Drawing.Color.Chartreuse;
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 541);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 42);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            // 
            // SendMail
            // 
            this.AcceptButton = this.sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(777, 590);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.copperIntegerInput);
            this.Controls.Add(this.silverIntegerInput);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.goldIntegerInput);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.findItemButton);
            this.Controls.Add(this.itemIdIntegerInput);
            this.Controls.Add(this.itemToSendLabel);
            this.Controls.Add(this.offlinePlayersComboBox);
            this.Controls.Add(this.onlinePlayersComboBox);
            this.Controls.Add(this.offlinePlayersLabel);
            this.Controls.Add(this.onlinePlayersLabel);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(797, 633);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(797, 633);
            this.Name = "SendMail";
            this.Text = "Send Mail";
            ((System.ComponentModel.ISupportInitialize)(this.itemIdIntegerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldIntegerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverIntegerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copperIntegerInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX onlinePlayersLabel;
        private DevComponents.DotNetBar.LabelX offlinePlayersLabel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx onlinePlayersComboBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx offlinePlayersComboBox;
        private DevComponents.DotNetBar.LabelX itemToSendLabel;
        private DevComponents.Editors.IntegerInput itemIdIntegerInput;
        private DevComponents.DotNetBar.ButtonX findItemButton;
        private DevComponents.DotNetBar.LabelX subjectLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX subjectTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX textTextBox;
        private DevComponents.DotNetBar.LabelX messageLabel;
        private DevComponents.DotNetBar.LabelX moneyLabel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput goldIntegerInput;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput silverIntegerInput;
        private DevComponents.Editors.IntegerInput copperIntegerInput;
        private DevComponents.DotNetBar.ButtonX sendButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
    }
}