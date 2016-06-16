namespace Point_Of_Sales
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelBOTTOM = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bttnPrint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bttnAddNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnModify = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblContains = new System.Windows.Forms.Label();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.chProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSupplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSellingPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTanggal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picLOGO = new System.Windows.Forms.PictureBox();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.panelBOTTOM.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(860, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 143;
            this.label10.Text = "CARI :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(923, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(251, 27);
            this.txtSearch.TabIndex = 142;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(42, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(91, 23);
            this.lblHeader.TabIndex = 140;
            this.lblHeader.Text = "PRODUCT";
            // 
            // panelBOTTOM
            // 
            this.panelBOTTOM.Controls.Add(this.panel1);
            this.panelBOTTOM.Controls.Add(this.label7);
            this.panelBOTTOM.Controls.Add(this.lblContains);
            this.panelBOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBOTTOM.Location = new System.Drawing.Point(0, 336);
            this.panelBOTTOM.Name = "panelBOTTOM";
            this.panelBOTTOM.Size = new System.Drawing.Size(1186, 64);
            this.panelBOTTOM.TabIndex = 144;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bttnPrint);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bttnAddNew);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bttnModify);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bttnDelete);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bttnReload);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bttnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(720, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 64);
            this.panel1.TabIndex = 133;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 49);
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
            this.bttnPrint.Location = new System.Drawing.Point(277, 8);
            this.bttnPrint.Name = "bttnPrint";
            this.bttnPrint.Size = new System.Drawing.Size(40, 40);
            this.bttnPrint.TabIndex = 147;
            this.bttnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnPrint.Click += new System.EventHandler(this.bttnPrint_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 32);
            this.label5.TabIndex = 146;
            this.label5.Text = "&New";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bttnAddNew
            // 
            this.bttnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAddNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnAddNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddNew.ForeColor = System.Drawing.Color.Black;
            this.bttnAddNew.Image = global::Point_Of_Sales.Properties.Resources.New_file;
            this.bttnAddNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnAddNew.Location = new System.Drawing.Point(183, 8);
            this.bttnAddNew.Name = "bttnAddNew";
            this.bttnAddNew.Size = new System.Drawing.Size(41, 40);
            this.bttnAddNew.TabIndex = 145;
            this.bttnAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 144;
            this.label6.Text = "&Rubah";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bttnModify
            // 
            this.bttnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnModify.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnModify.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModify.ForeColor = System.Drawing.Color.Black;
            this.bttnModify.Image = global::Point_Of_Sales.Properties.Resources._Edit_page;
            this.bttnModify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnModify.Location = new System.Drawing.Point(231, 8);
            this.bttnModify.Name = "bttnModify";
            this.bttnModify.Size = new System.Drawing.Size(40, 40);
            this.bttnModify.TabIndex = 143;
            this.bttnModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnModify.Click += new System.EventHandler(this.bttnModify_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 50);
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
            this.bttnDelete.Location = new System.Drawing.Point(323, 8);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(40, 40);
            this.bttnDelete.TabIndex = 139;
            this.bttnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 50);
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
            this.bttnReload.Location = new System.Drawing.Point(371, 8);
            this.bttnReload.Name = "bttnReload";
            this.bttnReload.Size = new System.Drawing.Size(40, 40);
            this.bttnReload.TabIndex = 137;
            this.bttnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 50);
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
            this.bttnCancel.Location = new System.Drawing.Point(419, 8);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(40, 40);
            this.bttnCancel.TabIndex = 135;
            this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(6, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 132;
            this.label7.Text = "PRODUCT RECORD:";
            // 
            // lblContains
            // 
            this.lblContains.AutoSize = true;
            this.lblContains.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContains.ForeColor = System.Drawing.Color.Black;
            this.lblContains.Location = new System.Drawing.Point(5, 30);
            this.lblContains.Name = "lblContains";
            this.lblContains.Size = new System.Drawing.Size(159, 13);
            this.lblContains.TabIndex = 119;
            this.lblContains.Text = "Informasi Produk Dan Stok";
            // 
            // lvProduct
            // 
            this.lvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProductCode,
            this.chProductName,
            this.chCategoryName,
            this.chSupplierName,
            this.chStock,
            this.chUnitPrice,
            this.chSellingPrice,
            this.chDiscount,
            this.chTanggal});
            this.lvProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.GridLines = true;
            this.lvProduct.HideSelection = false;
            this.lvProduct.HoverSelection = true;
            this.lvProduct.Location = new System.Drawing.Point(0, 48);
            this.lvProduct.MultiSelect = false;
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(1178, 245);
            this.lvProduct.TabIndex = 147;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            // 
            // chProductCode
            // 
            this.chProductCode.Text = "KODE PRODUK";
            this.chProductCode.Width = 120;
            // 
            // chProductName
            // 
            this.chProductName.Text = "NAMA PRODUK";
            this.chProductName.Width = 130;
            // 
            // chCategoryName
            // 
            this.chCategoryName.Text = "NAMA KATEGORI";
            this.chCategoryName.Width = 150;
            // 
            // chSupplierName
            // 
            this.chSupplierName.Text = "NAMA SUPPLIER";
            this.chSupplierName.Width = 150;
            // 
            // chStock
            // 
            this.chStock.Text = "STOK";
            this.chStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chStock.Width = 90;
            // 
            // chUnitPrice
            // 
            this.chUnitPrice.Text = "HARGA BELI";
            this.chUnitPrice.Width = 110;
            // 
            // chSellingPrice
            // 
            this.chSellingPrice.Text = "HARGA JUAL";
            this.chSellingPrice.Width = 120;
            // 
            // chDiscount
            // 
            this.chDiscount.Text = "DISKON %";
            this.chDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDiscount.Width = 120;
            // 
            // chTanggal
            // 
            this.chTanggal.Text = "TANGGAL";
            this.chTanggal.Width = 180;
            // 
            // picLOGO
            // 
            this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
            this.picLOGO.Location = new System.Drawing.Point(10, 7);
            this.picLOGO.Name = "picLOGO";
            this.picLOGO.Size = new System.Drawing.Size(24, 24);
            this.picLOGO.TabIndex = 141;
            this.picLOGO.TabStop = false;
            // 
            // picHeader
            // 
            this.picHeader.BackColor = System.Drawing.Color.Transparent;
            this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(1186, 42);
            this.picHeader.TabIndex = 139;
            this.picHeader.TabStop = false;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 400);
            this.ControlBox = false;
            this.Controls.Add(this.lvProduct);
            this.Controls.Add(this.panelBOTTOM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.picLOGO);
            this.Controls.Add(this.picHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduct";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.panelBOTTOM.ResumeLayout(false);
            this.panelBOTTOM.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picLOGO;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Panel panelBOTTOM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttnPrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttnAddNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnModify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblContains;
        public System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader chProductCode;
        private System.Windows.Forms.ColumnHeader chProductName;
        private System.Windows.Forms.ColumnHeader chCategoryName;
        private System.Windows.Forms.ColumnHeader chSupplierName;
        private System.Windows.Forms.ColumnHeader chUnitPrice;
        private System.Windows.Forms.ColumnHeader chSellingPrice;
        private System.Windows.Forms.ColumnHeader chStock;
        private System.Windows.Forms.ColumnHeader chTanggal;
        private System.Windows.Forms.ColumnHeader chDiscount;
    }
}