using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Count_Same_Values_In_Array
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Double.Parse)
                .ToArray();

            Dictionary<double, int> values = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!values.ContainsKey(input[i]))
                {
                    values.Add(input[i], 1);
                }
                else
                {
                    values[input[i]]++;
                }
            }

            foreach (var kvp in values)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
