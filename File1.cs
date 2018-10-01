using System;
using System.IO;

namespace FileIO
{
    class File1
    {
        static void Main(string[] args)
        {
            
                File.Delete(@"F:\JAVA\C#\FileHandling\bizrun.txt");
                Console.WriteLine("File has been deleted");
            
        }
    }
}
