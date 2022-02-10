using System;

namespace assignmentnew
{
    class Program
    {
        public void palindromeString(string st)
        {
            string temp = "";
            for(int i=st.Length-1;i>=0;i--)
            {
                temp += st[i];
            }
            Console.WriteLine(temp);
            if (st.Equals(temp))
            {
                Console.WriteLine("String Is Palindrome");

            }
            else
            {
                Console.WriteLine("String Is Not palindrome");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string st = Console.ReadLine();

            new Program().palindromeString(st);
        }
    }
}
