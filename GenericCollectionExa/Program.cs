using System;
using BookClass;
using System.Collections.Generic;

namespace GenericCollectionExa
{
    class program
    {
        int price;
        public void CalculateDiscount()
        {
            price = price - (price * 10 / 100);

        }
        public Book(int Bookid, string BookName, string AuthorName, float price)
        {
            this.Bookid = Bookid;
            this.BookName = BookName;
            this.AuthorName = AuthorName;
            this.price = price;


        }
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>();

            list.add(new Book(1, "Back to the Roots", "amannaah Bhatia", 350));
            list.add(new Book(1, "Shining Sikh Youth of India", "Dr. Prabhleen Singh", 460));
            list.add(new Book(1, "400 Days", "Chetan Bhagat", 450));
            list.add(new Book(1, "Relentless", "Yashwant Sinha", 500));
            foreach(Book book in list)
            {
                book.CalculateDiscount();
                Console.WriteLine(book);
               
            }
        }
    }
}
