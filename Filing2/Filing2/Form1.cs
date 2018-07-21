using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filing2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Fileing";
            this.button1.Text = "OK";
            this.button2.Text = "Cancel";
            this.radioButton1.Text = "Check File";
            this.radioButton2.Text = "Delete File";
            this.radioButton3.Text = "Copy File";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {

                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            if(radioButton2.Checked)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            if(radioButton3.Checked)
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
