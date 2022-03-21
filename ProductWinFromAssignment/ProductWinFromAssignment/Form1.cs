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

namespace ProductWinFromAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            try
            {

                Products pro = new Products();
                pro.Code = Convert.ToInt32(txtcode.Text);
                pro.Name = txtname.Text;
                pro.Price= txtprice.Text;
                FileStream fs = new FileStream(@"F:\ProductbinaryFile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, pro);
                fs.Close();
                MessageBox.Show("File Added");
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
                Products pro = new Products();
                FileStream fs = new FileStream(@"F:\ProductBinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                pro = (Products)bf.Deserialize(fs);
                txtcode.Text = pro.Code.ToString();
                txtname.Text = pro.Name;
                txtprice.Text = pro.Price;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Products pro = new Products();
                pro.Code = Convert.ToInt32(txtcode.Text);
                pro.Name = txtname.Text;
                pro.Price = txtprice.Text;
                FileStream fs = new FileStream(@"F:\Product.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, pro);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnjsonread_Click(object sender, EventArgs e)
        {
            try
            {
                Products pro = new Products();
                FileStream fs = new FileStream(@"F:\Product.json", FileMode.Open, FileAccess.Read);
                pro = JsonSerializer.Deserialize<Products>(fs);
                txtcode.Text = pro.Code.ToString();
                txtname.Text = pro.Name;
                txtprice.Text = pro.Price;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxmlwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Products pro = new Products();
                pro.Code = Convert.ToInt32(txtcode.Text);
                pro.Name = txtname.Text;
                pro.Price = txtprice.Text;
                FileStream fs = new FileStream(@"F:\ProductXmlFile.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Products));
                xml.Serialize(fs, pro);
                fs.Close();
                MessageBox.Show("File Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxmlread_Click(object sender, EventArgs e)
        {
            try
            {
                Products dept = new Products();
                FileStream fs = new FileStream(@"F:\ProductXmlFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Products));
                dept = (Products)xml.Deserialize(fs);
                txtcode.Text = dept.Code.ToString();
                txtname.Text = dept.Name;
                txtprice.Text = dept.Price;
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
                Products dept = new Products();
                dept.Code = Convert.ToInt32(txtcode.Text);
                dept.Name = txtname.Text;
                dept.Price = txtprice.Text;
                FileStream fs = new FileStream(@"F:\ProductSoapFile.soap", FileMode.Create, FileAccess.Write);
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
                Products dept = new Products();
                FileStream fs = new FileStream(@"F:\ProductSoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                dept = (Products)sf.Deserialize(fs);
                txtcode.Text = dept.Code.ToString();
                txtname.Text = dept.Name;
                txtprice.Text = dept.Price;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
