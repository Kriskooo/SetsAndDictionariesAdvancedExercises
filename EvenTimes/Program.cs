using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> occurancies = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (!occurancies.ContainsKey(currNum))
                {
                    occurancies.Add(currNum, 0);
                }
                occurancies[currNum]++;
            }
            foreach (var item in occurancies)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }

        }
    }
}
