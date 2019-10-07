using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Extension
{
    static class  UserExtension
    {
        public static void getFullName(this User obj)
        {
            Console.WriteLine("{0} De  {1}", obj.getFirstName(), obj.getSecondName());
        }

    }
}
