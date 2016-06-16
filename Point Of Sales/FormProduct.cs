using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Point_Of_Sales
{
    public partial class FormProduct : Form
    {
        clsFunctions sFunctions = new clsFunctions();
        public static FormProduct publicFormProduct;
        MySqlDataAdapter daFormProductList = new MySqlDataAdapter();
        MySqlCommand cmdDelete;
        DataSet dsFormProductList = new DataSet();

        private static FormProduct sForm = null;
        public static FormProduct Instance()
        {
            if (sForm == null) { sForm = new FormProduct(); }

            return sForm;
        }

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            daFormProductList = new MySqlDataAdapter("", clsConnection.CN);
            LoadProduct("SELECT tblproduct.productcode, tblproduct.productname, tblcategory.categoryname, tblcategory.categorycode, tblsupplier.suppliername, tblsupplier.suppliercode, tblproduct.unitprice, tblproduct.sellingprice,tblproduct.discount, tblproduct.stock,tblproduct.tanggal FROM tblproduct RIGHT JOIN tblcategory ON tblproduct.categoryautoid = tblcategory.autoid RIGHT JOIN tblsupplier ON tblproduct.supplierautoid = tblsupplier.autoid ORDER BY tblproduct.autoid ASC");
            publicFormProduct = this;
        }

        public void LoadProduct(string sSQL)
        {
            try
            {
                long totalRow = 0;
                daFormProductList.SelectCommand.CommandText = sSQL;
                dsFormProductList.Clear();
                daFormProductList.Fill(dsFormProductList, "tblproduct");
                totalRow = dsFormProductList.Tables["tblproduct"].Rows.Count - 1;
                lvProduct.Items.Clear();
                for (int i = 0; i <= totalRow; i++)
                {
                    lvProduct.Items.Add(new ListViewItem("" + dsFormProductList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(0).ToString(), 22));
                    lvProduct.Items[i].SubItems.Add("" + dsFormProductList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(1).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormProductList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(2).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormProductList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(4).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormProductList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(9).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormProductList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(6).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormProductList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(7).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormProductList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(8).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormProductList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(10).ToString());
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

        public void ReloadCurrent()
        {
            try
            {
                int lvw_pos;
                lvw_pos = lvProduct.FocusedItem.Index;
                LoadProduct("SELECT tblproduct.productcode, tblproduct.productname, tblcategory.categoryname, tblcategory.categorycode, tblsupplier.suppliername, tblsupplier.suppliercode, tblproduct.unitprice, tblproduct.sellingprice,tblproduct.discount, tblproduct.stock,tblproduct.tanggal FROM tblproduct RIGHT JOIN tblcategory ON tblproduct.categoryautoid = tblcategory.autoid RIGHT JOIN tblsupplier ON tblproduct.supplierautoid = tblsupplier.autoid ORDER BY tblproduct.autoid ASC");
                if (lvProduct.Items.Count != 0 && lvProduct.Items.Count - 1 >= lvw_pos)
                {
                    lvProduct.Items[lvProduct.FocusedItem.Index].Selected = false;
                    lvProduct.Items[lvProduct.FocusedItem.Index].Focused = false;
                    lvProduct.Items[lvw_pos].Focused = true;
                    lvProduct.Items[lvw_pos].Selected = true;
                    lvProduct.Items[lvw_pos].EnsureVisible();
                }
                lvw_pos = 0;
            }
            catch (ArgumentOutOfRangeException aooreE) { }
            catch (NullReferenceException nreE) { }
            catch (IOException ioeE) { MessageBox.Show("Error: " + ioeE.Source + ": " + ioeE.Message, clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnReload_Click(object sender, EventArgs e)
        {
            LoadProduct("SELECT tblproduct.productcode, tblproduct.productname, tblcategory.categoryname, tblcategory.categorycode, tblsupplier.suppliername, tblsupplier.suppliercode, tblproduct.unitprice, tblproduct.sellingprice, tblproduct.stock,tblproduct.tanggal FROM tblproduct RIGHT JOIN tblcategory ON tblproduct.categoryautoid = tblcategory.autoid RIGHT JOIN tblsupplier ON tblproduct.supplierautoid = tblsupplier.autoid ORDER BY tblproduct.autoid ASC");
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (clsFunctions.recordExist("SELECT tblusers.usercode, tblusers.usertype FROM tblusers WHERE (tblusers.usertype=1 && tblusers.usercode='" + clsVariables.sUsercode + "') ORDER BY tblusers.autoid ASC", "tblusers") == true)
            {
                if (lvProduct.Items.Count > 0)
                {
                    if (MessageBox.Show("Proses ini akan menghapus data secara permanen. Anda yakin ingin melanjutkan?", clsVariables.sMSGBOX, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        try
                        {                          
                            try
                            {
                                sFunctions.setOleDbCommand(cmdDelete, "DELETE FROM tblproduct WHERE productcode = @getProductCode", "@getProductCode", lvProduct.Items[lvProduct.FocusedItem.Index].SubItems[0].Text);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message, clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            ReloadCurrent();
                        }
                        catch (ArgumentOutOfRangeException aooreE) { }
                        catch (NullReferenceException nreE) { }
                        catch (IOException ioeE) { MessageBox.Show("Error: " + ioeE.Source + ": " + ioeE.Message, clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
                else { MessageBox.Show("No record to delete.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else
            {
                MessageBox.Show("Anda perlu hak akses administrator untuk menggunakan fitur ini!", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSearch(string sSearch)
        {
            LoadProduct("SELECT tblproduct.productcode, tblproduct.productname, tblcategory.categoryname, tblcategory.categorycode, tblsupplier.suppliername, tblsupplier.suppliercode, tblproduct.unitprice, tblproduct.sellingprice, tblproduct.stock,tblproduct.tanggal FROM tblproduct RIGHT JOIN tblcategory ON tblproduct.categoryautoid = tblcategory.autoid RIGHT JOIN tblsupplier ON tblproduct.supplierautoid = tblsupplier.autoid " +
                        "WHERE tblproduct.productcode LIKE '%" + sSearch + "%' OR tblproduct.productname LIKE '%" + sSearch + "%' OR tblcategory.categoryname LIKE '%" + sSearch + "%' OR tblsupplier.suppliername LIKE '%" + sSearch + "%' ORDER BY tblproduct.autoid ASC");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(txtSearch.Text);
            txtSearch.Focus();
        }

        private void bttnAddNew_Click(object sender, EventArgs e)
        {
            if (clsFunctions.recordExist("SELECT tblusers.usercode, tblusers.usertype FROM tblusers WHERE (tblusers.usertype=1 && tblusers.usercode='" + clsVariables.sUsercode + "') ORDER BY tblusers.autoid ASC", "tblusers") == true)
            {
                FormProduct_Modify.ADD_STATE = true;
                FormProduct_Modify sForm = new FormProduct_Modify();
                sForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Anda perlu hak akses administrator untuk menggunakan fitur ini!", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnModify_Click(object sender, EventArgs e)
        {
            if (clsFunctions.recordExist("SELECT tblusers.usercode, tblusers.usertype FROM tblusers WHERE (tblusers.usertype=1 && tblusers.usercode='" + clsVariables.sUsercode + "') ORDER BY tblusers.autoid ASC", "tblusers") == true)
            {
                if (lvProduct.Items.Count > 0)
                {
                    try
                    {
                        FormProduct_Modify.ADD_STATE = false;
                        FormProduct_Modify.sProductKode = lvProduct.Items[lvProduct.FocusedItem.Index].SubItems[0].Text;
                        FormProduct_Modify sForm = new FormProduct_Modify();
                        sForm.ShowDialog();
                    }
                    catch (ArgumentOutOfRangeException aooreE) { MessageBox.Show("" + aooreE.Message); }
                    catch (NullReferenceException nreE) { }
                }
                else { MessageBox.Show("No record to edit.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else
            {
                MessageBox.Show("Anda perlu hak akses administrator untuk menggunakan fitur ini!", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnPrint_Click(object sender, EventArgs e)
        {           
            listViewPrinter printer = new listViewPrinter(lvProduct, new Point(25, 25), false, lvProduct.Groups.Count > 0, "DATA PRODUK");
            printer.print();
        }
    }
}
