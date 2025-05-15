namespace ReadIntenalMail
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListView listView1;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();

            this.SuspendLayout();

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 20);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.Text = "Email:";

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 17);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 23);

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(320, 20);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.Text = "Password:";

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(390, 17);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 23);

            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(560, 16);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 25);
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(20, 55);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(62, 15);
            this.lblCount.Text = "Recent: 0";

            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(20, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(620, 280);
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;

            this.ClientSize = new System.Drawing.Size(664, 381);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Text = "IMAP Mail Reader";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
    #endregion
}

