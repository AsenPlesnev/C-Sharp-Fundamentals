using System;
using System.Linq;

namespace Rubik_s_Matrix
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

            int[][] rubikMatrix = new int[rows][];

            GetMatrix(rubikMatrix, cols);

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int index = int.Parse(tokens[0]);
                string command = tokens[1];
                int moves = int.Parse(tokens[2]);

                if (command == "down")
                {
                    MoveDown(rubikMatrix, index, moves % rubikMatrix.Length);
                }

                else if (command =="left")
                {
                    MoveLeft(rubikMatrix, index, moves % rubikMatrix[0].Length);
                }

                else if (command == "right")
                {
                    MoveRight(rubikMatrix, index, moves % rubikMatrix[0].Length);
                }

                else if (command == "up")
                {
                    MoveUp(rubikMatrix, index, moves % rubikMatrix.Length);
                }
            }

            int counter = 1;

            for (int row = 0; row < rubikMatrix.Length; row++)
            {
                for (int col = 0; col < rubikMatrix[row].Length; col++)
                {
                    if (rubikMatrix[row][col] == counter)
                    {
                        Console.WriteLine("No swap required");
                        counter++;
                        continue;
                    }
                    else
                    {
                        Rearrange(rubikMatrix, row, col, counter);
                        counter++;
                    }
                }
            }
        }

        private static void Rearrange(int[][] rubikMatrix, int row, int col, int counter)
        {
            for (int targetRow = 0; targetRow < rubikMatrix.Length; targetRow++)
            {
                for (int targetCol = 0; targetCol < rubikMatrix[targetRow].Length; targetCol++)
                {
                    if (rubikMatrix[targetRow][targetCol] == counter)
                    {
                        rubikMatrix[targetRow][targetCol] = rubikMatrix[row][col];
                        rubikMatrix[row][col] = counter;
                        Console.WriteLine($"Swap ({row}, {col}) with ({targetRow}, {targetCol})");
                        return;
                    }
                }
            }
        }

        private static void MoveUp(int[][] rubikMatrix, int col, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int firstElement = rubikMatrix[0][col];

                for (int row = 0; row < rubikMatrix.Length - 1; row++)
                {
                    rubikMatrix[row][col] = rubikMatrix[row + 1][col];
                }

                rubikMatrix[rubikMatrix.Length - 1][col] = firstElement;
            }
        }

        private static void MoveRight(int[][] rubikMatrix, int row, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int lastElement = rubikMatrix[row][rubikMatrix[row].Length - 1];

                for (int col = rubikMatrix.Length - 1; col > 0; col--)
                {
                    rubikMatrix[row][col] = rubikMatrix[row][col - 1];
                }

                rubikMatrix[row][0] = lastElement;
            }
        }

        private static void MoveLeft(int[][] rubikMatrix, int row, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                    int firstElement = rubikMatrix[row][0];

                    for (int col = 0; col < rubikMatrix[row].Length - 1; col++)
                    {
                        rubikMatrix[row][col] = rubikMatrix[row][col + 1];
                    }

                    rubikMatrix[row][rubikMatrix[row].Length - 1] = firstElement;
            }
        }

        private static void MoveDown(int[][] rubikMatrix, int col, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int lastElement = rubikMatrix[rubikMatrix.Length - 1][col];

                for (int row = rubikMatrix.Length - 1; row > 0; row--)
                {
                    rubikMatrix[row][col] = rubikMatrix[row - 1][col];
                }

                rubikMatrix[0][col] = lastElement;
            }
        }

        private static void PrintMatrix(int[][] rubikMatrix)
        {
            for (int row = 0; row < rubikMatrix.Length; row++)
            {
                Console.WriteLine(String.Join(" ", rubikMatrix[row]));
            }
        }

        private static void GetMatrix(int[][] rubikMatrix, int cols)
        {
            int counter = 1;

            for (int row = 0; row < rubikMatrix.Length; row++)
            {
                rubikMatrix[row] = new int[cols];

                for (int col = 0; col < rubikMatrix[row].Length; col++)
                {
                    rubikMatrix[row][col] = counter++;
                }
            }
        }
    }
}
