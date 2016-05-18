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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String txtPWDHash = clsSecurity.EncryptionMD5(txtPassword.Text);

            if (clsFunctions.recordExist("SELECT autoid, fullname FROM tblusers WHERE username LIKE '" + txtUsername.Text + "' AND password LIKE '" + txtPWDHash + "' ", "tblusers") == true)
            {
                //clsVariables.sTimeLogin = DateTime.Now.ToLongTimeString();

                long totalRow = 0;

                //Set the Data Adapter
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT tblusers.autoid, tblusers.fullname , tblusers.username, tblusers.usertype, tblusers.usercode FROM tblusers WHERE tblusers.username LIKE '" + txtUsername.Text + "' ", clsConnection.CN);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblusers");

                totalRow = ds.Tables["tblusers"].Rows.Count - 1;

                //clsVariables.sIdKasir = ds.Tables["tbluser"].Rows[0].ItemArray.GetValue(0).ToString();
                clsVariables.sFullname = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(1).ToString();
                clsVariables.sUsercode = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(4).ToString();
                
                //clsVariables.sIsAdmin = ds.Tables["tbluser"].Rows[0].ItemArray.GetValue(3).ToString() == "1" ? true : false;

                //clsUserLogs.record_login(clsVariables.sTimeLogin, clsVariables.sLibrarianID);
                clsApp.APP_CONNECTED = true;
                this.Close();
            }
            else
            {
                if (lblAttempt.Text == "1")
                {
                    MessageBox.Show("You already used all the attempts.\nThis will terminate the application.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    int iAttempt;

                    iAttempt = Convert.ToInt32(lblAttempt.Text) - 1;
                    lblAttempt.Text = iAttempt.ToString();
                    MessageBox.Show("Username/password Salah!. Mohon coba kembali.\n\nPeringatan: kamu masih mempunyai " + lblAttempt.Text + "kesempatan lagi.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsConnection.CN.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            clsConnection conn = new clsConnection();
            conn.setConnection(clsVariables.sIPAddress, clsVariables.sDbUser, clsVariables.sDbName, clsVariables.sDbPassword);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkUnmask_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnmask.Checked == true) { this.txtPassword.PasswordChar = Convert.ToChar(0); }
            else { this.txtPassword.PasswordChar = '•'; }
        }
    }
}
