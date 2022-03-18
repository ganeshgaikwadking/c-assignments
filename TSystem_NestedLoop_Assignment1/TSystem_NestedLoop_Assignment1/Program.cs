using System;


namespace TSystem_NestedLoop_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j;
            for(i=1; i<4; i++)
            {
                for (j = 1; j < 4; j++)
                    Console.WriteLine(i + " " + j);
            }
          
            Console.ReadLine();
        }
    }
}
