using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    class SoftUni_Party
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            var entry = Console.ReadLine();

            while (entry?.ToLower() != "party")
            {
                guests.Add(entry);

                entry = Console.ReadLine();
            }

            entry = Console.ReadLine();

            while (entry?.ToLower() != "end")
            {
                guests.Remove(entry);

                entry = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var guest in guests)
            {
                if (numbers.Contains(guest[0]))
                {
                    Console.WriteLine(guest);
                }
            }

            foreach (var guest in guests)
            {
                if (!numbers.Contains(guest[0]))
                {
                    Console.WriteLine(guest);
                }
            }

        }
    }
}
