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

        /// <summary>
        /// method that gets called when form gets loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_Load(object sender, EventArgs e)
        {
            User dateToday = new User();
            lbDate.Text = "Date: " + dateToday.getDate();


            timer1.Enabled = true;

            timer1.Interval = 1000;

            User getFactorAdvice = new User();
            lbSunscreen.Text = "Sunscreen Factor: " + getFactorAdvice.FactorAdvice();
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

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome form1 = new Welcome();
            form1.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

    }
}
