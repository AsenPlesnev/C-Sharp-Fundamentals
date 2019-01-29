using System;
using System.Linq;

namespace Add_VAT
{
    class Add_VAT
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n * 1.2)
                .ToArray();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
