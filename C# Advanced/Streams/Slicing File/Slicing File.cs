using System;
using System.Collections.Generic;
using System.IO;

namespace Slicing_File
{
    class Slicing_File
    {
        static List<string> paths;

        static void Main(string[] args)
        {
            paths = new List<string>();

            string sourceFile = "..//..//..//..//files//sliceMe.mp4";
            string destination = "..//..//..//..//files//assembled.mp4";
            int parts = 4;

            Slice(sourceFile, destination, parts);
            Assemble(paths, destination);
        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream readFile = new FileStream(sourceFile, FileMode.Open))
            {
                long size = readFile.Length / parts;

                byte[] buffer = new byte[4096];

                for (int i = 0; i < parts; i++)
                {
                    string destPath = destinationDirectory + $"Path{i}.mp4";
                    paths.Add(destPath);

                    int readedBytes = 0;

                    using (FileStream writeFile = new FileStream(destPath, FileMode.Create))
                    {
                        while (true)
                        {
                            int bytesCount = readFile.Read(buffer, 0, buffer.Length);

                            readedBytes += bytesCount;

                            if (readedBytes >= size)
                            {
                                break;
                            }
                            
                            if (bytesCount == 0)
                            {
                                break;
                            }

                            writeFile.Write(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            using (FileStream writeFile = new FileStream(destinationDirectory, FileMode.Create))
            {
                foreach (var path in paths)
                {
                    using (FileStream readFile = new FileStream(path, FileMode.Open))
                    {
                        byte[] buffer = new byte[readFile.Length];

                        readFile.Read(buffer, 0, buffer.Length);

                        writeFile.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
