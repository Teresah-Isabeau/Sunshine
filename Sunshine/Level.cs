using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardSystem
{
    /// <summary>
    /// class to bind User to the rewardSystem
    /// this class gets the reward list of the class rewards and sends it to user.
    /// this class can calculate the amount of rewards
    /// this class can show the current level of the user
    /// </summary>
    public class Level
    {
        public List<List<string>> userRewards { get; private set; }
        public int userLevel { get; private set; }
        public int rewardAmount { get; private set; }
        public int totalPoints { get; private set; }

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
        public void TotalPoints()
        {
            totalPoints = newUserPoints.GetPoints();
        }
        public void UserLevel()
        {
            userLevel = newUserPoints.LevelUp();
        }
        public void AllRewards()
        {
            userRewards = newUserPoints.AddReward();
        }
        
        public void Redeem(int pointAmount)
        {
            if (newUserPoints.EnoughPointsForReward(pointAmount)) 
            {
                totalPoints -= newUserPoints.RedeemPoints(pointAmount);
            }

        }
        
    }

}
