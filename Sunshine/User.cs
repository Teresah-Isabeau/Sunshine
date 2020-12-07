using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sunshine
{

    public class User
    {
        private string name;
        private decimal age;
        private string skinType;
        private string loginEmail; 
        private string loginPassword;
        private string country; 
        private string counter;
        private string date;
        private string factor;
        
        public User(string email, string password)
        {
            this.loginEmail = email;
            this.loginPassword = password;
        }
        
        //overloading, depending on what needs to be given to the class
        public  User(string name, decimal age, string country, string skinType)
        {
            this.name = name;
            this.age = age;
            this.skinType = skinType;
            this.country = country;
        }
        
        public User()
        {

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

        /*
        public string FormulaCountdown()
        {

        }
        */
        
        /// <summary>
        /// method to check if the given password is the same as the confirm password
        /// </summary>
        /// <param name="passwordCheck"></param>
        /// <returns></returns>
        public bool PasswordCheck(string passwordCheck)
        {
            bool logCheck = false;
            if (loginPassword == passwordCheck)
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
        
        /// <summary>
        /// method to give the user advice based on skin type.
        /// </summary>
        public string FactorAdvice()
        {
            if (AccountInfo.age > 18)
            {
                factor = "30 or 20";
            }
            else if (AccountInfo.age < 18)
            {
                factor = "50 or 30";
            }
            return factor;
        }
        
        
    }
}
