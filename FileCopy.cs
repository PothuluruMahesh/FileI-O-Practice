using System;
using System.IO;

namespace FileIO
{
    class FileCopy
    {
        static void Main(string[] args)
        {
            File.Copy(@"F:\JAVA\C#\FileHandling\bizrun.txt",@"F:\JAVA\C#\FileHandling\file\biz.txt");
            Console.WriteLine("File has been copied");
           // File.Move(@"F:\JAVA\C#\FileHandling\file\biz.txt", @"F:\JAVA\C#\FileHandling\biz1.txt");
           // Console.WriteLine("File has been Moved");
        }
    }
}
