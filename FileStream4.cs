using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class FileStream4
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream(@"F:\JAVA\C#\FileHandling\bizrun.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadLine();
            Console.WriteLine(line);

            s.Close();
            f.Close();
        }
    }
}
