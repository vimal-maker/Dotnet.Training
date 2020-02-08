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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string Constring, qrystring;
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Constring = "data source=BLT10147\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True";
            sqlcon = new SqlConnection(Constring);
            ds = new DataSet();

            using (sqlcon = new SqlConnection(Constring))
            {
                sqlcon.Open();
                qrystring = "select distinct country from customers";
                sqlcmd = new SqlCommand(qrystring, sqlcon);
                dr = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read()) 
                {
                    comboBox1.Items.Add(dr["country"]);
                }
            }
        }
    }
}

    

