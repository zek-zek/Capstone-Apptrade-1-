﻿using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class newPassword : Form
    {
        IFirebaseConfig Config = new FirebaseConfig
        {
            AuthSecret = "sME5IgoZXDCwFGwib4TV41eqvMgKmO4TEH2CEKs6",
            BasePath = "https://fir-capstone-3e2b5-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public newPassword()
        {
            InitializeComponent();
        }

        private void Confirmbttn_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
