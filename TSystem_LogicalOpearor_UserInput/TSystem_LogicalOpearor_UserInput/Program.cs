using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_LogicalOpearor_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {

        start:
            Console.WriteLine("Enter the First Value -true or false");
            bool num1 = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter the Second Value -true or false");
            bool num2 = Convert.ToBoolean(Console.ReadLine());

            bool result;
            result = num1 && num2;
            Console.WriteLine($"The And Operator Whould be::{result}");

            result = num1 || num2;
            Console.WriteLine($"The OR Operator Whould be::{result}");

            result = num1 != num2;
            Console.WriteLine($"The Not equal Operator Whould be::{result}");

            Console.ReadLine();
            goto start;
        }
    }
}
