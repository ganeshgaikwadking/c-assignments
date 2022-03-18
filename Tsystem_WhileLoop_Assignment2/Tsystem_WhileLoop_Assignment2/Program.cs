using System;


namespace Tsystem_WhileLoop_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i <= 3)
            {
                int j = 1;
                while (j <= 3)
                {
                    int k = 1;
                    while (k <= 3)
                    {
                        Console.WriteLine($"{i} {j} {k}");
                        k++;
                    }
                    j++;
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
