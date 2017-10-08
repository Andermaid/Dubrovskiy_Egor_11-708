//6. Найти максимальную длину последовательности натуральных чисел, равных в сумме числу n(n<=10^9). Пример: 25 = 3+4+5+6+7 (длина 5).
using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число n");
            long n = long.Parse(Console.ReadLine());
            int maxChainLenght = 0;
            for (long i = 1; i <= n / 2 + 1; i++)
            {
                int chainLenght = 0;
                for (int j = 0; j < n /2 + 1; j++)
                {
                    if (n == (2 * i + j) / 2 * (j + 1))//Сумма членов арифметической прогрессии от i до i+j.
                    {
                        chainLenght = j + 1;
                        if (chainLenght > maxChainLenght) maxChainLenght = chainLenght;
                        break;
                    }
                }
            }
            Console.WriteLine(maxChainLenght);
            Console.ReadLine();
        }
    }
}
