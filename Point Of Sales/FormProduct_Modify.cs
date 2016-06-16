using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sales
{
    public partial class FormProduct_Modify : Form
    {
        public static bool ADD_STATE;
        public static FormProduct_Modify publcFormProduct_Modify;
        public static string sProductKode;
        MySqlCommand cmdAddProduct;
        public static int sCategoryID;
        public static int sSupplierID;

        public FormProduct_Modify()
        {
            InitializeComponent();
        }

        private void FormProduct_Modify_Load(object sender, EventArgs e)
        {
            if (ADD_STATE == true)
            {
                //txtProductCode.Text = "PROD-" + clsFunctions.GenerateCD("SELECT MAX(autoid) FROM tblproduct", "tblproduct");
                cmdAddProduct = new MySqlCommand("INSERT INTO tblproduct( productcode , productname, categoryautoid, supplierautoid, unitprice, sellingprice, discount, stock, tanggal)" +
                                               "VALUES (@getProductCode,@getProductName,@getCategoryId,@getSupplierID,@getUnitPrice,@getSellingPrice,@Discount,@getStock,@Tanggal)", clsConnection.CN);
                this.Text = "Add New";
            }
            else
            {
                txtProductCode.Enabled = false;
                //Set Edit OleDbCommand
                cmdAddProduct = new MySqlCommand("UPDATE tblproduct SET productcode=@getProductCode, productname=@getProductName, categoryautoid=@getCategoryId, supplierautoid=@getSupplierID, unitprice=@getUnitPrice, sellingprice=@getSellingPrice, stock=@getStock, discount=@Discount WHERE productcode LIKE '" + sProductKode + "' ", clsConnection.CN);
                FillFields();
                this.Text = "Edit Existing";
            }
            cmdAddProduct.Parameters.Add("@getProductCode", MySqlDbType.VarChar);
            cmdAddProduct.Parameters.Add("@getProductName", MySqlDbType.VarChar);
            cmdAddProduct.Parameters.Add("@getCategoryId", MySqlDbType.Int16);
            cmdAddProduct.Parameters.Add("@getSupplierID", MySqlDbType.Int16);
            cmdAddProduct.Parameters.Add("@getUnitPrice", MySqlDbType.Decimal);
            cmdAddProduct.Parameters.Add("@getSellingPrice", MySqlDbType.Decimal);
            cmdAddProduct.Parameters.Add("@Discount", MySqlDbType.Decimal);
            cmdAddProduct.Parameters.Add("@getStock", MySqlDbType.Int32);
            cmdAddProduct.Parameters.Add("@Tanggal", MySqlDbType.Date);
            publcFormProduct_Modify = this;
        }

        private void FillFields()
        {
            long totalRow = 0;
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT tblproduct.productcode, tblproduct.productname, tblcategory.categoryname, tblcategory.categorycode, tblsupplier.suppliername, tblsupplier.suppliercode, tblproduct.unitprice, tblproduct.sellingprice, tblproduct.discount, tblproduct.stock , tblproduct.categoryautoid, tblproduct.supplierautoid FROM tblproduct RIGHT JOIN tblcategory ON tblproduct.categoryautoid = tblcategory.autoid RIGHT JOIN tblsupplier ON tblproduct.supplierautoid = tblsupplier.autoid " +
                        "WHERE tblproduct.productcode LIKE '" + sProductKode + "' ORDER BY tblproduct.autoid ASC", clsConnection.CN);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblproduct");
            totalRow = ds.Tables["tblproduct"].Rows.Count - 1;
            txtProductCode.Text = ds.Tables["tblproduct"].Rows[0].ItemArray.GetValue(0).ToString();
            txtProductName.Text = ds.Tables["tblproduct"].Rows[0].ItemArray.GetValue(1).ToString();
            txtCategoryName.Text = ds.Tables["tblproduct"].Rows[0].ItemArray.GetValue(2).ToString();
            txtSupplierName.Text = ds.Tables["tblproduct"].Rows[0].ItemArray.GetValue(4).ToString();
            txtUnitPrice.Text = ds.Tables["tblproduct"].Rows[0].ItemArray.GetValue(6).ToString();
            txtSellingPrice.Text = ds.Tables["tblproduct"].Rows[0].ItemArray.GetValue(7).ToString();
            txtDiskon.Text = ds.Tables["tblproduct"].Rows[0].ItemArray.GetValue(8).ToString();

            txtStock.Text = ds.Tables["tblproduct"].Rows[0].ItemArray.GetValue(9).ToString();

            sCategoryID = int.Parse(ds.Tables["tblproduct"].Rows[0].ItemArray.GetValue(10).ToString());
            sSupplierID = int.Parse(ds.Tables["tblproduct"].Rows[0].ItemArray.GetValue(11).ToString());
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Library ID");
                txtProductCode.Focus();
            }
            else if (txtCategoryName.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Complete Name");
            }
            else if (txtSupplierName.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Complete Name");
            }
            else
            {
                cmdAddProduct.Parameters["@getProductCode"].Value = txtProductCode.Text;
                cmdAddProduct.Parameters["@getProductName"].Value = txtProductName.Text;
                cmdAddProduct.Parameters["@getCategoryId"].Value = sCategoryID;
                cmdAddProduct.Parameters["@getSupplierID"].Value = sSupplierID;
                cmdAddProduct.Parameters["@getUnitPrice"].Value = txtUnitPrice.Text;
                cmdAddProduct.Parameters["@getSellingPrice"].Value = txtSellingPrice.Text;
                cmdAddProduct.Parameters["@Discount"].Value = txtDiskon.Text;
                cmdAddProduct.Parameters["@getStock"].Value = txtStock.Text;
                cmdAddProduct.Parameters["@Tanggal"].Value = DateTime.Now;
                cmdAddProduct.ExecuteNonQuery();

                if (ADD_STATE == false)
                {
                    FormProduct.publicFormProduct.ReloadCurrent();
                    MessageBox.Show("Changes in record has been successfully saved.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    FormProduct.publicFormProduct.LoadProduct("SELECT tblproduct.productcode, tblproduct.productname, tblcategory.categoryname, tblcategory.categorycode, tblsupplier.suppliername, tblsupplier.suppliercode, tblproduct.unitprice, tblproduct.sellingprice, tblproduct.stock FROM tblproduct RIGHT JOIN tblcategory ON tblproduct.categoryautoid = tblcategory.autoid RIGHT JOIN tblsupplier ON tblproduct.supplierautoid = tblsupplier.autoid ORDER BY tblproduct.autoid ASC");
                    MessageBox.Show("Record has been successfully added.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                this.Close();
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FormCategory_View.sFormIndex = "Product";
            FormCategory_View sForm = new FormCategory_View();
            sForm.ShowDialog();
        }

        public void SetCategory(string sCategoryName, string sIndexCategory)
        {
            txtCategoryName.Text = sCategoryName;
            sCategoryID = Convert.ToInt32(sIndexCategory);
        }

        public void SetSupplier(string sSupplierName, string sIndexSupplier)
        {
            txtSupplierName.Text = sSupplierName;
            sSupplierID = Convert.ToInt32(sIndexSupplier);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSupplier_View.sFormIndex = "Product";
            FormSupplier_View sForm = new FormSupplier_View();
            sForm.ShowDialog();
        }
    }
}
