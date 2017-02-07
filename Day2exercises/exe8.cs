using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2exercises
{
    class exe8
    {
        static void Main()
        {
            double dis;
            Console.Write("Enter a distance travelled : ");
            dis = Convert.ToDouble(Console.ReadLine());
            double total;
            total = 2.40 + dis * 0.4;
            total = Math.Round(total, 1);
            Console.WriteLine("Total Fare : {0:0.00}", total);
        }
    }
}
