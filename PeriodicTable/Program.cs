using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                foreach (var item in input)
                {
                    elements.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
