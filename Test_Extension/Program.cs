using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr = new User("Arjun", "Rampal");

            Console.WriteLine(usr.getFirstName());
            Console.WriteLine(usr.getSecondName());
            usr.getFullName();
            Console.ReadKey();
        }
    }
}
