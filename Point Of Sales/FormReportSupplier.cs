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
    public partial class FormReportSupplier : Form
    {
        public static FormReportSupplier publicFormReport;
        public static string mType2;

        private static FormReportSupplier sForm = null;
        public static FormReportSupplier Instance()
        {
            if (sForm == null) { sForm = new FormReportSupplier(); }

            return sForm;
        }
        public FormReportSupplier()
        {
            InitializeComponent();
        }

        private void FormReportSupplier_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            switch (mType2)
            {
                case "Supplier":
                    SetReportSupplier();
                    break;
            }
        }

        void SetReportSupplier()
        {
           
        }
    }
}
