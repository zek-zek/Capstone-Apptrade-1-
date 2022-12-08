namespace Capstone_Apptrade.Forms
{
    partial class PurchaseOrderModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderModule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnArchive = new FontAwesome.Sharp.IconButton();
            this.btnEditPOM = new FontAwesome.Sharp.IconButton();
            this.btnAddPOM = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 610);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 62);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1045, 548);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchase Order Module";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOrdered,
            this.dateDelivered,
            this.supplier,
            this.itemDescription,
            this.uom,
            this.quantity,
            this.price,
            this.receiveBy});
            this.dataGridView1.Location = new System.Drawing.Point(13, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 459);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.btnArchive);
            this.panel4.Controls.Add(this.btnEditPOM);
            this.panel4.Controls.Add(this.btnAddPOM);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 485);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1045, 63);
            this.panel4.TabIndex = 1;
            // 
            // dateOrdered
            // 
            this.dateOrdered.HeaderText = "Date Ordered";
            this.dateOrdered.MinimumWidth = 6;
            this.dateOrdered.Name = "dateOrdered";
            this.dateOrdered.Width = 125;
            // 
            // dateDelivered
            // 
            this.dateDelivered.HeaderText = "Date Delivered";
            this.dateDelivered.MinimumWidth = 6;
            this.dateDelivered.Name = "dateDelivered";
            this.dateDelivered.Width = 125;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Supplier";
            this.supplier.MinimumWidth = 6;
            this.supplier.Name = "supplier";
            this.supplier.Width = 125;
            // 
            // itemDescription
            // 
            this.itemDescription.HeaderText = "Item Description";
            this.itemDescription.MinimumWidth = 6;
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.Width = 125;
            // 
            // uom
            // 
            this.uom.HeaderText = "UOM";
            this.uom.MinimumWidth = 6;
            this.uom.Name = "uom";
            this.uom.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // receiveBy
            // 
            this.receiveBy.HeaderText = "Received By";
            this.receiveBy.MinimumWidth = 6;
            this.receiveBy.Name = "receiveBy";
            this.receiveBy.Width = 125;
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.Crimson;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.ForeColor = System.Drawing.Color.White;
            this.btnArchive.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnArchive.IconColor = System.Drawing.Color.White;
            this.btnArchive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArchive.IconSize = 20;
            this.btnArchive.Location = new System.Drawing.Point(702, 20);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(105, 31);
            this.btnArchive.TabIndex = 9;
            this.btnArchive.Text = "Archive";
            this.btnArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArchive.UseVisualStyleBackColor = false;
            // 
            // btnEditPOM
            // 
            this.btnEditPOM.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditPOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPOM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPOM.ForeColor = System.Drawing.Color.White;
            this.btnEditPOM.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnEditPOM.IconColor = System.Drawing.Color.White;
            this.btnEditPOM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditPOM.IconSize = 20;
            this.btnEditPOM.Location = new System.Drawing.Point(815, 19);
            this.btnEditPOM.Name = "btnEditPOM";
            this.btnEditPOM.Size = new System.Drawing.Size(105, 31);
            this.btnEditPOM.TabIndex = 8;
            this.btnEditPOM.Text = "Edit";
            this.btnEditPOM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPOM.UseVisualStyleBackColor = false;
            // 
            // btnAddPOM
            // 
            this.btnAddPOM.BackColor = System.Drawing.Color.Green;
            this.btnAddPOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPOM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPOM.ForeColor = System.Drawing.Color.White;
            this.btnAddPOM.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnAddPOM.IconColor = System.Drawing.Color.White;
            this.btnAddPOM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPOM.IconSize = 20;
            this.btnAddPOM.Location = new System.Drawing.Point(928, 20);
            this.btnAddPOM.Name = "btnAddPOM";
            this.btnAddPOM.Size = new System.Drawing.Size(105, 31);
            this.btnAddPOM.TabIndex = 7;
            this.btnAddPOM.Text = "Add";
            this.btnAddPOM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPOM.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 20;
            this.btnBack.Location = new System.Drawing.Point(29, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PurchaseOrderModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 610);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseOrderModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order Module";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveBy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnArchive;
        private FontAwesome.Sharp.IconButton btnEditPOM;
        private FontAwesome.Sharp.IconButton btnAddPOM;
    }
}