/*Произвести вычисления с точностью е по следующей рекуррентной схеме:
 * X0 = 0, Xk = cos(Xk-1). При этом Xn стремится к Х, где Х - корень уравнения Х = cos(X)
 Выполнил - Дубровский Егор*/
using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите е");
            double e = double.Parse(Console.ReadLine());
            double countOfNumbersAfterPoint = Math.Pow(e, -1);
            Console.WriteLine("Результат рекуррентных вычислений = " + (((int)(RecursionOfCos(e, 0, 0) * countOfNumbersAfterPoint)) / countOfNumbersAfterPoint));
            Console.ReadLine();
        }

        static double RecursionOfCos(double e, double x, double lastResult)
        {
            double result = Math.Cos(x);
            if (Math.Abs(result - lastResult) < e) return result;
            return RecursionOfCos(e, result, result);
        }

    }
}
