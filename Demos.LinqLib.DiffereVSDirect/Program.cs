using System;
using System.Collections.Generic;
using System.Linq;

namespace Demos.LinqLib.DiffereVSDirect
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> ints = new List<int>{ 2, 5, 23, 46, 72, 103 };
            ints = ints.getPairOnly();

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }

    static class ArrayExt
    {
        public static IEnumerable<int> getPairOnly (this IEnumerable<int> ints)
        {
            foreach (int i in ints)
            {
                if (i % 2 == 0) yield return i;
            }
           
        }
    }
}
