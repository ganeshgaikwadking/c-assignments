using System;
namespace TSystem_Var_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 90;
            Console.WriteLine($"The value of i ::{i}");
            i = 60;
            Console.WriteLine($"The value of i ::{i}");
            var str = "TSystem";
            Console.WriteLine($"The value of str ::{str}");
            str = "Ganesh";
            Console.WriteLine($"The value of str ::{str}");

            Console.ReadLine();
        }
    }
}
