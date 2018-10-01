using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class LinesWords
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"F:\JAVA\C#\FileHandling\biz1.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadToEnd();
            int count = 1;
          for(int i=0;i<line.Length;i++)
            {
                
            }

            s.Close();
            f.Close();
        }
    }
}
