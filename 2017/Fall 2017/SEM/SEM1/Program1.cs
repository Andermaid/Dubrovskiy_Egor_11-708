//Expr1. Как поменять местами значения двух переменных?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 5;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
