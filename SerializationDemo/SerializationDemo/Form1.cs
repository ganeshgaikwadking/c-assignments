using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;


namespace SerializationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Department dept = new Department();
                dept.id = Convert.ToInt32(txtdeptid.Text);
                dept.name = txtname.Text;
                dept.Location = txtlocation.Text;
                FileStream fs = new FileStream(@"F:\DeptBinaryFile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dept);                
                fs.Close();              
                MessageBox.Show("File Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.id = Convert.ToInt32(txtdeptid.Text);
                dept.name = txtname.Text;
                dept.Location = txtlocation.Text;
                FileStream fs = new FileStream(@"F:\Dept.json", FileMode.Create, FileAccess.Write);        
                JsonSerializer.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"F:\Dept.json", FileMode.Open, FileAccess.Read);
                dept = JsonSerializer.Deserialize<Department>(fs);
                txtdeptid.Text = dept.id.ToString();
                txtname.Text = dept.name;
                txtlocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxmlwrite_Click(object sender, EventArgs e)
        {
            Department dept = new Department();
            dept.id = Convert.ToInt32(txtdeptid.Text);
            dept.name = txtname.Text;
            dept.Location = txtlocation.Text;
            FileStream fs = new FileStream(@"F:\DeptXmlFile.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(Department));
            xml.Serialize(fs, dept);
            fs.Close();
            MessageBox.Show("File Added");
        }

        private void btnxmlread_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"F:\DeptXmlFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                txtdeptid.Text = dept.id.ToString();
                txtname.Text = dept.name;
                txtlocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"F:\DeptBinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                dept = (Department)bf.Deserialize(fs);
                txtdeptid.Text = dept.id.ToString();
                txtname.Text = dept.name;
                txtlocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.id = Convert.ToInt32(txtdeptid.Text);
                dept.name = txtname.Text;
                dept.Location = txtlocation.Text;
                FileStream fs = new FileStream(@"F:\DeptSoapFile.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsoapread_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"F:\DeptBinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                dept = (Department)bf.Deserialize(fs);
                txtdeptid.Text = dept.id.ToString();
                txtname.Text = dept.name;
                txtlocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
