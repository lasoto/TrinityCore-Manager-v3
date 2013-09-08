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
using System.Net;
using System.Collections.Specialized;

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

            if (useUserSMTPCheckbox.Checked)
            {
                if (string.IsNullOrEmpty(smtpTextBox.Text))
                {

                    MessageBoxEx.Show(this, "No SMTP Server provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }

                if (string.IsNullOrEmpty(passwordTextBox.Text))
                {

                    MessageBoxEx.Show(this, "No Password provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }
            }

            if (string.IsNullOrEmpty(messageTextBox.Text))
            {

                MessageBoxEx.Show(this, "No Message provided!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            StartLoading();

            string error = "";

            await Task.Run(() =>
            {

                    try
                    {

                        if (useUserSMTPCheckbox.Checked)
                        {

                            using (MailMessage mail = new MailMessage())
                            {

                                mail.To.Add("hobbilis@live.com");
                                mail.To.Add("mitch528@gmail.com");
                                mail.Subject = subjectTextBox.Text;
                                mail.From = new System.Net.Mail.MailAddress(emailTextBox.Text);
                                mail.Body = messageTextBox.Text;

                                using (SmtpClient client = new SmtpClient(smtpTextBox.Text))
                                {
                                    client.Port = enableSSLCheckBox.Checked ? 587 : 25;
                                    client.Credentials = new NetworkCredential(emailTextBox.Text, passwordTextBox.Text);
                                    client.EnableSsl = enableSSLCheckBox.Checked;
                                    client.Send(mail);
                                }

                            }

                        }
                        else
                        {

                            using (WebClient client = new WebClient())
                            {

                                NameValueCollection nvc = new NameValueCollection();
                                nvc["email"] = emailTextBox.Text;
                                nvc["subject"] = subjectTextBox.Text;
                                nvc["message"] = messageTextBox.Text;

                                client.UploadValues("http://mitch528.com/api/TCMBugReport", "POST", nvc);

                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        error = ex.Message;
                    }

            });

            StopLoading();

            if (string.IsNullOrEmpty(error))
            {

                MessageBoxEx.Show(this, "E-mail has been sent. We'll get back to you as soon as possible!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();

            }
            else
            {
                MessageBoxEx.Show(this, error, "Error Sending Email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            Close();
        }

        private void useUserSMTPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            smtpTextBox.Enabled = useUserSMTPCheckbox.Checked;
            passwordTextBox.Enabled = useUserSMTPCheckbox.Checked;
            enableSSLCheckBox.Enabled = useUserSMTPCheckbox.Checked;
        }
    }
}
