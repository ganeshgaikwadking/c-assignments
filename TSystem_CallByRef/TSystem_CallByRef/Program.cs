using System;


namespace TSystem_CallByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Call By Reference =================");
            int val = 50;
            Console.WriteLine($"The value Is Before Passing Function ::{val}");
            Program pg = new Program();
            pg.Show(ref val);
            Console.WriteLine($"The value Is After Passing Function ::{val}");
            Console.ReadLine();

        }
        public void Show(ref int Val)
        {
            Val = Val * Val;
            Console.WriteLine($"Value inside The Function :: {Val}");

        }

    }
}
