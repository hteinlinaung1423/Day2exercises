using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2exercises
{
    class exe6
    {
        static void Main()
        {
            int x1,x2, y1,y2;
            Console.Write("Enter a coordiante of x1 : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coordiante of x2 : ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coordiante of y1 : ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a coordiante of y2 : ");
            y2 = Convert.ToInt32(Console.ReadLine());
            double dis;
            dis = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
            dis = Math.Sqrt(dis);
            Console.WriteLine("Output of distance : {0}", dis);
        }
    }
}
