using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    class string_formatting
    {
        static int a = 45, b = 78, c = 0;
        public static void Main()
        {
            c = a + b;
            Console.WriteLine("Sum of {0} + {1} = {2}", a, b, c);
        }
    }
}
