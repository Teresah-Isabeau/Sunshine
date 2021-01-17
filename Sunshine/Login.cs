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
        Database con = new Database();
        string eMail, password;

        public Login()
        { 
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectToDatabase();       
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount form3 = new CreateAccount();
            form3.Show();
        }
        /// <summary>
        /// ConnectToDatabase is een method die checked of de ingevulde email en password overeen komen met gegevens in de database.
        /// if true -> dan word de gebruiker naar de Home Form geleid.
        /// if false -> dan krijgt de gebruiker een messagebox te zien "User not found"
        /// </summary>
        private void ConnectToDatabase()
        {
            if (tbEmail.Text != "" && tbPassword.Text != "")
            {
                string query = "SELECT eMail, password FROM Login WHERE eMail=@email AND password=@password";
                List<MySqlParameter> sqlParameters = new List<MySqlParameter>();
                MySqlParameter paramEmail = new MySqlParameter("@email", tbEmail.Text);
                MySqlParameter paramPassword = new MySqlParameter("@password", tbPassword.Text);
                sqlParameters.Add(paramEmail);
                sqlParameters.Add(paramPassword);

                bool userExists = con.Exists(query, sqlParameters);

                if (userExists)
                {
                    eMail = tbEmail.Text;
                    password = tbPassword.Text;

                    this.Hide();
                    Home form5 = new Home();
                    form5.Show();
                }
                else
                {
                    MessageBox.Show("User not found", "Information");
                }
            }
            else
            {
                MessageBox.Show("Username or Password is empty", "Information");
            }
        }
    }
}
