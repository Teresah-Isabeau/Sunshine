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
        private string email;
        private string password;
        private string country;
        private string counter;

        public User(string name, int age, int skinType, string email, string password, string country, string counter)
        {
            this.name = name;
            this.age = age;
            this.skinType = skinType;
            this.email = email;
            this.password = password;
            this.country = country;
            this.counter = counter;
        }

        public void newAccount()
        {

        }

        public bool loginCheck()
        {

        }

        public string formula()
        {

        }
        
    }
}
