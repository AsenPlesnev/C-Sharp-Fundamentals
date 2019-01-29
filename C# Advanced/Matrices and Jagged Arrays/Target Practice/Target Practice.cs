using System;
using System.Linq;

namespace Target_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            int[] target = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[][] matrix = new char[rows][];

            GetMatrix(matrix, cols, snake);

            Shoot(matrix, target);

            Collapse(matrix);

            Collapse(matrix);

            PrintMatrix(matrix);
        }

        private static void Collapse(char[][] matrix)
        {
            for (int j = 0; j < matrix[0].Length; j++) // Fall down all cells above the impact zone
            {
                for (int i = matrix.Length - 1; i > 0; i--)
                {
                    if (matrix[i][j] == ' ' && matrix[i - 1][j] != ' ')
                    {
                        CellFallsDown(matrix, i, j);
                    }
                }
            }
        }

        private static void CellFallsDown(char[][] matrix, int row, int col)
        {
            while (row < matrix.Length)
            {
                if (matrix[row][col] == ' ')
                {
                    var temp = matrix[row - 1][col];
                    matrix[row - 1][col] = matrix[row][col];
                    matrix[row][col] = temp;
                    row++;
                }
                else
                {
                    return;
                }
            }
        }

        private static void Shoot(char[][] matrix, int[] target)
        {
            int targetRow = target[0];
            int targetCol = target[1];
            int radius = target[2];

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    bool isInside = Math.Pow((targetRow - row),2) + Math.Pow((targetCol - col), 2) <= Math.Pow(radius, 2);

                    if (isInside)
                    {
                        matrix[row][col] = ' ';
                    }
                }
            }

        }

        private static void PrintMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(String.Join("", matrix[row]));
            }
        }

        private static void GetMatrix(char[][] matrix, int cols, string snake)
        {
            int counter = 0;

            bool isLeft = true;

            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                matrix[row] = new char[cols];

                if (isLeft)
                {
                    for (int col = matrix[row].Length - 1; col >= 0; col--)
                    {
                        if (counter > snake.Length - 1)
                        {
                            counter = 0;
                        }

                        matrix[row][col] = snake[counter++];
                    }

                    isLeft = false;
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (counter > snake.Length - 1)
                        {
                            counter = 0;
                        }

                        matrix[row][col] = snake[counter++];
                    }

                    isLeft = true;
                }
            }
        }
    }
}
