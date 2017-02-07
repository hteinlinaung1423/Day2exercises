using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2exercises
{
    class exe4
    {
        static void Main()
        {
            int c;
            Console.Write("Enter a Celsius : ");
            c = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(1.8 * c + 32);
            Console.WriteLine("Tempature in Fahrenheit : {0}", f);
        }
    }
}
