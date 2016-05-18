using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sales
{
    public class clsApp
    {
        public static bool APP_CONNECTED = false;
        public static bool havePrevInstance()
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex) { return false; }
        }

        public static void shell(string strShell, string sText)
        {
            try { System.Diagnostics.Process.Start(strShell); }
            catch (Exception ex)
            {
                MessageBox.Show(sText + " tidak terinstall di sistem.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
