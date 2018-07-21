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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "IsFileExist";
            this.label1.Text = "File Directory";
            this.label2.Text = "Filename";
            this.button1.Text = "Delete";
            this.AcceptButton = button1;
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text;
            if (File.Exists(s))
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "Warning!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    File.Delete(s);
                    MessageBox.Show("File deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Operation Cancelled!");

                }


            }
            else
            {
                MessageBox.Show("File Not Found.");
            }

        }
    }
}
