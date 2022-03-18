using System;
namespace TSystem_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 90;
            Console.WriteLine("==============DataTypes and Variables===========");
            Console.WriteLine("==============Int DataTypes===========");
            Console.WriteLine($"The Variable i Whould be:: {i}");
            Console.WriteLine("The Variable i Whould be:: {0}",i);
            Console.WriteLine("The Variable i Whould be:: " + i);

            string str = "TSystems";
            string str1 = "Ganesh";
            Console.WriteLine("==============DataTypes==========");
            Console.WriteLine("==============String Data===========");
            Console.WriteLine($"The Variable i Whould be:: {str}");
            Console.WriteLine("The Variable i Whould be:: {0} {1}", str,str1);
            Console.WriteLine("The Variable i Whould be:: " + str);

            float f = 45.78f;
            Console.WriteLine("==============DataTypes==========");
            Console.WriteLine("==============float Data===========");
            Console.WriteLine($"The Variable i Whould be:: {f}");
            Console.WriteLine("The Variable i Whould be:: {0}", f);
            Console.WriteLine("The Variable i Whould be:: " + f);

            double dl = 4578888.78666d;
            Console.WriteLine("==============DataTypes==========");
            Console.WriteLine("==============Double Data Type==========");
            Console.WriteLine($"The Variable i Whould be:: {dl}");
            Console.WriteLine("The Variable i Whould be:: {0}", dl);
            Console.WriteLine("The Variable i Whould be:: " + dl);

            decimal de = 45784333388.7855555666m;
            Console.WriteLine("==============DataTypes==========");
            Console.WriteLine("==============Decimal Data Type==========");
            Console.WriteLine($"The Variable i Whould be:: {de}");
            Console.WriteLine("The Variable i Whould be:: {0}", de);
            Console.WriteLine("The Variable i Whould be:: " + de);

            char ch = 'c';
            Console.WriteLine("==============DataTypes==========");
            Console.WriteLine("==============Char Data Type==========");
            Console.WriteLine($"The Variable i Whould be:: {ch}");
            Console.WriteLine("The Variable i Whould be:: {0}", ch);
            Console.WriteLine("The Variable i Whould be:: " + ch);

            Console.ReadLine();
        }
    }
}
