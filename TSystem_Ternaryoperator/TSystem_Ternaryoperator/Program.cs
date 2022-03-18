using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Ternaryoperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========Example of Ternary Operators======");
            int x = 5;
            int y =10;
            int result;
            result = x < y ? x : y;
            Console.WriteLine($"the result would be::{result}");

            result = x > y ? x : y;
            Console.WriteLine($"the result would be::{result}");

            Console.ReadLine();


        }
    }
}
