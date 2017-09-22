//Expr3. Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            int H = 19;
            if (H > 11)
            {
                H -= 12;
            }
            if (H> 5)
            {
                H = 12 - H;
            }
            H *= 30;
            Console.WriteLine(H.ToString());
            Console.ReadLine();
        }
    }
}
