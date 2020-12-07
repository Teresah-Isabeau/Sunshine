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
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            User userLogin = new User();
            
            if (userLogin.LoginCheck(tbEmail.Text, tbPassword.Text, CreateAccount.accountEmail, CreateAccount.accountPassword))
            {
                this.Hide();
                Home form5 = new Home();
                form5.Show();
            }
            else
            {
                MessageBox.Show("Wrong email or password. Please try again");
            }

        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount form3 = new CreateAccount();
            form3.Show();
        }
    }
}
