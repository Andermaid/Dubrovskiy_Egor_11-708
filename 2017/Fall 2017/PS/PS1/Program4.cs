//4. По заданному числу k и последовательности из n чисел (n<10000) найти длину самой длинной цепочки в последовательности, состоящей из чисел k (равных ему).
using System;
namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число k");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество чисел в последовательности n");
            int n = int.Parse(Console.ReadLine());
            int maxChainOfK = 0;
            int chainOfK = 0;
            Console.WriteLine("Введите n чисел последовательности");
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == k)
                {
                    chainOfK += 1;
                    if (chainOfK > maxChainOfK) maxChainOfK = chainOfK;
                }
                else chainOfK = 0;
            }
            Console.WriteLine(maxChainOfK);
            Console.ReadLine();
        }
    }
}
