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
    public partial class FormCash : Form
    {
        public static FormCash publicFormCash;

        public FormCash()
        {
            InitializeComponent();
        }

        private void FormCash_Load(object sender, EventArgs e)
        {
            publicFormCash = this;
        }

        private void txtCash_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                FormPOS.publicFormPOS.SumCashFinish(txtCash.Text);
                this.Close();
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
    }
}
