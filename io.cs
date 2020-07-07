using System;
using System.Collections.Generic;
using System.Text;
/*
 Program to print table of number using user's input
 */
namespace Basics
{
    class io
    {
        public readonly int n;
        io(int no) { n = no;  }
        public void disp()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, (n * i));
            }
        }
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number ?? ");
            n = Convert.ToInt32(Console.ReadLine());
            io t = new io(n);
            t.disp();
        }
    }
}
