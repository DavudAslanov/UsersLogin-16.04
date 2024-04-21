using UsersLogin_16._04._2024.Entity;

namespace UsersLogin_16._04._2024
{
    public partial class Form1 : Form
    {
        public static UserManager userManager = new UserManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.Text != string.Empty && Password.Text != string.Empty)
            {
                var a = userManager.GetAll();

                foreach (var item in a)
                {
                    if (item.Name == Login.Text && item.Password == Password.Text)
                    {
                        if(item.Name != "admin" && item.Password != "admin")
                        {
                            Accounts.Instance.account = item;
                            Account account = new Account();
                            account.Show();
                            this.Hide();
                        }
                        else if (item.Name == "admin" && item.Password == "admin")
                        {
                            Admin adminPanel = new Admin();
                            adminPanel.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Siz Yalnis Login Ve Ya password daxil etdiniz:");
                        }
                        MessageBox.Show("Daxil Oldunuz:");
                    }
                }
            }
            else
            {
                MessageBox.Show("Xanalar Doldurulmalidir:", "Bildiris", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
