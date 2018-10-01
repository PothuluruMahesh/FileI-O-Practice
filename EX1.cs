using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class EX1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Table is :");
            WriteTable();
            ReadTable();
            Console.WriteLine("Table Success fully Created");
        }
        static void WriteTable()
        {
            Console.WriteLine("Insert in to file.......");
            using (TextWriter sw = File.CreateText(@"F:\JAVA\C#\FileHandling\biz123.txt"))
            {
                for(int i=0;i<=10;i++)
                {
                    for(int j=0;j<=10;j++)
                    {
                        sw.WriteLine("{0}*{1}={2}", i, j, (i * j));
                    }
                    sw.WriteLine("-----------");
                }
            }
        }
        static void ReadTable()
        {
            Console.WriteLine("The Retrive the data from file");
            using (TextReader sr = File.OpenText(@"F:\JAVA\C#\FileHandling\biz123.txt"))
            {
                string tables = null;
                while ((tables = sr.ReadLine()) != null)
                {
                    Console.WriteLine("{0}", tables);
                }
                Console.WriteLine("Tables Printed");
            }
        }
    }
}
