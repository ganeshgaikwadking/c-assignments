using System;


namespace TSytem_Functions_AreaOpeartion
{
    class Program
    {
        static void Main(string[] args)
        {
        start:

            AreaOperation objAreaOperator = new AreaOperation();
            int AreaRactangle = objAreaOperator.AreaRactangle(10, 5);
            Console.WriteLine($"area of rectangle is :: {AreaRactangle}");
            int Areasquare = objAreaOperator.AreaSquare(5);
            Console.WriteLine($"area of rectangle is :: {Areasquare}"); 
            int AreaCircle = objAreaOperator.AreaCircle(4);
            Console.WriteLine($"area of rectangle is :: {AreaCircle}");
            Console.ReadLine();
           goto start;
            
        }
    }
    public class AreaOperation
    {
        public int AreaRactangle(int lenght, int width)
        {
            return lenght * width;
        }
        public int AreaSquare(int side)
        {
            return side * side;
        }
        public int AreaCircle(int radius)
        {
            return (int)(3.14 * radius * radius);
        }
    }

}
