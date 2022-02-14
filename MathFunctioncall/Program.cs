using System;
using MathLibraryExa;

namespace MathFunctioncall
{
    class Program
    {
        static void Main(string[] args)
        {
            math ma = new math();
            Console.WriteLine(ma.square(10));
            Console.WriteLine(ma.cube(2));
        }
    }
}
