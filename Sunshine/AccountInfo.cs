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

        public AccountInfo()
        {
            InitializeComponent();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            User userInfo = new User();
            userInfo.UserFacts(tbName.Text, nudAge.Value, cbCountry.Text, cbSkin.Text);

            this.Hide();
            Home form5 = new Home();
            form5.Show();
        }
    }
}
