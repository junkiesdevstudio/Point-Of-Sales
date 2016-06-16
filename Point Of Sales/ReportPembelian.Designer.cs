namespace Point_Of_Sales
{
    partial class ReportPembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPembelian));
            this.picLOGO = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chbeli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSellingPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPembelian = new System.Windows.Forms.ListView();
            this.chKodeproduk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDiskon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTanggal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bttnPrint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.panelBOTTOM = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBOTTOM.SuspendLayout();
            this.SuspendLayout();
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
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(39, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(177, 23);
            this.lblHeader.TabIndex = 142;
            this.lblHeader.Text = "REPORT PEMBELIAN";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(637, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 27);
            this.txtSearch.TabIndex = 144;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(523, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 19);
            this.label10.TabIndex = 145;
            this.label10.Text = "CARI NAMA :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.picLOGO);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 45);
            this.panel1.TabIndex = 150;
            // 
            // chProductName
            // 
            this.chProductName.Text = "NAMA PRODUK";
            this.chProductName.Width = 150;
            // 
            // chbeli
            // 
            this.chbeli.Text = "BELI";
            this.chbeli.Width = 120;
            // 
            // chSellingPrice
            // 
            this.chSellingPrice.Text = "JUAL";
            this.chSellingPrice.Width = 120;
            // 
            // lvPembelian
            // 
            this.lvPembelian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPembelian.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chKodeproduk,
            this.chProductName,
            this.chbeli,
            this.chSellingPrice,
            this.chDiskon,
            this.chStok,
            this.chTanggal});
            this.lvPembelian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPembelian.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPembelian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvPembelian.FullRowSelect = true;
            this.lvPembelian.GridLines = true;
            this.lvPembelian.HideSelection = false;
            this.lvPembelian.Location = new System.Drawing.Point(1, 51);
            this.lvPembelian.MultiSelect = false;
            this.lvPembelian.Name = "lvPembelian";
            this.lvPembelian.Size = new System.Drawing.Size(883, 294);
            this.lvPembelian.TabIndex = 149;
            this.lvPembelian.UseCompatibleStateImageBehavior = false;
            this.lvPembelian.View = System.Windows.Forms.View.Details;
            // 
            // chKodeproduk
            // 
            this.chKodeproduk.Text = "KODE PRODUK";
            this.chKodeproduk.Width = 120;
            // 
            // chDiskon
            // 
            this.chDiskon.Text = "DISKON";
            this.chDiskon.Width = 100;
            // 
            // chStok
            // 
            this.chStok.Text = "STOK";
            // 
            // chTanggal
            // 
            this.chTanggal.Text = "TANGGAL";
            this.chTanggal.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 19);
            this.label3.TabIndex = 147;
            this.label3.Text = "TOTAL HARGA BELI   :";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(188, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 146;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(485, 351);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 152;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 19);
            this.label9.TabIndex = 153;
            this.label9.Text = "TOTAL HARGA JUAL :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(637, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 154;
            this.label11.Text = "SELISIH  :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(726, 351);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 155;
            // 
            // panel2
            // 
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
            this.panel2.Size = new System.Drawing.Size(884, 64);
            this.panel2.TabIndex = 133;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(693, 48);
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
            this.bttnPrint.Location = new System.Drawing.Point(693, 7);
            this.bttnPrint.Name = "bttnPrint";
            this.bttnPrint.Size = new System.Drawing.Size(40, 40);
            this.bttnPrint.TabIndex = 147;
            this.bttnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnPrint.Click += new System.EventHandler(this.bttnPrint_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(740, 49);
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
            this.bttnDelete.Location = new System.Drawing.Point(739, 7);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(40, 40);
            this.bttnDelete.TabIndex = 139;
            this.bttnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(787, 49);
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
            this.bttnReload.Location = new System.Drawing.Point(787, 7);
            this.bttnReload.Name = "bttnReload";
            this.bttnReload.Size = new System.Drawing.Size(40, 40);
            this.bttnReload.TabIndex = 137;
            this.bttnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(833, 49);
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
            this.bttnCancel.Location = new System.Drawing.Point(835, 7);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(40, 40);
            this.bttnCancel.TabIndex = 135;
            this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // panelBOTTOM
            // 
            this.panelBOTTOM.Controls.Add(this.panel2);
            this.panelBOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBOTTOM.Location = new System.Drawing.Point(0, 382);
            this.panelBOTTOM.Name = "panelBOTTOM";
            this.panelBOTTOM.Size = new System.Drawing.Size(893, 64);
            this.panelBOTTOM.TabIndex = 151;
            this.panelBOTTOM.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBOTTOM_Paint);
            // 
            // ReportPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 446);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelBOTTOM);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvPembelian);
            this.MaximizeBox = false;
            this.Name = "ReportPembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportPembelian";
            this.Load += new System.EventHandler(this.ReportPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelBOTTOM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLOGO;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader chProductName;
        private System.Windows.Forms.ColumnHeader chbeli;
        private System.Windows.Forms.ColumnHeader chSellingPrice;
        public System.Windows.Forms.ListView lvPembelian;
        private System.Windows.Forms.ColumnHeader chDiskon;
        private System.Windows.Forms.ColumnHeader chTanggal;
        private System.Windows.Forms.ColumnHeader chKodeproduk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader chStok;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panelBOTTOM;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnReload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnPrint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
    }
}