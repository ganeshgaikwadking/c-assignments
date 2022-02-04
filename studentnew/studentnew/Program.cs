using System;

namespace studentnew
{
    class student
    {
      public  int rollno;
        public string name, division;
    }
    class program
    {
        public void Acceptdata(student s)
        {
            Console.WriteLine(" Enter Student Roll Number ");
            rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Student Name ");
            name = (Console.ReadLine());
            Console.WriteLine(" Division ");
            division = (Console.ReadLine());
        }
        public void PrintData()
        {
            Console.WriteLine("Student Roll Number-:" + rollno);
            Console.WriteLine("Name-:" + name);
            Console.WriteLine("Division-:" + division);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
