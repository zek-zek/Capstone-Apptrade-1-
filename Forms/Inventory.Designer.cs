namespace Capstone_Apptrade.Forms
{
    partial class Inventory
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAssets = new System.Windows.Forms.TabPage();
            this.dgAssets = new System.Windows.Forms.DataGridView();
            this.tabTrading = new System.Windows.Forms.TabPage();
            this.dgTrading = new System.Windows.Forms.DataGridView();
            this.tabAuctions = new System.Windows.Forms.TabPage();
            this.dgAuction = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPOM = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnArchive = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnImport = new FontAwesome.Sharp.IconButton();
            this.btnSIR = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabAssets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssets)).BeginInit();
            this.tabTrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrading)).BeginInit();
            this.tabAuctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuction)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 610);
            this.panel1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAssets);
            this.tabControl.Controls.Add(this.tabTrading);
            this.tabControl.Controls.Add(this.tabAuctions);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(32, 79);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(981, 456);
            this.tabControl.TabIndex = 1;
            // 
            // tabAssets
            // 
            this.tabAssets.BackColor = System.Drawing.Color.White;
            this.tabAssets.Controls.Add(this.dgAssets);
            this.tabAssets.Location = new System.Drawing.Point(4, 30);
            this.tabAssets.Name = "tabAssets";
            this.tabAssets.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssets.Size = new System.Drawing.Size(973, 422);
            this.tabAssets.TabIndex = 0;
            this.tabAssets.Text = "Assets";
            // 
            // dgAssets
            // 
            this.dgAssets.AllowUserToAddRows = false;
            this.dgAssets.AllowUserToDeleteRows = false;
            this.dgAssets.ColumnHeadersHeight = 29;
            this.dgAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAssets.Location = new System.Drawing.Point(3, 3);
            this.dgAssets.Name = "dgAssets";
            this.dgAssets.ReadOnly = true;
            this.dgAssets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgAssets.RowTemplate.Height = 24;
            this.dgAssets.Size = new System.Drawing.Size(967, 416);
            this.dgAssets.TabIndex = 0;
            // 
            // tabTrading
            // 
            this.tabTrading.BackColor = System.Drawing.Color.White;
            this.tabTrading.Controls.Add(this.dgTrading);
            this.tabTrading.Location = new System.Drawing.Point(4, 30);
            this.tabTrading.Name = "tabTrading";
            this.tabTrading.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrading.Size = new System.Drawing.Size(973, 422);
            this.tabTrading.TabIndex = 1;
            this.tabTrading.Text = "Trading";
            // 
            // dgTrading
            // 
            this.dgTrading.AllowUserToAddRows = false;
            this.dgTrading.AllowUserToDeleteRows = false;
            this.dgTrading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTrading.Location = new System.Drawing.Point(3, 3);
            this.dgTrading.Name = "dgTrading";
            this.dgTrading.ReadOnly = true;
            this.dgTrading.RowHeadersWidth = 51;
            this.dgTrading.RowTemplate.Height = 24;
            this.dgTrading.Size = new System.Drawing.Size(967, 416);
            this.dgTrading.TabIndex = 1;
            // 
            // tabAuctions
            // 
            this.tabAuctions.BackColor = System.Drawing.Color.White;
            this.tabAuctions.Controls.Add(this.dgAuction);
            this.tabAuctions.Location = new System.Drawing.Point(4, 30);
            this.tabAuctions.Name = "tabAuctions";
            this.tabAuctions.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuctions.Size = new System.Drawing.Size(973, 422);
            this.tabAuctions.TabIndex = 2;
            this.tabAuctions.Text = "Auction";
            // 
            // dgAuction
            // 
            this.dgAuction.AllowUserToAddRows = false;
            this.dgAuction.AllowUserToDeleteRows = false;
            this.dgAuction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAuction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAuction.Location = new System.Drawing.Point(3, 3);
            this.dgAuction.Name = "dgAuction";
            this.dgAuction.ReadOnly = true;
            this.dgAuction.RowHeadersWidth = 51;
            this.dgAuction.RowTemplate.Height = 24;
            this.dgAuction.Size = new System.Drawing.Size(967, 416);
            this.dgAuction.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(32, 69);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(981, 10);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btnPOM);
            this.panel5.Controls.Add(this.iconButton1);
            this.panel5.Controls.Add(this.btnArchive);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.btnImport);
            this.panel5.Controls.Add(this.btnSIR);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(32, 535);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(981, 75);
            this.panel5.TabIndex = 3;
            // 
            // btnPOM
            // 
            this.btnPOM.BackColor = System.Drawing.Color.Gray;
            this.btnPOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOM.ForeColor = System.Drawing.Color.White;
            this.btnPOM.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnPOM.IconColor = System.Drawing.Color.White;
            this.btnPOM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPOM.IconSize = 25;
            this.btnPOM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOM.Location = new System.Drawing.Point(222, 19);
            this.btnPOM.Name = "btnPOM";
            this.btnPOM.Size = new System.Drawing.Size(225, 44);
            this.btnPOM.TabIndex = 5;
            this.btnPOM.Text = "Purchase Order Module";
            this.btnPOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPOM.UseVisualStyleBackColor = false;
            this.btnPOM.Click += new System.EventHandler(this.btnPOM_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DarkKhaki;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowsAltV;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(500, 19);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(114, 44);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Refresh";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.Crimson;
            this.btnArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.ForeColor = System.Drawing.Color.White;
            this.btnArchive.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btnArchive.IconColor = System.Drawing.Color.White;
            this.btnArchive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArchive.IconSize = 30;
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Location = new System.Drawing.Point(860, 19);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(114, 44);
            this.btnArchive.TabIndex = 3;
            this.btnArchive.Text = "Archive";
            this.btnArchive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArchive.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.Location = new System.Drawing.Point(740, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Green;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnImport.IconColor = System.Drawing.Color.White;
            this.btnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImport.IconSize = 30;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(620, 19);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(114, 44);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSIR
            // 
            this.btnSIR.BackColor = System.Drawing.Color.Gray;
            this.btnSIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSIR.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIR.ForeColor = System.Drawing.Color.White;
            this.btnSIR.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnSIR.IconColor = System.Drawing.Color.White;
            this.btnSIR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSIR.IconSize = 25;
            this.btnSIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSIR.Location = new System.Drawing.Point(12, 19);
            this.btnSIR.Name = "btnSIR";
            this.btnSIR.Size = new System.Drawing.Size(204, 44);
            this.btnSIR.TabIndex = 0;
            this.btnSIR.Text = "Summary Item Report";
            this.btnSIR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSIR.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(32, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 69);
            this.panel2.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.LineColor = System.Drawing.Color.Black;
            this.txtSearch.LineSize = 2;
            this.txtSearch.Location = new System.Drawing.Point(0, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(888, 39);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "\r\n";
            this.txtSearch.TextOffsetX = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 25;
            this.btnSearch.Location = new System.Drawing.Point(888, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 53);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(981, 16);
            this.panel7.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 610);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1013, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 610);
            this.panel4.TabIndex = 2;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 610);
            this.Controls.Add(this.panel1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabAssets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAssets)).EndInit();
            this.tabTrading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrading)).EndInit();
            this.tabAuctions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAuction)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnSIR;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAssets;
        private System.Windows.Forms.TabPage tabTrading;
        private System.Windows.Forms.TabPage tabAuctions;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnArchive;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnImport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dgAssets;
        private System.Windows.Forms.DataGridView dgTrading;
        private System.Windows.Forms.DataGridView dgAuction;
        private FontAwesome.Sharp.IconButton btnPOM;
    }
}