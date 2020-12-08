using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunshine
{
    public class Coupon
    {
        private int points;
        private List<string> rewards = new List<string>();

        public Coupon(int points)
        {
            this.points = points;
        }


    }
}
