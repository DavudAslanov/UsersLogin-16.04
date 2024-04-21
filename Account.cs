using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersLogin_16._04._2024.Entity;

namespace UsersLogin_16._04._2024
{
    public partial class Account : Form
    {
        public UserManager userManager = new UserManager();
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            var user = Accounts.Instance.account;
            FirstName.Text = user.FirstName;
            Email.Text = user.Email;
            Password.Text = user.Password;
            Name.Text = user.Name;
            Lockedfalse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lockedtrue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = Name.Text,
                Password = Password.Text,
                FirstName = FirstName.Text,
                Email = Email.Text,
            };
            userManager.Update(user);
            MessageBox.Show("Melumatlar deyisdirildi:");
            Lockedfalse();
        }
        public void Lockedfalse()
        {
            Name.Enabled = false;
            Password.Enabled = false;
            FirstName.Enabled = false;
            Email.Enabled = false;
        }
        public void Lockedtrue()
        {
            Name.Enabled = true;
            Password.Enabled = true;
            FirstName.Enabled = true;
            Email.Enabled = true;
        }

        private void Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
