using System;

namespace StudentBook
{
    class Program
    {
        int Bookid;
        string BookName, AuthorName;
        float price,Dicount;

        public  Program(int Bookid, string BookName, string AuthorName, float price)
            {
            this.Bookid = Bookid;
            this.BookName = BookName;
            this.AuthorName = AuthorName;
            this.price = price;
           

            }
        public void CalculateDiscount()
        {
            price = price - (price * 10 / 100);

        }
        public override string ToString()
        {
            return " Bookid = " +Bookid  + "Book Name = " + BookName + "Author Name" + AuthorName + "Book Price" + price;
        }

        static void Main(string[] args)
        {
            Program book = new Program (1, "Life in the Clock Tower Valley", "Shakoor Rather", 500);
            Program book1 = new Program(2, "Elephant in the Womb", "Kalki Koechlin", 300);

            book.CalculateDiscount();
            Console.WriteLine(book);
            book1.CalculateDiscount();
            Console.WriteLine(book1);
           
            
        }
        
    }
  
}
