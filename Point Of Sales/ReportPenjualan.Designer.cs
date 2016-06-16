namespace Point_Of_Sales
{
    partial class ReportPenjualan
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
            sForm = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPenjualan));
            this.panelBOTTOM = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bttnPrint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.chinvoice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chcash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkembali = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chtanggal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLOGO = new System.Windows.Forms.PictureBox();
            this.panelBOTTOM.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBOTTOM
            // 
            this.panelBOTTOM.Controls.Add(this.panel2);
            this.panelBOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBOTTOM.Location = new System.Drawing.Point(0, 389);
            this.panelBOTTOM.Name = "panelBOTTOM";
            this.panelBOTTOM.Size = new System.Drawing.Size(757, 64);
            this.panelBOTTOM.TabIndex = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.bttnPrint);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bttnDelete);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bttnReload);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bttnCancel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 64);
            this.panel2.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 27);
            this.label5.TabIndex = 154;
            this.label5.Text = "&Detail";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Point_Of_Sales.Properties.Resources.detail1;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(501, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 153;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(199, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 33);
            this.textBox1.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 33);
            this.label3.TabIndex = 152;
            this.label3.Text = "Jumlah Total :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 48);
            this.label8.TabIndex = 148;
            this.label8.Text = "&Print";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bttnPrint
            // 
            this.bttnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPrint.ForeColor = System.Drawing.Color.Black;
            this.bttnPrint.Image = global::Point_Of_Sales.Properties.Resources._Print;
            this.bttnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnPrint.Location = new System.Drawing.Point(547, 12);
            this.bttnPrint.Name = "bttnPrint";
            this.bttnPrint.Size = new System.Drawing.Size(40, 40);
            this.bttnPrint.TabIndex = 147;
            this.bttnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnPrint.Click += new System.EventHandler(this.bttnPrint_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(594, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 48);
            this.label4.TabIndex = 140;
            this.label4.Text = "&Delete";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bttnDelete
            // 
            this.bttnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDelete.ForeColor = System.Drawing.Color.Black;
            this.bttnDelete.Image = global::Point_Of_Sales.Properties.Resources.Delete;
            this.bttnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnDelete.Location = new System.Drawing.Point(593, 12);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(40, 40);
            this.bttnDelete.TabIndex = 139;
            this.bttnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(641, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 64);
            this.label2.TabIndex = 138;
            this.label2.Text = "&Reload";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bttnReload
            // 
            this.bttnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnReload.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnReload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReload.ForeColor = System.Drawing.Color.Black;
            this.bttnReload.Image = global::Point_Of_Sales.Properties.Resources.Refresh;
            this.bttnReload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnReload.Location = new System.Drawing.Point(641, 12);
            this.bttnReload.Name = "bttnReload";
            this.bttnReload.Size = new System.Drawing.Size(40, 40);
            this.bttnReload.TabIndex = 137;
            this.bttnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 72);
            this.label1.TabIndex = 136;
            this.label1.Text = "&Cancel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancel.ForeColor = System.Drawing.Color.Black;
            this.bttnCancel.Image = global::Point_Of_Sales.Properties.Resources.Cancel;
            this.bttnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnCancel.Location = new System.Drawing.Point(689, 12);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(40, 40);
            this.bttnCancel.TabIndex = 135;
            this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // lvProduct
            // 
            this.lvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chinvoice,
            this.chtotal,
            this.chcash,
            this.chkembali,
            this.chtanggal});
            this.lvProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.GridLines = true;
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(0, 44);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(746, 339);
            this.lvProduct.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvProduct.TabIndex = 148;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            this.lvProduct.SelectedIndexChanged += new System.EventHandler(this.lvProduct_SelectedIndexChanged);
            this.lvProduct.DoubleClick += new System.EventHandler(this.lvProduct_DoubleClick);
            // 
            // chinvoice
            // 
            this.chinvoice.Text = "INVOICE";
            this.chinvoice.Width = 170;
            // 
            // chtotal
            // 
            this.chtotal.Text = "TOTAL";
            this.chtotal.Width = 120;
            // 
            // chcash
            // 
            this.chcash.Text = "TUNAI";
            this.chcash.Width = 120;
            // 
            // chkembali
            // 
            this.chkembali.Text = "KEMBALI";
            this.chkembali.Width = 120;
            // 
            // chtanggal
            // 
            this.chtanggal.Text = "TANGGAL";
            this.chtanggal.Width = 200;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(39, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(181, 23);
            this.lblHeader.TabIndex = 142;
            this.lblHeader.Text = "REPORT PENJUALAN";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(449, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 27);
            this.txtSearch.TabIndex = 144;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(319, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 19);
            this.label10.TabIndex = 145;
            this.label10.Text = "CARI PRODUK :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.picLOGO);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 45);
            this.panel1.TabIndex = 149;
            // 
            // picLOGO
            // 
            this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
            this.picLOGO.Location = new System.Drawing.Point(7, 10);
            this.picLOGO.Name = "picLOGO";
            this.picLOGO.Size = new System.Drawing.Size(24, 24);
            this.picLOGO.TabIndex = 143;
            this.picLOGO.TabStop = false;
            // 
            // ReportPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 453);
            this.ControlBox = false;
            this.Controls.Add(this.panelBOTTOM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportPenjualan";
            this.Load += new System.EventHandler(this.ReportPenjualan_Load);
            this.panelBOTTOM.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBOTTOM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttnPrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnCancel;
        public System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.PictureBox picLOGO;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader chkembali;
        private System.Windows.Forms.ColumnHeader chtanggal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader chcash;
        private System.Windows.Forms.ColumnHeader chinvoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader chtotal;
    }
}