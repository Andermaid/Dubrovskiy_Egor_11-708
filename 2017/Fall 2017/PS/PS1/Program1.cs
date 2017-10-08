//1. Проверить, является ли шестизначное число палиндромом (abcdef=fedcba).
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите шестизначное число");
            long number = int.Parse(Console.ReadLine());
            Console.WriteLine("Palindrom Check "+PalindromCheck(number));
            Console.ReadLine();
        }
        static bool PalindromCheck(long number)
        {
            int firstHalf = (int)(number / 1000);
            int secondHalf = (int)(number - (firstHalf * 1000));
            int inversedSecondHalf = secondHalf / 100;
            secondHalf %= 100;
            inversedSecondHalf += (secondHalf / 10) * 10;
            inversedSecondHalf += (secondHalf % 10) * 100;
            return firstHalf == inversedSecondHalf;
        }
    }
}
