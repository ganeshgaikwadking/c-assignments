using System;

namespace TSystem_NestedIfElse_Ex_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
             start:
            Console.WriteLine("Enter Marks :");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num > 100)
            {
                Console.WriteLine($"Invalid Marks :: {num}");
            }
            else if (num >= 0 && num < 40)
            {
                Console.WriteLine($"Is fail :: {num}");
            }
            else if (num >= 40 && num < 50)
            {
                Console.WriteLine($"Is  C gread ::{num}");
            }
            else if (num >= 50 && num < 60)
            {
                Console.WriteLine($"Is  B Gread :: {num}");
            }
            else if (num >= 60 && num < 75)
            {
                Console.WriteLine($"Is  A Gread :: {num}");
            }
            else if (num >= 75 && num < 95)
            {
                Console.WriteLine($"Is A++ Gread :: {num}");
            }
            else if (num >= 95)
                Console.WriteLine($"Is  OutStanding :: {num} ");
            goto start;

            Console.ReadLine();
        }
    }
}
