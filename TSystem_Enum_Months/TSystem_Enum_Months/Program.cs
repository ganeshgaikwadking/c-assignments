using System;

namespace TSystem_Enum_Months
{
    class Program
    {
        public enum Months { January, February, March, April, May, June, july,August,September,October,November,December }
        static void Main(string[] args)
        {
            int jan = (int)Months.January;
            int feb = (int)Months.February;
            int mar = (int)Months.March;
            int apr = (int)Months.April;
            int ma = (int)Months.May;
            int jun = (int)Months.June;
            int jul = (int)Months.july;
            int aug = (int)Months.August;
            int sep = (int)Months.September;
            int oct = (int)Months.October;
            int nov = (int)Months.November;
            int dec = (int)Months.December;

            Console.WriteLine("=======Enum By Unboxing Months=======");
            Console.WriteLine($"the index of Monday will be    :: {jan}");
            Console.WriteLine($"the index of Tuesday will be   :: {feb}");
            Console.WriteLine($"the index of Wednesday will be :: {mar}");
            Console.WriteLine($"the index of Thursday will be  :: {apr}");
            Console.WriteLine($"the index of Friday will be    :: {ma}");
            Console.WriteLine($"the index of saturday will be  :: {jun}");
            Console.WriteLine($"the index of Sunday will be    :: {jul}");
            Console.WriteLine($"the index of Wednesday will be :: {aug}");
            Console.WriteLine($"the index of Thursday will be  :: {sep}");
            Console.WriteLine($"the index of Friday will be    :: {oct}");
            Console.WriteLine($"the index of saturday will be  :: {nov}");
            Console.WriteLine($"the index of Sunday will be    :: {dec}");


            Console.WriteLine("===============Enum by Using foreach Loop==============================");
            foreach (string s in Enum.GetNames(typeof(Months)))
            {
                Console.WriteLine($"months Would be:: {s}");
            }

            Console.WriteLine("==================Index And Value===========================");
            int num = (int)Months.January;
            string str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

             num = (int)Months.February;
             str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

             num = (int)Months.March;
             str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Months.April;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Months.May;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Months.June;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Months.july;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Months.August;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Months.September;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Months.October;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Months.November;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Months.December;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            Console.ReadLine();

        }
    }
}
