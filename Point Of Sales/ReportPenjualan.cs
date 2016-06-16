using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1;
using System.Globalization;

namespace Point_Of_Sales
{
    public partial class ReportPenjualan : Form
    {
        CultureInfo culture = new CultureInfo("id-ID");
        clsFunctions sFunctions = new clsFunctions();
        MySqlDataAdapter daFormPenjualanList = new MySqlDataAdapter();
        MySqlCommand cmdDelete;
        DataSet dsFormPenjualanList = new DataSet();

        public static ReportPenjualan publicFormPenjualan;
        private static ReportPenjualan sForm = null;
        public static ReportPenjualan Instance()
        {
            if (sForm == null)
            {
                sForm = new ReportPenjualan();
            }
            return sForm;
        }
        public ReportPenjualan()
        {
            InitializeComponent();
        }

        private void ReportPenjualan_Load(object sender, EventArgs e)
        {
            daFormPenjualanList = new MySqlDataAdapter("", clsConnection.CN);
            LoadSupplier("SELECT tblsales.invoiceno,tblsales.subtotal,tblsales.cash,tblsales.changecash,tblsales.dateadded From tblsales GROUP BY invoiceno HAVING COUNT(*) >= 1");
            publicFormPenjualan = this;
        }

        public void LoadSupplier(string sSQL)
        {
            int total_pembelian = 0;
            long totalRow = 0;
            daFormPenjualanList.SelectCommand.CommandText = sSQL;
            dsFormPenjualanList.Clear();
            daFormPenjualanList.Fill(dsFormPenjualanList, "tblsales");
            totalRow = dsFormPenjualanList.Tables["tblsales"].Rows.Count;
            lvProduct.Items.Clear();
            try
            {
                for (int i = 0; i <= totalRow; i++)
                {
                    lvProduct.Items.Add(new ListViewItem("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(0).ToString(), 22));
                    lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(1).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(2).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(3).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(4).ToString());
                    total_pembelian += int.Parse(lvProduct.Items[i].SubItems[1].Text);
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
                    catch (ArgumentOutOfRangeException aooreE)
                    {

                    }
                    catch (NullReferenceException nreE)
                    {

                    }
                }
            }
            catch (Exception ex)
            {

            }
            textBox1.Text = total_pembelian.ToString("C", culture);
        }


        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnPrint_Click(object sender, EventArgs e)
        {
            listViewPrinter printer = new listViewPrinter(lvProduct, new Point(55, 55), false, lvProduct.Groups.Count > 0, "DATA PENJUALAN");
            printer.print();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(txtSearch.Text);
            txtSearch.Focus();
        }

        private void LoadSearch(string sSearch)
        {
            LoadSupplier("SELECT * FROM tblsales where nama_produk like '%" + sSearch + "%'");
        }

        private void bttnReload_Click(object sender, EventArgs e)
        {
            LoadSupplier("SELECT * FROM tblsales ORDER BY tblsales.autoid ASC");
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (lvProduct.Items.Count > 0)
            {
                if (MessageBox.Show("Proses ini akan menghapus data secara permanen. Anda yakin ingin melanjutkan?", clsVariables.sMSGBOX, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    try
                    {
                        try
                        {
                            sFunctions.setOleDbCommand(cmdDelete, "DELETE FROM tblsales WHERE autoid = @autoid", "@autoid", lvProduct.Items[lvProduct.FocusedItem.Index].SubItems[0].Text);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message, clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    catch (ArgumentOutOfRangeException aooreE) { }
                    catch (NullReferenceException nreE) { }
                    catch (IOException ioeE) { MessageBox.Show("Error: " + ioeE.Source + ": " + ioeE.Message, clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                LoadSupplier("SELECT * FROM tblsales ORDER BY tblsales.autoid ASC");
            }
            else { MessageBox.Show("No record to delete.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PenjualanDetail.ADD_STATE = false;
            PenjualanDetail.sCategoryKode = lvProduct.Items[lvProduct.FocusedItem.Index].SubItems[0].Text;
            PenjualanDetail sForm = new PenjualanDetail();
            sForm.ShowDialog();
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lvProduct_DoubleClick(object sender, EventArgs e)
        {
            PenjualanDetail.ADD_STATE = false;
            PenjualanDetail.sCategoryKode = lvProduct.Items[lvProduct.FocusedItem.Index].SubItems[0].Text;
            PenjualanDetail sForm = new PenjualanDetail();
            sForm.ShowDialog();
        }
    }
}

