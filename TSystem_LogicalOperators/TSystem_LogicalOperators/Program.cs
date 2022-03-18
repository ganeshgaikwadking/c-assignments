using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;
            bool result;
            result = a && b;
            Console.WriteLine($"The And Operator would be :: {result}");

            result = a || b;
            Console.WriteLine($"The OR Operator would be :: {result}");


            result = a != b;
            Console.WriteLine($"The Not Equal Operator would be :: {result}");

            Console.ReadLine();
        }
    }
}
