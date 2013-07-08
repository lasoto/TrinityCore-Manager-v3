using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using DevComponents.DotNetBar;
using TrinityCore_Manager.CustomForms;

namespace TrinityCore_Manager
{
    public partial class ReportBug : TCMForm
    {
        public ReportBug()
        {
            InitializeComponent();
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {

                MessageBoxEx.Show(this, "No e-mail provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (!IsValid(emailTextBox.Text))
            {

                MessageBoxEx.Show(this, "Email address is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (string.IsNullOrEmpty(subjectTextBox.Text))
            {

                MessageBoxEx.Show(this, "No subject provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (string.IsNullOrEmpty(smtpTextBox.Text))
            {

                MessageBoxEx.Show(this, "No SMTP Server provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {

                MessageBoxEx.Show(this, "No Username provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {

                MessageBoxEx.Show(this, "No Password provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            if (string.IsNullOrEmpty(messageTextBox.Text))
            {

                MessageBoxEx.Show(this, "No Message provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            StartLoading();

            await Task.Run(() =>
            {

                MailMessage mail = new MailMessage();

                mail.To.Add("hobbilis@live.com");
                mail.To.Add("mitch528@gmail.com");
                mail.Subject = subjectTextBox.Text;
                mail.From = new System.Net.Mail.MailAddress(emailTextBox.Text);
                mail.Body = messageTextBox.Text;

                SmtpClient client = new SmtpClient(smtpTextBox.Text);
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(usernameTextBox.Text, passwordTextBox.Text);
                client.EnableSsl = true;
                client.Send(mail);

            });

            StopLoading();

            MessageBoxEx.Show(this, "E-mail has been sent. We'll get back to you as soon as possible!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();



        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
