using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class Even_Times
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> evenInteger = new Dictionary<int, int>();

            int number = 0;

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (!evenInteger.ContainsKey(number))
                {
                    evenInteger.Add(number, 1);
                }
                else
                {
                    evenInteger[number] += 1;
                }
            }

            foreach (var kvp in evenInteger)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
