using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adonets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Field should not be blank,type any data");

            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Apadi than solluven");
            }
            else
            {
                double n1, n2;
                n1 = double.Parse(textBox1.Text);
                n2 = double.Parse(textBox2.Text);

                double Result = 0;
                if (radioButton1.Checked)
                {
                    Result = n1 + n2;
                    lblSolution.Text = "sum" + Result;
                }
                else if (radioButton2.Checked)
                {
                    Result = n1 - n2;
                    lblSolution.Text = "Difference" + Result;
                }
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
