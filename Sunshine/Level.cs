using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardSystem
{
    /// <summary>
    /// class to bind User to the rewardSystem
    /// this class gets the reward list of the class rewards and sends it to user,
    /// it can claculate the amount of rewards,
    /// shows the current level to the user,
    /// shows the current total of points,
    /// </summary>
    public class Level
    {
        public List<List<string>> userRewards { get; private set; }
        public int userLevel { get; private set; }
        public int rewardAmount { get; private set; }
        public int totalPoints { get; private set; }
        private bool enoughPoints;

        public RewardSystem.Coupon newUserPoints { get; private set; }

        public Level()
        {
            newUserPoints = new Coupon();
        }
        public int CountRewards()
        {
            rewardAmount = userRewards.Count;
            return rewardAmount;
        }
        public int TotalPoints()
        {
            totalPoints = newUserPoints.totalPoints;
            return totalPoints;
        }

        public int GeneratePoints() 
        {
            totalPoints = newUserPoints.GetPoints();
            return totalPoints;
        }
        public void UserLevel()
        {
            userLevel = newUserPoints.LevelUp();
        }
        public void AllRewards()
        {
            userRewards = newUserPoints.AddReward();
        }
        
        public bool Redeem(int pointAmount)
        {
            enoughPoints = false;
            if (newUserPoints.EnoughPointsForReward(pointAmount)) 
            {
                totalPoints -= newUserPoints.RedeemPoints(pointAmount);
                enoughPoints = true;
            }
            return enoughPoints;

        }
        public string GetCoupon(System.Windows.Forms.ListBox listRewards)
        {
           return newUserPoints.Claim(listRewards);

        }
        
    }

}
