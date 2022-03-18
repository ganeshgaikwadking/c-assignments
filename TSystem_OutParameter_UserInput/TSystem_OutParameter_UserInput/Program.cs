using System;


namespace TSystem_OutParameter_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int add;
            int sub;
            int mul;
            int div;
            Program prg = new Program();
            prg.Arithmatic(out add, out sub, out mul, out div);
            Console.WriteLine($"Addition :: {add}");
            Console.WriteLine($"Substraction :: {sub}");
            Console.WriteLine($"Multiplication :: {mul}");
            Console.WriteLine($"Division:: {div}");
            Console.ReadLine();
        }
        public void Arithmatic(out int add, out int sub, out int mul, out int div)
        {
            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Number");
            int b = Convert.ToInt32(Console.ReadLine());
            add = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
        }

    }
}
