using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_UnaryOperators_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the value");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The value of x :: {x}");
            int result = x++;
            Console.WriteLine($"The value of result :: {result}");

            Console.WriteLine("========================");

            Console.WriteLine("Enter the value");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The value of x1 :: {x1}");
            int result1 = x1--;
            Console.WriteLine($"The value of result1 :: {result1}");
            Console.WriteLine("========================");

            Console.WriteLine("Enter the value");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The value of x2 :: {x2}");
            int result2 = ++x2;
            Console.WriteLine($"The value of result2 :: {result2}");

            Console.WriteLine("========================");
            Console.WriteLine("Enter the value");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The value of x3 :: {x3}");
            int result3 = --x3;
            Console.WriteLine($"The value of result3 :: {result3}");
            Console.ReadLine();
            goto start;
        }
    }
}
