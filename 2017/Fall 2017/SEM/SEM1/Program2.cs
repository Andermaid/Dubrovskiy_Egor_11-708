//Expr2. Задается натуральное трехзначное число (гарантируется, что трехзначное). Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            int a = 147;
            int b = a/100;
            a %= 100;
            b += (a / 10) * 10;
            b += (a % 10) * 100;
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
