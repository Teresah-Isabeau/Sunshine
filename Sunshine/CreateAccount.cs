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
            if (RegisterToDatabase() == true)

       /* {
            accountEmail = tbEmail.Text;
            accountPassword = tbPassword.Text;
            NewUser = new User(accountEmail, accountPassword);

            if (string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbPassword.Text) || string.IsNullOrWhiteSpace(tbConfirm.Text))
            {
                MessageBox.Show("Please fill in every field!");
            }
            else if (NewUser.PasswordCheck(tbConfirm.Text)) */

            {
                MessageBox.Show("Created account succesfully!", "Information");
                this.Hide();
                AccountInfo form4 = new AccountInfo();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Failed to create account", "Information");
            }
        }
        /// <summary>
        /// RegisterToDatabase is een method die de gebruiker zijn ingevulde email en password opslaat in de database. 
        /// if true -> de gebruiker ontvangt een messagebox dat het gelukt is en word weer terug geleid naar het Login Form.
        /// if false -> de gebruiker ontvangt een messagebox "failed to create account" 
        /// </summary>
        /// <returns>returns een bool om aan te geven of dit gelukt is of niet</returns>
        private bool RegisterToDatabase()
        {
            Database conn = new Database();
            string cmdString = "";

            cmdString = "insert into Login(eMail, password) values (@email, @password)";
            List<MySqlParameter> sqlParameters = new List<MySqlParameter>();
            MySqlParameter paramEmail = new MySqlParameter("@email", tbEmail.Text);
            MySqlParameter paramPassword = new MySqlParameter("@password", tbPassword.Text);
            sqlParameters.Add(paramEmail);
            sqlParameters.Add(paramPassword);

            int affectedRows = conn.Insert(cmdString, sqlParameters);

            if (affectedRows == 1)
            {
                return true;
            }
            else
            {
                return false;              
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
