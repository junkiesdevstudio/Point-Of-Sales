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
    public partial class FormDiscount : Form
    {
        public static FormDiscount publicFormDiscount;

        public FormDiscount()
        {
            InitializeComponent();
        }

        private void FormDiscount_Load(object sender, EventArgs e)
        {
            publicFormDiscount = this;
        }

        private void txtMemberCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormPOS.publicFormPOS.SetDiscount(txtMemberCode.Text);
                this.Close();
            }
        }
    }
}
