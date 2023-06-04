using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static Donna.global;
using static Donna.voids;

namespace Donna
{
    public partial class Main : Form
    {
        private Rectangle controlOriginalRectangle;
        private Rectangle originalFormSize;

        void checkCon()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    label_db_conn.Text = "1";
                }
                else
                {
                    label_db_conn.Text = "0";
                }
            }
            catch (Exception ex)
            {
                timer_main.Stop();
                MessageBox.Show(ex.Message, "checkCon");
            }
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        void startup()
        {
            if (startupDone)
            {
                panel1.Visible = true;
                panel_home.Visible = true;

                this.Opacity = 100;
                this.WindowState = FormWindowState.Maximized;
                return;
            }

            panel1.Visible = false;
            panel_home.Visible = false;
            panel_viewer.Visible = false;

            this.Opacity = 0;
            this.WindowState = FormWindowState.Minimized;

            Startup startup = new();
            startup.Show();
        }

        public Main()
        {
            InitializeComponent();
            startup();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
        }

        private void button_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_stock_Click(object sender, EventArgs e)
        {
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            AddDevice addDevice = new();
            addDevice.Show();
        }

        private void Timer_main_Tick(object sender, EventArgs e)
        {
            checkCon();

            try
            {
                if (startupDone)
                {
                    startup();
                }
            }
            catch (Exception ex)
            {
                timer_main.Stop();
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Devices devices = new();
            devices.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            string x = "x";

            if (x == "xx")
            {
                foreach (Control c in Controls)
                {
                    controlOriginalRectangle = new Rectangle(c.Location.X, c.Location.Y, c.Width, c.Height);
                    resizeControl(controlOriginalRectangle, c);
                }
            }
        }
    }
}
