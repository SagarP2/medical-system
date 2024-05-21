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
    public partial class MangeUser : Form 
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-GSU07MCF\\SQLEXPRESS;Initial Catalog=Medical;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public MangeUser()
        {
            InitializeComponent();
        }

        private void MangeUser_Load(object sender, EventArgs e)
        {
            BindUser();
        }

        private void BindUser()
        {
            SqlDataAdapter ad = new SqlDataAdapter();
            DataTable dt = new DataTable();

            con.Close();
            ad = new SqlDataAdapter("select * from Tbl_MangeUser;", con);

            con.Open();
            ad.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
            //throw new NotImplementedException();
        }

        private void bntAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();

                cmd = new SqlCommand("insert into Tbl_MangeUser values('" + txtname.Text + "','" + txtpass.Text + "'," + txtcpass.Text + ");", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User Record Inserted Successfully!!!!");
                ClearData();
                BindUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Close();

            cmd = new SqlCommand("delete from Tbl_MangeUser where username='"+txtname.Text+"';", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Record Deleted Successfully!!!!");
            ClearData();
            BindUser();
        }

        private void ClearData()
        {
            txtname.Clear();
            txtpass.Clear();
            txtcpass.Clear();
            //throw new NotImplementedException();
        }
    }
}
