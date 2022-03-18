using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 23;
            object obj = num;

            int i = (int)obj;
            Console.WriteLine($"Value type i will be :: {i}");
            Console.WriteLine($"onject obj will be = :: {obj}");
            Console.ReadLine();
        }
    }
}
