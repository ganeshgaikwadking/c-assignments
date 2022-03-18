using System;


namespace TSystem_ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====ArithmeticOperators======");
            int a = 70;
            int b = 35;
            int result = a + b;
            Console.WriteLine($"The Addition would be::{result}");

             result = a - b;
            Console.WriteLine($"The Substraction would be::{result}");

            result = a * b;
            Console.WriteLine($"The Multiplication would be::{result}");

            result = a / b;
            Console.WriteLine($"The Division would be::{result}");

            Console.ReadLine();

        }
    }
}
