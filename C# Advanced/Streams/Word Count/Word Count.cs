using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Word_Count
{
    class Word_Count
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            string wordsSourcePath = "..//..//..//..//files//words.txt";
            string textSourcePath = "..//..//..//..//files//text.txt";
            string destinationPath = "..//..//..//..//files//result.txt";

            using (StreamReader streamReader = new StreamReader(wordsSourcePath))
            {
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    line = line.ToLower();
                     
                    if (wordsCount.ContainsKey(line))
                    {
                        wordsCount.Add(line, 0);
                    }

                    line = streamReader.ReadLine();
                }
            }

            using (StreamReader streamReader = new StreamReader(textSourcePath))
            {
                string line = streamReader.ReadLine();

                while (line != null)
                {

                    line = line.ToLower();
                    Regex regex = new Regex("[A-Za-z]+");

                    foreach (Match currentWord in regex.Matches(line))
                    {
                        if (wordsCount.ContainsKey(currentWord.Value))
                        {
                            wordsCount[currentWord.Value] += 1;
                        }
                    }

                    line = streamReader.ReadLine();
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(destinationPath))
            {
                foreach (var word in wordsCount.OrderByDescending(v => v.Value))
                {
                    streamWriter.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
