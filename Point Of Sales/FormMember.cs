using MySql.Data.MySqlClient;
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

namespace Point_Of_Sales
{
    public partial class FormMember : Form
    {
        clsFunctions sFunctions = new clsFunctions();

        public static FormMember publicFormMember;

        MySqlDataAdapter daFormMemberList = new MySqlDataAdapter();
        MySqlCommand cmdDelete;
        DataSet dsFormMemberList = new DataSet();

        private static FormMember sForm = null;
        public static FormMember Instance()
        {
            if (sForm == null) { sForm = new FormMember(); }

            return sForm;
        }
        public FormMember()
        {
            InitializeComponent();
        }

        private void bttnAddNew_Click(object sender, EventArgs e)
        {
            FormMember_Modify.ADD_STATE = true;
            FormMember_Modify sForm = new FormMember_Modify();
            sForm.ShowDialog();
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            daFormMemberList = new MySqlDataAdapter("", clsConnection.CN);

            LoadMember("SELECT tblmember.membercode, tblmember.fullname, tblmember.address, tblmember.telephone, tblmember.status, tblmember.discount, tbldiscount.percent  FROM tbldiscount RIGHT JOIN tblmember ON tbldiscount.autoid = tblmember.discount ORDER BY tblmember.autoid ASC");

            publicFormMember = this;
        }

        public void LoadMember(string sSQL)
        {
            try
            {
                long totalRow = 0;

                daFormMemberList.SelectCommand.CommandText = sSQL;

                dsFormMemberList.Clear();
                daFormMemberList.Fill(dsFormMemberList, "tblmember");

                totalRow = dsFormMemberList.Tables["tblmember"].Rows.Count - 1;


                lvMember.Items.Clear();
                for (int i = 0; i <= totalRow; i++)
                {
                    lvMember.Items.Add(new ListViewItem("" + dsFormMemberList.Tables["tblmember"].Rows[i].ItemArray.GetValue(0).ToString(), 22));
                    lvMember.Items[i].SubItems.Add("" + dsFormMemberList.Tables["tblmember"].Rows[i].ItemArray.GetValue(1).ToString());
                    lvMember.Items[i].SubItems.Add("" + dsFormMemberList.Tables["tblmember"].Rows[i].ItemArray.GetValue(2).ToString());
                    lvMember.Items[i].SubItems.Add("" + dsFormMemberList.Tables["tblmember"].Rows[i].ItemArray.GetValue(3).ToString());
                    lvMember.Items[i].SubItems.Add("" + dsFormMemberList.Tables["tblmember"].Rows[i].ItemArray.GetValue(6).ToString());
                    lvMember.Items[i].SubItems.Add("" + dsFormMemberList.Tables["tblmember"].Rows[i].ItemArray.GetValue(4).ToString());
                    //lvMember.Items[i].SubItems.Add("" + dsFormMemberList.Tables["tblmember"].Rows[i].ItemArray.GetValue(6).ToString());

                }
                if (lvMember.Items.Count > 0)
                {
                    try
                    {
                        lvMember.Items[0].Focused = true;
                        lvMember.Items[0].Selected = true;
                        lvMember.Items[0].EnsureVisible();
                        lvMember.Focus();
                    }
                    catch (ArgumentOutOfRangeException aooreE) { MessageBox.Show(aooreE.Message); }
                    catch (NullReferenceException nreE) { MessageBox.Show(nreE.Message); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bttnReload_Click(object sender, EventArgs e)
        {
            LoadMember("SELECT tblmember.membercode, tblmember.fullname, tblmember.address, tblmember.telephone, tblmember.status, tblmember.discount, tbldiscount.percent  FROM tbldiscount RIGHT JOIN tblmember ON tbldiscount.autoid = tblmember.discount ORDER BY tblmember.autoid ASC");
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (lvMember.Items.Count > 0)
            {
                if (MessageBox.Show("Proses ini akan menghapus data secara permanen. Anda yakin ingin melanjutkan?", clsVariables.sMSGBOX, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    try
                    {
                        try
                        {
                            sFunctions.setOleDbCommand(cmdDelete, "DELETE FROM tblmember WHERE membercode = @getMemberCode", "@getMemberCode", lvMember.Items[lvMember.FocusedItem.Index].SubItems[0].Text);
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

        }

        public void ReloadCurrent()
        {
            try
            {
                int lvw_pos;

                lvw_pos = lvMember.FocusedItem.Index;

                LoadMember("SELECT tblmember.membercode, tblmember.fullname, tblmember.address, tblmember.telephone, tblmember.status, tblmember.discount, tbldiscount.percent  FROM tbldiscount RIGHT JOIN tblmember ON tbldiscount.autoid = tblmember.discount ORDER BY tblmember.autoid ASC");

                if (lvMember.Items.Count != 0 && lvMember.Items.Count - 1 >= lvw_pos)
                {
                    lvMember.Items[lvMember.FocusedItem.Index].Selected = false;
                    lvMember.Items[lvMember.FocusedItem.Index].Focused = false;

                    lvMember.Items[lvw_pos].Focused = true;
                    lvMember.Items[lvw_pos].Selected = true;
                    lvMember.Items[lvw_pos].EnsureVisible();

                }
                lvw_pos = 0;

            }
            catch (ArgumentOutOfRangeException aooreE) { }

            catch (NullReferenceException nreE) { }

            catch (IOException ioeE) { MessageBox.Show("Error: " + ioeE.Source + ": " + ioeE.Message, clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lvMember_Click(object sender, EventArgs e)
        {
            if (lvMember.Items.Count > 0)
            {
                if (lvMember.SelectedItems.Count < 1) { MessageBox.Show("Pls. Select an Item.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Error); }

                else { lvMember_SelectedIndexChanged(sender, e); }
            }
            else
            {
                MessageBox.Show("No more records found.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lvMember_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnModify_Click(object sender, EventArgs e)
        {
            if (lvMember.Items.Count > 0)
            {
                try
                {
                    FormMember_Modify.ADD_STATE = false;
                    FormMember_Modify.sMemberKode = lvMember.Items[lvMember.FocusedItem.Index].SubItems[0].Text;
                    FormMember_Modify sForm = new FormMember_Modify();
                    sForm.ShowDialog();

                }
                catch (ArgumentOutOfRangeException aooreE) {}
                catch (NullReferenceException nreE) { }
            }
            else { MessageBox.Show("No record to edit.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
