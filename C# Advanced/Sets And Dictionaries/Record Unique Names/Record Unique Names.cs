using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    class Record_Unique_Names
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < counter; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
