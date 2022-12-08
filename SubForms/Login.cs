using System;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Capstone_Apptrade.BackEnd;
using Capstone_Apptrade.Forms;
using Capstone_Apptrade.POS;
using MySql.Data.MySqlClient;

namespace Capstone_Apptrade.SubForms
{
    public partial class Login : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlDataReader row;
        accountInformation accInfo;
        PointOfSales pointOfSales;
        Dashboard dashboard;
        Inventory inventory;
        string first_name, last_name, email;
        string[] arPosition = {"Admin", "Cashier", "Material Control Department" };
        public Login()
        {
            InitializeComponent();

            for(int i = 0; i < arPosition.Length; i++)
            {
                cbPosition.Items.Add(arPosition[i]);
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT ID, Username, Password, Role, First_name, Last_name, Email, Status FROM tbAccounts " +
                    "WHERE Username ='" + txtUsername.Text + "' AND Password ='" + txtPassword.Text + "' AND Role = '"+cbPosition.Text+"' AND Status = 1";
                row = con.ExecuteReader(query);
                if (txtUsername.Text != "" && txtPassword.Text != "" && cbPosition.Text != "")
                {
                    if (cbPosition.Text.Equals(arPosition[0]))
                    {
                        if (row.HasRows)
                        {
                            while (row.Read())
                            {
                                first_name = row["First_name"].ToString();
                                last_name = row["Last_name"].ToString();
                                email = row["Email"].ToString();
                            }
                            accInfo = new accountInformation(first_name + " " + last_name, email);
                            dashboard = new Dashboard(first_name + " " + last_name, email);
                            dashboard.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Data not found", "Information");
                        }
                    }
                    else if (cbPosition.Text.Equals(arPosition[1]))
                    { 
                        if (row.HasRows)
                        {
                            while (row.Read())
                            {
                                first_name = row["First_name"].ToString();
                                last_name = row["Last_name"].ToString();
                                email = row["Email"].ToString();
                            }
                            accInfo = new accountInformation(first_name + " " + last_name, email);
                            pointOfSales = new PointOfSales();
                            pointOfSales.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Data not found", "Information");
                        }
                    }
                    else if (cbPosition.Text.Equals(arPosition[2]))
                    {
                        if (row.HasRows)
                        {
                            while (row.Read())
                            {
                                first_name = row["First_name"].ToString();
                                last_name = row["Last_name"].ToString();
                                email = row["Email"].ToString();
                            }
                            accInfo = new accountInformation(first_name + " " + last_name, email);
                            inventory = new Inventory();
                            inventory.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Data not found", "Information");
                        }
                    }             
                }
                else
                {
                    MessageBox.Show("Username, Password or Position is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
