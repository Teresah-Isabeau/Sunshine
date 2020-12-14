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
    }
}
