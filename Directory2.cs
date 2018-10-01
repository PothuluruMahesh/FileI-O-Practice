using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Directory2
    {
        static void Main(string[] args)
        {
            DirectoryInfo df = new DirectoryInfo(@"F:\MaheshMahesh");
            if(df.Exists)
            {
                Console.WriteLine(df.GetHashCode());
                df.Delete();
                
                Console.WriteLine("Directory Successfully Deleted");
                return;
            }
            Console.WriteLine("Directory doesn't Exits");
        }
    }
}
