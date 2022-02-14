using System;
using System.Collections.Generic;


namespace GenericCollectionExa
{
   public class program
    {
        public int BookId, BookPrice;
        public string BookName;
        public string BookAuthor;

        public program(int id, string name, string author, int price)
        {
            BookId = id;
            BookName = name;
            BookAuthor = author;
            BookPrice = price;
        }
        public override string ToString()
        {
            return ("Book ID =" +BookId + " " +"Book Name=" +BookName + " ," +"Auth0r Name=" +BookAuthor + "," +"Book Price="+ BookPrice + ",");
        }
        static void Main(string[] args)
        {
            List<program> list = new List<program>();

            list.Add(new program(1, "Back to the Roots", "amannaah Bhatia", 350));
            list.Add(new program(2, "Shining Sikh Youth of India", "Dr. Prabhleen Singh", 460));
            list.Add(new program(3, "400 Days", "Chetan Bhagat", 450));
            list.Add(new program(4, "Relentless", "Yashwant Sinha", 500));
            foreach(program book in list)
            {
               Console.WriteLine(book);  
            }
        }
    }
}
