using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Palindrome_Assingment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, a, temp;
            Console.WriteLine("Enter The Number");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                a = num % 10;
                sum = (sum * 10) + a;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("The number is Palindrome {");

            }
            else {
                Console.WriteLine("The number is not Palindrome ");


            }
            Console.ReadLine();
        }
    }
}
