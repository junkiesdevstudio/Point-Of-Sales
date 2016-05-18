using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sales
{
    static class clsStart
    {
        [STAThread]
        static void Main()
        {
            if (clsApp.havePrevInstance() == false)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormLogin());

                if (clsApp.APP_CONNECTED == true) { Application.Run(new FormMDI()); }
            }
            else
            {
                MessageBox.Show("Aplikasi masih berjalan.", clsVariables.sMSGBOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
