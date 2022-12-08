namespace Capstone_Apptrade.SubForms
{
    partial class newPassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCnfrmPass = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtAdminPass = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Confirmbttn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.txtCnfrmPass);
            this.panel1.Controls.Add(this.txtAdminPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Confirmbttn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 274);
            this.panel1.TabIndex = 1;
            // 
            // txtCnfrmPass
            // 
            this.txtCnfrmPass.BackColor = System.Drawing.Color.White;
            this.txtCnfrmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCnfrmPass.FocusedLineColor = System.Drawing.Color.Silver;
            this.txtCnfrmPass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnfrmPass.LineColor = System.Drawing.Color.Black;
            this.txtCnfrmPass.LineSize = 2;
            this.txtCnfrmPass.Location = new System.Drawing.Point(46, 142);
            this.txtCnfrmPass.Name = "txtCnfrmPass";
            this.txtCnfrmPass.PasswordChar = '\0';
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
            this.txtAdminPass.PasswordChar = '\0';
            this.txtAdminPass.SelectedText = "";
            this.txtAdminPass.Size = new System.Drawing.Size(294, 31);
            this.txtAdminPass.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Confirm New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "New Password";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Crimson;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(206, 210);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(81, 42);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.Text = "Cancel";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Confirmbttn
            // 
            this.Confirmbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.Confirmbttn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmbttn.ForeColor = System.Drawing.Color.Black;
            this.Confirmbttn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Confirmbttn.IconColor = System.Drawing.Color.Black;
            this.Confirmbttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Confirmbttn.Location = new System.Drawing.Point(295, 210);
            this.Confirmbttn.Margin = new System.Windows.Forms.Padding(4);
            this.Confirmbttn.Name = "Confirmbttn";
            this.Confirmbttn.Size = new System.Drawing.Size(81, 42);
            this.Confirmbttn.TabIndex = 13;
            this.Confirmbttn.Text = "Confirm";
            this.Confirmbttn.UseVisualStyleBackColor = false;
            this.Confirmbttn.Click += new System.EventHandler(this.Confirmbttn_Click);
            // 
            // newPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 274);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newPassword";
            this.Text = "newPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI.WinForms.GunaLineTextBox txtCnfrmPass;
        private Guna.UI.WinForms.GunaLineTextBox txtAdminPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Confirmbttn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}