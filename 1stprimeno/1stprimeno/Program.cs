using System;

namespace _1stprimeno
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("Number is Prime.");
            }
            else
            {
                Console.Write("Number is not Prime.");
            }
           
        }
    }
}