//Expr4.Найти количество чисел меньших N, которые имеют простые делители X или Y.
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
            int x = 5;
            int y = 7;
            int N = 20;
            N-= 1;
            int m;
            m = (N / x) + (N / y) - (N /( x * y ));
            Console.WriteLine(m.ToString());
            Console.ReadLine();
        }
    }
}
