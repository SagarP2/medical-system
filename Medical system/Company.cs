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
    public partial class Company : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-GSU07MCF\\SQLEXPRESS;Initial Catalog=Medical;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            BindCompany();
        }

        private void BindCompany()
        {
            SqlDataAdapter ad = new SqlDataAdapter();
            DataTable dt = new DataTable();

            con.Close();
            ad = new SqlDataAdapter("select * from Tbl_Company;", con);

            con.Open();
            ad.Fill(dt);
            con.Close();

            dataGridView.DataSource = dt;
            //throw new NotImplementedException();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();

                cmd = new SqlCommand("insert into Tbl_Company values('" + txtname.Text + "','" + txtadd.Text + "','" + txtpersn.Text + "','" + txtmobile + "');", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Company Record Inserted Successfully!!!!");
                ClearData();
                BindCompany();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }

        private void ClearData()
        {
            txtname.Clear();
            txtadd.Clear();
            txtpersn.Clear();
            txtmobile.Clear();
 	        //throw new NotImplementedException();
        }
        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            con.Close();

            cmd = new SqlCommand("delete from Tbl_Company where cId='" + textBox1.Text + "';", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Company Record Deleted Successfully!!!!");
            ClearData();
            BindCompany();
        }
    }
}
