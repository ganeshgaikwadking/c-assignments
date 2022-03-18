using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_outParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================Out Parameters===============");
            int val;
            Program pg = new Program();
             pg.Show(out val);
            Console.WriteLine($"Value After passing to the fuction ::{val}");
            Console.ReadLine();
        }
        public void Show(out int val)
        {
            int sq = 5;
            val = sq;
            val = val * val;
            Console.WriteLine($"Tha Value inside the Function");


        }

    }
}
