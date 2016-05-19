using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Point_Of_Sales
{
    public partial class FormCategory_View : Form
    {
        public static FormCategory_View publicCatList;
        public static string sFormIndex;

        MySqlDataAdapter daCategoryList = new MySqlDataAdapter();
        DataSet dsCategoryList = new DataSet();

        public FormCategory_View()
        {
            InitializeComponent();
        }

        private void FormCategory_View_Load(object sender, EventArgs e)
        {
            daCategoryList = new MySqlDataAdapter("", clsConnection.CN);
            LoadCategory();
            publicCatList = this;
        }

        public void LoadCategory()
        {
            long totalRow = 0;
            daCategoryList.SelectCommand.CommandText = "SELECT categorycode, categoryname, autoid FROM tblcategory ORDER BY autoid ASC";

            dsCategoryList.Clear();
            daCategoryList.Fill(dsCategoryList, "tblcategory");

            totalRow = dsCategoryList.Tables["tblcategory"].Rows.Count - 1;

            listView1.Items.Clear();
            for (int i = 0; i <= totalRow; i++)
            {
                listView1.Items.Add(new ListViewItem("" + dsCategoryList.Tables["tblcategory"].Rows[i].ItemArray.GetValue(0).ToString(), 15));
                listView1.Items[i].SubItems.Add("" + dsCategoryList.Tables["tblcategory"].Rows[i].ItemArray.GetValue(1).ToString());
                listView1.Items[i].SubItems.Add("" + dsCategoryList.Tables["tblcategory"].Rows[i].ItemArray.GetValue(2).ToString());
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
                FormProduct_Modify.publcFormProduct_Modify.SetCategory(listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text, listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text);
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
