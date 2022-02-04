using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,c,i;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            c = n / 2;
            for (i = 2; i <= c; i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine("Number is not prime");
                    break;
                }
            }
        }
    }
}
