using System;

namespace ArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[15];
            int i;
            string str;
            Console.WriteLine("Enter 15 Book Names:");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            for (i = 0; i < 10; i++)
            {

                Console.Write("The string you entered is :{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}\n", str);
            }
        }
    }
}
