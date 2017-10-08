//5. По заданному k (от 1 до 20) найти наименьшее целое число, делящееся нацело на все числа от 1 до k.
using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число k");
            int k = int.Parse(Console.ReadLine());
            int nok = 1;
            for (int i = 1; i < k+1; i++)
            {
                int a = nok;
                int b = i;
                while (a != b)
                {
                    if (a > b) a -= b;
                    else b -= a;
                }
                int nod = a;
                nok *= i / nod;
            }
            Console.WriteLine(nok);
            Console.ReadLine();
        }
    }
}
