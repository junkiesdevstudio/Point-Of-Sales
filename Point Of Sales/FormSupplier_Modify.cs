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

        }
    }
}
