using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class Unique_Usernames
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            string name = String.Empty;

            for (int i = 0; i < count; i++)
            {
                name = Console.ReadLine();

                uniqueNames.Add(name);
            }

            foreach (var nickname in uniqueNames)
            {
                Console.WriteLine(nickname);
            }

        }
    }
}
