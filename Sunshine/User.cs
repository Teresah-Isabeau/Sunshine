﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sunshine
{
    //ToDo: edit the variables,
    //make list for rewards, take rewards from class Level
    //take level and totalpoints from class Level

    public class User
    {
        private string name;
        private decimal age;
        private string skinType;

        public string LoginEmail { get; private set; }
        public string LoginPassword { get; private set; }

        private string country;
        private string date;
        private string factor;
        private DateTime endTime;

        private int totalPoints;
        private int level;   

        public List<List<string>> userRewards { get; private set; }

        public static Timer countdownTimer { get; private set; }
        private string sunscreenCountdown;


        public User(string email, string password)
        {
            this.LoginEmail = email;
            this.LoginPassword = password;
        }

        public User()
        {

        }
        public void UserInformation(string Name, decimal Age, string Country, string SkinType)
        {
            name = Name;
            age = Age;
            country = Country;
            skinType = SkinType;
        }

        /// <summary>
        /// method that checks if the login is equal to the password and email of the account
        /// returns a boolean
        /// will be able to login if true
        /// will get a message if false
        /// </summary>
        /// <param name="inputEmail"></param>
        /// <param name="inputPass"></param>
        /// <param name="accountEmail"></param>
        /// <param name="accountPassword"></param>
        /// <returns></returns>
        public bool LoginCheck(string inputEmail, string inputPass, string accountEmail, string accountPassword)
        {
            bool loginCheck = false;
            if (inputEmail == accountEmail && inputPass == accountPassword)
            {
                loginCheck = true;
            }
            return loginCheck;
        }

        /// <summary>
        /// method to check if the given password is the same as the confirm password
        /// </summary>
        /// <param name="passwordCheck"></param>
        /// <returns></returns>
        public bool PasswordCheck(string passwordCheck)
        {
            bool logCheck = false;
            if (LoginPassword == passwordCheck)
            {
                logCheck = true;

            }
            return logCheck;
        }

        /// <summary>
        /// method that returns the date of today
        /// </summary>
        /// <returns></returns>
        public string getDate()
        {
            date = DateTime.Now.ToShortDateString();
            return date;

        }

        public string SunscreenTimer(Timer sunscreenTimer)
        {
            countdownTimer = sunscreenTimer;
            TimeSpan remainingTime = endTime - DateTime.Now;
            if (remainingTime < TimeSpan.Zero)
            {
                countdownTimer.Enabled = false;
                DialogResult msg = MessageBox.Show("Reapply Sunscreen!");
                if (msg == DialogResult.OK)
                {
                    Login.UserLevel.GeneratePoints();
                    Login.UserLevel.UserLevel();
                    Login.UserLevel.AllRewards();
                    EnableTimer(countdownTimer);
                }
            }
            else
            {
                sunscreenCountdown = "Time until reapply: " + remainingTime.ToString(@"dd\.hh\:mm\:ss");
                //lbIndication.Text = formatted;
            }
            return sunscreenCountdown;
        }
        public void EnableTimer(Timer sunscreenTimer)
        {
            countdownTimer = sunscreenTimer;
            var minutes = 0.1; //countdown time
            var start = DateTime.Now; // Use UtcNow instead of Now
            endTime = start.AddMinutes(minutes); //endTime is a member, not a local variable
            countdownTimer.Enabled = true;
        }

        /// <summary>
        /// method to give the user advice based on skin type.
        /// </summary>
        public string FactorAdvice()
        {
            if (age < 16)
            {
                factor = "Children neet to use at least sunscreen factor 30 or 50.";
            }
            else if (age > 18)
            {
                switch (int.Parse(skinType))
                {
                
                    case 1:
                        factor = "Your skin is very sensitive to the sun.\nUse at least sunscreen factor 30 or higher.";
                        break;
                    case 2:
                        factor = "Your skin is very sensitive to the sun.\nUse at least sunscreen factor 30 or higher.";
                        break;
                    case 3:
                        factor = "Your skin sometimes burns and you sometimes get a tan.\nUse sunscreen factor 15 or higher";
                        break;
                    case 4:
                        factor = "You tan easily and don't burn often. But you are still at risk.\nUse sunscreen factor 15 or higher.";
                        break;
                    case 5:
                        factor = "You tan very easily and don't burn often, but you are still at risk.\nUse sunscreen factor 15 or higher.";
                        break;
                    case 6:
                        factor = "Even if you don't burn,\npeople with dark skin are still at risk of getting skin cancer.\nUse sunscreen factor 15 or higher";
                        break;
                    default:
                        factor = "";
                        break;
                }

            }
            return factor;
        }
        public void CountdownSunscreen()
        {
            var hours = 2; //countdown time
            var start = DateTime.Now; 
            endTime = start.AddHours(hours); //endTime is a member, not a local variable
        }
        public int GetLevel()
        {
            level = Login.UserLevel.userLevel;
            return level;
        }
        public int PointsOfUser() 
        {
            totalPoints = Login.UserLevel.TotalPoints();
            return totalPoints;
        }

        public List<List<string>> RewardsOfUser()
        {
            userRewards = Login.UserLevel.userRewards;
            return userRewards;

        }
    }
}

