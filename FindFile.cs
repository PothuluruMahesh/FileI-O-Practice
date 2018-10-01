using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class FindFile
    {
        static void Main(string[] args)
        {
            DirectoryInfo df = new DirectoryInfo(@"F:\JAVA\BizRunTime Meterials\BIZRUNTIME\trainees");
            Console.WriteLine(df.GetFiles().Length);
        }
    }
}
