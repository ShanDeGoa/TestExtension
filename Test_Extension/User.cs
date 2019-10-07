using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Extension
{
    class User
    {
        string firstName;
        string lastName;


        public User(string firstName,string lastName){

            this.firstName = firstName;
            this.lastName = lastName;

        }


        public string getFirstName()
        {
            return ("Mr . " + this.firstName);
        }

        public string getSecondName()
        {
            return ( this.lastName);
        }

        
    }
}
