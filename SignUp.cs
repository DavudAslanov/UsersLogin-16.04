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
    public partial class SignUp : Form
    {
        public static UserManager userManager = new UserManager();
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Name.Text != string.Empty && Password.Text != string.Empty && FirstName.Text != string.Empty && Email.Text != string.Empty)
            {


                User user = new User()
                {
                    Name = Name.Text,
                    Password = Password.Text,
                    FirstName = FirstName.Text,
                    Email = Email.Text,
                };
                if (Validation.ValidationTrue(user))
                {
                    MessageBox.Show("Siz qeydiyatdan kecdiniz:");
                    userManager.Add(user);
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Xanalar doldurulmalidir Sertler: Parol 8 simvoldan az olmamalidir\n ad 3 simvoldan az olmamalidir\n Email '@' isaresi qoylmalidir\n","Bildiris",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Xanalar Bos qala bilmez:", "Bildiris", MessageBoxButtons.OK);
            }

        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
