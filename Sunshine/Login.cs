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
        public static RewardSystem.Level UserLevel { get; private set; }

        public Login()
        {
            InitializeComponent();
            UserLevel = new RewardSystem.Level();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (CreateAccount.NewUser.LoginCheck(tbEmail.Text, tbPassword.Text, CreateAccount.NewUser.LoginEmail, CreateAccount.NewUser.LoginPassword))
                {
                    //ConnectToDatabase(); 
                    this.Hide();
                    Home form5 = new Home();
                    form5.Show();
                }
                else
                {
                    MessageBox.Show("Wrong email or password. Please try again!");
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("No account found, please make an account first!");
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

        private void Login_Load(object sender, EventArgs e)
        {
            if (Home.countdownTimer != null)
            {
                Home.countdownTimer.Enabled = false;
            }
        }
    }
}
