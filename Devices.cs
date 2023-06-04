using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Donna.global;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Donna
{
    public partial class Devices : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        void GetData()
        {
            try
            {
                if (radioButton_all.Checked)
                {
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = devicesTable;
                    return;
                }

                if (radioButton_received.Checked)
                {
                    return;
                }
                if (radioButton_done.Checked)
                {
                    return;
                }
                if (radioButton_refused.Checked)
                {
                    return;
                }
                if (radioButton_delivered.Checked)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public Devices()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            radioButton_all.Select();
        }
    }
}
