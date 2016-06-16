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
using MySql.Data.MySqlClient;

namespace Point_Of_Sales
{
    public partial class FormUser_Modify : Form
    {
        public static bool ADD_STATE;
        public static FormUser_Modify publcFormUser_Modify;
        public static string sUserKode;

        string imgPath = "";
        string imgName = "";

        MySqlCommand cmdAddUsers;

        public FormUser_Modify()
        {
            InitializeComponent();
        }

        private void FormUser_Modify_Load(object sender, EventArgs e)
        {         
            if (ADD_STATE == true)
            {
                txtUserKode.Text = "USR-" + clsFunctions.GenerateCD("SELECT MAX(autoid) FROM tblusers", "tblusers");
                txtUserID.Text = txtUserKode.Text;
                cmdAddUsers = new MySqlCommand("INSERT INTO tblusers( usercode , fullname, address, email, telephone, usertype, status, username, password, datemodify, usermodifyby, dateadded, useraddedby)" + 
                                               "VALUES (@getUsercode,@getFullname,@getAddress,@getEmail,@getTelephone,@getUsertype,@getStatus,@getUsername,@getPassword,@getDatemodify,@getUsermodifyby, @getDateadded, @getUseraddedby)", clsConnection.CN);
                this.Text = "Add New";
            }
            else
            {

                try
                {
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\@Data\\@Image\\" + sUserKode + ".lms") == true)
                    { picLibrarian.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\@Data\\@Image\\" + sUserKode + ".lms", true); }
                }
                catch (Exception ex) { }

                txtUserKode.ReadOnly = true;

                //Set Edit OleDbCommand
                cmdAddUsers = new MySqlCommand("UPDATE tblusers SET usercode=@getUsercode, fullname=@getFullname, address=@getAddress, email=@getEmail, telephone=@getTelephone, usertype=@getUsertype, status=@getStatus, username=@getUsername, password=@getPassword, datemodify=@getDatemodify, usermodifyby=@getUsermodifyby WHERE usercode LIKE '" + sUserKode + "' ", clsConnection.CN);
                FillFields();
                this.Text = "Edit Existing";
            }

            cmdAddUsers.Parameters.Add("@getUsercode", MySqlDbType.VarChar);
            cmdAddUsers.Parameters.Add("@getFullname", MySqlDbType.VarChar);
            cmdAddUsers.Parameters.Add("@getAddress", MySqlDbType.Text);
            cmdAddUsers.Parameters.Add("@getEmail", MySqlDbType.VarChar);
            cmdAddUsers.Parameters.Add("@getTelephone", MySqlDbType.VarChar);
            cmdAddUsers.Parameters.Add("@getUsertype", MySqlDbType.Int16);
            cmdAddUsers.Parameters.Add("@getStatus", MySqlDbType.VarChar);
            cmdAddUsers.Parameters.Add("@getUsername", MySqlDbType.VarChar);
            cmdAddUsers.Parameters.Add("@getPassword", MySqlDbType.VarChar);
            cmdAddUsers.Parameters.Add("@getDatemodify", MySqlDbType.Date);
            cmdAddUsers.Parameters.Add("@getUsermodifyby", MySqlDbType.Int16);
            cmdAddUsers.Parameters.Add("@getDateadded", MySqlDbType.Date);
            cmdAddUsers.Parameters.Add("@getUseraddedby", MySqlDbType.Int16);

            publcFormUser_Modify = this;
        }

        private void FillFields()
        {
            long totalRow = 0;

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT tblusers.usercode,  tblusers.fullname,  tblusers.address,  tblusers.email, tblusers.status, tblusers.usertype, tblusers.username, tblusers.password, tblusertype.autoid, tblusertype.typename, tblusers.status,  tblusers.telephone FROM tblusertype RIGHT JOIN tblusers ON tblusertype.autoid = tblusers.usertype WHERE tblusers.usercode LIKE '" + sUserKode + "' ", clsConnection.CN);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblusers");

            totalRow = ds.Tables["tblusers"].Rows.Count - 1;

            txtUserKode.Text = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(0).ToString();
            txtFirstName.Text = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(1).ToString();
            txtStreetAddress.Text = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(2).ToString();
            txtEmailAdd.Text = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(3).ToString();
            txtUserID.Text = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(6).ToString();
            txtPassword.Text = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(7).ToString();

            cmbType.Text = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(9).ToString();
            cmbStatus.Text = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(10).ToString();
            txtContactNo.Text = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(11).ToString();
        }

        private void bttnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openIMG = new OpenFileDialog();

            try
            {
                openIMG.Filter = "Format gambar (*.bmp,*.jpg,*.gif,*.png)|*.bmp;*.jpg;*.gif;*.jpeg;*.png";
                openIMG.ShowDialog();
                imgPath = openIMG.FileName;
                if (imgPath != "") { picLibrarian.Image = Image.FromFile(imgPath); }
            }
            catch (Exception ex) { }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserKode.Text == "")
            {
                clsFunctions.isTextEmptyMsg("Library ID");
                txtUserKode.Focus();
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
            else if (ADD_STATE == true && clsFunctions.recordExist("SELECT usercode FROM tblusers WHERE usercode LIKE '" + txtUserKode.Text + "' ", "tblusers") == true)
            {
                MessageBox.Show("Usercode telah dipakai. Mohon di cek dan diganti!", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserKode.Focus();
            }
            else if (clsFunctions.recordExist("SELECT username FROM tblusers WHERE username LIKE '" + txtUserID.Text + "' ", "tblusers") == true)
            {
                MessageBox.Show("Username telah dipakai. Mohon di cek dan diganti!", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserID.Focus();
            }
            else
            {
                cmdAddUsers.Parameters["@getUsercode"].Value = txtUserKode.Text;
                cmdAddUsers.Parameters["@getFullname"].Value = txtFirstName.Text;
                cmdAddUsers.Parameters["@getAddress"].Value = txtStreetAddress.Text;
                cmdAddUsers.Parameters["@getEmail"].Value = txtEmailAdd.Text;
                cmdAddUsers.Parameters["@getTelephone"].Value = txtContactNo.Text;
                cmdAddUsers.Parameters["@getUsertype"].Value = cmbType.Text == "ADMINISTRATOR" ? 1 : 2;
                cmdAddUsers.Parameters["@getStatus"].Value = cmbStatus.Text;
                cmdAddUsers.Parameters["@getUsername"].Value = txtUserID.Text;
                cmdAddUsers.Parameters["@getPassword"].Value = txtPassword.Text;
                cmdAddUsers.Parameters["@getDatemodify"].Value = DateTime.Now;
                cmdAddUsers.Parameters["@getUsermodifyby"].Value = 1;
                cmdAddUsers.Parameters["@getDateadded"].Value = DateTime.Now;
                cmdAddUsers.Parameters["@getUseraddedby"].Value = 1;
                cmdAddUsers.ExecuteNonQuery();
                FormUser.publicFormUser.RemovePic();
                imgName = sUserKode + ".lms";

                if (ADD_STATE == false)
                {
                    if (imgPath != "")
                    {
                        File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\@Data\\@Image\\" + imgName);
                        File.Copy(imgPath, AppDomain.CurrentDomain.BaseDirectory + "\\@Data\\@Image\\" + imgName, true);
                    }
                    FormUser.publicFormUser.ReloadCurrent();
                    MessageBox.Show("Changes in record has been successfully saved.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (imgPath == "") { imgName = ""; }
                    else
                    {
                        File.Copy(imgPath, AppDomain.CurrentDomain.BaseDirectory + "\\@Data\\@Image\\" + txtUserKode.Text + ".lms", true);
                    }
                    FormUser.publicFormUser.LoadUsers("SELECT tblusers.usercode, tblusers.fullname, tblusers.address, tblusers.email, tblusertype.typename, tblusers.status, tblusers.username FROM tblusertype RIGHT JOIN tblusers ON tblusertype.autoid = tblusers.usertype ORDER BY tblusers.autoid ASC");
                    MessageBox.Show("Record has been successfully added.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            //Clear All TextFields
            txtFirstName.Clear();
            txtStreetAddress.Clear();
            txtContactNo.Clear();
            txtEmailAdd.Clear();
            txtUserID.Clear();
            txtPassword.Clear();
        }
    }
}
