using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sunshine
{
    public partial class CreateAccount : Form
    {
        //public static to be able to access it when to use login
        //checks what user filled in at create account equals login
        public static string accountEmail;
        public static string accountPassword;

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {          
            connection conn = new connection();
            MySqlCommand cmd = null;
            string cmdString = "";

            cmdString = "insert into Login('" + tbEmail.Text + "','" + tbPassword.Text + "') values (@eMail, @password)";

            conn.ExecuteDataSet(cmdString);

            MessageBox.Show("Data Stored Successfully");

            /* accountEmail = tbEmail.Text;
             accountPassword = tbPassword.Text;
             User newAccount = new User(accountEmail, accountPassword);

             if (newAccount.PasswordCheck(tbConfirm.Text))
             {
                 this.Hide();
                 AccountInfo form4 = new AccountInfo();
                 form4.Show();

             }
             else
             {
                 MessageBox.Show("Passwords aren't the same, please try again.");
             }*/
        }
    }
}
