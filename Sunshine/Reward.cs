﻿using System;
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
    public partial class Reward : Form
    {
        public Reward()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            Home form5 = new Home();
            form5.Show();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {

        }

        private void Reward_Load(object sender, EventArgs e)
        {
            Home.countdownTimer.Enabled = false;

            lbPoints.Text = "Points: " + CreateAccount.NewUser.PointsOfUser();
            lbLevel.Text = "Level: " + CreateAccount.NewUser.GetLevel();
            try
            {
                foreach (List<string> sublist in Login.UserLevel.userRewards)
                {
                    listRewards.Items.Add("[" + sublist[0] + "] " + sublist[1] + " " + sublist[2] + "%" + " " + "Point Cost: " + sublist[3]);
                }
            }
            catch (System.NullReferenceException)
            {
                listRewards.Text = "No rewards yet";
            }


        }

        
        private void btnClaim_Click(object sender, EventArgs e)
        {
            lbClaimedReward.Text = Login.UserLevel.GetCoupon(listRewards);
            lbPoints.Text = "Points: " + CreateAccount.NewUser.PointsOfUser();

        }
    }
}
