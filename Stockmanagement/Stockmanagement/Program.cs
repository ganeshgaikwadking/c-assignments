using System;

namespace Stockmanagement
{
    class Selling
    {
        public Selling(string Message):base(Message)
        {

        }
        public void PrintError()
        {
            Console.WriteLine("Insufficient Stock");
        }

    }
    class purchase
    { 
         double qauntity;

        public purchase(double quan)
        {
            qauntity = quan;
        
        }
        
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            
        }
    }
}
