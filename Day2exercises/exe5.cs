using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2exercises
{
    class exe5
    {
        static void Main()
        {
            int x, y;
            Console.Write("Enter an integer number : ");
            x = Convert.ToInt32(Console.ReadLine());
            y = (5 * x * x) - 4 * x + 3;
            Console.WriteLine("Output of y : {0}", y);

        }
    }
}
