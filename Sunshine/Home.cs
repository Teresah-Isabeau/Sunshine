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
        DateTime endTime;
        private bool reapplied = false;
        private int totalUserPoints;
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
            lbDate.Text = "Date: " + CreateAccount.NewUser.getDate();


            timer1.Enabled = true;
            timer1.Interval = 1000;


            lbSunscreen.Text = "Sunscreen Factor: " + CreateAccount.NewUser.FactorAdvice();

            EnableTimer();
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
            Reward form6 = new Reward(totalUserPoints);
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
            DateTime timeNow = DateTime.Now;
            lbTime.Text = DateTime.Now.ToLongTimeString();
            if (timeNow.Hour >= 12 && timeNow.Hour < 15)
            {
                lblOutOfSun.Enabled = true;
                lblOutOfSun.Text = "It's the best if you stay out of the sun between 12 and 15";
            }
        }

        private void sunscreenTimer_Tick(object sender, EventArgs e)
        {

            TimeSpan remainingTime = endTime - DateTime.Now;
            if (remainingTime < TimeSpan.Zero)
            {
                sunscreenTimer.Enabled = false;
                reapplied = true;
                DialogResult msg = MessageBox.Show("Reapply Sunscreen!");
                if (msg == DialogResult.OK)
                {
                    Login.UserLevel.TotalPoints();
                    EnableTimer();

                }
            }
            else
            {
                string formatted = "Time until reapply: " + remainingTime.ToString(@"dd\.hh\:mm\:ss");
                lbIndication.Text = formatted;
            }
        }
        private void EnableTimer()
        {
            var minutes = 0.5; //countdown time
            var start = DateTime.Now; // Use UtcNow instead of Now
            endTime = start.AddMinutes(minutes); //endTime is a member, not a local variable
            sunscreenTimer.Enabled = true;
        }
    }
}
