using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sales
{
    public class clsFunctions : clsConnection
    {
        public void setOleDbCommand(MySqlCommand cmd, string sCommand, string sParameters, string sMatch)
        {
            //Set the delete command
            cmd = new MySqlCommand(sCommand, CN);
            cmd.Parameters.Add(sParameters, MySqlDbType.VarChar);
            cmd.Parameters[sParameters].Value = sMatch;
            cmd.ExecuteNonQuery();
        }
        public static bool recordExist(string sSQL, string sTable)
        {
            long totalRow = 0;
            //Set the Data Adapter
            MySqlDataAdapter da = new MySqlDataAdapter(sSQL, CN);
            DataSet ds = new DataSet();
            da.Fill(ds, sTable);

            totalRow = Convert.ToInt32(ds.Tables[sTable].Rows.Count);
            if (totalRow > 0) { return true; }
            else { return false; }
        }

        public static void isTextEmptyMsg(string sField)
        {
            MessageBox.Show(sField + " kosong.Please check itMohon dicek kembali!", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void FillTabControls(TabControl tb, string sSQL, string sTable, string sFirstItem)
        {
            long totalRow = 0;
            //Set the Data Adapter
            MySqlDataAdapter da = new MySqlDataAdapter(sSQL, CN);
            DataSet ds = new DataSet();
            da.Fill(ds, sTable);

            totalRow = ds.Tables[sTable].Rows.Count - 1;

            tb.TabPages.Clear();
            if (sFirstItem != "") tb.TabPages.Add(new TabPage(sFirstItem));
            for (int i = 0; i <= totalRow; i++) tb.TabPages.Add(new TabPage("" + ds.Tables[sTable].Rows[i].ItemArray.GetValue(0).ToString()));
            if (tb.TabPages.Count > 0) tb.SelectedIndex = 0;
        }

        public void FillCombo(ComboBox cb, string sSQL, string sTable, int sNum)
        {
            long totalRow = 0;
            //Set the Data Adapter
            MySqlDataAdapter da = new MySqlDataAdapter(sSQL, CN);
            DataSet ds = new DataSet();
            da.Fill(ds, sTable);

            totalRow = ds.Tables[sTable].Rows.Count - 1;

            cb.Items.Clear();
            for (int i = 0; i <= totalRow; i++) cb.Items.Add("" + ds.Tables[sTable].Rows[i].ItemArray.GetValue(sNum).ToString());
            if (cb.Items.Count > 1) cb.SelectedIndex = 0;
        }

        public void CreateDirectory(string sFolder)
        {
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + sFolder) == false)
            {

                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + sFolder);
            }
        }

        public DataSet GetReport(DataSet ds, string sSQL, string sTable)
        {
            DataSet rtnDs = ds;
            FillDataSet(rtnDs, sSQL, sTable);
            return rtnDs;
        }

        protected DataSet FillDataSet(DataSet dset, string sSQL, string tbl)
        {
            MySqlCommand cmd = new MySqlCommand(sSQL, clsConnection.CN);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            try { adapter.Fill(dset, tbl); }
            catch (Exception ex) { }

            return dset;

        }

        public static string GenerateCD(string sSQL, string tbl)
        {
            MySqlCommand cmd = new MySqlCommand(sSQL, clsConnection.CN);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, tbl);

            int idgenerate = 0;
            if (ds.Tables[tbl].Rows[0].ItemArray.GetValue(0).ToString() != "")
                idgenerate = int.Parse(ds.Tables[tbl].Rows[0].ItemArray.GetValue(0).ToString());
            else
                idgenerate = 0;

            return idgenerate.ToString("D9");
        }

        public static void BackupDatabase(string sPath)
        {
            string sProvider = "server=" + clsVariables.sIPAddress + ";uid=" + clsVariables.sDbUser + ";" + "pwd=" + clsVariables.sDbPassword + ";database=" + clsVariables.sDbName + ";Convert Zero Datetime=True";
            using (MySqlConnection conn = new MySqlConnection(sProvider))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(sPath);
                        conn.Close();
                    }
                }

            }
        }

        public static void RestoreDatabase(string sPath)
        {
            string sProvider = "server=" + clsVariables.sIPAddress + ";uid=" + clsVariables.sDbUser + ";" + "pwd=" + clsVariables.sDbPassword + ";database=" + clsVariables.sDbName;
            using (MySqlConnection conn = new MySqlConnection(sProvider))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(sPath);
                        conn.Close();
                    }
                }
            }
        }

    }
}
