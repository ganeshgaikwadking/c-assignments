using System;
using System.Collections.Generic;


namespace stackassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(50);
            st.Push(40);
            st.Push(6);
            st.Push(20);

            foreach(int ob in st)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
