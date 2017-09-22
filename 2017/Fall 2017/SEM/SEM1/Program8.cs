//Expr8.Дана прямая L и точка А. Найти точку пересечения прямой L с перпендикулярной ей прямой Р, проходящей через точку А.
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
            var kL = Convert.ToDouble(Console.ReadLine());//Прямая y=kx+b.
            var bL = Convert.ToDouble(Console.ReadLine());
            int xA = 2;
            int yA = 5;
            var kP = -(1 / kL);
            var bP = yA - (xA * kP);
            double xCross;
            if (kL < kP || kL > kP)
            {
                xCross = (bL - bP) / (kP - kL);
            }
            else xCross = 0;
            var yCross = kL * xCross + bL;
            Console.WriteLine("Точка пересечения прямой y = " + kL.ToString() + "x + " + bL.ToString() + " с перпендикулярной ей прямой y = " + kP.ToString() + "x + " + bP.ToString() + " - (" + xCross.ToString() + ";" + yCross.ToString() + ").");
            Console.ReadLine();
        }
    }
}
