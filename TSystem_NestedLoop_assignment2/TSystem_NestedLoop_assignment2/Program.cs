using System;


namespace TSystem_NestedLoop_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j;
            for (i = 3; i > 0; i--)
            {
                for (j = 3; j > 0; j--)
                    Console.WriteLine(i + " " + j);

            }
            Console.ReadLine();
        }
    }
}
