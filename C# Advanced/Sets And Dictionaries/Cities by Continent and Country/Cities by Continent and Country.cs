using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Cities_by_Continent_and_Country
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < counter; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                    continents[continent].Add(country, new List<string>());
                    continents[continent][country].Add(city);
                }
                else
                {
                    if (!continents[continent].ContainsKey(country))
                    {
                        continents[continent].Add(country, new List<string>());
                        continents[continent][country].Add(city);
                    }
                    else
                    {
                        continents[continent][country].Add(city);
                    }

                }
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}
