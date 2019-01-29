using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> parkingSpots = new Dictionary<int, List<int>>();

            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            for (int row = 0; row < rows; row++)
            {
                parkingSpots.Add(row, new List<int>() { 0 });
            }

            string command = Console.ReadLine();

            while (command != "stop")
            {
                int[] tokens = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(Int32.Parse)
                    .ToArray();

                int entryRow = tokens[0];
                int targetRow = tokens[1];
                int targetCol = tokens[2];

                if (!parkingSpots[targetRow].Contains(targetCol))
                {
                    parkingSpots[targetRow].Add(targetCol);
                    int steps = Math.Abs(entryRow - targetRow) + targetCol + 1;

                    Console.WriteLine(steps);
                }
                else if (parkingSpots[targetRow].Count == cols)
                {
                    Console.WriteLine($"Row {targetRow} full");
                }
                else
                {
                    int counter = 1;
                    while (true)
                    {
                        

                        int steps = targetCol - counter;

                        if (!parkingSpots[targetRow].Contains(steps) && steps > 0)
                        {
                            parkingSpots[targetRow].Add(steps);

                            int totalSteps = Math.Abs(entryRow - targetRow) + steps + 1;

                            Console.WriteLine(totalSteps);

                            break;
                        }

                        steps = targetCol + counter;

                        if (!parkingSpots[targetRow].Contains(steps) && steps < cols)
                        {
                            parkingSpots[targetRow].Add(steps);

                            int totalSteps = Math.Abs(entryRow - targetRow) + steps + 1;

                            Console.WriteLine(totalSteps);

                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
