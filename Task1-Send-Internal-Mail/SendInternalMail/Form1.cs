using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SendInternalMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1", 25))
            {
                try
                {
                    string mailFrom = txtFrom.Text.Trim();
                    string mailTo = txtTo.Text.Trim();
                    string password = txtPassword.Text.Trim();

                    var credentials = new NetworkCredential(mailFrom, password);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = credentials;
                    smtpClient.EnableSsl = false;

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(mailFrom);
                    message.To.Add(mailTo);
                    message.Subject = txtSubject.Text.Trim();
                    message.Body = txtBody.Text;
                    message.IsBodyHtml = true;

                    smtpClient.Send(message);
                    MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to send email:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
