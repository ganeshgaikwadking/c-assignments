using System;

namespace AscciExample
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int a;
            Console.WriteLine("Enter A character :");
            ch = Convert.ToChar(Console.ReadLine());
            a = ch;

            if (a >= 65 && a <= 90)
                {
                Console.WriteLine("Entered Character Is Capital letter ");
                
            }
            if (a >= 97 && a <= 122)
            {
                Console.WriteLine("Entered Character Is Small Letter ");
            }
            else if (a >= 48 && a <= 57)
            {
                Console.WriteLine("IT is A Digit ");
            }

            else if (a >= 0 && a <= 47 || a >= 58 && a <= 64 || a >= 91 && a <= 96 || a >= 123 && a <= 127)
            {
                Console.WriteLine("IT is A special Symbol ");
            }

        }
    }
}
