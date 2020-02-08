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

namespace dataaccessusingdataadapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataAdapter da;
        DataSet ds;

        string constring, qrystring;

        private void GVproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Products1_Click(object sender, EventArgs e)
        {
            qrystring = "select productID,productname,unitprice,quantityperunit,categoryID from products";
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            da = new SqlDataAdapter(sqlcmd);
           // ds = new DataSet();
            da.Fill(ds, "productinfo");
            GVproducts.DataSource = ds;
            GVproducts.DataMember = "productinfo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constring = "data source=BLUESAPPHIRE\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(constring);
            ds = new DataSet();

            sqlcon.Open();
            
            
        }
    }
}
