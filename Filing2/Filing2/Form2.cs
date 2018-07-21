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

namespace Filing2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "IsFileExist";
            this.label1.Text = "File Directory";
            this.label2.Text = "Filename";
            this.label3.Text = "Extension";
            this.button1.Text = "Check"; 
            this.AcceptButton = button1;
            string[] ext = { ".exe", ".txt", ".pdf", ".html", ".png", ".bmp",".jpeg" };
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.AddRange(ext);

        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {

            string s = textBox1.Text + textBox2.Text + comboBox1.Text;
            if (File.Exists(s))
            {
                MessageBox.Show("Yes, File exist.");
            }
            else
            {
                MessageBox.Show("File Not Found.");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
