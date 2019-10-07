using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Extension
{
    static class IntExtension
    {
        public static string TripleValue(this int val)
        {
            return (val * 3).ToString();
        }
    }
}
