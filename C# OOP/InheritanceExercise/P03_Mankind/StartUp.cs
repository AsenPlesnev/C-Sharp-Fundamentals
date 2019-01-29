using System;

namespace P03_Mankind
{
    public class StartUp
    {
        public static void Main()
        {
            GetHumans();
        }

        private static void GetHumans()
        {
            var studentData = Console.ReadLine().Split();
            var workerData = Console.ReadLine().Split();

                var student = new Student(studentData[0], studentData[1], studentData[2]);
                var worker = new Worker(workerData[0], workerData[1], decimal.Parse(workerData[2]), double.Parse(workerData[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
        }
    }
}
