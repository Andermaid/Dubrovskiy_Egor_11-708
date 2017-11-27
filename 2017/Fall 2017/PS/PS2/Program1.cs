/*Вычислить сумму ряда с заданной точностью е и определить, на каком шаге достигается эта точность.
 * 1)Arctg(X); |X|<=1
 * 2)Sqrt(X + 1); |X|<=1
 * 3)X^a
 Выполнил - Дубровский Егор*/

using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите х");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите е");
            double e = double.Parse(Console.ReadLine());
            double countOfNumbersAfterPoint = Math.Pow(e, -1);
            Console.WriteLine("Введите а");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Arctg {0} = {1}\n", x, ((int)(GetSumOfArctg(x, e, 1, 0) * countOfNumbersAfterPoint)) / countOfNumbersAfterPoint);
            Console.WriteLine("{0}^{1} = {2}\n", x, a, ((int)(GetSumOfXPowA(x, e, 0, a, 0) * countOfNumbersAfterPoint)) / countOfNumbersAfterPoint);
            Console.WriteLine("Sqrt {0} = {1}\n", x + 1, ((int)(GetSumOfSqrt(x, e, 0, 0) * countOfNumbersAfterPoint)) / countOfNumbersAfterPoint);
            Console.ReadLine();
        }
        /*Результат умножается на е^-1, чтобы в нужная часть числа осталась в целой части,
        затем от этого числа отсекается лишнее, и полученное число заново делится на e^-1*/ 

        static double GetSumOfArctg(double x, double e, int n, double lastResult)
        {
            double result = x / n;
            if (Math.Abs(lastResult - result) < e)
            {
                Console.WriteLine("Точность достигнута на шаге " + ((n / 2) + 1));
                return 0;
            }
            return result + GetSumOfArctg(-x * Math.Pow(x, 2), e, n + 2, result);
        }

        static double GetSumOfSqrt(double x, double e, int n, double lastResult)
        {
            double result = Math.Pow(-1, n) * Math.Pow(x, n) / (1 - (2 * n)) / Math.Pow(4, n); ;
            if (n > 0) result *= Factorial(2 * n) / Math.Pow(Factorial(n), 2);
            if (Math.Abs(lastResult - result) < e)
            {
                Console.WriteLine("Точность достигнута на шаге " + (n + 1));
                return 0;
            }
            return result + GetSumOfSqrt(x, e, n + 1, result);
        }

        static double GetSumOfXPowA(double x, double e, int n, double a, double lastResult)
        {
            double result = Math.Pow(a - 1, n) * x * Math.Pow(Math.Log(x), n) / Factorial(n);
            if (Math.Abs(lastResult - result) < e)
            {
                Console.WriteLine("Точность достигнута на шаге " + (n + 1));
                return 0;
            }
            return result + GetSumOfXPowA(x, e, n + 1, a, result);
        }

        static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }
}