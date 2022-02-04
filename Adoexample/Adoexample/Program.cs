using System;
using System.Data;
using System.Data.SqlClient;
namespace Adoexample
{
    class Program
    {
        static void Main(string[] args)
            
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "LAPTOP-U11GPVJB\\SQLEXPRESS";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "GetDepartmentUsingID";
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("deptid", 200);

                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("Dept info id");
                reader.Read();
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t", reader[2] + "\t" + reader[3]);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }


        }
    }
}
