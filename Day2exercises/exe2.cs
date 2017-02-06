using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2exercises
{
    class exe2
    {
        static void Main()
        {
            double d;
            Console.Write("Enter a double precision number : ");
            d = Convert.ToDouble(Console.ReadLine());
            d = Math.Sqrt(d);
            Console.WriteLine("The square root of the number rounded to 3 decimal : {0:0.000}", d);
        }

    }
}
