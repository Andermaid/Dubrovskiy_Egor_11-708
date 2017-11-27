/*Напишите программу для перевода многозначного числа в системы счисления с основанием 2, 8, 16.
 * Выполнил - Дубровский Егор*/
using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число");
            string text = Console.ReadLine();
            int count = text.Length;;
            int[] number = new int[count];
            for (int i = 0; i < count; i++)
                number[i] = (int)text[i] - 48;
            Console.WriteLine("{0} в двоичной системе = {1}\n", text, ConvertToSystemN(2, count, (int[])number.Clone()));
            Console.WriteLine("{0} в восьмеричной системе = {1}\n", text, ConvertToSystemN(8, count, (int[])number.Clone()));
            Console.WriteLine("{0} в шестнадцатиричной системе = {1}\n", text, ConvertToSystemN(16, count, (int[])number.Clone()));
            Console.ReadLine();
        }
        static string ConvertToSystemN(int n, int count, int[] number)
        {
            bool allZero = true;
            for (int i = 0; i < count - 1; i++)
            {
                number[i + 1] += (number[i] % n) * 10;
                number[i] /= n;
                if (number[i] != 0) allZero = false;
            }
            int lastNumber = number[count - 1] % n;
            number[count - 1] /= n;
            if (allZero == true && number[count - 1] == 0)
                if (lastNumber > 9) return ((char)(lastNumber + 55)).ToString();
                else return lastNumber.ToString();
            if (lastNumber > 9) return ConvertToSystemN(n, count, number).ToString() + ((char)(lastNumber + 55)).ToString();
            return ConvertToSystemN(n, count, number).ToString() + lastNumber.ToString();
        }
    }
}
