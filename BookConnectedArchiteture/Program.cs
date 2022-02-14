using System;
using System.Data;
using System.Data.SqlClient;

namespace BookConnectedArchiteture
{
    class Program
    {
        static void Main(string[] args)
        {
          
            try
            {
              
                int Book_id, price;
                string Book_name, Author_Name;
                char c;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=LAPTOP-U11GPVJB\\SQLEXPRESS;database=BookData;trusted_connection=true";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                do
                {

                    Console.WriteLine("1.Display details..");
                    Console.WriteLine("2.Insert Book data..");
                    Console.WriteLine("3.Update Book Data..");
                    Console.WriteLine("4.DeleteBook data..");
                    Console.WriteLine(" Enter Choice  :");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("book Deatils");
                            con.Open();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "SelectBookData";
                            cmd.Connection = con;
                            SqlDataReader datareader = cmd.ExecuteReader();
                            while (datareader.Read())
                            {
                                Console.WriteLine(datareader[0] + "\t" + datareader[1] + "\t" + datareader[2] + "\t" + datareader[3]);

                            }
                            con.Close();
                            break;
                        case 2:
                            Console.WriteLine("Enter Book id:");
                            Book_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Book name :");
                            Book_name = Console.ReadLine();
                            Console.WriteLine("Enter Author name :");
                            Author_Name = Console.ReadLine();
                            price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter price :");
                            con.Open();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "InsertBookData";
                            cmd.Connection = con;

                            cmd.Parameters.AddWithValue("bookid", Book_id);
                            cmd.Parameters.AddWithValue("BookName", Book_name);
                            cmd.Parameters.AddWithValue("AuthorName", Author_Name);
                            cmd.Parameters.AddWithValue("Price", price);
                            int no = cmd.ExecuteNonQuery();
                            Console.WriteLine("data inserted Successfully..");
                            con.Close();
                            break;

                        case 3:
                            Console.WriteLine("Enter Book id:");
                            Book_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Book name :");
                            Book_name = Console.ReadLine();
                            Console.WriteLine("Enter Author name :");
                            Author_Name = Console.ReadLine();
                            price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter price :");
                            con.Open();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "UpdateBookData";
                            cmd.Connection = con;

                            cmd.Parameters.AddWithValue("bookid", Book_id);
                            cmd.Parameters.AddWithValue("BookName", Book_name);
                            cmd.Parameters.AddWithValue("AuthorName", Author_Name);
                            cmd.Parameters.AddWithValue("Price", price);
                            int num = cmd.ExecuteNonQuery();
                            Console.WriteLine("data Updated Successfully..");
                            con.Close();
                            break;
                        case 4:
                            Console.WriteLine("Enter Book id:");
                            Book_id = Convert.ToInt32(Console.ReadLine());
                            con.Open();
                            cmd.Parameters.Clear();
                            cmd.CommandText = "DeletBookData";
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("bookid", Book_id);
                            int numm = cmd.ExecuteNonQuery();
                            Console.WriteLine("Data deleted Successfully...");
                            con.Close();
                            break;
                        default:
                            Console.WriteLine("Please Enter Valid Choice");
                            break;

                    }
                    Console.WriteLine("Do you want to continue...");
                    c = Convert.ToChar(Console.ReadLine());
                }

                while (c == 'Y');
            }
            catch (Exception e)
            {

                Console.WriteLine("executed Successfully..");
            }

            }
        }
    }















