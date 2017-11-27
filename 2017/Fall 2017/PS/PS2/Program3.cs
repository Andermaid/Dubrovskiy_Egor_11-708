/*Вычислить приближённое значение определённого интеграла на промежутке [1, 3] функции y = cos(sin(x)).
 * Выполнил - Дубровский Егор*/
using System;
using System.Collections.Generic;

namespace ConsoleApp20
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество промежутков");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("y = cos(sin(x))\nЗначение интеграла = 1,39408\n");
            Console.WriteLine("Метод правых прямоугольников\nРезультат = {0:0.00000}\n", MethodOfRightRectangles(n));
            Console.WriteLine("Метод левых прямоугольников\nРезультат = {0:0.00000}\n", MethodOfLeftRectangles(n));
            Console.WriteLine("Метод трапеций\nРезультат = {0:0.00000}\n", MethodOfTrapezes(n));
            Console.WriteLine("Метод Симпсона\nРезультат = {0:0.00000}\n", SimpsonsMethod(n));
            Console.WriteLine("Метод Монте-Карло\nРезультат = {0:0.00000}\n", MonteCarloMethod());
            Console.ReadLine();
        }

        static double MethodOfRightRectangles(double n)
        {
            double integral = 0;
            double segment = 2 / n;
            for (int i = 1; i <= n; i++)
            {
                integral += Math.Cos(Math.Sin(1 + (segment * i)));
            }
            integral *= segment;
            return integral;
        }

        static double MethodOfLeftRectangles(double n)
        {
            double integral = 0;
            double segment = 2 / n;
            for (int i = 0; i < n; i++)
            {
                integral += Math.Cos(Math.Sin(1 + (segment * i)));
            }
            integral *= segment;
            return integral;
        }

        static double MethodOfTrapezes(double n)
        {
            double integral = 0;
            double segment = 2 / n;
            for (int i = 0; i < n; i++)
            {
                integral += Math.Cos(Math.Sin(1 + (segment * i))) + Math.Cos(Math.Sin(1 + (segment * (i + 1))));
            }
            integral *= segment / 2;
            return integral;
        }

        static double SimpsonsMethod(double n)
        {
            double integral = Math.Cos(Math.Sin(1));
            double segment = 2 / n;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0) integral += 2 * Math.Cos(Math.Sin(1 + (segment * i)));
                else integral += 4 * Math.Cos(Math.Sin(1 + (segment * i)));
            }
            //По формуле Котеса
            integral *= segment / 3;
            return integral;
        }

        static double MonteCarloMethod()
        {
            Random random = new Random();
            var points = new Dictionary<double, double>();
            double[] pointsX = new double[1000000];
            for (int i = 0; i < 1000000; i++)
            {
                pointsX[i] = 1 + random.NextDouble() + random.NextDouble();
                points[pointsX[i]] = random.NextDouble();
            }
            double allPointsCount = points.Count;
            double rightPointsCount = 0;
            foreach (var e in points)
                if (e.Value <= Math.Cos(Math.Sin(e.Key))) rightPointsCount++;
            return 2 * rightPointsCount / allPointsCount;
        }
    }
}
