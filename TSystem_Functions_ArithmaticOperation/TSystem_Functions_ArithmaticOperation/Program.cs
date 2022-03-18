using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Functions_ArithmaticOperation
{

    class Program
    {
        static void Main(string[] args)
        {
            ArithmaticmaticOperation objArithmaticOperation = new ArithmaticmaticOperation();
            objArithmaticOperation.Addition();
            objArithmaticOperation.Substraction();
            objArithmaticOperation.multiplication();
            objArithmaticOperation.Division();
            Console.ReadLine();
        }
        public class ArithmaticmaticOperation
        {

            public void Addition()
            {
                int a = 60;
                int b = 30;
                int sum = a + b;
                Console.WriteLine($"The Addtion Is :: {sum}");
            }
            public void Substraction()
            {
                int a = 60;
                int b = 30;
                int sum = a - b;
                Console.WriteLine($"The Substraction Is :: {sum}");
            }
            public void multiplication()
            {
                int a = 60;
                int b = 30;
                int sum = a * b;
                Console.WriteLine($"The multiplication Is :: {sum}");
            }
            public void Division()
            {
                int a = 60;
                int b = 30;
                int sum = a / b;
                Console.WriteLine($"The Division Is :: {sum}");
            }
            

        }
        
    }

}


