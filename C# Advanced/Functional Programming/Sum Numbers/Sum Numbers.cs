using System;
using System.Linq;

namespace Sum_Numbers
{
    class Sum_Numbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(Parse)
                .ToArray();

            Console.WriteLine(numbers.Length);

            Console.WriteLine(numbers.Sum());
        }

        public static Func<string, int> Parse = n => int.Parse(n);
    }
}
