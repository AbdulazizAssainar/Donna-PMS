using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Donna.global;

namespace Donna
{
    internal class voids
    {
        public static bool getDeviceDone = false, startupDone = false;

        public static void GetDevices()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    GetDevices();
                }

                string query = "SELECT * FROM Table_Device";
                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if the reader has rows and read the data
                        if (reader.HasRows)
                        {
                            // Store the data
                            devicesTable.Load(reader);
                        }
                    }
                }

                getDeviceDone = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
