using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program<T>
    {
        static IEnumerable<string> MakeNewSequenceLinq(IEnumerable<string> a, IEnumerable<string> b)
        {
            var result =
                from first in a
                from second in b
                select (string)(first + "." + second.Where(n => first.Count(char.IsLetter) == second.Count(char.IsLetter) ||
                                                           (first.Count(char.IsDigit) == second.Count(char.IsDigit) &&
                                                            first.Count(char.IsLetter) < second.Count(char.IsLetter))));
            return result
                .OrderByDescending(n => n);
        }
    }
}
