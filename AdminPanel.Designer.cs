namespace UsersLogin_16._04._2024
{
    partial class Admin
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Del = new DataGridViewButtonColumn();
            panel1 = new Panel();
            password1 = new TextBox();
            label4 = new Label();
            email1 = new TextBox();
            label5 = new Label();
            first1 = new TextBox();
            label3 = new Label();
            name1 = new TextBox();
            label2 = new Label();
            Add = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Name, FirstName, Email, Password, Del });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1109, 269);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // Del
            // 
            Del.FillWeight = 20F;
            Del.HeaderText = "Del";
            Del.MinimumWidth = 6;
            Del.Name = "Del";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 386);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 269);
            panel1.TabIndex = 1;
            // 
            // password1
            // 
            password1.Location = new Point(12, 251);
            password1.Name = "password1";
            password1.Size = new Size(298, 27);
            password1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 217);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 17;
            label4.Text = "Password";
            // 
            // email1
            // 
            email1.Location = new Point(12, 178);
            email1.Name = "email1";
            email1.Size = new Size(298, 27);
            email1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 155);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 15;
            label5.Text = "Email";
            // 
            // first1
            // 
            first1.Location = new Point(12, 114);
            first1.Name = "first1";
            first1.Size = new Size(298, 27);
            first1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 13;
            label3.Text = "FirstName";
            // 
            // name1
            // 
            name1.Location = new Point(12, 41);
            name1.Name = "name1";
            name1.Size = new Size(298, 27);
            name1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 7);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 11;
            label2.Text = "Name";
            // 
            // Add
            // 
            Add.Location = new Point(12, 284);
            Add.Name = "Add";
            Add.Size = new Size(144, 46);
            Add.TabIndex = 19;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // button1
            // 
            button1.Location = new Point(162, 284);
            button1.Name = "button1";
            button1.Size = new Size(148, 46);
            button1.TabIndex = 20;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(15, 336);
            button2.Name = "button2";
            button2.Size = new Size(141, 42);
            button2.TabIndex = 21;
            button2.Text = "GetAll";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(162, 336);
            button3.Name = "button3";
            button3.Size = new Size(148, 44);
            button3.TabIndex = 22;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 655);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Add);
            Controls.Add(password1);
            Controls.Add(label4);
            Controls.Add(email1);
            Controls.Add(label5);
            Controls.Add(first1);
            Controls.Add(label3);
            Controls.Add(name1);
            Controls.Add(label2);
            Controls.Add(panel1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            FormClosed += Admin_FormClosed;
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox password1;
        private Label label4;
        private TextBox email1;
        private Label label5;
        private TextBox first1;
        private Label label3;
        private TextBox name1;
        private Label label2;
        private Button Add;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewButtonColumn Del;
    }
}