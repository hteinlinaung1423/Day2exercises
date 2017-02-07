using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2exercises
{
    class exe3
    {
        static void Main()
        {
            double s, t, h;
            Console.Write("Enter a salary : ");
            s = Convert.ToDouble(Console.ReadLine());
            t = s * 3 / 100;
            h = s * 10 / 100;
            Console.WriteLine("Total income : ${0:0,0.00}", (s + t + h));


        }
    }
}
