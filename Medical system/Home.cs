using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_system
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangeUser m = new MangeUser();
            m.Show();
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangeUser m = new MangeUser();
            m.Show();
        }

        private void repotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangeUser m = new MangeUser();
            m.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangeUser m = new MangeUser();
            m.Show();
        }

        private void repotsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Company C = new Company();
            C.Show();
        }

        private void newStockToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Stock S = new Stock();
            S.Show();
        }

        private void updateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock S = new Stock();
            S.Show();
        }

        private void removeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock S = new Stock();
            S.Show();
        }

        private void stockInRepotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInRepots R = new StockInRepots();
            R.Show();
        }

        private void selsRepotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleRepots SR = new SaleRepots();
            SR.Show();
        }

        private void totalStockRepotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalStock ST = new TotalStock();
            ST.Show();
        }

        private void aDDDElToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company C = new Company();
            C.Show();
        }
    }
}
