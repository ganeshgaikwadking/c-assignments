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

namespace ProductWithArchitectureAssignment
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        
        public Form1()
        {
            InitializeComponent();
        
            con = new SqlConnection(@"Server=LAPTOP-U11GPVJB\SQLEXPRESS;Database=Assignment;Integrated Security=True");

        }
        private void ClearData()
        {
            txtproductid.Clear();
            txtproductname.Clear();
            txtcompanyname.Clear();
           
        }

        //private void lblid_click(object sender, eventargs e)
        //{

        //}
      
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Employee values(@id,@name,@company,@category)";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtproductid.Text));
                cmd.Parameters.AddWithValue("@name", txtproductname.Text);
                cmd.Parameters.AddWithValue("@company", txtproductname.Text);
                cmd.Parameters.AddWithValue("@category", Convert.ToInt32(cmbcategoryname.Text));
                //cmbcategoryname.DropDownStyle = ComboBoxStyle.DropDownList;
                //cmbcategoryname.Enabled = true;
              

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Successfully Saved the Record");
                    txtproductid.Enabled = true;
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

        private void cmbcategoryname_SelectedIndexChanged(object sender, EventArgs e)
        {


            //SqlConnection con = new SqlConnection();
            //string quert = "select * from Category";
            //SqlCommand cmd = new SqlCommand(quert, con);
            //con.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    int id = dr.GetInt32(0);
            //    cmbcategoryname.Items.Add(id);
            //}
            //Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.assignmentDataSet.Category);

        }
    }
}
