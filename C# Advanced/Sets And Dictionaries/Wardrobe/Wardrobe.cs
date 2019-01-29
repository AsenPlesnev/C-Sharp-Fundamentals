using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                 .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentItem = clothes[j];

                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j], 1);
                    }
                    else
                    {
                        wardrobe[color][clothes[j]]++;
                    }
                }
            }

            string[] targetItem = Console.ReadLine().Split();

            string targetColor = targetItem[0];
            string item = targetItem[1];

            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var clothes in kvp.Value)
                {
                    Console.Write($"* {clothes.Key} - {clothes.Value}");

                    if (kvp.Key == targetColor && clothes.Key == item)
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
