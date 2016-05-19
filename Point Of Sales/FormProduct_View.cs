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
    public partial class FormProduct_View : Form
    {
        public static FormProduct_View publicFormProduct_View;
        public static string sFormIndex;

        MySqlDataAdapter daProductList = new MySqlDataAdapter();
        DataSet dsProductrList = new DataSet();

        public FormProduct_View()
        {
            InitializeComponent();
        }

        private void FormProduct_View_Load(object sender, EventArgs e)
        {
            daProductList = new MySqlDataAdapter("", clsConnection.CN);
            LoadProduct("SELECT tblproduct.productcode, tblproduct.productname, tblcategory.categoryname, tblcategory.categorycode, tblsupplier.suppliername, tblsupplier.suppliercode, tblproduct.unitprice, tblproduct.sellingprice, tblproduct.stock, tblproduct.autoid FROM tblproduct RIGHT JOIN tblcategory ON tblproduct.categoryautoid = tblcategory.autoid RIGHT JOIN tblsupplier ON tblproduct.supplierautoid = tblsupplier.autoid ORDER BY tblproduct.autoid ASC");
            publicFormProduct_View = this;
        }

        public void LoadProduct(string sSQL)
        {
            try
            {
                long totalRow = 0;

                daProductList.SelectCommand.CommandText = sSQL;

                dsProductrList.Clear();
                daProductList.Fill(dsProductrList, "tblproduct");

                totalRow = dsProductrList.Tables["tblproduct"].Rows.Count - 1;

                lvProduct.Items.Clear();
                for (int i = 0; i <= totalRow; i++)
                {
                    lvProduct.Items.Add(new ListViewItem("" + dsProductrList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(0).ToString(), 22));
                    lvProduct.Items[i].SubItems.Add("" + dsProductrList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(1).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsProductrList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(6).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsProductrList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(8).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsProductrList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(9).ToString());
                }
                if (lvProduct.Items.Count > 0)
                {
                    try
                    {
                        lvProduct.Items[0].Focused = true;
                        lvProduct.Items[0].Selected = true;
                        lvProduct.Items[0].EnsureVisible();
                        lvProduct.Focus();
                    }
                    catch (ArgumentOutOfRangeException aooreE) { }
                    catch (NullReferenceException nreE) { }
                }
            }
            catch (Exception ex) { }
        }

        private void bttnSelect_Click(object sender, EventArgs e)
        {
            if (sFormIndex == "POS")
            {
                FormPOS.publicFormPOS.SetProductPOS("SELECT productcode, productname, unitprice, sellingprice, stock, autoid FROM tblproduct WHERE productcode='" + lvProduct.Items[lvProduct.FocusedItem.Index].SubItems[0].Text + "'");
                //FormPOS.publicFormPOS.SetSupplier(lvProduct.Items[lvProduct.FocusedItem.Index].SubItems[1].Text, lvProduct.Items[lvProduct.FocusedItem.Index].SubItems[2].Text);
            }
            this.Close();
        }
    }
}
