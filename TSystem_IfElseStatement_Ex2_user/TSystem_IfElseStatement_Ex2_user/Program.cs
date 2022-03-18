using System;


namespace TSystem_IfElseStatement_Ex2_user
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 10)
            {
                Console.WriteLine($"the value :: {num} is less than 10");

            }
            else { 
            Console.WriteLine($"the value :: {num} is greater than 10");
            }
            Console.ReadLine();
        }
    }
}
