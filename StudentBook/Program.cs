using System;


namespace StudentBook
{
    public class BookData
    {
        int Bookid;
        string BookName, AuthorName;
        float price,Dicount;

        public BookData(int Bookid, string BookName, string AuthorName, float price)
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
            BookData book = new BookData(1, "Life in the Clock Tower Valley", "Shakoor Rather", 500);
            BookData book1 = new BookData(2, "Elephant in the Womb", "Kalki Koechlin", 300);

            book.CalculateDiscount();
            Console.WriteLine(book);
            book1.CalculateDiscount();
            Console.WriteLine(book1);
           
            
        }
        
    }
  
}
