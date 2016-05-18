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
using System.IO;

namespace Point_Of_Sales
{
    public partial class FormUser : Form
    {
        clsFunctions sFunctions = new clsFunctions();

        public static FormUser publicFormUser;

        MySqlDataAdapter daFormUserList = new MySqlDataAdapter();
        MySqlCommand cmdDelete;
        DataSet dsFormUserList = new DataSet();

        private static FormUser sForm = null;
        public static FormUser Instance()
        {
            if (sForm == null) { sForm = new FormUser(); }

            return sForm;
        }


        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            sFunctions.CreateDirectory("\\@Data\\@Image");

            daFormUserList = new MySqlDataAdapter("", clsConnection.CN);

            LoadUsers("SELECT tblusers.usercode, tblusers.fullname, tblusers.address, tblusers.email, tblusertype.typename, tblusers.status, tblusers.username FROM tblusertype RIGHT JOIN tblusers ON tblusertype.autoid = tblusers.usertype ORDER BY tblusers.autoid ASC");

            publicFormUser = this;
        }

        public void LoadUsers(string sSQL)
        {
            try
            {
                long totalRow = 0;

                daFormUserList.SelectCommand.CommandText = sSQL;

                dsFormUserList.Clear();
                daFormUserList.Fill(dsFormUserList, "tblusers");

                totalRow = dsFormUserList.Tables["tblusers"].Rows.Count - 1;

                lvUser.Items.Clear();
                for (int i = 0; i <= totalRow; i++)
                {
                    lvUser.Items.Add(new ListViewItem("" + dsFormUserList.Tables["tblusers"].Rows[i].ItemArray.GetValue(0).ToString(), 22));
                    lvUser.Items[i].SubItems.Add("" + dsFormUserList.Tables["tblusers"].Rows[i].ItemArray.GetValue(1).ToString());
                    lvUser.Items[i].SubItems.Add("" + dsFormUserList.Tables["tblusers"].Rows[i].ItemArray.GetValue(2).ToString());
                    lvUser.Items[i].SubItems.Add("" + dsFormUserList.Tables["tblusers"].Rows[i].ItemArray.GetValue(3).ToString());
                    lvUser.Items[i].SubItems.Add("" + dsFormUserList.Tables["tblusers"].Rows[i].ItemArray.GetValue(4).ToString());
                    lvUser.Items[i].SubItems.Add("" + dsFormUserList.Tables["tblusers"].Rows[i].ItemArray.GetValue(5).ToString());
                    lvUser.Items[i].SubItems.Add("" + dsFormUserList.Tables["tblusers"].Rows[i].ItemArray.GetValue(6).ToString());
                    
                }
                if (lvUser.Items.Count > 0)
                {
                    try
                    {
                        lvUser.Items[0].Focused = true;
                        lvUser.Items[0].Selected = true;
                        lvUser.Items[0].EnsureVisible();
                        lvUser.Focus();
                    }
                    catch (ArgumentOutOfRangeException aooreE) { }
                    catch (NullReferenceException nreE) { }
                }
            }
            catch (Exception ex) { }
        }

        public void ReloadCurrent()
        {
            try
            {
                int lvw_pos;

                lvw_pos = lvUser.FocusedItem.Index;

                LoadUsers("SELECT tblusers.usercode, tblusers.fullname, tblusers.address, tblusers.email, tblusertype.typename, tblusers.status, tblusers.username FROM tblusertype RIGHT JOIN tblusers ON tblusertype.autoid = tblusers.usertype ORDER BY tblusers.autoid ASC");

                if (lvUser.Items.Count != 0 && lvUser.Items.Count - 1 >= lvw_pos)
                {
                    lvUser.Items[lvUser.FocusedItem.Index].Selected = false;
                    lvUser.Items[lvUser.FocusedItem.Index].Focused = false;

                    lvUser.Items[lvw_pos].Focused = true;
                    lvUser.Items[lvw_pos].Selected = true;
                    lvUser.Items[lvw_pos].EnsureVisible();

                }
                lvw_pos = 0;

            }
            catch (ArgumentOutOfRangeException aooreE) { }

            catch (NullReferenceException nreE) { }

            catch (IOException ioeE) { MessageBox.Show("Error: " + ioeE.Source + ": " + ioeE.Message, clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnAddNew_Click(object sender, EventArgs e)
        {
            if (clsFunctions.recordExist("SELECT tblusers.usercode, tblusers.usertype FROM tblusers WHERE (tblusers.usertype=1 && tblusers.usercode='" + clsVariables.sUsercode + "') ORDER BY tblusers.autoid ASC", "tblusers") == true)
            {
                FormUser_Modify.ADD_STATE = true;
                FormUser_Modify sForm = new FormUser_Modify();
                sForm.ShowDialog();

            }else
            {
                MessageBox.Show("Anda perlu hak akses administrator untuk menggunakan fitur ini!", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemovePic()
        {
            try
            {
                picLibrarian.Image.Dispose();
                picLibrarian.Image = null;
            }
            catch (NullReferenceException nre) { }
        }

        private void lvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemovePic();
            if (lvUser.Items.Count > 0)
            {
                try
                {
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\@Data\\@Image\\" + lvUser.Items[lvUser.FocusedItem.Index].SubItems[0].Text + ".lms") == true)
                    {
                        picLibrarian.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\@Data\\@Image\\" + lvUser.Items[lvUser.FocusedItem.Index].SubItems[0].Text + ".lms", true);
                    }
                }
                catch (Exception ex) { }
            }
        }

        private void lvUser_Click(object sender, EventArgs e)
        {
            if (lvUser.Items.Count > 0)
            {
                if (lvUser.SelectedItems.Count < 1) { MessageBox.Show("Pls. Select an Item.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error); }

                else { lvUser_SelectedIndexChanged(sender, e); }
            }
            else
            {
                MessageBox.Show("No more records found.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bttnReload_Click(object sender, EventArgs e)
        {
            LoadUsers("SELECT tblusers.usercode, tblusers.fullname, tblusers.address, tblusers.email, tblusertype.typename, tblusers.status, tblusers.username FROM tblusertype RIGHT JOIN tblusers ON tblusertype.autoid = tblusers.usertype ORDER BY tblusers.autoid ASC");
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {

            if (clsFunctions.recordExist("SELECT tblusers.usercode, tblusers.usertype FROM tblusers WHERE (tblusers.usertype=1 && tblusers.usercode='" + clsVariables.sUsercode + "') ORDER BY tblusers.autoid ASC", "tblusers") == true)
            {
                if (lvUser.Items.Count > 0)
                {
                    if (MessageBox.Show("Proses ini akan menghapus data secara permanen. Anda yakin ingin melanjutkan?", clsVariables.sMSGBOX, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        try
                        {
                            RemovePic();
                            try
                            {
                                sFunctions.setOleDbCommand(cmdDelete, "DELETE FROM tblusers WHERE usercode = @getUsercode", "@getUsercode", lvUser.Items[lvUser.FocusedItem.Index].SubItems[0].Text);
                                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\@Data\\@Image\\" + lvUser.Items[lvUser.FocusedItem.Index].SubItems[0].Text + ".lms") == true)
                                {
                                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\@Data\\@Image\\" + lvUser.Items[lvUser.FocusedItem.Index].SubItems[0].Text + ".lms");
                                }
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
            }else
            {
                MessageBox.Show("Anda perlu hak akses administrator untuk menggunakan fitur ini!", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bttnModify_Click(object sender, EventArgs e)
        {

            if (clsFunctions.recordExist("SELECT tblusers.usercode, tblusers.usertype FROM tblusers WHERE (tblusers.usertype=1 && tblusers.usercode='" + clsVariables.sUsercode + "') ORDER BY tblusers.autoid ASC", "tblusers") == true)
            {
                //if (lvUser.Items[lvUser.FocusedItem.Index].SubItems[0].Text == clsVariables.sUsercode)
                //{
                if (lvUser.Items.Count > 0)
                {
                    try
                    {
                        FormUser_Modify.ADD_STATE = false;
                        FormUser_Modify.sUserKode = lvUser.Items[lvUser.FocusedItem.Index].SubItems[0].Text;
                        FormUser_Modify sForm = new FormUser_Modify();
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

        private void bttnPrint_Click(object sender, EventArgs e)
        {
            if (clsFunctions.recordExist("SELECT tblusers.usercode, tblusers.usertype FROM tblusers WHERE (tblusers.usertype=1 && tblusers.usercode='" + clsVariables.sUsercode + "') ORDER BY tblusers.autoid ASC", "tblusers") == true)
            {

            }
            else
            {
                MessageBox.Show("Anda perlu hak akses administrator untuk menggunakan fitur ini!", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSearch(string sSearch)
        {
            LoadUsers("SELECT tblusers.usercode, tblusers.fullname, tblusers.address, tblusers.email, tblusertype.typename, tblusers.status, tblusers.username FROM tblusertype RIGHT JOIN tblusers ON tblusertype.autoid = tblusers.usertype WHERE tblusers.usercode LIKE '%" + sSearch + "%' OR tblusers.fullname LIKE '%" + sSearch + "%' ORDER BY tblusers.autoid ASC");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearch(txtSearch.Text);
            txtSearch.Focus();
        }
    }
}
