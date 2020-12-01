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
        private int age;
        private int skinType;
        private readonly string email;
        private readonly string password;
        private string country;
        private string counter;
        private string passwordCheck;
        

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
        public User()
        {

        }
        public void UserFacts(int name, int age, int skinType, int country, int counter)
        {

        }

        //checking if email and password are correct
        //checking in database
        public bool LoginCheck(string inputEmail, string inputPass)
        {
            bool loginCheck = false;
            if (inputEmail == email && inputPass == password)
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
            if (password == passwordCheck)
            {
                logCheck = true;

            }
            return logCheck;
        }
        
    }
}
