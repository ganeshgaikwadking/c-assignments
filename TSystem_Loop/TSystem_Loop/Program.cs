using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=====================================================");
            Console.WriteLine("============For Loop======================");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The Value {i} for loop executed");
            }
            Console.WriteLine("============For Loop======================");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"The Value {i} for loop executed");
            }
            Console.WriteLine("============for Loop in backeord direction ======================");
            Console.WriteLine("--------for Loop Background Counting-----------");
            for(int i=10; i>=0;i--)
            {
                Console.WriteLine($"the value {i} for loop executed");
            }
            Console.ReadLine();

        }
    }
}
