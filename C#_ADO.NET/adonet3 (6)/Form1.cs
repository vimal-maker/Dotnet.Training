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

namespace adonet2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqcon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        string constring, qryString;


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           constring ="data source=BLUESAPPHIRE\\SQLEXPRESS2014;Initial catalog = Northwind;Integrated Security = true;";
            sqlCon = new SqlConnection(constring);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender,EventArgs e)
        {
            sqlCon.open();
            

        }

    
    }
}
