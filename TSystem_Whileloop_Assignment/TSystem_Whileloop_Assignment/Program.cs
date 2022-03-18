using System;


namespace TSystem_Whileloop_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <=3 )
            {
              int  j = 1;
                while(j<=3)
                {
                    Console.WriteLine("loop" +" "+ i + " " + j);
                    j++;
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
