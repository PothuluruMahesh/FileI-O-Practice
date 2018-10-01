using System;
using System.IO;
namespace FileIO
{
    class StrinWriter2
    {
        static void Main(string[] args)
        {
            StringWriter str = new StringWriter();
            str.WriteLine("Hello, this message is read by StringReader class");
            str.WriteLine("Hello, this message is read by StringReader class");
            str.Flush();
            str.WriteLine("Hello, this message is read by StringReader class");
            str.Close();
            // Creating StringReader instance and passing StringWriter  
            StringReader reader = new StringReader(str.ToString());
            // Reading data  
           // while (reader.Peek > -1)
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}