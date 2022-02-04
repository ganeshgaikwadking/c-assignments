using System;

namespace student
{
    class student
    {
        int StudentRollno;
        string sname, division;
        public void AcceptData()
        {
            Console.WriteLine(" Enter Student Roll Number ");
            StudentRollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Student Name ");
            sname = (Console.ReadLine());
            Console.WriteLine(" Division ");
            division = (Console.ReadLine());
        }
        public void PrintData()
        {
            Console.WriteLine("Student Roll Number-:" +StudentRollno);
            Console.WriteLine("Name-:" +sname);
            Console.WriteLine("Division-:" +division);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            student st = new student();
            st.AcceptData();
            st.PrintData();
        }
    }
}
