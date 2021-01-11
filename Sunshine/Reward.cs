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
    public partial class Reward : Form
    {
        private int totalUserPoints;
        public Reward(int totalPoints)
        {
            InitializeComponent();
            this.totalUserPoints = totalPoints;
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

            lbPoints.Text = "Points: " + Login.UserLevel.totalPoints.ToString();
            lbLevel.Text = "Level: " + Login.UserLevel.userLevel.ToString();

            foreach (List<string> sublist in Login.UserLevel.userRewards)
            {
                listRewards.Items.Add(sublist[0] + " " + sublist[1] + " " + sublist[2] + " " + sublist[3] + "%");
            }

        }

        
        private void btnClaim_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listRewards);
            selectedItems = listRewards.SelectedItems;
            if ((listRewards.SelectedIndex + 1) != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {

                    foreach (List<string> sublist in Login.UserLevel.userRewards)
                    {

                        if (listRewards.SelectedItem.ToString() == sublist[0] + " " + sublist[1] + " " + sublist[2] + " " + sublist[3] + "%")
                        {
                            listRewards.Items.Remove(selectedItems[i]);
                            Login.UserLevel.userRewards.Remove(sublist);
                            break;

                        }
                    }
                    



                }
                print();
            }
        }
        public void print()
        {
            foreach (List<string> sublist in Login.UserLevel.userRewards)
            {
                foreach (string item in sublist)
                {
                    MessageBox.Show(item);
                }
            }
        }
    }
}
