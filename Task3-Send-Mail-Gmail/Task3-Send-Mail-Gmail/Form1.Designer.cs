namespace Task3_Send_Mail_Gmail
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_From = new TextBox();
            textBox_To = new TextBox();
            textBox_Password = new TextBox();
            label4 = new Label();
            label5 = new Label();
            richTextBox_Body = new RichTextBox();
            textBox_Subject = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F);
            label1.Location = new Point(48, 73);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 33);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F);
            label2.Location = new Point(48, 179);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 33);
            label2.TabIndex = 1;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F);
            label3.Location = new Point(876, 123);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 33);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // textBox_From
            // 
            textBox_From.Location = new Point(238, 73);
            textBox_From.Margin = new Padding(6, 4, 6, 4);
            textBox_From.Name = "textBox_From";
            textBox_From.Size = new Size(420, 44);
            textBox_From.TabIndex = 3;
            // 
            // textBox_To
            // 
            textBox_To.Location = new Point(238, 179);
            textBox_To.Margin = new Padding(6, 4, 6, 4);
            textBox_To.Name = "textBox_To";
            textBox_To.Size = new Size(420, 44);
            textBox_To.TabIndex = 4;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(1043, 117);
            textBox_Password.Margin = new Padding(6, 4, 6, 4);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(398, 44);
            textBox_Password.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F);
            label4.Location = new Point(48, 299);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 33);
            label4.TabIndex = 6;
            label4.Text = "Subject:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F);
            label5.Location = new Point(48, 351);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 33);
            label5.TabIndex = 7;
            label5.Text = "Body:";
            // 
            // richTextBox_Body
            // 
            richTextBox_Body.Location = new Point(238, 360);
            richTextBox_Body.Name = "richTextBox_Body";
            richTextBox_Body.Size = new Size(1203, 467);
            richTextBox_Body.TabIndex = 8;
            richTextBox_Body.Text = "";
            // 
            // textBox_Subject
            // 
            textBox_Subject.Location = new Point(238, 299);
            textBox_Subject.Margin = new Padding(6, 4, 6, 4);
            textBox_Subject.Name = "textBox_Subject";
            textBox_Subject.Size = new Size(1203, 44);
            textBox_Subject.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(747, 852);
            button1.Name = "button1";
            button1.Size = new Size(258, 73);
            button1.TabIndex = 10;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1554, 953);
            Controls.Add(button1);
            Controls.Add(textBox_Subject);
            Controls.Add(richTextBox_Body);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_To);
            Controls.Add(textBox_From);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            Margin = new Padding(6, 4, 6, 4);
            Name = "Form1";
            Text = "Send Mail via Gmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_From;
        private TextBox textBox_To;
        private TextBox textBox_Password;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBox_Body;
        private TextBox textBox_Subject;
        private Button button1;
    }
}
