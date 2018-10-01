using System;
using System.IO;

namespace FileIO
{
    class TextWriter1
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText(@"F:\JAVA\C#\FileHandling\bizrun2.txt"))
            {
                writer.WriteLine("Hello C#");
                writer.WriteLine("C# File Handling by JavaTpoint");
            }
            Console.WriteLine("Data written successfully...");
        }
    }
}
