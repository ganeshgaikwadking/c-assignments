using System;

namespace studentgeneric
{
    class student
    {
        int rollno;
        int stdname, subject;
        public student(int rno,string sname,string sub)
        {
            rollno = rno;
            stdname = sname;
            subject = sub;

        }
        public override string ToString()
        {
            return rollno

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
