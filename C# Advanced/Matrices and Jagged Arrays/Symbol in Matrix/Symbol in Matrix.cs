using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Symbol_in_Matrix 
    {
        static void Main(string[] args)
        {
            int size = Int32.Parse(Console.ReadLine());

            bool wasFound = false;

            char[] columnElements = new char[size];

            char[,] matrix = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    columnElements[j] = input[j];

                    matrix[i, j] = columnElements[j];
                    
                }
            }

            char symbolToFind = char.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(matrix[i, j] == symbolToFind)
                    {
                        Console.WriteLine($"({i}, {j})");
                        wasFound = true;
                        break;
                    }
                }
            }

            if (wasFound == false)
            {
                Console.WriteLine($"{symbolToFind} does not occur in the matrix");
            }

        }
    }
}
