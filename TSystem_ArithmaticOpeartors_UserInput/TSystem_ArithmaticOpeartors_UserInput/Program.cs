using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_ArithmaticOpeartors_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second First Number");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a + b;
            Console.WriteLine($"The Addition would be::{result}");

            result = a - b;
            Console.WriteLine($"The Substraction would be::{result}");

            result = a * b;
            Console.WriteLine($"The Multiplication would be::{result}");

            result = a / b;
            Console.WriteLine($"The Division would be::{result}");

            Console.ReadLine();

            

        }
    }
}
