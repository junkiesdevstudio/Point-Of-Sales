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
    public partial class FormCategory_Modify : Form
    {
        public static bool ADD_STATE;
        public static FormCategory_Modify publcFormCategory_Modify;
        public static string sCategoryKode;
        MySqlCommand cmdAddCategory;
        public FormCategory_Modify()
        {
            InitializeComponent();
        }

        private void FormCategory_Modify_Load(object sender, EventArgs e)
        {
            if (ADD_STATE == true)
            {
                txtCategoryCode.Text = "CAT-" + clsFunctions.GenerateCD("SELECT MAX(autoid) FROM tblcategory", "tblcategory");
                cmdAddCategory = new MySqlCommand("INSERT INTO tblcategory( categorycode , categoryname, description, dateadded, addedby)" +
                                               "VALUES (@getCategoryCode,@getCategoryName,@getDescription,@getDateAdded,@getAddedBy)", clsConnection.CN);
                this.Text = "Add New";
            }
            else
            {
                txtCategoryCode.ReadOnly = true;

                //Set Edit OleDbCommand
                cmdAddCategory = new MySqlCommand("UPDATE tblcategory SET categorycode=@getCategoryCode, categoryname=@getCategoryName, description=@getDescription, dateadded=@getDateAdded, addedby=@getAddedBy WHERE categorycode LIKE '" + sCategoryKode + "' ", clsConnection.CN);
                FillFields();
                this.Text = "Edit Existing";
            }

            cmdAddCategory.Parameters.Add("@getCategoryCode", MySqlDbType.VarChar);
            cmdAddCategory.Parameters.Add("@getCategoryName", MySqlDbType.VarChar);
            cmdAddCategory.Parameters.Add("@getDescription", MySqlDbType.Text);
            cmdAddCategory.Parameters.Add("@getDateAdded", MySqlDbType.Date);
            cmdAddCategory.Parameters.Add("@getAddedBy", MySqlDbType.Int16);
            publcFormCategory_Modify = this;
        }

        private void FillFields()
        {
            long totalRow = 0;
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT  categorycode , categoryname, description FROM tblcategory WHERE categorycode LIKE '" + sCategoryKode + "' ", clsConnection.CN);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblcategory");
            totalRow = ds.Tables["tblcategory"].Rows.Count - 1;
            txtCategoryCode.Text = ds.Tables["tblcategory"].Rows[0].ItemArray.GetValue(0).ToString();
            txtCategoryName.Text = ds.Tables["tblcategory"].Rows[0].ItemArray.GetValue(1).ToString();
            txtDescription.Text = ds.Tables["tblcategory"].Rows[0].ItemArray.GetValue(2).ToString();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCategoryCode.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Library ID");
                txtCategoryCode.Focus();
            }
            else if (txtCategoryName.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Complete Name");
            }
            else
            {
                cmdAddCategory.Parameters["@getCategoryCode"].Value = txtCategoryCode.Text;
                cmdAddCategory.Parameters["@getCategoryName"].Value = txtCategoryName.Text;
                cmdAddCategory.Parameters["@getDescription"].Value = txtDescription.Text;
                cmdAddCategory.Parameters["@getDateAdded"].Value = DateTime.Now;
                cmdAddCategory.Parameters["@getAddedBy"].Value = 1;
                cmdAddCategory.ExecuteNonQuery();
                if (ADD_STATE == false)
                {
                    FormCategory.publicFormCategory.ReloadCurrent();
                    MessageBox.Show("Changes in record has been successfully saved.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FormCategory.publicFormCategory.LoadCategory("SELECT tblcategory.categorycode, tblcategory.categoryname, tblcategory.description FROM tblcategory ORDER BY tblcategory.autoid ASC");
                    MessageBox.Show("Record has been successfully added.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }
    }
}
