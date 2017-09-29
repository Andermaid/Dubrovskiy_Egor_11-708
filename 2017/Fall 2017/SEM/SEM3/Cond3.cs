/*Cond3. (1493. В одном шаге от счастья) Дан номер трамвайного билета, 
 * в котором суммы первых трёх цифр и последних трёх цифр отличаются на 1 (но не сказано, в какую сторону). 
 * Правда ли, что предыдущий или следующий билет счастливый?*/
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            long number = int.Parse(Console.ReadLine());
            Console.WriteLine("Предыдущий номер счастливый - " + CheckLuck(number - 1));
            Console.WriteLine("Следующий номер счастливый - " + CheckLuck(number + 1));
            Console.ReadLine();
        }
        static bool CheckLuck(long number)
        {
            int firstHalf = (int)(number / 1000);
            int secondHalf = (int)(number - (firstHalf * 1000));
            return SumOfNumbers(firstHalf) == SumOfNumbers(secondHalf);
        }
        static int SumOfNumbers(int number)
        {
            return (number / 100) + (number % 10) + ((number / 10) - ((number / 100) * 10));
        }
    }
}
