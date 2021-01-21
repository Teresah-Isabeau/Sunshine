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
        public static Timer countdownTimer { get; set; }

        public Home()
        {
            InitializeComponent();
            countdownTimer = sunscreenTimer;

        }

        /// <summary>
        /// method that gets called when form gets loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_Load(object sender, EventArgs e)
        {
            lbDate.Text = "Date: " + CreateAccount.NewUser.getDate();
            lblOutOfSun.Visible = false;

            timer1.Enabled = true;
            timer1.Interval = 1000;
            lbSunscreen.Text = "Sunscreen Factor: " + CreateAccount.NewUser.FactorAdvice();

            CreateAccount.NewUser.EnableTimer(countdownTimer);
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

        private void TimeNow_Tick(object sender, EventArgs e) 
        {
            DateTime timeNow = DateTime.Now;
            lbTime.Text = DateTime.Now.ToLongTimeString();
            if (timeNow.Hour >= 12 && timeNow.Hour < 15)
            {
                lblOutOfSun.Visible = true;
                lblOutOfSun.Text = "You should stay out of the sun between\n12 and 15.";
            }
        }

        private void sunscreenTimer_Tick(object sender, EventArgs e)
        {
            lbIndication.Text = CreateAccount.NewUser.SunscreenTimer(countdownTimer);

        }
    }
}
