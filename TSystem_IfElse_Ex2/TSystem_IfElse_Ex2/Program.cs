using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_IfElse_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Number to check grather or smaller");
            int value = 50;
            if (value < 10)
            {

                Console.WriteLine($"the value :: {value} is lesss than 10");
            }
            else {
                Console.WriteLine($"the value :: {value} is grater than 10");
            }
            Console.ReadLine();
        }
    }
}
