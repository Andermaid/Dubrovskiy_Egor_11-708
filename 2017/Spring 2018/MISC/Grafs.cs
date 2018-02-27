using System;
using System.Collections.Generic;

namespace ConsoleApp24
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] points = new int[n];
            while (true)
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                if (points[first] > 0)
                    points[second] = first;
                else if (points[second] > 0)
                    points[first] = second;
                else
                {
                    points[first] = first;
                    points[second] = first;
                }

            }
        }
    }
}