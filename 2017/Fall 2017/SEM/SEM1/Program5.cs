//Expr5. Найти количество високосных лет на отрезке [a, b], не используя циклы.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int a = 1999;
            int b = 2001;
            int n;
            n = (b / 4) - (b / 100) + (b / 400) - ((a / 4) - (a / 100) + (a / 400));
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
