using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_IfElseStatement_Exa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=75;
            if (num % 2 == 0)
            {
                Console.WriteLine($"The Number is Even Number :: {num}");
            }
            else {
                Console.WriteLine($"The Number is Odd Number :: {num}");
            }
            Console.ReadLine();

        }
    }
}
