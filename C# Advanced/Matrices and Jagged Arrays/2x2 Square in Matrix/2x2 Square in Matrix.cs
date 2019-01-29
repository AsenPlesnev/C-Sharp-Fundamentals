using System;
using System.Linq;

namespace _2x2_Square_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            char[][] matrix = new char[rows][];

            int squareCounter = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(Char.Parse)
                    .ToArray();
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (col < cols - 1 && row < rows - 1)
                    {
                        if (matrix[row][col] == matrix[row][col + 1] && matrix[row][col] == matrix[row + 1][col] && matrix[row][col] == matrix[row + 1][col + 1])
                        {
                            squareCounter++;
                        }
                    }
                }
            }

            Console.WriteLine(squareCounter);
        }
    }
}
