using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class FileStream1
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"F:\JAVA\C#\FileHandling\bizrun1.txt", FileMode.OpenOrCreate);
            //  fs.WriteByte(65);
            for (int i = 65;i <= 95;i++)
            {
                fs.WriteByte((byte)i);
            }
            fs.Close();
        }
    }
}
