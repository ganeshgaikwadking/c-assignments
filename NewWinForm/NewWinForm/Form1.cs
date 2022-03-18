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

namespace NewWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreatefolder_Click(object sender, EventArgs e)
        {
            string path = @"E:\Test";
            if(Directory.Exists(path))
            {
                MessageBox.Show("Folder Already Created...");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Created.....");
            }
        }

        private void btncreatefile_Click(object sender, EventArgs e)
        {
            string path = @"E:\Test\TestFile.txt";
            if(File.Exists(path))
            {
                MessageBox.Show("File Is Already Created");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("creadted");
            }
        }
        FileStream fs;
        BinaryWriter bw;
        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                 fs = new FileStream(@"E:\Test\dept1.txt", FileMode.Create, FileAccess.Write);
                 bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtdeptid.Text));
                bw.Write(txtname.Text);
                bw.Write(txtlocation.Text);
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bw.Close();
                fs.Close();
            }
        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\Test\dept1.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtdeptid.Text = br.ReadInt32().ToString();
                txtname.Text = br.ReadString();
                txtlocation.Text = br.ReadString();
                br.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         

}
}
