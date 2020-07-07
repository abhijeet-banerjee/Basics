using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Basics
{
    public partial class Partial_class
    {
        public readonly int ht, wt;
        public Partial_class(int h,int w)
        {
            ht = h; wt = w;
        }
    }
}

namespace Basics
{
 public partial class Partial_class
    {
       public void disp()
        {
            Console.WriteLine("Height = {0} and Weight = {1}", ht, wt);
        }
    }
}

namespace MyTest
{
   public class Exec
    {
        public static void Main(string[] args)
        {
            Basics.Partial_class p = new Basics.Partial_class(6,78);
            p.disp();
        }
    }
}
