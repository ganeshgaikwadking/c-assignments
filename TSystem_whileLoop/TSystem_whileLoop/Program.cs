using System;


namespace TSystem_whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            Console.WriteLine("===========while loop==========");
            while(i<=10)
            {

                Console.WriteLine($"While loop executed::{i}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
