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
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void picSplashScreen_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
