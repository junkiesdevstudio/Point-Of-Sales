using Point_Of_Sales.REPORT;
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
    public partial class FormReport : Form
    {

        public static FormReport publicFormReport;
        public static string mType;

        private static FormReport sForm = null;
        public static FormReport Instance()
        {
            if (sForm == null) { sForm = new FormReport(); }

            return sForm;
        }
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            switch (mType)
            {
                case "Member":
                    SetReportMember();
                    break;
            }
        }

        void SetReportMember()
        {
            ReportMember rptMember = new ReportMember();
            crystalReportViewer.ReportSource = rptMember;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
