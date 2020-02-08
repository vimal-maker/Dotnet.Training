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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        string constring, qrystring;

        private void customers_Click(object sender, EventArgs e)
        {
            qrystring = "select c.customerID,c.companyname,c.Address,c.country,o.orderId,o.orderdate,o.shippeddate  from customers c join orders o on o.customerID = c.customerID";
            sqlcmd = new SqlCommand(qrystring, sqlcon);

            da = new SqlDataAdapter(sqlcmd);
            //ds = new DataSet();
            da.Fill(ds, "customerInfo");
            Customerorders.DataSource = ds;
            Customerorders.DataMember = "customerinfo";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qrystring = "select * from customers where country='" + comboBox1.Text + "'";
            sqlcmd = new SqlCommand(qrystring, sqlcon);

            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            //ds = new DataSet();
            da.Fill(ds, "customerInfo");
            Customerorders.DataSource = ds;
            Customerorders.DataMember = "customerinfo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qrystring = "select p.productID,p.productname,p.QuantityPerUnit,p.UnitPrice,c.categoryId,c.categoryname,c.Description  from categories c join products p on p.categoryID= c.categoryID";
            sqlcmd = new SqlCommand(qrystring, sqlcon);

            da = new SqlDataAdapter(sqlcmd);
            //ds = new DataSet();
            da.Fill(ds, "customerInfo");
            Customerorders.DataSource = ds;
            Customerorders.DataMember = "customerinfo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qrystring = "select count(OrderID) from orders";
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            sqlcon.Open();
            sqlcmd.ExecuteScalar().ToString();
            MessageBox.Show("Total Number Of Order Placed:" + sqlcmd.ExecuteScalar().ToString());
            sqlcon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            qrystring = "Select productID,productname,unitprice,quantityperunit,categoryID from products";
            using (sqlcon = new SqlConnection(constring))
            {
                sqlcmd = new SqlCommand(qrystring, sqlcon);
                sqlcon.Open();
                da = new SqlDataAdapter(sqlcmd);
                ds.Clear();
                da.Fill(ds, "productinfo");

                DataTable dt = ds.Tables["productinfo"];

                var products = from product in dt.AsEnumerable()
                               where product.Field<decimal>("unitPrice") >= 50
                               select new
                               {
                                   prodID = product["productID"],
                                   prodname = product["productname"],
                                   price = product["productprice"],
                                   quantity = product["productquantity"]
                               };
                foreach (var product in products)
                {
                    MessageBox.Show("productId=" + product.prodID + "name=" + product.prodname + "price=" + product.price + "quantity=" + product.quantity, "products with price < 50.00");
                }
            }


            //private void Form2_Load(object sender, EventArgs e)
            //{
            //    constring = "data source=BLT10147\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            //    sqlcon = new SqlConnection(constring);
            //    ds = new DataSet();

            //    sqlcon.Open();
            //    qrystring = "select distinct country from Customers";
            //    sqlcmd = new SqlCommand(qrystring, sqlcon);

            //    dr = sqlcmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        comboBox1.Items.Add(dr["Country"]);

            //    }
            //    dr.Close();
            //    sqlcon.Close();


            }
        }
    
    }



