using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Threadcls demo = new Threadcls();
            Thread t1 = new Thread(new ThreadStart(demo.Test));
            Thread t2 = new Thread(new ThreadStart(demo.Test));
            Thread t3 = new Thread(new ThreadStart(demo.Test));
            t1.Name = "First Thread";
            t2.Name = "Second Thread";
            t3.Name = "Third Thread";

          

            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.BelowNormal;
            t3.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();

        }
    }
}
