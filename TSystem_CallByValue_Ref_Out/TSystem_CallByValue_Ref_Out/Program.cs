using System;


namespace TSystem_CallByValue_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            start:

            Console.WriteLine("=========== Call by value =================");
            int val = 20;
            Console.WriteLine($"The value Is Before Passing Function ::{val}");
            Program pg = new Program();
            pg.Show(val);
            Console.WriteLine($"The value Is After Passing Function ::{val}");
            Console.ReadLine();

            Console.WriteLine("=========== Call By Reference =================");
            int num = 50;
            Console.WriteLine($"The value Is Before Passing Function ::{num}");
            Program pgr = new Program();
            pgr.Refe(ref num);
            Console.WriteLine($"The value Is After Passing Function ::{num}");
            Console.ReadLine();

            Console.WriteLine("=========== Out Parameter =================");
            int add;
            int sub;
            int mul;
            int div;
            Program prg1 = new Program();
            prg1.Arithmatic(out add, out sub, out mul, out div);
            Console.WriteLine($"Addition :: {add}");
            Console.WriteLine($"Substraction :: {sub}");
            Console.WriteLine($"Multiplication :: {mul}");
            Console.WriteLine($"Division:: {div}");
            Console.ReadLine();


            goto start;
        }
        public void Show(int Val)
        {
            Val = Val * Val;
            Console.WriteLine($"Value inside The Function :: {Val}");

        }
        public void Refe(ref int num)
        {
            num = num * num;
            Console.WriteLine($"Value inside The Function :: {num}");

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
