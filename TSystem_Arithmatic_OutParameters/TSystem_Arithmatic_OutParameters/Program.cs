using System;


namespace TSystem_Arithmatic_OutParameters
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
            prg.Arithmatic(out add,out sub,out mul,out div);
            Console.WriteLine($"Addition :: {add}");
            Console.WriteLine($"Substraction :: {sub}");
            Console.WriteLine($"Multiplication :: {mul}");
            Console.WriteLine($"Division:: {div}");
            Console.ReadLine();


        }
        public void Arithmatic(out int add,out int sub,out int  mul, out int div)
        {

            int a = 10;
            int b = 5;
            add = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
           

        }
    }
}
