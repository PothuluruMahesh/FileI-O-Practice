using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class StreamReader1
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream(@"F:\JAVA\C#\FileHandling\bizrun1.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = "";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s.Close();
            f.Close();
        }
    }
}
