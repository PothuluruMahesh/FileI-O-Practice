using System;
using System.IO;

namespace FileIO
{
    class FileStream3
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter any DATA in tp the biz1.txt file");
            String s1=Console.ReadLine();
            File.WriteAllText(@"F:\JAVA\C#\FileHandling\biz1.txt", s1);
           
        }
    }
}
