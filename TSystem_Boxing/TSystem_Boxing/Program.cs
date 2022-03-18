using System;


namespace TSystem_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            object obj = num;
            num = 200;
            Console.WriteLine($"Value Type num will be::{num}");
            Console.WriteLine($"Object obj will be :: {obj}");
            Console.ReadLine();

        }
    }
}
