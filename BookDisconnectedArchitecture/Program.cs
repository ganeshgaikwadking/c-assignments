using System;
using System.Data;
using System.Data.SqlClient;


namespace BookDisconnectedArchitecture
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                char c;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=LAPTOP-U11GPVJB\\SQLEXPRESS;database=BookData;trusted_connection=true";
                SqlCommand sc = new SqlCommand("SelectBookData", con);
                sc.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqladp = new SqlDataAdapter(sc);
                SqlCommandBuilder builder = new SqlCommandBuilder(sqladp);
                DataSet dataset = new DataSet();
                DataTable datatb = dataset.Tables["SelectBookData"];
                do
                {
                    Console.WriteLine("1. Display Deatails ");
                    Console.WriteLine("2. Insert Data");
                    Console.WriteLine("3. update Data");
                    Console.WriteLine("4. Delete Data");
                    Console.WriteLine(" Enter Choice  :");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("All Books");
                            foreach (DataRow row in datatb.Rows)
                            {
                                Console.WriteLine(row["Book_id"] + "\t" + row["book_Name"] + "\t" + row["Author_Name"] + "\t" + row["price"]);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter Book Id:");
                            int book_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Book Name:");
                            string book_name = Console.ReadLine();
                            Console.WriteLine("Enter Author Name:");
                            string author_name = Console.ReadLine();
                            Console.WriteLine("Enter Book price:");
                            int price = Convert.ToInt32(Console.ReadLine());

                            DataRow datar = datatb.NewRow();
                            datar["bookid"] = book_id;
                            datar["Bookname"] = book_name;
                            datar["AuthorName"] = author_name;
                            datar["price"] = price;

                            datatb.Rows.Add(datar);
                            sqladp.Update(dataset, "SelectBookData");
                            Console.WriteLine("data Inserted Successfully...");
                            break;


                        case 3:
                            Console.WriteLine("Enter Book Id:");
                            int book_idd = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Book Name:");
                            string book_namee = Console.ReadLine();
                            Console.WriteLine("Enter Author Name:");
                            string author_namee = Console.ReadLine();
                            Console.WriteLine("Enter Book price:");
                            int pricee = Convert.ToInt32(Console.ReadLine());


                            DataRow[] updater = datatb.Select("bookid=" + book_idd);
                            DataRow rowupdate = updater[0];
                            rowupdate["bookid"] = book_idd;
                            rowupdate["Bookname"] = book_namee;
                            rowupdate["AuthorName"] = author_namee;
                            rowupdate["price"] = pricee;
                            sqladp.Update(dataset, "SelectBookData");
                            Console.WriteLine("Update Successfully...");


                            break;

                        case 4:
                            Console.WriteLine("enter book_id: ");
                            int bookid = Convert.ToInt32(Console.ReadLine());

                            DataRow[] delerow = datatb.Select("bookid=" + bookid);
                            DataRow deleterow = delerow[0];
                            deleterow.Delete();
                            sqladp.Update(dataset, "SelectBookData");
                            Console.WriteLine("Data delete succeefully.... ");
                            break;

                        default:
                            break;
                    }
                    Console.WriteLine("Do you want to continue...");
                    c = Convert.ToChar(Console.ReadLine());
                }
                while (c == 'Y');
            }
            catch (Exception e)
            {
            }


        }
    }
}
    

