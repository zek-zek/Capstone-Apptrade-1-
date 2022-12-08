using Capstone_Apptrade.POS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Apptrade.Forms
{
    public partial class Sales : Form
    {
        private PointOfSales PointOfSales;
        public Sales()
        {
            InitializeComponent();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPOS_Click_1(object sender, EventArgs e)
        {
            PointOfSales = new PointOfSales();
            PointOfSales.Show();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            productList productList = new productList();
            productList.Show();
        }
    }
}
