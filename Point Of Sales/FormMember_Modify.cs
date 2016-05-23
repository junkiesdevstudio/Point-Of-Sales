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
            if (ADD_STATE == true)
            {
                txtUserKode.Text = "" + clsFunctions.GenerateCD("SELECT MAX(autoid) FROM tblmember", "tblmember");

                cmdAddMembers = new MySqlCommand("INSERT INTO tblmember( membercode , fullname, address, telephone, status, discount)" +
                                               "VALUES (@getMemberCode,@getMemberName,@getAddress,@getTelephone,@getStatus,@getDiscount)", clsConnection.CN);
                this.Text = "Add New";
            }
            else
            {


                txtUserKode.ReadOnly = true;

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

            FillComboDiscount();

            publcFormMember_Modify = this;
        }

        private void FillComboDiscount()
        {
            Dictionary<string, string> m_CodeDiscount = new Dictionary<string, string>();
            long totalRow = 0;

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tbldiscount", clsConnection.CN);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbldiscount");

            totalRow = ds.Tables["tblmember"].Rows.Count - 1;
        }

        private void FillFields()
        {
            long totalRow = 0;

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT tblmember.membercode, tblmember.fullname, tblmember.address, tblmember.telephone, tblmember.status, tblmember.discount, tbldiscount.percent FROM tbldiscount RIGHT JOIN tblmember ON tbldiscount.autoid = tblmember.discount WHERE tblmember.membercode LIKE '" + sMemberKode + "' ", clsConnection.CN);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblmember");

            totalRow = ds.Tables["tblmember"].Rows.Count - 1;

            txtUserKode.Text = ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(0).ToString();
            txtFirstName.Text = ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(1).ToString();
            txtStreetAddress.Text = ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(2).ToString();
            txtContactNo.Text = ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(3).ToString();

            cmbStatus.Text = ds.Tables["tblmember"].Rows[0].ItemArray.GetValue(4).ToString();

        }
    }
}
