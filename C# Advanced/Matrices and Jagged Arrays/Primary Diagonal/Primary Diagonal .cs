using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Primary_Diagonal 
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int sumPrimary = 0;

            int[,] matrix = new int[count, count];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = Console.ReadLine()
                    .Split()
                    .Select(Int32.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];

                    if (row == col)
                    {
                        sumPrimary += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(sumPrimary);
        }
    }
}
