using System.IO;
using System;

namespace FileIO
{
    class FileStream2
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"F:\JAVA\C#\FileHandling\bizrun1.txt", FileMode.OpenOrCreate);
            //  fs.WriteByte(65);
            int i = 0;
            while((i=(fs.ReadByte())) != -1)
            {
                Console.Write((char)i+"");
            }
            fs.Close();
            Console.WriteLine();
        }
    }
}
