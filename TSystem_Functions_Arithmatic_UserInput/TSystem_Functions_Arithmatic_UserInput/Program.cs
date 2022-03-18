using System;


namespace TSystem_Functions_Arithmatic_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {

        Start:
            int a, b;
            Console.WriteLine("Enter First Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());

            ArithmaticOperation objArithmaticOperation = new ArithmaticOperation();
            objArithmaticOperation.Addion(a,b);
            objArithmaticOperation.Substraction(a, b);
            objArithmaticOperation.Multiplication(a, b);
            objArithmaticOperation.Division(a, b);
            Console.ReadLine();
            goto Start;


        }
    }
    public class ArithmaticOperation
    {
        public void Addion(int m,int n)
        {
            int sum = m + n;
            Console.WriteLine($"Addtion Is :: {sum}");
        }
        public void Substraction(int m, int n)
        {
            int sum = m - n;
            Console.WriteLine($"Substraction Is :: {sum}");
        }
        public void Multiplication(int m, int n)
        {
            int sum = m * n;
            Console.WriteLine($"Multiplication Is :: {sum}");
        }
        public void Division(int m, int n)
        {
            int sum = m / n;
            Console.WriteLine($"Division Is :: {sum}");
        }
    }
}
