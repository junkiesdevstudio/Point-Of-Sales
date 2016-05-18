using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Of_Sales
{
    public class clsConnection
    {
        public static MySqlConnection CN = new MySqlConnection();

        public void setConnection(string sServer, string sUser, string sDBName, string sPassword)
        {
            string sProvider = "server=" + sServer + ";uid=" + sUser + ";" + "pwd=" + sPassword + ";database=" + sDBName;
            CN.ConnectionString = sProvider;
            CN.Open();
        }
    }
}
