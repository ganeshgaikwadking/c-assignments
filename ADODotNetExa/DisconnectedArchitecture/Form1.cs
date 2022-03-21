using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DisconnectedArchitecture
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Form1()

        {

            con = new SqlConnection(@"Server=LAPTOP-U11GPVJB\SQLEXPRESS;Database=PracticeDB;Integrated Security=True");

            InitializeComponent();
        }
        public DataSet GetAllEmployees()
        {
            da = new SqlDataAdapter("select * from Employee", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Emp");
            return ds;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployees();
                // insert new record
                DataRow row = ds.Tables["Emp"].NewRow();
                row["Id"] = txtid.Text;
                row["Name"] = txtname.Text;
                row["Designation"] = txtdesignation.Text;
                row["Salary"] = txtsalary.Text;
                ds.Tables["Emp"].Rows.Add(row);
                int result = da.Update(ds.Tables["Emp"]); // this will reflect the changes in to the DB
                if (result == 1)
                {
                    MessageBox.Show("Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployees();

                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtid.Text));
                if (row != null)
                {
                    txtid.Text = row["Id"].ToString();
                    txtname.Text = row["Name"].ToString();
                    txtdesignation.Text = row["Designation"].ToString();
                    txtsalary.Text = row["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployees();
                // insert new record
                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtid.Text));

                row["Name"] = txtname.Text;
                row["Designation"] = txtdesignation.Text;
                row["Salary"] = txtsalary.Text;

                int result = da.Update(ds.Tables["Emp"]); // this will reflect the changes in to the DB
                if (result == 1)
                {
                    MessageBox.Show("updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployees();
                // insert new record
                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtid.Text));
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["Emp"]); // this will reflect the changes in to the DB
                    if (result == 1)
                    {
                        MessageBox.Show("deleted");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

