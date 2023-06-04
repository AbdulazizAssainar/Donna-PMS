using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Donna.global;

namespace Donna
{
    public partial class AddDevice : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        void GetLastId()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    string String = "Select Id from Table_Device ORDER BY id DESC";
                    SqlCommand command = new(String, sqlCon);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable data = new();
                    data.Load(reader);

                    if (data.Rows.Count != 0)
                    {
                        int lastId = int.Parse(data.Rows[0][0].ToString()) + 1;
                        label_id.Text = lastId.ToString();
                    }
                    else
                    {
                        label_id.Text = "1";
                    }

                    sqlCon.Close();
                }
                else
                {
                    sqlCon.Open();
                    GetLastId();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ShowHide()
        {
            if (checkBox_checked.Checked)
            {
                this.Size = new Size(600, 400);
                panel1.Size = new Size(576, 376);
                button_close.Location = new Point(541, 3);
                label7.Visible = label11.Visible = label12.Visible = textBox_det.Visible = textBox_paid.Visible = checkBox_dd.Visible = true;
            }
            else
            {
                this.Size = new Size(400, 400);
                panel1.Size = new Size(376, 376);
                button_close.Location = new Point(341, 3);
                label7.Visible = label11.Visible = label12.Visible = textBox_det.Visible = textBox_paid.Visible = checkBox_dd.Visible = false;
            }

            if (checkBox_dd.Checked)
            {
                label10.Visible = dateTimePicker.Visible = true;
            }
            else { label10.Visible = dateTimePicker.Visible = false; }
        }

        void SetData()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    string query = "INSERT INTO Table_Device (name, phone, brand, model, serial, checked, details, paid, delivery, date, status) VALUES (@name, @phone, @brand, @model, @serial, @checked, @details, @paid, @delivery, @date, @status)";

                    SqlCommand command = new SqlCommand(query, sqlCon);

                    command.Parameters.AddWithValue("@name", textBox_name.Text.Trim());
                    command.Parameters.AddWithValue("@phone", textBox_phone.Text.Trim());
                    command.Parameters.AddWithValue("@brand", comboBox_brand.Text.Trim());
                    command.Parameters.AddWithValue("@model", comboBox_model.Text.Trim());
                    command.Parameters.AddWithValue("@serial", textBox_serial.Text.Trim());
                    command.Parameters.AddWithValue("@status", "Recevied");
                    if (!checkBox_checked.Checked)
                    {
                        command.Parameters.AddWithValue("@checked", false);
                        command.Parameters.AddWithValue("@details", "");
                        command.Parameters.AddWithValue("@paid", "");
                        command.Parameters.AddWithValue("@delivery", false);
                        command.Parameters.AddWithValue("@date", "");
                        MessageBox.Show("!checkBox_checked Done");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@checked", true);
                        command.Parameters.AddWithValue("@details", textBox_det.Text.Trim());
                        command.Parameters.AddWithValue("@paid", dateTimePicker.Text.Trim());
                        if (!checkBox_dd.Checked)
                        {
                            command.Parameters.AddWithValue("@delivery", false);
                            command.Parameters.AddWithValue("@date", "");
                            MessageBox.Show("!checkBox_dd Done");
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@delivery", true);
                            DateTime selectedDate = dateTimePicker.Value;
                            string dateString = selectedDate.ToString("dd-MM-yyyy");
                            command.Parameters.AddWithValue("@date", dateString.Trim());
                            MessageBox.Show("checkBox_dd Done");
                        }
                        MessageBox.Show("checkBox_checked Done");
                    }

                    command.ExecuteNonQuery();
                    ClearScreen();
                    MessageBox.Show("All Done");
                }
                else
                {
                    sqlCon.Open();
                    SetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ClearScreen()
        {
            textBox_name.Clear();
            textBox_phone.Clear();
            comboBox_brand.SelectedItem = null;
            comboBox_model.SelectedItem = null;
            textBox_serial.Clear();
            checkBox_checked.Checked = false;
            textBox_det.Clear();
            textBox_paid.Clear();
            checkBox_dd.Checked = false;
        }

        public AddDevice()
        {
            InitializeComponent();
            GetLastId();
            ShowHide();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SetData();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowHide();
        }

        private void CheckBox_dd_CheckedChanged(object sender, EventArgs e)
        {
            ShowHide();
        }
    }
}
