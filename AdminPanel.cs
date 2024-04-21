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
using UsersLogin_16._04._2024.DB;
using UsersLogin_16._04._2024.Entity;

namespace UsersLogin_16._04._2024
{
    public partial class Admin : Form
    {
        public static UserManager userManager = new UserManager();
        public Admin()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            WriteTotable();
        }
        private void WriteTotable()
        {
            var users = Database.Instance.users;
            dataGridView1.Rows.Clear();
            if (dataGridView1.Rows.Count < users.Count)
                dataGridView1.Rows.Add(users.Count - dataGridView1.Rows.Count);

            int i = 0;
            foreach (var item in users)
            {
                if (item.Name != "admin")
                {
                    dataGridView1.Rows[i].Cells[0].Value = item.Id;
                    dataGridView1.Rows[i].Cells[1].Value = item.Name;
                    dataGridView1.Rows[i].Cells[2].Value = item.FirstName;
                    dataGridView1.Rows[i].Cells[3].Value = item.Password;
                    dataGridView1.Rows[i].Cells[4].Value = item.Email;

                }
                else
                {
                    continue;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            else
            {
                MessageBox.Show("Cedvel Bosdur", "bildiris", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (name1.Text != string.Empty && password1.Text != string.Empty && first1.Text != string.Empty && email1.Text != string.Empty)
            {
          
                
                    if(password1.Text.Length > 8)
                    {
                        User user = new User()
                        {
                            Name = name1.Text,
                            Password = password1.Text,
                            FirstName = first1.Text,
                            Email = email1.Text,
                        };
                        if (Validation.ValidationTrue(user))
                        {
                            userManager.Add(user);
                            WriteTotable();
                            Deletebox();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Uzunluq 8 simvoldan az olmamalidir:");
                    }
             
            }
            else
            {
                MessageBox.Show("Xanalar Bos qala bilmez:", "Bildiris", MessageBoxButtons.OK);
            }
            MessageBox.Show("Siz qeydiyatdan kecdiniz:");
        }
        public void Deletebox()
        {
            name1.Text = " ";
            password1.Text = " ";
            email1.Text = " ";
            first1.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (first1.Text != string.Empty && name1.Text != string.Empty && email1.Text != string.Empty && password1.Text != string.Empty)
            {
                var a = userManager.GetAll();
                foreach (var item in a)
                {
                    name1.Text = item.Name;
                    password1.Text = item.Password;
                    email1.Text = item.Email;
                    first1.Text = item.FirstName;
                };
                WriteTotable();
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = name1.Text,
                Password = password1.Text,
                FirstName = first1.Text,
                Email = email1.Text,
            };
            userManager.Update(user);
            WriteTotable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = name1.Text,
                Password = password1.Text,
                FirstName = first1.Text,
                Email = email1.Text,
            };
            userManager.Delete(user);
            WriteTotable();
            Deletebox();
        }
    }
}
