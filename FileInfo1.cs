using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class FileInfo1
    {
        static void Main(string[] args)
        {
            FileInfo fi=new FileInfo(@"F:\JAVA\C#\FileHandling\bizrun1.txt");
            fi.Create();
            fi.MoveTo((@"F:\JAVA\C#\FileHandling\File\bizrun1.txt"));
            fi.CopyTo((@"F:\JAVA\C#\FileHandling\bizrun1.txt"));
            fi.Delete();
            if(File.Exists(@"F:\JAVA\C#\FileHandling\bizrun1.txt"))
            {
                Console.WriteLine("file has been created");

            }
            else
            {
                Console.WriteLine("File not created");
            }
        }
    }
}
