using System;
using System.Linq;

namespace Group_Numbers
{
    class Group_Numbers
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];

            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

            jaggedArray[0] = input
                .Where(x => Math.Abs(x) % 3 == 0)
                .ToArray();

            jaggedArray[1] = input
                .Where(x => Math.Abs(x) % 3 == 1)
                .ToArray();

            jaggedArray[2] = input
                .Where(x => Math.Abs(x) % 3 == 2)
                .ToArray();

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(String.Join(' ', item));
            }
        }
    }
}
