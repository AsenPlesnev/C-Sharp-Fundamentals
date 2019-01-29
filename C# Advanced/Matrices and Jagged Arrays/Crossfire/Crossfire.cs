using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossfire
{
    class Crossfire
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            List<List<int>> matrix = new List<List<int>>();

            GetMatrix(matrix, rows, cols);

            string input = Console.ReadLine();

            while (input != "Nuke it from orbit")
            {
                int[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();

                int row = tokens[0];
                int col = tokens[1];
                int radius = tokens[2];

                Attack(matrix, row, col, radius);

                input = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static void Attack(List<List<int>> matrix, int targetRow, int targetCol, int radius)
        {
            for (int row = targetRow - radius; row <= targetRow + radius; row++)
            {
                if (isInside(matrix, row, targetCol))
                {
                    matrix[row][targetCol] = 0;
                }
            }

            for (int col = targetCol - radius; col <= targetCol + radius; col++)
            {
                if (isInside(matrix, targetRow, col))
                {
                    matrix[targetRow][col] = 0;
                }
            }

            for (int row = 0; row < matrix.Count; row++)
            {
                matrix[row].RemoveAll(x => x == 0);

                if (matrix[row].Count == 0)
                {
                    matrix.RemoveAt(row);
                    row--;
                }
            }
        }

        private static bool isInside(List<List<int>> matrix, int row, int col)
        {
            return row >= 0 && row < matrix.Count && col >= 0 && col < matrix[row].Count;
        }

        private static void PrintMatrix(List<List<int>> matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }

        private static void GetMatrix(List<List<int>> matrix, int rows, int cols)
        {
            int counter = 1;

            for (int row = 0; row < rows; row++)
            {
                List<int> currentNumbers = new List<int>();

                for (int col = 0; col < cols; col++)
                {
                    currentNumbers.Add(counter++);
                }

                matrix.Add(currentNumbers);
            }
        }
    }
}
