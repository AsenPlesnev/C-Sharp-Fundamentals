using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Diagonal_Difference
    {
        static void Main(string[] args)
        {
            int size = Int32.Parse(Console.ReadLine());

            int primarySum = 0;

            int secondarySum = 0;

            int[][] matrix = new int[size][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().
                    Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(Int32.Parse)
                    .ToArray();
  
            }

            for (int row = 0; row < matrix.Length; row++)
            { 
                    primarySum += matrix[row][row];

                    secondarySum += matrix[row][matrix.Length - 1 - row];
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
