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
    public partial class FormMember_Modify : Form
    {
        public static bool ADD_STATE;
        public static FormMember_Modify publcFormMember_Modify;
        public static string sMemberKode;

        string imgPath = "";
        string imgName = "";

        MySqlCommand cmdAddMembers;

        public FormMember_Modify()
        {
            InitializeComponent();
        }

        private void FormMember_Modify_Load(object sender, EventArgs e)
        {
            FillComboDiscount();

            if (ADD_STATE == true)
            {
                txtMemberKode.Text = "" + clsFunctions.GenerateCD("SELECT MAX(autoid) FROM tblmember", "tblmember");

                cmdAddMembers = new MySqlCommand("INSERT INTO tblmember( membercode , fullname, address, telephone, status, discount)" +
                                               "VALUES (@getMemberCode,@getMemberName,@getAddress,@getTelephone,@getStatus,@getDiscount)", clsConnection.CN);
                this.Text = "Add New";
            }
            else
            {


                txtMemberKode.ReadOnly = true;

                //Set Edit OleDbCommand
                cmdAddMembers = new MySqlCommand("UPDATE tblmember SET membercode=@getMemberCode, fullname=@getMemberName, address=@getAddress, telephone=@getTelephone, status=@getStatus, discount=@getDiscount WHERE membercode LIKE '" + sMemberKode + "' ", clsConnection.CN);
                FillFields();
                this.Text = "Edit Existing";
            }

            cmdAddMembers.Parameters.Add("@getMemberCode", MySqlDbType.VarChar);
            cmdAddMembers.Parameters.Add("@getMemberName", MySqlDbType.VarChar);
            cmdAddMembers.Parameters.Add("@getAddress", MySqlDbType.Text);
            cmdAddMembers.Parameters.Add("@getTelephone", MySqlDbType.VarChar);
            cmdAddMembers.Parameters.Add("@getStatus", MySqlDbType.VarChar);
            cmdAddMembers.Parameters.Add("@getDiscount", MySqlDbType.Decimal);

            



            publcFormMember_Modify = this;
        }

        private void FillComboDiscount()
        {
            Dictionary<string, string> m_CodeDiscount = new Dictionary<string, string>();
            long totalRow = 0;

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tbldiscount", clsConnection.CN);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbldiscount");

            totalRow = ds.Tables["tbldiscount"].Rows.Count - 1;

            for(int x=0; x <= totalRow; x++)
            {
                m_CodeDiscount.Add(ds.Tables["tbldiscount"].Rows[x].ItemArray.GetValue(0).ToString(), ds.Tables["tbldiscount"].Rows[x].ItemArray.GetValue(1).ToString());       
            }

            cmbDiscount.DataSource = new BindingSource(m_CodeDiscount, null);
            cmbDiscount.DisplayMember = "Value";

        }

        private void FillFields()
        {
            long totalRow = 0;

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT tblmember.membercode, tblmember.fullname, tblmember.address, tblmember.telephone, tblmember.status, tblmember.discount, tbldiscount.percent FROM tbldiscount RIGHT JOIN tblmember ON tbldiscount.autoid = tblmember.discount WHERE tblmember.membercode LIKE '" + sMemberKode + "' ", clsConnection.CN);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblmember");

            totalRow = ds.Tables["tblmember"].Rows.Count - 1;

            txtMemberKode.Text = ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(0).ToString();
            txtFirstName.Text = ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(1).ToString();
            txtStreetAddress.Text = ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(2).ToString();
            txtContactNo.Text = ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(3).ToString();


            cmbStatus.Text = ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(4).ToString();
            //cmbDiscount.SelectedItem = cmbDiscount.Items.OfType<KeyValuePair<string, string>>().ToList().FirstOrDefault(i => i.Key == ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(6).ToString());

            SelectByKey(ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(5).ToString());

            //MessageBox.Show(ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(5).ToString());
        }

        void SelectByKey(string key)
        {
            foreach (var item in cmbDiscount.Items)
                if (((KeyValuePair<string, string>)item).Key == key)
                {
                    cmbDiscount.SelectedItem = item;
                    break;
                }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMemberKode.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Library ID");
                txtMemberKode.Focus();
            }
            else if (txtFirstName.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Complete Name");
            }

            else if (txtContactNo.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Contact Number");
                txtContactNo.Focus();
            }
            else
            {
                cmdAddMembers.Parameters["@getMemberCode"].Value = txtMemberKode.Text;
                cmdAddMembers.Parameters["@getMemberName"].Value = txtFirstName.Text;
                cmdAddMembers.Parameters["@getAddress"].Value = txtStreetAddress.Text;
                cmdAddMembers.Parameters["@getTelephone"].Value = txtContactNo.Text;

                string key = ((KeyValuePair<string, string>)cmbDiscount.SelectedItem).Key;
                cmdAddMembers.Parameters["@getDiscount"].Value = key;
                cmdAddMembers.Parameters["@getStatus"].Value = cmbStatus.Text;

                /* BELUM BENAR */
                //cmdAddMembers.Parameters["@getDiscount"].Value = txtContactNo.Text;

                cmdAddMembers.ExecuteNonQuery();

                if (ADD_STATE == false)
                {
                    FormMember.publicFormMember.ReloadCurrent();
                    MessageBox.Show("Changes in record has been successfully saved.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FormMember.publicFormMember.LoadMember("SELECT tblmember.membercode, tblmember.fullname, tblmember.address, tblmember.telephone, tblmember.status, tblmember.discount, tbldiscount.percent  FROM tbldiscount RIGHT JOIN tblmember ON tbldiscount.autoid = tblmember.discount ORDER BY tblmember.autoid ASC");
                    MessageBox.Show("Record has been successfully added.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            
        }
    }
}
