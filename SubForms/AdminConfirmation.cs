using Capstone_Apptrade.BackEnd;
using Capstone_Apptrade.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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

namespace Capstone_Apptrade.SubForms
{
    public partial class AdminConfirmation : Form
    {

        string[] arEdits = { "Account profile", "New password" };
        public AdminConfirmation()
        {
            InitializeComponent();
            for (int i = 0; i < arEdits.Length; i++)
            {
                cbEdits.Items.Add(arEdits[i]);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Confirmbttn_Click(object sender, EventArgs e)
        {

        }

        private void cbEdits_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            

            
        }
    }
}
