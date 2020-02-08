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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        string constring, qrystring;

        //private void UpdateProduct_Click(object sender, EventArgs e)
        //{
            
        //}


        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
         

        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            qrystring = "select unitprice from from products where productname= '" + productlist.Text + "'";
            sqlcmd = new SqlCommand(qrystring, sqlcon);

            sqlcon.Open();
            label3.Text = "price:" + sqlcmd.ExecuteScalar().ToString();
            sqlcon.Close();
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            qrystring = "update products set unitprice=" + Convert.ToDouble(textBox2.Text) +"where productname ='"+productlist.Text+"'";

            sqlcmd = new SqlCommand(qrystring, sqlcon);
            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Product updated", "New product price:");
            sqlcon.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            constring= "data source=BLT10146\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(constring);

            sqlcon.Open();
            qrystring = "select ProductName from Products";
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            dr = sqlcmd.ExecuteReader();
            while(dr.Read())
            {
                productlist.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlcon.Close();
            
        }
    }
}
