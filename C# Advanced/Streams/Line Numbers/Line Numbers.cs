using System;
using System.IO;

namespace Line_Numbers
{
    class Line_Numbers
    {
        static void Main(string[] args)
        {
            string destinationPath = "..//..//..//..//files//output.txt";

            using (StreamReader streamReader = new StreamReader("..//..//..//..//files//text.txt"))
            {
                using (StreamWriter streamWriter = new StreamWriter(destinationPath))
                {
                    var line = streamReader.ReadLine();

                    int counter = 1;

                    while (line != null)
                    {
                        streamWriter.WriteLine($"Line {counter}:{line}");

                        counter++;

                        line = streamReader.ReadLine();
                    }
                }
            }
        }
    }
}
