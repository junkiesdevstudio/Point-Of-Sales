﻿namespace Point_Of_Sales
{
    partial class FormSupplier_View
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.chSupplierCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSupplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttnSelect = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSupplierCode,
            this.chSupplierName,
            this.chIndex});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Navy;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(298, 243);
            this.listView1.TabIndex = 223;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // chSupplierCode
            // 
            this.chSupplierCode.Text = "KODE";
            this.chSupplierCode.Width = 100;
            // 
            // chSupplierName
            // 
            this.chSupplierName.Text = "NAMA SUPPLIER";
            this.chSupplierName.Width = 220;
            // 
            // chIndex
            // 
            this.chIndex.Text = "Index";
            this.chIndex.Width = 0;
            // 
            // bttnSelect
            // 
            this.bttnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttnSelect.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSelect.Location = new System.Drawing.Point(103, 261);
            this.bttnSelect.Name = "bttnSelect";
            this.bttnSelect.Size = new System.Drawing.Size(100, 25);
            this.bttnSelect.TabIndex = 222;
            this.bttnSelect.Text = "&Pilih";
            this.bttnSelect.Click += new System.EventHandler(this.bttnSelect_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancel.Location = new System.Drawing.Point(210, 261);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(100, 25);
            this.bttnCancel.TabIndex = 221;
            this.bttnCancel.Text = "&Batal";
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // FormSupplier_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 298);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bttnSelect);
            this.Controls.Add(this.bttnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSupplier_View";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSupplier_View";
            this.Load += new System.EventHandler(this.FormSupplier_View_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chSupplierCode;
        private System.Windows.Forms.ColumnHeader chSupplierName;
        private System.Windows.Forms.ColumnHeader chIndex;
        private System.Windows.Forms.Button bttnSelect;
        private System.Windows.Forms.Button bttnCancel;
    }
}