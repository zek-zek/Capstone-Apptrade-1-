using Capstone_Apptrade.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Apptrade.SubForms
{
    public partial class accountList : Form
    {
        public accountList()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
        }
    }
}
