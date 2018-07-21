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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

  
       private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "File Copy";
            this.label1.Text = "Source address";
            this.label2.Text = "Source Filename";
            this.label3.Text = "Destination address";
            this.label4.Text = "Destination Filename";
            this.button1.Text = "Copy";
            this.AcceptButton = button1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text;
            string d = textBox3.Text + textBox4.Text;

            if (File.Exists(d))
            {
                DialogResult dr = MessageBox.Show("Do you want to replace?", "File already exist!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    File.Copy(s, d);
                    MessageBox.Show("File copied successfully");
                }
                else
                { 
                    MessageBox.Show("Operation Cancelled!");
                }
            }

            else
            {
                File.Copy(s, d);
                MessageBox.Show("File copied successfully");
            }
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = textBox2.Text;
        }
    }
}
