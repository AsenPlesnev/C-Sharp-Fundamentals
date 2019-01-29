using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] tokens = input.Split(':', StringSplitOptions.RemoveEmptyEntries);

                string contestName = tokens[0];

                string password = tokens[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, password);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] tokens = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contestName = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contests.ContainsKey(contestName) && contests[contestName] == password)
                {
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, new Dictionary<string, int>());
                    }

                    if (!students[username].ContainsKey(contestName))   
                    {
                        students[username].Add(contestName, points);
                    }

                    if (students[username][contestName] < points)
                    {
                        students[username][contestName] = points;
                    }
                }
                
                input = Console.ReadLine();
            }

            var topStudent = students.OrderByDescending(x => x.Value.Sum(s => s.Value)).FirstOrDefault();

            Console.WriteLine($"Best candidate is {topStudent.Key} with total {topStudent.Value.Sum(x => x.Value)} points.");

            Console.WriteLine("Ranking:");

            var sortedStudents = students.OrderBy(x => x.Key);

            foreach (var kvp in sortedStudents)
            {
                Console.WriteLine(kvp.Key);

                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
