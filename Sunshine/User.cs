using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public User(string email, string password)
        {
            this.loginEmail = email;
            this.loginPassword = password;
        }
        public User()
        {

        }
        public void UserFacts(string name, decimal age, string country, string skinType)
        {
            this.name = name;
            this.age = age;
            this.skinType = skinType;
            this.country = country;
        }

        //checking if email and password are correct
        //checking in database
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
        public string Formula()
        {

        }
        */
        public bool PasswordCheck(string passwordCheck)
        {
            bool logCheck = false;
            if (loginPassword == passwordCheck)
            {
                logCheck = true;

            }
            return logCheck;
        }
        
    }
}
