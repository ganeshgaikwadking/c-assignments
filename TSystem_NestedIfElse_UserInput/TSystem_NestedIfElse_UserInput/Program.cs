using System;


namespace TSystem_NestedIfElse_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {   start:
            Console.WriteLine("Enter Marks");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0 || num > 100)
            {
                Console.WriteLine($" invalid Marks :: {num} ");
            }
           
           else if (num >=0 && num < 40)
            {
                Console.WriteLine($"Fail::{num}");
            }

            else if (num>=40 && num<50)
            {
                Console.WriteLine($" C Gread :: {num}");
            }
            else if (num>=50 &&num < 60)
            {
                Console.WriteLine($"B Gread ::{num} ");
            }
            else if (num>=60 && num < 75)
            {
                Console.WriteLine($"A Gread :: {num}");
            }
            else if (num >=75 && num < 95)
            {
                Console.WriteLine($"A++ Gread ::{num}");
            }
            else if (num >=95)
            {
                Console.WriteLine($"Outstanding ::{num}");
            }
            goto start;
            Console.ReadLine();
            
        }
        
    }
    
}
