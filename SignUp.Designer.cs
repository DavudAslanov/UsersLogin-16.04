namespace UsersLogin_16._04._2024
{
    partial class SignUp
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
            Password = new TextBox();
            label4 = new Label();
            Email = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            FirstName = new TextBox();
            label3 = new Label();
            Name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(Password);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(FirstName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(181, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 573);
            panel1.TabIndex = 1;
            // 
            // Password
            // 
            Password.Location = new Point(60, 344);
            Password.Name = "Password";
            Password.Size = new Size(298, 27);
            Password.TabIndex = 10;
            Password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 310);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // Email
            // 
            Email.Location = new Point(60, 271);
            Email.Name = "Email";
            Email.Size = new Size(298, 27);
            Email.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 248);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // button2
            // 
            button2.Location = new Point(210, 390);
            button2.Name = "button2";
            button2.Size = new Size(148, 47);
            button2.TabIndex = 6;
            button2.Text = "Qeydiyatdan Kec";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(58, 390);
            button1.Name = "button1";
            button1.Size = new Size(152, 47);
            button1.TabIndex = 5;
            button1.Text = "Giris";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(60, 207);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(298, 27);
            FirstName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 173);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 3;
            label3.Text = "FirstName";
            // 
            // Name
            // 
            Name.Location = new Point(60, 134);
            Name.Name = "Name";
            Name.Size = new Size(298, 27);
            Name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 100);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 40);
            label1.Name = "label1";
            label1.Size = new Size(127, 24);
            label1.TabIndex = 0;
            label1.Text = "Login Panel";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 638);
            Controls.Add(panel1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            FormClosed += SignUp_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox FirstName;
        private Label label3;
        private TextBox Name;
        private Label label2;
        private Label label1;
        private TextBox Password;
        private Label label4;
        private TextBox Email;
        private Label label5;
    }
}