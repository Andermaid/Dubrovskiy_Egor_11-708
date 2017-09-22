//Expr7.Найти вектор, параллельный прямой. Перпендикулярный прямой.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main()
        {
            int k = Convert.ToInt32(Console.ReadLine()); //Прямая y=kx+b.
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Параллельный вектор-(1;"+k.ToString()+")");
            Console.WriteLine("Перпендикулярный вектор-("+(-k).ToString()+";1)");
            Console.ReadLine();
        }
    }
}
