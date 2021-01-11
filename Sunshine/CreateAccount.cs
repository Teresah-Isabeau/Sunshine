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
            if (RegisterToDatabase() == true)
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
            database conn = new database();
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
    }
}
