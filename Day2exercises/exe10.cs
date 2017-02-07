using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2exercises
{
    class exe10
    {
        static void Main()
        {
            int a, b, c;
            double s;
            Console.Write("Enter a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c :");
            c = Convert.ToInt32(Console.ReadLine());
            s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Area of Triangle : {0}", area);

        }
    }
}
