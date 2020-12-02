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
    public partial class AccountInfo : Form
    {
        string email;
        string password;

        public AccountInfo()
        {
        }

        public AccountInfo(string email, string password )
        {
            InitializeComponent();
            this.email = email;
            this.password = password;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form5 = new Home();
            form5.Show();
        }
    }
}
