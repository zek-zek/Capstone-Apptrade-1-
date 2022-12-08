using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp;
using Capstone_Apptrade.BackEnd;
using MySql.Data.MySqlClient;

namespace Capstone_Apptrade.SubForms
{
    public partial class addProduct : Form
    {

        myDBConnection connection = new myDBConnection();
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable data;
        string[] arCategory = {"Animal", "Art & Craft", "Baby", "Carriers and Accessories", "Cleaning, safety, & Others", 
                                "Clothing", "Cosmetics", "Electronics", "Food & Beverage", "Footwear", "Furniture",
                                "Garden & Patio", "Health & Beauty", "Home", "Jewelry", "Media", "Music & Instrument", 
                                "Occasion & Seasonal", "Office", "Photography", "Sport & Recreation", "Tools & Hardware", 
                                "Toys", "Vehicle", "Watches"};
        public addProduct()
        {
            InitializeComponent();

            for(int i = 0; i<arCategory.Length; i++)
            {
                cbCategory.Items.Add(arCategory[i]);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            BarcodeGenerator generator = new BarcodeGenerator();
            generator.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUOM.Clear();
            txtSKU.Clear();
            txtBarcode.Clear();
            cbCategory.Text = "choose---";
            txtProductName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
        }

        private void btnSave_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                
                string insertQuery = "INSERT INTO tbProducts (Name, Description, Category, SKU, Barcode, UOM, Price) VALUES ('"+txtProductName.Text+"', '"+txtDescription.Text+"','"+cbCategory.Text +"', '"+txtSKU.Text+"', '"+txtBarcode.Text +"', '"+txtUOM.Text +"', '"+txtPrice.Text +"')";

                command = new MySqlCommand(insertQuery, connection.conn);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("No data inserted");
                }

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
