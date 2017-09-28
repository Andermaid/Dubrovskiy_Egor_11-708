/*Cond7. ** (1484. Кинорейтинг) На сайте за фильм проголосовало N человек, каждый поставил оценку от 1 до 10. 
 * Сейчас рейтинг фильма равен X (рейтинг — средняя оценка, округлённая до десятых по математическим правилам, цифра 5 всегда округляется вверх). 
 * Сколько минимум раз нужно поставить фильму оценку 1, чтобы его рейтинг гарантированно стал не выше Y? В решении нельзя использовать циклы.*/
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double X = int.Parse(Console.ReadLine());
            double Y = int.Parse(Console.ReadLine());
            int n = (int)Math.Ceiling((N * (Y - X)) / (1 - Y));
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
