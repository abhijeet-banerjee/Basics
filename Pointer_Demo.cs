using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    public unsafe class Pointer_Demo
    {
        public void Mul(int *a,int *b)
        {
            *a *= 2;
            *b *= 3;
        }
        public static void Main()
        {
            int a = 4, b = 5;
            Pointer_Demo d = new Pointer_Demo();
            d.Mul(&a,&b);
            Console.WriteLine("a = "+a+" b= "+b);
        }
    }
}
