using System;

namespace Fibbonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c, numberOfElements;
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b + " ");

            for (int i = 2; i < numberOfElements; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
