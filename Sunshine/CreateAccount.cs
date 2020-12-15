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
            // MySqlConnection conn = new MySqlConnection("server=192.168.172.20;user id=TestUser;database=Sunshine;");
            connection conn = new connection();
            MySqlCommand cmd = null;
            string cmdString = "";
           // conn.Open();

            cmdString = "insert into Login values(" + tbEmail.Text + ",'" + tbPassword.Text + ")";

            conn.ExecuteDataSet(cmdString);
            //cmd = new MySqlCommand(cmdString, conn);
            //cmd.ExecuteNonQuery();

            //.Close();

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
