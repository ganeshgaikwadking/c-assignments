using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers Between 1 To 200: ");
            for (int i = 2; i <= 200; i++)
            {
                for (int j = 2; j <= 200; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.Read();
        }
    }
}