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
    public partial class Stock : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-GSU07MCF\\SQLEXPRESS;Initial Catalog=Medical;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
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

            dataGridView12.DataSource = dt;
            //throw new NotImplementedException();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();

                cmd = new SqlCommand("insert into Tbl_Stock values('" + txtiname.Text + "','" + txtidetail.Text + "'," + txtiprice.Text + "," + txtiqnt.Text + ",'" + txtcompany.Text + "','" + txtlocation.Text + "'," + dateexpire.Text + ");", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Stock Inserted Successfully!!!!");
                ClearData();
                BindStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }

        private void ClearData()
        {
            //throw new NotImplementedException();
        }

        private void btnDeletestock_Click(object sender, EventArgs e)
        {
            con.Close();

            cmd = new SqlCommand("delete from Tbl_Stock where Iname='" + txtiname.Text + "';", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Stock Deleted Successfully!!!!");
            ClearData();
            BindStock();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("update Tbl_Stock set Iname='" + textBoxiname.Text + "', IQuentity='" + txtcurentqnt.Text + "' where Iname=" + textBoxiname.Text + ";", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!!!!");
            ClearData();
            BindStock();
        }
      
    }
}
