using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardSystem
{
    /// <summary>
    /// method getPoints gives the user points
    /// levelUp will level the user with 1 level whe the levelpoints are reached
    /// </summary>
    public class Points
    {
        public int totalPoints { get; protected set; }
        public int levelPoints { get; private set; }
        public int level { get; protected set; }
        public int pointsNeededToLevelUp { get; private set; }
        public bool leveledUp { get; protected set; }

        public Points()
        {
            totalPoints = 0;
            levelPoints = 0;
            level = 1;
            pointsNeededToLevelUp = 10;
        }
        public void ShowPointsAndLevel()
        {
            Console.WriteLine("Total Points: " + totalPoints);
            Console.WriteLine("Level: " + level);
        }

        public int GetPoints()
        {
            totalPoints += 5;
            Console.WriteLine("Total points: " + totalPoints);
            return totalPoints;
        }
        public int LevelUp()
        {
            leveledUp = false;

            if (levelPoints == pointsNeededToLevelUp)
            {
                level += 1;
                levelPoints = 0;
                pointsNeededToLevelUp += 10;
                leveledUp = true;
            }
            else
            {
                levelPoints += 5;
                leveledUp = false;
            }
            Console.WriteLine("Level: " + level);
            return level;
        }

    }
    public enum Item
    {
        Sunscreen,
        Aftersun,
        Drink,
        Beachball,
        Towel,
        Icecream,
        CoolerBox
    }
    /// <summary>
    /// child class of the parent Points
    /// rewardList is a list of lists,
    /// the sublists are the random rewards + point cost
    /// RandomEnumValue will generate a random item from the enum,
    /// using Enum.GetValues to retrieve an array of all values,
    /// then selec a random array item
    /// T is a generic type parameter
    /// AddReward will add a reward list to the list if the user leveledUp
    /// </summary>
    ///
    public class Coupon : Points
    {
        public List<List<string>> rewardList { get; private set; }
        public Random randomEnumItem { get; private set; }
        public string rewardChoice { get; private set; }
        public int rewardCount { get; private set; }

        public Random randomPointAmount { get; private set; }
        public int savePointCost { get; private set; }

        public Random coupon { get; private set; }
        public int saveCoupon { get; private set; }

        public Coupon()
        {
            randomPointAmount = new Random();
            randomEnumItem = new Random();
            rewardList = new List<List<string>>();
            rewardCount = 1;
            coupon = new Random();
        }

        //Generics allow you to define the specification of the data type of programming elements in a class or a method,
        //until it is actually used in the program.
        //In other words, generics allow you to write a class or method that can work with any data type.
        public T RandomEnumValue<T>()
        {
            var itemArray = Enum.GetValues(typeof(Item));
            return (T)itemArray.GetValue(randomEnumItem.Next(itemArray.Length));
        }

        public void AddReward()
        {
            var value = RandomEnumValue<Item>();
            int addPoints, addCoupon;

            addCoupon = GenerateCoupon();
            addPoints = GeneratePointCost();
            if (leveledUp)
            {
                rewardList.Add(new List<string> { rewardCount.ToString(), addPoints.ToString(), value.ToString(),
                    addCoupon.ToString() });

                rewardCount++;
            }
        }
        public void ShowRewards()
        {

            foreach (List<string> sublist in rewardList)
            {
                Console.WriteLine(sublist[0] + " " + sublist[1] + " " + sublist[2] + " " + sublist[3] + "%");
            }
        }

        public void ChooseReward()
        {
            if (rewardList.Count == 0)
            {
                Console.WriteLine("No rewards");
            }
            else
            {
                Console.WriteLine("Enter the number of the reward or type 'exit' to go back");
                Console.WriteLine("Rewards: ");
                ShowRewards();
                rewardChoice = Console.ReadLine();
                foreach (List<string> sub in rewardList)
                {
                    if (rewardChoice == sub[0])
                    {
                        Console.Clear();
                        if (EnoughPointsForReward(int.Parse(sub[1])))
                        {
                            RedeemPoints(int.Parse(sub[1]));
                            Console.WriteLine("You chose reward: \n" + sub[0] + " " + sub[1] + " " + sub[2] + " " + sub[3] + "%");
                            rewardList.Remove(sub);
                        }
                        else
                        {
                            Console.WriteLine("Not enough points!");
                        }
                        break;
                    }
                }
            }
        }
        public int GenerateCoupon()
        {

            saveCoupon = coupon.Next(5, 25);
            return saveCoupon;
        }

        public int GeneratePointCost()
        {
            if (saveCoupon <= 6)
            {
                savePointCost = randomPointAmount.Next(30, 60);
            }
            else if (saveCoupon > 6 && saveCoupon <= 8)
            {
                savePointCost = randomPointAmount.Next(60, 100);
            }
            else if (saveCoupon > 8 && saveCoupon <= 12)
            {
                savePointCost = randomPointAmount.Next(100, 130);
            }
            else if (saveCoupon > 11 && saveCoupon <= 20)
            {
                savePointCost = randomPointAmount.Next(130, 160);
            }
            else if (saveCoupon > 19 && saveCoupon <= 25)
            {
                savePointCost = randomPointAmount.Next(160, 200);
            }
            return savePointCost;
        }


        public bool EnoughPointsForReward(int pointCost)
        {
            if (pointCost > totalPoints)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void RedeemPoints(int pointCost)
        {
            totalPoints -= pointCost;
        }
    }

}

