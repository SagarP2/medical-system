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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-GSU07MCF\\SQLEXPRESS;Initial Catalog=Medical;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = txtname.Text;
            password = txtpass.Text;
            try
            {
                String query = " select * from Tbl_Login where username='" + txtname.Text + "' AND password='" + txtpass.Text + "' ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Home s = new Home();
                    s.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Login");
            }
            finally
            {
                con.Close();
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
