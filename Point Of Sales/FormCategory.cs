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
    public partial class FormCategory : Form
    {
        clsFunctions sFunctions = new clsFunctions();
        public static FormCategory publicFormCategory;
        MySqlDataAdapter daFormCategoryList = new MySqlDataAdapter();
        MySqlCommand cmdDelete;
        DataSet dsFormCategoryList = new DataSet();
        private static FormCategory sForm = null;
        public static FormCategory Instance()
        {
            if (sForm == null) { sForm = new FormCategory(); }
            return sForm;
        }

        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            daFormCategoryList = new MySqlDataAdapter("", clsConnection.CN);
            LoadCategory("SELECT tblcategory.categorycode, tblcategory.categoryname, tblcategory.description FROM tblcategory ORDER BY tblcategory.autoid ASC");
            publicFormCategory = this;
        }

        public void ReloadCurrent()
        {
            try
            {
                int lvw_pos;
                lvw_pos = lvCategory.FocusedItem.Index;
                LoadCategory("SELECT tblcategory.categorycode, tblcategory.categoryname, tblcategory.description FROM tblcategory ORDER BY tblcategory.autoid ASC");

                if (lvCategory.Items.Count != 0 && lvCategory.Items.Count - 1 >= lvw_pos)
                {
                    lvCategory.Items[lvCategory.FocusedItem.Index].Selected = false;
                    lvCategory.Items[lvCategory.FocusedItem.Index].Focused = false;

                    lvCategory.Items[lvw_pos].Focused = true;
                    lvCategory.Items[lvw_pos].Selected = true;
                    lvCategory.Items[lvw_pos].EnsureVisible();
                }
                lvw_pos = 0;

            }
            catch (ArgumentOutOfRangeException aooreE) { }
            catch (NullReferenceException nreE) { }
            catch (IOException ioeE) { MessageBox.Show("Error: " + ioeE.Source + ": " + ioeE.Message, clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void LoadCategory(string sSQL)
        {
            try
            {
                long totalRow = 0;
                daFormCategoryList.SelectCommand.CommandText = sSQL;
                dsFormCategoryList.Clear();
                daFormCategoryList.Fill(dsFormCategoryList, "tblcategory");
                totalRow = dsFormCategoryList.Tables["tblcategory"].Rows.Count - 1;
                lvCategory.Items.Clear();
                for (int i = 0; i <= totalRow; i++)
                {
                    lvCategory.Items.Add(new ListViewItem("" + dsFormCategoryList.Tables["tblcategory"].Rows[i].ItemArray.GetValue(0).ToString(), 22));
                    lvCategory.Items[i].SubItems.Add("" + dsFormCategoryList.Tables["tblcategory"].Rows[i].ItemArray.GetValue(1).ToString());
                    lvCategory.Items[i].SubItems.Add("" + dsFormCategoryList.Tables["tblcategory"].Rows[i].ItemArray.GetValue(2).ToString());

                }
                if (lvCategory.Items.Count > 0)
                {
                    try
                    {
                        lvCategory.Items[0].Focused = true;
                        lvCategory.Items[0].Selected = true;
                        lvCategory.Items[0].EnsureVisible();
                        lvCategory.Focus();
                    }
                    catch (ArgumentOutOfRangeException aooreE) { }
                    catch (NullReferenceException nreE) {}
                }
            }
            catch (Exception ex) {}
        }

        private void bttnAddNew_Click(object sender, EventArgs e)
        {
            if (clsFunctions.recordExist("SELECT tblusers.usercode, tblusers.usertype FROM tblusers WHERE (tblusers.usertype=1 && tblusers.usercode='" + clsVariables.sUsercode + "') ORDER BY tblusers.autoid ASC", "tblusers") == true)
            {
                FormCategory_Modify.ADD_STATE = true;
                FormCategory_Modify sForm = new FormCategory_Modify();
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
                if (lvCategory.Items.Count > 0)
                {
                    try
                    {
                        FormCategory_Modify.ADD_STATE = false;
                        FormCategory_Modify.sCategoryKode = lvCategory.Items[lvCategory.FocusedItem.Index].SubItems[0].Text;
                        FormCategory_Modify sForm = new FormCategory_Modify();
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

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (clsFunctions.recordExist("SELECT tblusers.usercode, tblusers.usertype FROM tblusers WHERE (tblusers.usertype=1 && tblusers.usercode='" + clsVariables.sUsercode + "') ORDER BY tblusers.autoid ASC", "tblusers") == true)
            {
                if (lvCategory.Items.Count > 0)
                {
                    if (MessageBox.Show("Proses ini akan menghapus data secara permanen. Anda yakin ingin melanjutkan?", clsVariables.sMSGBOX, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        try
                        {
                       
                            try
                            {
                                sFunctions.setOleDbCommand(cmdDelete, "DELETE FROM tblcategory WHERE categorycode = @getCategoryCode", "@getCategoryCode", lvCategory.Items[lvCategory.FocusedItem.Index].SubItems[0].Text);

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

        private void bttnReload_Click(object sender, EventArgs e)
        {
            LoadCategory("SELECT tblcategory.categorycode, tblcategory.categoryname, tblcategory.description FROM tblcategory ORDER BY tblcategory.autoid ASC");
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSearch(string sSearch)
        {
            LoadCategory("SELECT tblcategory.categorycode, tblcategory.categoryname, tblcategory.description FROM tblcategory WHERE categorycode LIKE '%" + sSearch + "%' OR categoryname LIKE '%" + sSearch + "%' ORDER BY tblcategory.autoid ASC");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(txtSearch.Text);
            txtSearch.Focus();
        }

        private void bttnPrint_Click(object sender, EventArgs e)
        {
            //listViewPrinter printer = new listViewPrinter(lvCategory, new Point(10, 10), checkBox1.Checked, lvCategory.Groups.Count > 0, "REKAP SUPPLIER");
            listViewPrinter printer = new listViewPrinter(lvCategory, new Point(55, 55),false, lvCategory.Groups.Count > 0, "DATA KATEGORI");
            printer.print();
        }
    }
}
