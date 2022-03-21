using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADODotNetExa
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server=LAPTOP-U11GPVJB\SQLEXPRESS;Database=PracticeDB;Integrated Security=True");
        }
        private void  ClearData()
        {
            txtid.Clear();
            txtname.Clear();
            txtdesignation.Clear();
            txtsalary.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String qry = "insert into Employee values(@id,@name,@designation,@salary)";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@designation", txtdesignation.Text);
                cmd.Parameters.AddWithValue("@salary",Convert.ToInt32(txtsalary.Text));

                int result = cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Successfully Saved the Record");
                    txtid.Enabled = true;
                    ClearData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Employee where Id=@id";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                dr = cmd.ExecuteReader(0);
                if (dr.HasRows)
                { 
                   if(dr.Read())
                    {
                        txtname.Text = dr["Name"].ToString();
                        txtdesignation.Text = dr["Designation"].ToString();
                        txtsalary.Text = dr["salary"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Employee set Name=@name,Designation=@designation,Salary=@salary where Id=@id";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@designation", txtdesignation.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(txtsalary.Text));

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Successfully updates the Record");
                    ClearData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Employee where Id=@id ";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Successfully Deleted the Record");
                    ClearData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select MAX(Id) from Employee";
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj = cmd.ExecuteScalar();
                if(obj==DBNull.Value)
                {
                    txtid.Text = "1";
                }
                else
                {
                    int id = Convert.ToInt32(obj);
                    id++;
                    txtid.Text = id.ToString();
                }
                txtid.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
