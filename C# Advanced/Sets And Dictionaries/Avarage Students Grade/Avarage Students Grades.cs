using System;
using System.Collections.Generic;
using System.Linq;

namespace Avarage_Students_Grade
{
    class Avarage_Students_Grade
    {
        static void Main(string[] args)
        {
            int numberOfStudents = Int32.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string student = tokens[0];
                double grade = Double.Parse(tokens[1]);

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<double>());
                    students[student].Add(grade);
                }
                else
                {
                    students[student].Add(grade);
                }
            }

            foreach (var kvp in students)
            {
                var name = kvp.Key;

                var studentGrades = kvp.Value;

                var avarage = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {avarage:f2})");

                Console.WriteLine();
            }
        }
    }
}
