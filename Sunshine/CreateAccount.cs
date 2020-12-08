using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Sunshine
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //string email = tbEmail.Text;
            //string password = tbPassword.Text;
            //string confirmPassword = tbConfirm.Text;

            Database database = new Database();

            User newAccount = new User(tbEmail.Text, tbPassword.Text);
            
            if (newAccount.PasswordCheck(tbConfirm.Text))
            {
                this.Hide();
                AccountInfo form4 = new AccountInfo(tbEmail.Text, tbPassword.Text);
                form4.Show();

            }
            else
            {
                MessageBox.Show("Passwords aren't the same, please try again.");

                SqlCommand insertCommand = new SqlCommand("insert into users(Email, Password, ConfirmPassword) values (@email, @password, @confirmPassword)");
               // insertCommand.Parameters.AddWithValue("@email, email");
            }
        }
    }
}
