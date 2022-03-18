using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Enum_Languages
{
    class Program
    {
        public enum Language { DotNet, AWS, CSharp, MVC, Angular, DotNetCore, Azure, Java }

        static void Main(string[] args)
        {
            int dnet = (int)Language.DotNet;
            int aws = (int)Language.AWS;
            int cs = (int)Language.CSharp;
            int mvc = (int)Language.MVC;
            int ang = (int)Language.Angular;
            int dncore = (int)Language.DotNetCore;
            int az = (int)Language.Azure;
            int java = (int)Language.Java;

            Console.WriteLine("=======Enum By Unboxing Language=======");
            Console.WriteLine($"the index of Dot Net will be         :: {dnet}");
            Console.WriteLine($"the index of AWS will be             :: {aws}");
            Console.WriteLine($"the index of CSharp will be          :: {cs}");
            Console.WriteLine($"the index of MVC will be             :: {mvc}");
            Console.WriteLine($"the index of Angular will be         :: {ang}");
            Console.WriteLine($"the index of Dot Net Core will be    :: {dncore}");
            Console.WriteLine($"the index of Azure will be           :: {az}");
            Console.WriteLine($"the index of Java will be            :: {java}");


            Console.WriteLine("===============Enum by Using foreach Loop==============================");
            foreach (string s in Enum.GetNames(typeof(Language)))
            {
                Console.WriteLine($"months Would be:: {s}");
            }

            Console.WriteLine("==================Index And Value===========================");
            int num = (int)Language.DotNet;
            string str = Enum.GetName(typeof(Language), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Language.AWS;
             str = Enum.GetName(typeof(Language), num);
             Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Language.CSharp;
            str = Enum.GetName(typeof(Language), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Language.MVC;
            str = Enum.GetName(typeof(Language), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Language.Angular;
            str = Enum.GetName(typeof(Language), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Language.DotNetCore;
            str = Enum.GetName(typeof(Language), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Language.Azure;
            str = Enum.GetName(typeof(Language), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            num = (int)Language.Java;
            str = Enum.GetName(typeof(Language), num);
            Console.WriteLine($"Index :: {num} value ::{str}");

            Console.ReadLine();

        }
    }
}
