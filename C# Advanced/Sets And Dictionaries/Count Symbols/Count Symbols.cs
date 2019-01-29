using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Count_Symbols
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbolsCount = new SortedDictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbolsCount.ContainsKey(input[i]))
                {
                    symbolsCount.Add(input[i], 1);
                }

                else
                {
                    symbolsCount[input[i]]++;
                }
            }

            foreach (var kvp in symbolsCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
