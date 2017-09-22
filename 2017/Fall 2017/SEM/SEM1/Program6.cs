//Expr6. Посчитать расстояние от точки до прямой, заданной двумя разными точками.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 2;
            double x = 1;
            double y = 1;
            double r = Math.Abs(((y2 - y1) * x) - ((x2 - x1) * y) + (x2 * y1) + (x1 * y2)) / Math.Sqrt(((y2 - y1) * (y2 - y1) + ((x2 - x1) * (x2 - x1))));
            Console.WriteLine(r.ToString());
            Console.ReadLine();
        }
    }
}
