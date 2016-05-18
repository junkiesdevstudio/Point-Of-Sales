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
    public partial class FormSupplier : Form
    {
        clsFunctions sFunctions = new clsFunctions();

        public static FormSupplier publicFormSupplier;

        MySqlDataAdapter daFormSupplierList = new MySqlDataAdapter();
        MySqlCommand cmdDelete;
        DataSet dsFormSupplierList = new DataSet();

        private static FormSupplier sForm = null;
        public static FormSupplier Instance()
        {
            if (sForm == null) { sForm = new FormSupplier(); }

            return sForm;
        }

        public FormSupplier()
        {
            InitializeComponent();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            sFunctions.CreateDirectory("\\@Data\\@Image");

            daFormSupplierList = new MySqlDataAdapter("", clsConnection.CN);

            LoadSupplier("SELECT tblsupplier.suppliercode, tblsupplier.suppliername, tblsupplier.discription, tblsupplier.contactperson, tblsupplier.email, tblsupplier.address, tblsupplier.status FROM tblsupplier ORDER BY tblsupplier.autoid ASC");

            publicFormSupplier = this;
        }

        public void LoadSupplier(string sSQL)
        {
            try
            {
                long totalRow = 0;

                daFormSupplierList.SelectCommand.CommandText = sSQL;

                dsFormSupplierList.Clear();
                daFormSupplierList.Fill(dsFormSupplierList, "tblsupplier");

                totalRow = dsFormSupplierList.Tables["tblsupplier"].Rows.Count - 1;

                lvSupplier.Items.Clear();
                for (int i = 0; i <= totalRow; i++)
                {
                    lvSupplier.Items.Add(new ListViewItem("" + dsFormSupplierList.Tables["tblsupplier"].Rows[i].ItemArray.GetValue(0).ToString(), 22));
                    lvSupplier.Items[i].SubItems.Add("" + dsFormSupplierList.Tables["tblsupplier"].Rows[i].ItemArray.GetValue(1).ToString());
                    lvSupplier.Items[i].SubItems.Add("" + dsFormSupplierList.Tables["tblsupplier"].Rows[i].ItemArray.GetValue(2).ToString());
                    lvSupplier.Items[i].SubItems.Add("" + dsFormSupplierList.Tables["tblsupplier"].Rows[i].ItemArray.GetValue(3).ToString());
                    lvSupplier.Items[i].SubItems.Add("" + dsFormSupplierList.Tables["tblsupplier"].Rows[i].ItemArray.GetValue(4).ToString());
                    lvSupplier.Items[i].SubItems.Add("" + dsFormSupplierList.Tables["tblsupplier"].Rows[i].ItemArray.GetValue(5).ToString());
                    lvSupplier.Items[i].SubItems.Add("" + dsFormSupplierList.Tables["tblsupplier"].Rows[i].ItemArray.GetValue(6).ToString());

                }
                if (lvSupplier.Items.Count > 0)
                {
                    try
                    {
                        lvSupplier.Items[0].Focused = true;
                        lvSupplier.Items[0].Selected = true;
                        lvSupplier.Items[0].EnsureVisible();
                        lvSupplier.Focus();
                    }
                    catch (ArgumentOutOfRangeException aooreE) { }
                    catch (NullReferenceException nreE) { }
                }
            }
            catch (Exception ex) { }
        }

        private void bttnAddNew_Click(object sender, EventArgs e)
        {
            if (clsFunctions.recordExist("SELECT tblusers.usercode, tblusers.usertype FROM tblusers WHERE (tblusers.usertype=1 && tblusers.usercode='" + clsVariables.sUsercode + "') ORDER BY tblusers.autoid ASC", "tblusers") == true)
            {
                FormSupplier_Modify.ADD_STATE = true;
                FormSupplier_Modify sForm = new FormSupplier_Modify();
                sForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Anda perlu hak akses administrator untuk menggunakan fitur ini!", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
