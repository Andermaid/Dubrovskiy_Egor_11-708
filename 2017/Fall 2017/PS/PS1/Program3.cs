//3. По заданному числу k, вывести символ 0 столько раз, сколько он встречается в двоичном представлении числа.
using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число k");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (k > 0)
            {
                if (k % 2 == 0) Console.Write('0');
                k /= 2;
            }
            Console.ReadLine();
        }
    }
}
