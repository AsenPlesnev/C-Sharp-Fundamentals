using System;
using System.Collections.Generic;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Revision")
            {
                if (!shops.ContainsKey(input[0]))
                {
                    shops.Add(input[0], new Dictionary<string, double>());
                    shops[input[0]].Add(input[1], double.Parse(input[2]));

                }

                if (!shops[input[0]].ContainsKey(input[1]))
                {
                    shops[input[0]].Add(input[1], double.Parse(input[2]));
                }

                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
