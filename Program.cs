using System;
// Usage of dynamic.
namespace Basics
{
    class Program
    {
        public void disp(dynamic x,dynamic y)
        {
            Console.WriteLine("x's type is "+x.GetType().ToString()+" and y's type is "+y.GetType().ToString());
            Console.WriteLine(x+y+"\n");
        }
        public dynamic Prod(dynamic a,dynamic b)
        {
            return (a * b);
        }
        static void Main(string[] args)
        {
            Program m = new Program();
            m.disp(1200, 7895);
            m.disp("Abhijeet ", "Banerjee");
            dynamic q = m.Prod(455, 788);
            Console.WriteLine("Product = "+q);

        }

    }
}
