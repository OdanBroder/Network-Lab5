namespace SendInternalMail
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Button btnSend;

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBody;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();

            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(30, 23);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 15);
            this.lblFrom.Text = "From:";

            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(30, 63);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 15);
            this.lblTo.Text = "To:";

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.Text = "Password:";

            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(30, 143);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(49, 15);
            this.lblSubject.Text = "Subject:";

            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(30, 183);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(38, 15);
            this.lblBody.Text = "Body:";

            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(120, 20);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(300, 23);

            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(120, 60);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(300, 23);

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 23);

            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(120, 140);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(300, 23);

            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(120, 180);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(300, 120);
            this.txtBody.Text = "";

            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(120, 320);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 30);
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(480, 380);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblBody);

            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Internal Mail Sender";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
