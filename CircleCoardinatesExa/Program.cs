using System;

namespace CircleCoardinatesExa
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, radius;
            float  pc;

            Console.WriteLine("Enter the center co-ordinates of the circle: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the radius of the circle: ");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the point co-ordinates: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            pc = x2 - x1 + y2 - y1;


            if   ( pc > radius)
            {
                Console.WriteLine("lies outside the circle", x2, y2);
            }
            else if (pc < radius)
            { Console.WriteLine("lies outside the circle", x2, y2); }

            else if (pc == radius)
            { Console.WriteLine("Boundry Of circle", x2, y2); }
            else
                Console.WriteLine("Incorrect Entry", x2, y2);
        }
    }
}
