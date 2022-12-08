using Capstone_Apptrade.BackEnd;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Capstone_Apptrade.Forms
{
    public partial class Account : Form
    {
        myDBConnection con = new myDBConnection();
        string [] arRoles = {"Admin", "Cashier", "Material Control Department"};
        int status = 1;
        void role()
        {
            for(int i = 0; i<arRoles.Length; i++)
            {
                cbRoles.Items.Add(arRoles[i]);
            }
            cbRoles.Text = "Choose---";
        }
        public Account()
        {
            InitializeComponent();
            role();
        }


        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            createAccount _account = new createAccount(txtEmail.Text, txtPassword.Text, txtusername.Text,cbRoles.Text, txtFirstName.Text, txtLastName.Text, status);

            try
            {
                
                string insertQuery = "INSERT INTO tbAccounts (Username, Password,Role , First_name, Last_name, Email, Status) " +
                    "VALUES ('" + _account.Username + "', '" + _account.Password + "', '" + _account.Role + "', '" + _account.Fname + "', '" + _account.Lname+ "', '" + _account.Email+ "', '" + _account.Status+ "')";

                if(_account.Username != "" && _account.Password != "" && _account.Fname != "" && _account.Lname != "" && _account.Email != "")
                {
                    con.Open();
                    con.ExecuteDataSet(insertQuery);
                    MessageBox.Show("new account created");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("sorry may kulang kapa", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
