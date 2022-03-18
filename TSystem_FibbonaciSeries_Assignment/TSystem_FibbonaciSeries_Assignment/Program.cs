using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_FibbonaciSeries_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3, i, n;
            //n = 20;
            Console.WriteLine("Enter Number of range ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series:");
            Console.Write(num1 + " " + num2 + " ");
            for (i = 2; i < num; ++i)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
            Console.ReadLine();
        }
    }
}
