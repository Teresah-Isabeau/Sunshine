using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
