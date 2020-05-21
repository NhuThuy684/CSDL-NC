using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_KS
{
    class DataConnection
    {
        string connStr;
        public DataConnection()
        {
            connStr = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QL_Khach_san;Integrated Security=True";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(connStr);
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
