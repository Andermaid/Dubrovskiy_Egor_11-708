using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1
{
    class Number
    {
        public int NumeralSystem;
        public List<Numeric> Elements;

        public Number(int numeralSystem)
        {
            NumeralSystem = numeralSystem;
        }

        static public Number Code(int number, int numeralSystem)
        {
            var newNumber = new Number(numeralSystem);
            while (number > 0)
            {
                newNumber.Elements.AddFirst(new Numeric(number % numeralSystem));
                number /= numeralSystem;
            }
            Console.WriteLine("Данное число в {0}-ичной системе = ", numeralSystem);
            Print(newNumber);
            return newNumber;
        }

        public int Decode(Number number)
        {
            return -1;
        }

        public static void Print(Number number)
        {
            foreach (Numeric e in number.Elements)
                Console.Write(e.Num);
        }
    }

    class Numeric
    {
        public int Num;
        //public int Position;

        public Numeric(int num)
        {
            Num = num;
        }
    }
}
