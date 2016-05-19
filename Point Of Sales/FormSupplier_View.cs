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
    public partial class FormSupplier_View : Form
    {
        public static FormSupplier_View publicSupList;
        public static string sFormIndex;

        MySqlDataAdapter daSupplierList = new MySqlDataAdapter();
        DataSet dsSupplierList = new DataSet();

        public FormSupplier_View()
        {
            InitializeComponent();
        }

        private void FormSupplier_View_Load(object sender, EventArgs e)
        {
            daSupplierList = new MySqlDataAdapter("", clsConnection.CN);
            LoadSupplier();
            publicSupList = this;
        }

        public void LoadSupplier()
        {
            long totalRow = 0;
            daSupplierList.SelectCommand.CommandText = "SELECT suppliercode, suppliername, autoid FROM tblsupplier ORDER BY autoid ASC";

            dsSupplierList.Clear();
            daSupplierList.Fill(dsSupplierList, "tblsupplier");

            totalRow = dsSupplierList.Tables["tblsupplier"].Rows.Count - 1;

            listView1.Items.Clear();
            for (int i = 0; i <= totalRow; i++)
            {
                listView1.Items.Add(new ListViewItem("" + dsSupplierList.Tables["tblsupplier"].Rows[i].ItemArray.GetValue(0).ToString(), 15));
                listView1.Items[i].SubItems.Add("" + dsSupplierList.Tables["tblsupplier"].Rows[i].ItemArray.GetValue(1).ToString());
                listView1.Items[i].SubItems.Add("" + dsSupplierList.Tables["tblsupplier"].Rows[i].ItemArray.GetValue(2).ToString());
            }
            if (listView1.Items.Count > 0)
            {
                try
                {
                    listView1.Items[0].Focused = true;
                    listView1.Items[0].Selected = true;
                    listView1.Items[0].EnsureVisible();
                    listView1.Focus();
                }
                catch (ArgumentOutOfRangeException aooreE) { }
                catch (NullReferenceException nreE) { }
            }
        }

        private void bttnSelect_Click(object sender, EventArgs e)
        {
            if (sFormIndex == "Product")
            {
                FormProduct_Modify.publcFormProduct_Modify.SetSupplier(listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text, listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text);
            }
            this.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            bttnSelect_Click(sender, e);
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
