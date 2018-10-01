using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class TextWriter2
    {
        static void Main(string[] args)
        {
            using (TextReader writer = File.OpenText(@"F:\JAVA\C#\FileHandling\bizrun.txt"))
            {
                //Console.WriteLine(writer.ReadToEnd());
                Console.WriteLine(writer.ReadLine());
                Console.WriteLine(writer.Read());
            }
            Console.WriteLine("Data Read successfully...");
        }
    }
}
