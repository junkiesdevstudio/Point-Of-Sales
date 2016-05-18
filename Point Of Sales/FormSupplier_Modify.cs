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
    public partial class FormSupplier_Modify : Form
    {
        public static bool ADD_STATE;
        public static FormSupplier_Modify publcFormSupplier_Modify;

        public static string sSupplierKode;

        MySqlCommand cmdAddSupplier;

        public FormSupplier_Modify()
        {
            InitializeComponent();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSupplierCode.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Library ID");
                txtSupplierCode.Focus();
            }
            else if (txtSupplierName.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Complete Name");
            }

            else if (txtPhone.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Contact Number");
                txtPhone.Focus();
            }
            else
            {


                cmdAddSupplier.Parameters["@getSupplierCode"].Value = txtSupplierCode.Text;
                cmdAddSupplier.Parameters["@getSupplierName"].Value = txtSupplierName.Text;
                cmdAddSupplier.Parameters["@getDiscription"].Value = txtDiscription.Text;
                cmdAddSupplier.Parameters["@getContactPerson"].Value = txtContactPerson.Text;
                cmdAddSupplier.Parameters["@getBussinesNo"].Value = txtPhone.Text;
                cmdAddSupplier.Parameters["@getEmail"].Value = txtEmail.Text;
                cmdAddSupplier.Parameters["@getAddress"].Value = txtAddress.Text;
                cmdAddSupplier.Parameters["@getStatus"].Value = cmbStatus.Text;
                cmdAddSupplier.Parameters["@getDateAdded"].Value = dtStock.Value;


                cmdAddSupplier.ExecuteNonQuery();

                if (ADD_STATE == false)
                {
                    FormSupplier.publicFormSupplier.ReloadCurrent();
                    MessageBox.Show("Changes in record has been successfully saved.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    FormSupplier.publicFormSupplier.LoadSupplier("SELECT tblsupplier.suppliercode, tblsupplier.suppliername, tblsupplier.discription, tblsupplier.bussinessno, tblsupplier.email, tblsupplier.address, tblsupplier.status FROM tblsupplier ORDER BY tblsupplier.autoid ASC");
                    MessageBox.Show("Record has been successfully added.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                this.Close();
            }
        }

        private void FormSupplier_Modify_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("ACTIVE");
            cmbStatus.Items.Add("INACTIVE");

            if (ADD_STATE == true)
            {
                txtSupplierCode.Text = "SUPP-" + clsFunctions.GenerateCD("SELECT MAX(autoid) FROM tblsupplier", "tblsupplier");

                cmdAddSupplier = new MySqlCommand("INSERT INTO tblsupplier( suppliercode , suppliername, discription, contactperson, bussinessno, email, address, status, dateadded)" +
                                               "VALUES (@getSupplierCode,@getSupplierName,@getDiscription,@getContactPerson,@getBussinesNo,@getEmail,@getAddress,@getStatus,@getDateAdded)", clsConnection.CN);
                this.Text = "Add New";
            }
            else
            {
                txtSupplierCode.ReadOnly = true;

                //Set Edit OleDbCommand
                cmdAddSupplier = new MySqlCommand("UPDATE tblsupplier SET suppliercode=@getSupplierCode, suppliername=@getSupplierName, discription=@getDiscription, contactperson=@getContactPerson, bussinessno=@getBussinesNo, email=@getEmail, address=@getAddress, status=@getStatus, dateadded=@getDateAdded WHERE suppliercode LIKE '" + sSupplierKode + "' ", clsConnection.CN);
                FillFields();
                this.Text = "Edit Existing";
            }

            cmdAddSupplier.Parameters.Add("@getSupplierCode", MySqlDbType.VarChar);
            cmdAddSupplier.Parameters.Add("@getSupplierName", MySqlDbType.VarChar);
            cmdAddSupplier.Parameters.Add("@getDiscription", MySqlDbType.Text);
            cmdAddSupplier.Parameters.Add("@getContactPerson", MySqlDbType.VarChar);
            cmdAddSupplier.Parameters.Add("@getBussinesNo", MySqlDbType.VarChar);
            cmdAddSupplier.Parameters.Add("@getEmail", MySqlDbType.VarChar);
            cmdAddSupplier.Parameters.Add("@getAddress", MySqlDbType.VarChar);
            cmdAddSupplier.Parameters.Add("@getStatus", MySqlDbType.VarChar);
            cmdAddSupplier.Parameters.Add("@getDateAdded", MySqlDbType.Date);

            publcFormSupplier_Modify = this;
        }

        private void FillFields()
        {
            long totalRow = 0;

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT  suppliercode , suppliername, discription, contactperson, bussinessno, email, address, status, dateadded FROM tblsupplier WHERE suppliercode LIKE '" + sSupplierKode + "' ", clsConnection.CN);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblsupplier");

            totalRow = ds.Tables["tblsupplier"].Rows.Count - 1;

            txtSupplierCode.Text = ds.Tables["tblsupplier"].Rows[0].ItemArray.GetValue(0).ToString();
            txtSupplierName.Text = ds.Tables["tblsupplier"].Rows[0].ItemArray.GetValue(1).ToString();
            txtDiscription.Text = ds.Tables["tblsupplier"].Rows[0].ItemArray.GetValue(2).ToString();
            txtContactPerson.Text = ds.Tables["tblsupplier"].Rows[0].ItemArray.GetValue(3).ToString();
            txtPhone.Text = ds.Tables["tblsupplier"].Rows[0].ItemArray.GetValue(4).ToString();
            txtEmail.Text = ds.Tables["tblsupplier"].Rows[0].ItemArray.GetValue(5).ToString();
            txtAddress.Text = ds.Tables["tblsupplier"].Rows[0].ItemArray.GetValue(6).ToString();
            cmbStatus.Text = ds.Tables["tblsupplier"].Rows[0].ItemArray.GetValue(7).ToString();
            dtStock.Text = ds.Tables["tblsupplier"].Rows[0].ItemArray.GetValue(8).ToString();
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
