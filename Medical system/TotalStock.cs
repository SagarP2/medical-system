using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Medical_system
{
    public partial class TotalStock : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-GSU07MCF\\SQLEXPRESS;Initial Catalog=Medical;Integrated Security=True");
        SqlCommand cmd = new SqlCommand(); 
        public TotalStock()
        {
            InitializeComponent();
        }

        private void btnitemsearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Tbl_Stock where Iname = '" + txtiname.Text + "';", con);
            con.Close();

            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                //txtiname.Text = dr.GetValue(1).ToString();
            }
        }

        private void TotalStock_Load(object sender, EventArgs e)
        {
            BindStock();
        }

        private void BindStock()
        {
            SqlDataAdapter ad = new SqlDataAdapter();
            DataTable dt = new DataTable();

            con.Close();
            ad = new SqlDataAdapter("select * from Tbl_Stock;", con);

            con.Open();
            ad.Fill(dt);
            con.Close();

            GVReports.DataSource = dt;
            //throw new NotImplementedException();
        }
    }
}
