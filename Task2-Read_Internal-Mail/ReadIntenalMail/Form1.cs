using System;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReadIntenalMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                using (var client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (senderCert, certificate, chain, sslPolicyErrors) => true;
                    client.Connect("127.0.0.1", 143, false); 
                    client.Authenticate(email, password);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    lblCount.Text = $"Total: {inbox.Count} - Recent: {inbox.Recent}";
                    listView1.Items.Clear();

                    if (listView1.Columns.Count == 0)
                    {
                        listView1.Columns.Add("Email", 200);
                        listView1.Columns.Add("From", 200);
                        listView1.Columns.Add("Thời gian", 150);
                        listView1.View = View.Details;
                    }

                    int count = inbox.Count;
                    for (int i = inbox.Count - count; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        var name = new ListViewItem(message.Subject);

                        name.SubItems.Add(message.From.ToString());
                        name.SubItems.Add(message.Date.DateTime.ToString());

                        listView1.Items.Add(name);
                    }

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "IMAP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
