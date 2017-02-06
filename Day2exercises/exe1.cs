using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2exercises
{
    class exe1
    {
        static void Main(string[] args)
        {
            double d;
            Console.Write("Enter a double precision number : ");
            d = Convert.ToDouble(Console.ReadLine());
            d = Math.Sqrt(d);
            Console.WriteLine("Square root of the number : {0} ", d);

        }
    }
}
