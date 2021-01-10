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
                MessageBox.Show("Created account successfully");
            } else
            {
                MessageBox.Show("Failed to create account");
            }
        }
    }
}
