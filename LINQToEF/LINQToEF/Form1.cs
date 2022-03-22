using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQToEF
{
    public partial class Form1 : Form
    {
        EmployeeEntities DbContext = new EmployeeEntities();

        public Form1()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            txtid.Clear();
            txtname.Clear();
            txtdesignation.Clear();
            txtsalary.Clear();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtid.Text);
                emp.Name = txtname.Text;
                emp.Designation = txtdesignation.Text;
                emp.Salary = Convert.ToDecimal(txtsalary.Text);

                DbContext.Employees.Add(emp);
                int res = DbContext.SaveChanges();
                if (res == 1)
                {
                    MessageBox.Show("Saved");
                    ClearData();
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try {

                Employee emp = DbContext.Employees.Find(Convert.ToInt32(txtid.Text));
                if (emp != null)
                {
                    txtname.Text = emp.Name;
                    txtdesignation.Text = emp.Designation;
                    txtsalary.Text = emp.Salary.ToString();
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

                Employee emp = DbContext.Employees.Find(Convert.ToInt32(txtid.Text));
                if (emp != null)
                {
                    emp.Name = txtname.Text;
                    emp.Designation = txtdesignation.Text;
                    emp.Salary = Convert.ToDecimal(txtsalary.Text);
                    int res = DbContext.SaveChanges();
                    if (res == 1)
                    {
                        MessageBox.Show("Updated");
                        ClearData();

                    }
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try { 
            Employee emp = DbContext.Employees.Find(Convert.ToInt32(txtid.Text));
            if (emp != null)
            {
                DbContext.Employees.Remove(emp);
                int res = DbContext.SaveChanges();
                if (res == 1)
                {
                    MessageBox.Show("Deleted");

                }
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
    }
}
