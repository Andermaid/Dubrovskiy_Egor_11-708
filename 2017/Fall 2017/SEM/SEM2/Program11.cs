//Expr11. Дано время в часах и минутах. Найти угол от часовой к минутной стрелке на обычных часах.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int hour = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            if (hour >= 12)
            {
                hour -= 12;
            }
            double hourCorner = hour * 30 + min * 0.5;
            int minCorner = min * 6;
            double corner = Math.Abs(hourCorner - minCorner);
            if (corner > 180)
            {
                corner = 360 - corner;
            }
            Console.WriteLine(corner.ToString());
            Console.ReadLine();
        }
    }
}
