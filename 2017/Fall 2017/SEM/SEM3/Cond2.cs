//Cond2.Пролезет ли брус со сторонами x, y, z в отверстие со сторонами a, b, если его разрешается поворачивать на 90 градусов?
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            bool result;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if ((a > x && b > y) || (a > y && b > x)) result = true;
            else if ((a > x && b > z) || (a > z && b > x)) result = true;
            else if ((a > z && b > y) || (a > y && b > z)) result = true;
            else result = false;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
