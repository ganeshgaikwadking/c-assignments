using System;
using System.IO;


namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fl = new FileStream("NewFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fl);

            Console.WriteLine("Enter Data to File");
            string fileinfo = Console.ReadLine();
            sw.WriteLine(fileinfo);
            sw.Flush();

            Console.WriteLine("Successfull");

        }
    }
}
