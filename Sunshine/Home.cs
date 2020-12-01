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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountInfo form4 = new AccountInfo();
            form4.Show();
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reward form6 = new Reward();
            form6.Show();
        }
    }
}
