using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    public partial class Partial_Method
    {
        public readonly int ht, wt;
        public Partial_Method(int h, int w)
        {
            ht = h; wt = w;
        }
        partial void disp();   // To be implemented in another part
        public void IsAverage()
        {
            if (ht > 5 && wt <= 72)
                Console.WriteLine("Well Built in");
            else
                Console.WriteLine("Not well Built in");
        }
    }
}

namespace Basics
{
    public partial class Partial_Method
    {
        partial void disp()
        {
            Console.WriteLine("Height = {0} and Weight = {1}", ht, wt);
        }
        public static void Main()
        {
            Partial_Method m = new Partial_Method(6, 70);
            m.disp();
            m.IsAverage();
        }
    }
}

