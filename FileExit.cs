using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class FileExit
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.Exists(@"F:\JAVA\C#\FileHandling\bizrun.txt") ? "File exists." : "File does not exist.");
            if(File.Exists(@"F:\JAVA\C#\FileHandling\bizrun.txt"))
            {
                Console.WriteLine("File is available in the directory");

            }
            else
            {
                Console.WriteLine("File is Not Available in the directory");
            }
        }
    }
}
