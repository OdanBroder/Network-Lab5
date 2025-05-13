using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
namespace Task3_Send_Mail_Gmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_Password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool isEmail1Valid = Regex.IsMatch(textBox_From.Text, emailPattern);
            bool isEmail2Valid = Regex.IsMatch(textBox_To.Text, emailPattern);
            if(!isEmail1Valid||!isEmail2Valid)
            {
                MessageBox.Show("Invalid email format");
                return;
            }
            try
            {
                var fromAddress = new MailAddress(textBox_From.Text.Trim());
                var toAddress = new MailAddress(textBox_To.Text.Trim());
                string fromPassword = textBox_Password.Text;
                string subject = textBox_Subject.Text;
                string body = richTextBox_Body.Text;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 10000
                };
                using (var message = new MailMessage(fromAddress, toAddress))
                {
                    message.Subject = subject;
                    message.Body = body;
                    smtp.Send(message);
                    MessageBox.Show("Send successfully!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
