using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Directory1
    {
        static void Main(string[] args)
        {
            // Provide directory name with complete location.  
            DirectoryInfo directory = new DirectoryInfo(@"F:\MaheshMahesh");
            try
            {
                // Check, directory exist or not.  
                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }
                // Creating a new directory.  
                directory.Create();
                Console.WriteLine("The directory is created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }
        }
    }
}
