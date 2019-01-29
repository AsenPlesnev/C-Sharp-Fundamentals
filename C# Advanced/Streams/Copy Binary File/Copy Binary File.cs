using System;
using System.IO;

namespace Copy_Binary_File
{
    class Copy_Binary_File
    {
        static void Main(string[] args)
        {
            using (FileStream readFile = new FileStream("..//..//..//..//files//copyMe.png", FileMode.Open))
            {
                using (FileStream writeFile = new FileStream("..//..//..//..//files//copyMe-copy.png", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int bytesCount = readFile.Read(buffer, 0, buffer.Length);

                        if (bytesCount == 0)
                        {
                            break;
                        }

                        writeFile.Write(buffer, 0, bytesCount);
                    }
                }
            }
        }
    }
}
