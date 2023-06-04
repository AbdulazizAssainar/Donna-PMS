using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donna
{
    internal class global
    {
        public static readonly SqlConnection sqlCon = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Repo\Donna\db_mn.mdf;Integrated Security=True");

        public static DataTable devicesTable = new();
        public static DataTable usersTable = new();
        public static DataTable customersTable = new();
        public static DataTable receiptsTable = new();
    }
}
