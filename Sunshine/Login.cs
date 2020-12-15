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
    public partial class Login : Form
    {
        connection con = new connection();
        string id, username, password, firstname, lastname, address;

        public Login()
        {
            
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbEmail.Text != "" && tbPassword.Text != "")
                {

                    con.Open();
                    string query = "select id,username,password,firstname,lastname,address from user WHERE username ='" + tbEmail.Text + "' AND password ='" + tbPassword.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            id = row["id"].ToString();
                            username = row["username"].ToString();
                            password = row["password"].ToString();
                            firstname = row["firstname"].ToString();
                            lastname = row["lastname"].ToString();
                            address = row["address"].ToString();
                        }
                        MessageBox.Show("Data found your name is " + firstname + " " + lastname + " " + " and your address at " + address);
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        
    
            /* User userLogin = new User();

             if (userLogin.LoginCheck(tbEmail.Text, tbPassword.Text, CreateAccount.accountEmail, CreateAccount.accountPassword))
             {
                 this.Hide();
                 Home form5 = new Home();
                 form5.Show();
             }
             else
             {
                 MessageBox.Show("Wrong email or password. Please try again");
             }*/

}

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount form3 = new CreateAccount();
            form3.Show();
        }
    }
}
