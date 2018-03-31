using System;

namespace Sem1
{
    class Number
    {
        public int NumeralSystem;
        public List<int> Elements;

        public Number(int numeralSystem)
        {
            Elements = new List<int>();
            NumeralSystem = numeralSystem;
        }

        public static Number Code(int number, int numeralSystem)
        {
            var result = new Number(numeralSystem);
            while (number > 0)
            {
                result.Elements.AddFirst(number % numeralSystem);
                number /= numeralSystem;
            }
            if (result.Elements.Count == 0) result.Elements.Add(number);
            return result;
        }

        public static int Decode(Number number)
        {
            int result = 0;
            int n = 1;
            var current = number.Elements.Tail;
            while (current != null)
            {
                result += n * current.Value;
                n *= number.NumeralSystem;
                current = current.Previous;
            }
            return result;
        }

        public static Number Multiplicate(Number multiplicand, int q)
        {
            if (multiplicand.NumeralSystem <= q) throw new Exception("Разные системы счисления");
            Number result = new Number(multiplicand.NumeralSystem);
            result.Elements.Add(0);
            var currentMultiplicand = multiplicand.Elements.Tail;
            var currentResult = result.Elements.Tail;
            while (currentMultiplicand != null)
            {
                currentResult.Value = currentMultiplicand.Value * q;
                result.Elements.AddFirst(currentMultiplicand.Value / multiplicand.NumeralSystem);
                currentResult.Value %= multiplicand.NumeralSystem;
                currentMultiplicand = currentMultiplicand.Previous;
                currentResult = currentResult.Previous;
            }
            return result;
        }

        public static Number AddictSimpleNumber(Number number, int q)
        {
            var current = number.Elements.Tail;
            current.Value += q;
            while (current.Value >= number.NumeralSystem)
            {
                current.Previous.Value += current.Value / number.NumeralSystem;
                current.Value %= number.NumeralSystem;
                current = current.Previous;
            }
            return number;
        }

        public static Number AddictTwoNumbers(Number firstArg, Number secondArg)
        {
            if (firstArg.NumeralSystem != secondArg.NumeralSystem) throw new Exception("Разные системы счисления");
            Number result;
            Number argument;
            if (firstArg.Elements.Count >= secondArg.Elements.Count)
            {
                result = firstArg;
                argument = secondArg;
            }
            else
            {
                result = secondArg;
                argument = firstArg;
            }
            var currentResult = result.Elements.Tail;
            var currentArgument = argument.Elements.Tail;
            while (currentArgument.Previous != null)
            {
                currentResult.Value += currentArgument.Value;
                currentResult.Previous.Value += currentResult.Value / result.NumeralSystem;
                currentResult.Value %= result.NumeralSystem;
                currentResult = currentResult.Previous;
                currentArgument = currentArgument.Previous;
            }
            currentResult.Value += currentArgument.Value;
            if (currentResult.Previous == null) result.Elements.AddFirst(currentResult.Value / result.NumeralSystem);
            else currentResult.Previous.Value += currentResult.Value / result.NumeralSystem;
            currentResult.Value %= result.NumeralSystem;
            return result;
        }

        public static Number MultiplicateTwoNumbers(Number multiplicand, Number multiplier)
        {
            if (multiplicand.NumeralSystem != multiplier.NumeralSystem) throw new Exception("Разные системы счисления");
            var result = new Number(multiplicand.NumeralSystem);
            result.Elements.Add(0);
            var tempMultiplicand = multiplicand;
            var currentMultiplier = multiplier.Elements.Tail;
            while (currentMultiplier != null)
            {
                AddictTwoNumbers(result, Multiplicate(tempMultiplicand, currentMultiplier.Value));
                currentMultiplier = currentMultiplier.Previous;
                tempMultiplicand.Elements.Add(0);
            }
            return result;
        }

        public static void Print(Number number)
        {
            Console.Write("Данное число в {0}-ичной системе = ", number.NumeralSystem);
            foreach (int e in number.Elements)
                Console.Write(e);
            Console.WriteLine();
        }
    }
}
