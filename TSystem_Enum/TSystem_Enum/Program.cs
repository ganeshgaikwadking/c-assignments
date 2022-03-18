using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Enum
{
    class Program
    {
        public enum Days { Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday}
        static void Main(string[] args)
        {
            int mon = (int)Days.Monday;
            int tues = (int)Days.Tuesday;
            int wed = (int)Days.Wednesday;
            int thur = (int)Days.Thursday;
            int fri = (int)Days.Friday;
            int sat = (int)Days.Saturday;
            int sun = (int)Days.Sunday;

            Console.WriteLine("=======Enum By Unboxing=======");
            Console.WriteLine($"the index of Monday will be :: {mon}");
            Console.WriteLine($"the index of Tuesday will be :: {tues}");
            Console.WriteLine($"the index of Wednesday will be :: {wed}");
            Console.WriteLine($"the index of Thursday will be :: {thur}");
            Console.WriteLine($"the index of Friday will be :: {fri}");
            Console.WriteLine($"the index of saturday will be :: {sat}");
            Console.WriteLine($"the index of Sunday will be :: {sun}");

            Console.WriteLine("===============Enum by Using foreach Loop==============================");
            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine($"Days Would be:: {s}");
            }

            Console.WriteLine("==================Index And Value===========================");
            int num = (int)Days.Monday;
           string str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index :: {num}value ::{str}");

             num = (int)Days.Tuesday;
             str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index :: {num}value ::{str}");


            num = (int)Days.Wednesday;
            str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index :: {num}value ::{str}");

            num = (int)Days.Thursday;
            str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index :: {num}value ::{str}");
            

            num = (int)Days.Friday;
            str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Days.Saturday;
            str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index :: {num}value ::{str}");

            num = (int)Days.Sunday;
            str = Enum.GetName(typeof(Days), num);
            Console.WriteLine($"Index :: {num}value ::{str}");

            Console.ReadLine();
        }
    }
}
