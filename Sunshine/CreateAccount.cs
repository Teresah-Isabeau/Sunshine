using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlConnector;
/*
namespace Sunshine
{
    connection con = new connection();
    string id, username, password, firstname, lastname, address;
    public Form1()
    {
        InitializeComponent();
    }
    private void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {

                con.Open();
                string query = "select id,username,password,firstname,lastname,address from user WHERE username ='" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "'";
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
    }
}  
   /* public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            //string confirmPassword = tbConfirm.Text;

            Database objectDatabase = new Database();

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
             }

            if (email.Equals(""))
            {
                MessageBox.Show("Please enter your Email");
            }

            else if (password.Equals(""))
            {
                MessageBox.Show("Please enter your password");
            }

            else
            {
                MySqlCommand insertCommand = new MySqlCommand("insert into users(email , password) values(@gebruikersnaam, @Wachtwoord)");
                
                insertCommand.Parameters.AddWithValue("@gebruikersnaam", email);
                insertCommand.Parameters.AddWithValue("@Wachtwoord", password);
                //insertCommand.Parameters.AddWithValue("@confirmPassword, ConfirmPassword");

                int row = objectDatabase.executeQuery(insertCommand);

                if(row == 1)
                {
                    this.Hide();
                    AccountInfo form4 = new AccountInfo(tbEmail.Text, tbPassword.Text);
                    form4.Show();
                }

                else
                {
                    MessageBox.Show("An error has ocurred, please try again");
                }
            }
        }
    }*/

