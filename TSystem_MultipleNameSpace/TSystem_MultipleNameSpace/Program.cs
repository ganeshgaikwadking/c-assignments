using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_MultipleNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            First_TSystem.Tsystem objTSystem1 = new First_TSystem.Tsystem();
            objTSystem1.Hello();

            Second_TSystem.Tsystem objTSystem2 = new Second_TSystem.Tsystem();
            objTSystem2.Hello();

            Console.ReadLine();


        }
    }
}
namespace First_TSystem
{

    public class Tsystem
    {
        public void Hello()
        {
            Console.WriteLine("Hello TSystem Batch 1");

        }

    }
}
namespace Second_TSystem
{

    public class Tsystem
    {
        public void Hello()
        {
            Console.WriteLine("Hello TSystem Batch 2");

        }

    }
}

