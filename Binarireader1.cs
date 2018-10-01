using System;
using System.IO;

namespace FileIO
{
    class Binarireader1
    {
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
        static void WriteBinaryFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(@"F:\JAVA\C#\FileHandling\bizrun.txt", FileMode.Create)))
            {

                writer.Write(12.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(@"F:\JAVA\C#\FileHandling\bizrun.txt", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }
        }
    }
}
