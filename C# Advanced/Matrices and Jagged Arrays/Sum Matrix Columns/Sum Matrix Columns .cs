using System;
using System.Linq;

namespace Sum_Matrix_Columns
{
    class Sum_Matrix_Columns
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(", ")
                .Select(Int32.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            int[] sumOfColumns = new int[matrix.GetLength(1)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = Console.ReadLine()
                    .Split(" ")
                    .Select(Int32.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];

                    sumOfColumns[col] += columnElements[col];
                }
            }

            foreach (var element in sumOfColumns)
            {
                Console.WriteLine(element);
            }
        }
    }
}
