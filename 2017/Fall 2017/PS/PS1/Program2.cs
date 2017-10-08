//2. По двум первым членам арифметической прогрессии и числу k вычислить значение k-го члена.
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первые 2 члена прогрессии");
            double a1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число k");
            int k = int.Parse(Console.ReadLine());
            double d = a2 - a1;
            double ak = a1 + (d * (k - 1));
            Console.WriteLine(ak);
            Console.ReadLine();
        }
    }
}
