using System;
using System.Linq;

namespace Square_With_Maximum_Sum
{
    class Square_With_Maximum_Sum 
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ")
                .Select(Int32.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            int maxSum = Int32.MinValue;

            int rowIndex = 0;
            int colIndex = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] columnElement = Console.ReadLine()
                    .Split(", ")
                    .Select(Int32.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = columnElement[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;

                        rowIndex = i;
                        colIndex = j;
                    }
                }
            }


            for (int i = rowIndex; i < rowIndex + 2; i++)
            {
                for (int j = colIndex; j < colIndex + 2; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
