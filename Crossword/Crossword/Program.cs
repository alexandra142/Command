using System;
using System.Collections.Generic;

namespace Crossword
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> names = new List<string>() { "mery","alex", "jozko", "ale" };

            Console.WriteLine("Before sort");
            names.ForEach(Console.WriteLine);
            Console.WriteLine("=============================");

            Sort(names);

            Console.WriteLine("After sort:");
            names.ForEach(Console.WriteLine);

            Console.ReadKey();
        }

        private static void Sort(List<string> names)
        {
            names.Sort(CompareNames);
        }

        private static int CompareNames(string name1, string name2)
        {
            int l1 = name1.Length;
            int l2 = name2.Length;

            if (l1 == l2)
                return string.Compare(name1, name2, true);

            return l1 - l2;
        }
    }
}
