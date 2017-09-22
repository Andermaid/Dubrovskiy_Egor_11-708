//Expr10. Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main()
        {
            long sum = Sum(3) + Sum(5) - Sum(15);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        static long Sum(int n)
        {
            int count = 999 / n;
            int lastNumber = count * n;
            return (n + lastNumber) / 2 * count;
        }
        
    }
}
