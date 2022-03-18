using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_BooleanOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a2 = 5;
            int b2 = 10;
            bool result1;
            result1 = a2 > b2;
            Console.WriteLine($"a2 is greather than b2::{result1}");

            result1 = a2 < b2;
            Console.WriteLine($"a2 is less than b2::{result1}");

            result1 = a2 >= b2;
            Console.WriteLine($"a2 is greather than equal to b2::{result1}");

            result1 = a2 <= b2;
            Console.WriteLine($"a2 is less than equal to b2::{result1}");

            int a4 = 5;
            int b4 = 5;
            result1 = a4 >= b4;
            Console.WriteLine($"a4 is greater than equal to b4 ::{result1}");

            result1 = a4 <= b4;
            Console.WriteLine($"a4 is less than equal to b4 ::{result1}");

            Console.ReadLine();

        }
    }
}
