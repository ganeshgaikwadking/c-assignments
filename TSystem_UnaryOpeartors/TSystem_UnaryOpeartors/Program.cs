using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_UnaryOpeartors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=====Unary Operator====");
            int x = 10,res;
            res = x++;
            Console.WriteLine("========================");
            Console.WriteLine($"The value of x :: {x}");
            Console.WriteLine($"The value of res :: {res}");

            Console.WriteLine("========================");
            int x1 = 10, res1;
            res1 = x1--;
            Console.WriteLine($"The value of x1::{x1}");
            Console.WriteLine($"The value of res1::{res1}");


            Console.WriteLine("========================");
            int x2 = 10, res2;
            res2 = ++x2;
            Console.WriteLine($"The value of x2::{x2}");
            Console.WriteLine($"The value of res2::{res2}");

            Console.WriteLine("========================");
            int x3 = 10, res3;
            res3 = --x3;
            Console.WriteLine($"The value of x3::{x3}");
            Console.WriteLine($"The value of res3::{res3}");

            Console.ReadLine();
        }
    }
}
