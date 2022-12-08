using System;
using System.Drawing;
using System.IO;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Capstone_Apptrade.BackEnd;
using Capstone_Apptrade.SubForms;
using MySql.Data.MySqlClient;

namespace Capstone_Apptrade.Forms
{
    public partial class UserAccount : Form
    {
        static string host = "129.150.49.96";
        static string database = "DbApptrade";
        static string userDB = "zekzek";
        static string password = "Wasak@1314sa";
        public static string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
        MySqlConnection connection = new MySqlConnection(strProvider);
        MySqlCommand command;
        
        public UserAccount(string name, string email)
        {
            InitializeComponent();

            txtName.Text = name;
            txtEmail.Text = email;
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                ImageBoxCircle.Image = Image.FromFile(opf.FileName);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AdminConfirmation admin = new AdminConfirmation();
            admin.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AdminConfirmation admin = new AdminConfirmation();
            admin.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            ImageBoxCircle.Image.Save(ms, ImageBoxCircle.Image.RawFormat);
            byte[] img = ms.ToArray();

            String insertQuery = "INSERT INTO tbSuperAdmin(Profile_img) VALUES('@img')";

            connection.Open();
            command = new MySqlCommand(insertQuery, connection);
            command.Parameters.Add("@img", MySqlDbType.Blob);
            command.Parameters["@img"].Value = img;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted");
            }

            connection.Close();
        

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

    }
}
