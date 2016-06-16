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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String Teks_enkripsi = clsSecurity.EncryptionMD5(textBox2.Text);
            String Teks_enkripsi = textBox2.Text;
            if (clsFunctions.recordExist("SELECT * FROM tblusers WHERE username LIKE '" + textBox1.Text + "' AND password LIKE '" + Teks_enkripsi + "' ", "tblusers") == true)
            {
                long total_baris = 0;
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT tblusers.autoid, tblusers.fullname , tblusers.username, tblusers.usertype, tblusers.usercode FROM tblusers WHERE tblusers.username LIKE '" + textBox1.Text + "' ", clsConnection.CN);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblusers");
                total_baris = ds.Tables["tblusers"].Rows.Count - 1;
                clsVariables.sFullname = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(1).ToString();
                clsVariables.sUsercode = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(4).ToString();
                clsApp.APP_CONNECTED = true;
                this.Close();               
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                //String Teks_enkripsi = clsSecurity.EncryptionMD5(textBox2.Text);
                String Teks_enkripsi = textBox2.Text;
                if (clsFunctions.recordExist("SELECT * FROM tblusers WHERE username LIKE '" + textBox1.Text + "' AND password LIKE '" + Teks_enkripsi + "' ", "tblusers") == true)
                {
                    long total_baris = 0;
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT tblusers.autoid, tblusers.fullname , tblusers.username, tblusers.usertype, tblusers.usercode FROM tblusers WHERE tblusers.username LIKE '" + textBox1.Text + "' ", clsConnection.CN);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblusers");
                    total_baris = ds.Tables["tblusers"].Rows.Count - 1;
                    clsVariables.sFullname = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(1).ToString();
                    clsVariables.sUsercode = ds.Tables["tblusers"].Rows[0].ItemArray.GetValue(4).ToString();
                    clsApp.APP_CONNECTED = true;
                    this.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
