namespace Point_Of_Sales
{
    partial class FormProduct_View
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
            this.lvProduct = new System.Windows.Forms.ListView();
            this.chProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttnSelect = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvProduct
            // 
            this.lvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProductCode,
            this.chProductName,
            this.chUnitPrice,
            this.chStock,
            this.chIndex});
            this.lvProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvProduct.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProduct.ForeColor = System.Drawing.Color.Navy;
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.GridLines = true;
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(12, 91);
            this.lvProduct.MultiSelect = false;
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(575, 198);
            this.lvProduct.TabIndex = 224;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            // 
            // chProductCode
            // 
            this.chProductCode.Text = "KODE";
            this.chProductCode.Width = 100;
            // 
            // chProductName
            // 
            this.chProductName.Text = "NAMA PRODUK";
            this.chProductName.Width = 220;
            // 
            // chUnitPrice
            // 
            this.chUnitPrice.DisplayIndex = 3;
            this.chUnitPrice.Text = "HARGA";
            this.chUnitPrice.Width = 150;
            // 
            // chStock
            // 
            this.chStock.DisplayIndex = 4;
            this.chStock.Text = "STOCK";
            this.chStock.Width = 100;
            // 
            // chIndex
            // 
            this.chIndex.DisplayIndex = 2;
            this.chIndex.Text = "Index";
            this.chIndex.Width = 0;
            // 
            // bttnSelect
            // 
            this.bttnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttnSelect.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSelect.Location = new System.Drawing.Point(380, 297);
            this.bttnSelect.Name = "bttnSelect";
            this.bttnSelect.Size = new System.Drawing.Size(100, 25);
            this.bttnSelect.TabIndex = 226;
            this.bttnSelect.Text = "&Pilih";
            this.bttnSelect.Click += new System.EventHandler(this.bttnSelect_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancel.Location = new System.Drawing.Point(487, 297);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(100, 25);
            this.bttnCancel.TabIndex = 225;
            this.bttnCancel.Text = "&Batal";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(83, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(222, 21);
            this.txtSearch.TabIndex = 227;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 228;
            this.label1.Text = "CARI :";
            // 
            // FormProduct_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bttnSelect);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.lvProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduct_View";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduct_View";
            this.Load += new System.EventHandler(this.FormProduct_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader chProductCode;
        private System.Windows.Forms.ColumnHeader chProductName;
        private System.Windows.Forms.ColumnHeader chIndex;
        private System.Windows.Forms.ColumnHeader chUnitPrice;
        private System.Windows.Forms.ColumnHeader chStock;
        private System.Windows.Forms.Button bttnSelect;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}