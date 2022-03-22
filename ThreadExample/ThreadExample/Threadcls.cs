using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{
   public class Threadcls
    {
       public void Test()
        {
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name);
                }
            }
        }


    }
}
