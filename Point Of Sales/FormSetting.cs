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
    public partial class FormSetting : Form
    {

        public static FormSetting publicFormSetting;

        MySqlDataAdapter daFormSettingList = new MySqlDataAdapter();
        MySqlCommand cmdDelete;
        DataSet dsFormSettingList = new DataSet();

        private static FormSetting sForm = null;
        public static FormSetting Instance()
        {
            if (sForm == null) { sForm = new FormSetting(); }

            return sForm;
        }

        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBackupDatabase_Click(object sender, EventArgs e)
        {
         
            saveFileDialog.Filter = "SQL | *.sql";
            saveFileDialog.ShowDialog();
            
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog.FileName;
            clsFunctions.BackupDatabase(name);
        }

        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "SQL | *.sql";
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string name = openFileDialog.FileName;
            clsFunctions.RestoreDatabase(name);
        }
    }
}
