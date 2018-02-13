using System;
using System.Collections.Generic;

namespace ConsoleApp24
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Fraction> list = new List<Fraction>
            {
                new Fraction { num = 0, denom = 1 },
                new Fraction { num = 1, denom = 1 }
            };
            if (n > 1)
                for (int i = 2; i <= n; i++)
                {
                    int countOfFractions = list.Capacity * 2;
                    int countOfNewFractions = 0;
                    for (int j = 0; j < countOfFractions; j++)
                    {
                        if (list[j + countOfNewFractions].num == 1 && list[j + countOfNewFractions].denom == 1) break;
                        double a = list[j + countOfNewFractions].num;
                        double b = list[j + countOfNewFractions].denom;
                        double c = list[j + countOfNewFractions + 1].num;
                        double d = list[j + countOfNewFractions + 1].denom;
                        double newFraction = (a + c) / (b + d);
                        if (a / b < newFraction && newFraction < c / d && b + d <= i)
                        {
                            list.Insert(j + 1 + countOfNewFractions, new Fraction { num = (int)(a + c), denom = (int)(b + d) });
                            countOfNewFractions++;
                        }
                    }
                }
            foreach (Fraction e in list)
                Console.WriteLine("{0}/{1}", e.num, e.denom);
            Console.ReadLine();
        }
    }

    public struct Fraction
    {
        public int num;
        public int denom;
    }
}