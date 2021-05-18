using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    class Test
    {
        static void Main(string[] args)
        {
            int i = 0;
            ulong ul = 0;
            string s = "Test";

            Console.WriteLine("int: {0}", Utils1.Utils.IsItFormattable(i));
            Console.WriteLine("ulong: {0}", Utils1.Utils.IsItFormattable(ul));
            Console.WriteLine("String: {0}", Utils1.Utils.IsItFormattable(s));
            Console.ReadKey();
        }
    }
}
