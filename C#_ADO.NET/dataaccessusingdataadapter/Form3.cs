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
    public partial class Form3 : Form
    {
        string Constring, qrystring;
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        DataSet ds;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
                while(dr!=null)
                {
                    comboBox1.Items.Add(dr["country"]);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* sqlcon.Open();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "getcustomebycoumtry";
            sqlcmd.CommandType = CommandType.StoredProcedureProcedure;*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
