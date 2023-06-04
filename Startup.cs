using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Donna.global;
using static Donna.voids;

namespace Donna
{
    public partial class Startup : Form
    {
        int per;

        public Startup()
        {
            InitializeComponent();

            try
            {
                Version version = Assembly.GetEntryAssembly().GetName().Version;
                label_vr.Text = "v " + version;

                per = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Startup_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label_per.Text = per+"%";

            if (per == 1)
            {
                per = 5;
                sqlCon.Open();
            }
            
            if (per == 5 && sqlCon.State == ConnectionState.Open)
            {
                per = 10;
                GetDevices();
            }

            if (per == 10 && getDeviceDone)
            {
                per = 100;
            } 

            if (per == 100)
            {
                startupDone = true;
                timer.Stop();
                this.Close();
            }

            
        }
    }
}
