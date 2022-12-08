namespace Capstone_Apptrade.SubForms
{
    partial class AdminConfirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEdits = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtCnfrmPass = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtAdminPass = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirmbttn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbEdits);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.txtCnfrmPass);
            this.panel1.Controls.Add(this.txtAdminPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Confirmbttn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 342);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Edit Account or New Password";
            // 
            // cbEdits
            // 
            this.cbEdits.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEdits.FormattingEnabled = true;
            this.cbEdits.Location = new System.Drawing.Point(46, 217);
            this.cbEdits.Name = "cbEdits";
            this.cbEdits.Size = new System.Drawing.Size(294, 29);
            this.cbEdits.TabIndex = 17;
            this.cbEdits.Text = "Choose---";
            this.cbEdits.SelectedIndexChanged += new System.EventHandler(this.cbEdits_SelectedIndexChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Crimson;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(224, 287);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(81, 42);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.Text = "Cancel";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtCnfrmPass
            // 
            this.txtCnfrmPass.BackColor = System.Drawing.Color.White;
            this.txtCnfrmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCnfrmPass.FocusedLineColor = System.Drawing.Color.Silver;
            this.txtCnfrmPass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnfrmPass.LineColor = System.Drawing.Color.Black;
            this.txtCnfrmPass.LineSize = 2;
            this.txtCnfrmPass.Location = new System.Drawing.Point(46, 140);
            this.txtCnfrmPass.Name = "txtCnfrmPass";
            this.txtCnfrmPass.PasswordChar = '*';
            this.txtCnfrmPass.SelectedText = "";
            this.txtCnfrmPass.Size = new System.Drawing.Size(294, 31);
            this.txtCnfrmPass.TabIndex = 15;
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.BackColor = System.Drawing.Color.White;
            this.txtAdminPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminPass.FocusedLineColor = System.Drawing.Color.Silver;
            this.txtAdminPass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPass.LineColor = System.Drawing.Color.Black;
            this.txtAdminPass.LineSize = 2;
            this.txtAdminPass.Location = new System.Drawing.Point(46, 63);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.PasswordChar = '*';
            this.txtAdminPass.SelectedText = "";
            this.txtAdminPass.Size = new System.Drawing.Size(294, 31);
            this.txtAdminPass.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Admin Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Admin Password";
            // 
            // Confirmbttn
            // 
            this.Confirmbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.Confirmbttn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmbttn.ForeColor = System.Drawing.Color.Black;
            this.Confirmbttn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Confirmbttn.IconColor = System.Drawing.Color.Black;
            this.Confirmbttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Confirmbttn.Location = new System.Drawing.Point(313, 287);
            this.Confirmbttn.Margin = new System.Windows.Forms.Padding(4);
            this.Confirmbttn.Name = "Confirmbttn";
            this.Confirmbttn.Size = new System.Drawing.Size(81, 42);
            this.Confirmbttn.TabIndex = 13;
            this.Confirmbttn.Text = "Confirm";
            this.Confirmbttn.UseVisualStyleBackColor = false;
            this.Confirmbttn.Click += new System.EventHandler(this.Confirmbttn_Click);
            // 
            // AdminConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 342);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "AdminConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Confirmation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Confirmbttn;
        private Guna.UI.WinForms.GunaLineTextBox txtCnfrmPass;
        private Guna.UI.WinForms.GunaLineTextBox txtAdminPass;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEdits;
    }
}