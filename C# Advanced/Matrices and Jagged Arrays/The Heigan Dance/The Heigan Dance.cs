using System;

namespace The_Heigan_Dance
{
    class The_Heigan_Dance
    {
        static int playerRow = 7;
        static int playerCol = 7;

        static int plagueCloud = 3500;
        static int eruption = 6000;

        static int playerHealth = 18500;
        static double heiganHealth = 3000000;
        static bool isPlagueCloud = false;
        static string lastSpeel = "";

        static void Main(string[] args)
        {
            double damage = Double.Parse(Console.ReadLine());

            while (true)
            {
                if (playerHealth > 0)
                {
                    heiganHealth -= damage;
                }

                if (isPlagueCloud)
                {
                    playerHealth -= plagueCloud;
                    isPlagueCloud = false;
                    lastSpeel = "Plague Cloud";
                }

                if (playerHealth <= 0 || heiganHealth <= 0)
                {
                    break;
                }

                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string magic = tokens[0];
                int targetRow = Int32.Parse(tokens[1]);
                int targetCol = Int32.Parse(tokens[2]);


                if (!IsInImpactArea(playerRow, playerCol, targetRow, targetCol))
                {
                    continue;
                }
                
                bool canMoveUp = !IsInImpactArea(playerRow - 1,playerCol, targetRow, targetCol) && IsInside(playerRow - 1);
                bool canMoveRight = !IsInImpactArea(playerRow, playerCol + 1, targetRow, targetCol) && IsInside(playerCol + 1);
                bool canMoveDown = !IsInImpactArea(playerRow + 1, playerCol, targetRow, targetCol) && IsInside(playerRow + 1);
                bool canMoveLeft = !IsInImpactArea(playerRow, playerCol - 1, targetRow, targetCol) && IsInside(playerCol - 1);

                if (canMoveUp)
                {
                    playerRow--;
                    continue;
                }
                else if (canMoveRight)
                {
                    playerCol++;
                    continue;
                }
                else if (canMoveDown)
                {
                    playerRow++;
                    continue;
                }
                else if (canMoveLeft)
                {
                    playerCol--;
                    continue;
                }

                if (magic == "Cloud")
                {
                    playerHealth -= plagueCloud;
                    isPlagueCloud = true;
                    lastSpeel = "Plague Cloud";
                }
                else if (magic == "Eruption")
                {
                    playerHealth -= eruption;
                    lastSpeel = "Eruption";
                }
            }

            if (heiganHealth <= 0)
            {
                Console.WriteLine($"Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {heiganHealth:F2}");
            }

            if (playerHealth <= 0)
            {
                Console.WriteLine($"Player: Killed by {lastSpeel}");
            }
            else
            {
                Console.WriteLine($"Player: {playerHealth}");
            }

            Console.WriteLine($"Final position: {playerRow}, {playerCol}");
        }

        private static bool IsInside(int rcIndex)
        {
            return rcIndex >= 0 && rcIndex < 15;
        }

        private static bool IsInImpactArea(int targetPlayerRow, int targetPlayerCol, int row, int col)
        {
            return targetPlayerRow >= row - 1 && targetPlayerRow <= row + 1 && targetPlayerCol >= col - 1 && targetPlayerCol <= col + 1;
        }
    }
}
