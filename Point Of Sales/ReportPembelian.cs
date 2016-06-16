using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
    public partial class ReportPembelian : Form
    {
        CultureInfo culture = new CultureInfo("id-ID");
        private System.Windows.Forms.Button printButton;
        private Font printFont;
        private StreamReader streamToPrint;

        MySqlDataAdapter daFormPembelian = new MySqlDataAdapter();
        MySqlCommand cmdDelete;
        DataSet daFormPembelianList = new DataSet();

        clsFunctions sFunctions = new clsFunctions();
        public static ReportPembelian publicFormUser;
        private static ReportPembelian sForm = null;
        public static ReportPembelian Instance()
        {
            if (sForm == null)
            {
                sForm = new ReportPembelian();
            }
            return sForm;
        }
        public ReportPembelian()
        {
            InitializeComponent();
        }

        private void ReportPembelian_Load(object sender, EventArgs e)
        {
            daFormPembelian = new MySqlDataAdapter("", clsConnection.CN);
            LoadSupplier("SELECT tblproduct.productcode,tblproduct.productname,tblproduct.unitprice,tblproduct.sellingprice,tblproduct.discount,tblproduct.stock,tblproduct.tanggal FROM tblproduct ORDER BY tblproduct.autoid ASC");
            publicFormUser = this;
        }

        public void LoadSupplier(string sSQL)
        {
            int total_pembelian = 0;
            int total_penjualan = 0;
            int laba = 0;
            long totalRow = 0;
            daFormPembelian.SelectCommand.CommandText = sSQL;
            daFormPembelianList.Clear();
            daFormPembelian.Fill(daFormPembelianList, "tblproduct");
            totalRow = daFormPembelianList.Tables["tblproduct"].Rows.Count;
            lvPembelian.Items.Clear();
            try
            {
                for (int i = 0; i <= totalRow; i++)
                {                  
                    lvPembelian.Items.Add(new ListViewItem("" + daFormPembelianList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(0).ToString(), 22));
                    lvPembelian.Items[i].SubItems.Add("" + daFormPembelianList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(1).ToString());
                    lvPembelian.Items[i].SubItems.Add("" + daFormPembelianList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(2).ToString());
                    lvPembelian.Items[i].SubItems.Add("" + daFormPembelianList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(3).ToString());
                    lvPembelian.Items[i].SubItems.Add("" + daFormPembelianList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(4).ToString());
                    lvPembelian.Items[i].SubItems.Add("" + daFormPembelianList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(5).ToString());
                    lvPembelian.Items[i].SubItems.Add("" + daFormPembelianList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(6).ToString());
                    //lvPembelian.Items[i].SubItems.Add("" + daFormPembelianList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(7).ToString());
                    //lvPembelian.Items[i].SubItems.Add("" + daFormPembelianList.Tables["tblproduct"].Rows[i].ItemArray.GetValue(8).ToString());
                    total_pembelian += int.Parse(lvPembelian.Items[i].SubItems[2].Text);
                    total_penjualan += int.Parse(lvPembelian.Items[i].SubItems[3].Text);
                    laba = total_penjualan - total_pembelian;
                }
                if (lvPembelian.Items.Count > 0)
                {
                    try
                    {
                        lvPembelian.Items[0].Focused = true;
                        lvPembelian.Items[0].Selected = true;
                        lvPembelian.Items[0].EnsureVisible();
                        lvPembelian.Focus();
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
            textBox1.Text = total_pembelian.ToString("C",culture);
            textBox2.Text = total_penjualan.ToString("C", culture);
            textBox3.Text = laba.ToString("C", culture);
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnPrint_Click(object sender, EventArgs e)
        {
            listViewPrinter printer = new listViewPrinter(lvPembelian, new Point(15, 15), false, lvPembelian.Groups.Count > 0, "DATA PEMBELIAN");
            printer.print();
        }
        private void bttnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(txtSearch.Text);
            txtSearch.Focus();
        }

        private void LoadSearch(string sSearch)
        {
            LoadSupplier("SELECT * FROM tblproduct where productname like '%" + sSearch + "%'");
        }

        private void panelBOTTOM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
