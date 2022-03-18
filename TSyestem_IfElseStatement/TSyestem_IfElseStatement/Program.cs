using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSyestem_IfElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 15;

            if (num < 10)
            {
                Console.WriteLine($"Number is Less than 10 ");
            }
            else
            {
                Console.WriteLine($"Number is grater then 10 ");
            }
            Console.ReadLine();
        }
    }
}
