using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    class Parking_Lot
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();
            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0]?.ToLower() != "end")
            {
                switch (input[0].ToLower())
                {
                    case "in":
                        carNumbers.Add(input[1]);
                        break;
                    case "out":
                        carNumbers.Remove(input[1]);
                        break;
                }

                input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carNumbers.Count > 0)
            {
                foreach (var car in carNumbers)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}
