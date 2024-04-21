namespace UsersLogin_16._04._2024
{
    partial class Account
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
            panel1 = new Panel();
            button1 = new Button();
            Password = new TextBox();
            label4 = new Label();
            Email = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            FirstName = new TextBox();
            label3 = new Label();
            Name = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 157);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(899, 9);
            button1.Name = "button1";
            button1.Size = new Size(141, 53);
            button1.TabIndex = 0;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Password
            // 
            Password.Location = new Point(12, 412);
            Password.Name = "Password";
            Password.Size = new Size(298, 27);
            Password.TabIndex = 20;
            Password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 378);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 19;
            label4.Text = "Password";
            // 
            // Email
            // 
            Email.Location = new Point(12, 339);
            Email.Name = "Email";
            Email.Size = new Size(298, 27);
            Email.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 316);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 17;
            label5.Text = "Email";
            // 
            // button2
            // 
            button2.Location = new Point(162, 458);
            button2.Name = "button2";
            button2.Size = new Size(148, 47);
            button2.TabIndex = 16;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(10, 458);
            button3.Name = "button3";
            button3.Size = new Size(152, 47);
            button3.TabIndex = 15;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(12, 275);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(298, 27);
            FirstName.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 241);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 13;
            label3.Text = "FirstName";
            // 
            // Name
            // 
            Name.Location = new Point(12, 202);
            Name.Name = "Name";
            Name.Size = new Size(298, 27);
            Name.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 168);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 11;
            label2.Text = "Name";
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 506);
            Controls.Add(Password);
            Controls.Add(label4);
            Controls.Add(Email);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(FirstName);
            Controls.Add(label3);
            Controls.Add(Name);
            Controls.Add(label2);
            Controls.Add(panel1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            FormClosed += Account_FormClosed;
            Load += Account_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox Password;
        private Label label4;
        private TextBox Email;
        private Label label5;
        private Button button2;
        private Button button3;
        private TextBox FirstName;
        private Label label3;
        private TextBox Name;
        private Label label2;
    }
}