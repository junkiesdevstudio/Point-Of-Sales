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
    public partial class PenjualanDetail : Form
    { 
        public static string sCategoryKode;
        public static bool ADD_STATE;
        CultureInfo culture = new CultureInfo("id-ID");
        clsFunctions sFunctions = new clsFunctions();
        MySqlDataAdapter daFormPenjualanList = new MySqlDataAdapter();
        MySqlCommand cmdDelete;
        DataSet dsFormPenjualanList = new DataSet();

        public static PenjualanDetail publicFormPenjualan;
        private static PenjualanDetail sForm = null;
        public static PenjualanDetail Instance()
        {
            if (sForm == null)
            {
                sForm = new PenjualanDetail();
            }
            return sForm;
        }
        public PenjualanDetail()
        {
            InitializeComponent();
        }

        private void PenjualanDetail_Load(object sender, EventArgs e)
        {
            daFormPenjualanList = new MySqlDataAdapter("", clsConnection.CN);
            LoadSupplier("SELECT tblsales.invoiceno,tblsales.autoid, tblsales.nama_produk, tblsales.unitprice,tblsales.quantity,tblsales.discount,tblsales.subtotal,tblsales.cash,tblsales.changecash,tblsales.dateadded From tblsales where invoiceno='"+ sCategoryKode + "'");
            //PenjualanDetail = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                    label6.Text= dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(0).ToString();
                    lvProduct.Items.Add(new ListViewItem("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(1).ToString(), 22));
                    lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(2).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(3).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(4).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(5).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(6).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(7).ToString());
                    lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(8).ToString());
                    //lvProduct.Items[i].SubItems.Add("" + dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(8).ToString());
                    label7.Text= dsFormPenjualanList.Tables["tblsales"].Rows[i].ItemArray.GetValue(8).ToString();
                    total_pembelian += int.Parse(lvProduct.Items[i].SubItems[5].Text);
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

        private void bttnPrint_Click(object sender, EventArgs e)
        {
            
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
    }
}
