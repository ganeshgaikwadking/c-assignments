using System;

namespace ThreePointexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3;
            double ab, bc, ac;

            Console.WriteLine("Enter the co-ordinates of first point (X1, Y1): ") ;
            x1 =Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the co-ordinates of second point (X2, Y2)): ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the co-ordinates of third point (X3, Y3): ");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            ab =y2 - y1/x2-x1 ;
            bc = y3 -y1 /x3-x1;
            ac = y3 - y2 / x3 -x2;

            if(ab==bc && ab==ac)
            {
                Console.WriteLine("Points Are Fall on one Straith line");
            }
            else
            {
                Console.WriteLine("points Are Not not Fall On One Straight Line");
            }
            Console.ReadKey();
        }
    }
}
