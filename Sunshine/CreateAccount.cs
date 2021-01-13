using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunshine
{
    public partial class CreateAccount : Form
    {
        private string accountEmail;
        private string accountPassword;

        private static User newUser;
        public static User NewUser
        {
            get { return newUser; }
            set { newUser = value; }
        }

        public CreateAccount()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            accountEmail = tbEmail.Text;
            accountPassword = tbPassword.Text;
            NewUser = new User(accountEmail, accountPassword);

            if (string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbPassword.Text) || string.IsNullOrWhiteSpace(tbConfirm.Text))
            {
                MessageBox.Show("Please fill in every field!");
            }
            else if (NewUser.PasswordCheck(tbConfirm.Text))
            {
                this.Hide();
                AccountInfo form4 = new AccountInfo();
                form4.Show();

            }
            else
            {
                MessageBox.Show("Passwords aren't the same, please try again.");
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
