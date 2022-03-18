using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_CallByValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Call by value =================");
            int val = 20;
            Console.WriteLine($"The value Is Before Passing Function ::{val}");
            Program pg = new Program();
            pg.Show(val);
            Console.WriteLine($"The value Is After Passing Function ::{val}");
            Console.ReadLine();

        }
        public void Show(int Val)
        {
            Val = Val *Val;
            Console.WriteLine($"Value inside The Function :: {Val}");

         }
    }
}
