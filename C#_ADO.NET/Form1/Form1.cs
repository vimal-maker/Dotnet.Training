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

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        string constring, qrystring;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            qrystring = "select productname from products";
            sqlcmd = new SqlCommand(qrystring, sqlcon);

            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlcon.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constring = "data source=BLT10146\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(constring);

            sqlcon.Open();

            qrystring = "select productname from products";
            sqlcmd = new SqlCommand(qrystring, sqlcon);

            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlcon.Close();
            comboBox1.Text = "all Products";//naming conbox
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qrystring = "select UnitPrice from products where ProductName ='" + comboBox1.Text + "'";
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            sqlcon.Open();
            price.Text = "Unit Price:" + sqlcmd.ExecuteScalar().ToString();
            sqlcon.Close();

        }
    }
}
