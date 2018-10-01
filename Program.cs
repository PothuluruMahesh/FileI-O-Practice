using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.Create(@"F:\JAVA\C#\FileHandling\bizrun.txt");
            Console.WriteLine("File has been created");
        }
    }
}
