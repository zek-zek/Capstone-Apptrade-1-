using Capstone_Apptrade.BackEnd;
using Capstone_Apptrade.SubForms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using IdentityServer4.Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
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
    public partial class Inventory : Form
    {
        addProduct addProduct;
        myDBConnection connection = new myDBConnection();
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable data;

        public void assets()
        {
            connection.Open();
            command = new MySqlCommand("SELECT * FROM tbAssets", connection.conn);
            command.ExecuteNonQuery();
            data = new DataTable();
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(data);
            dgAssets.DataSource = data.DefaultView;
            connection.Close();
        }
        public void trading()
        {
            connection.Open();
            command = new MySqlCommand("SELECT * FROM tbTrading", connection.conn);
            command.ExecuteNonQuery();
            data = new DataTable();
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(data);
            dgTrading.DataSource = data.DefaultView;
            connection.Close();
        }
        public void auction()
        {
            connection.Open();
            command = new MySqlCommand("SELECT * FROM tbAuction", connection.conn);
            command.ExecuteNonQuery();
            data = new DataTable();
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(data);
            dgAuction.DataSource = data.DefaultView;
            connection.Close();
        }
        public Inventory()
        {
            InitializeComponent();
            assets();
            trading();
            auction();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addProduct = new addProduct();
            addProduct.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPOM_Click(object sender, EventArgs e)
        {
            PurchaseOrderModule purchaseOrderModule = new PurchaseOrderModule();
            purchaseOrderModule.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }
    }
}
