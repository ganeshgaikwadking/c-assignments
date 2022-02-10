using System;

namespace Rectangleexample
{
    class Program
    {
        public void calculate(float length,float breadth,out float area,out float perimeter)
        {
            area = length * breadth;
            perimeter = 2 * length + 2 * breadth;
        }
        static void Main(string[] args)
        {
            float area;
            float perimeter;
            Console.WriteLine("enter heigth  and breadth");
            float length=float.Parse(Console.ReadLine());
             float breadth=float.Parse(Console.ReadLine());

            Program rect = new Program();
            rect.calculate(length, breadth, out area,out  perimeter);
            Console.WriteLine("area of rectangle = " + area + "perimeter of rectangle = " + perimeter);

        }
    }
}
