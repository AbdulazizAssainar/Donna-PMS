namespace Donna
{
    partial class AddDevice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label12 = new Label();
            textBox_paid = new TextBox();
            checkBox_dd = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            dateTimePicker = new DateTimePicker();
            label9 = new Label();
            textBox_serial = new TextBox();
            button_close = new Button();
            button1 = new Button();
            checkBox_checked = new CheckBox();
            label1 = new Label();
            comboBox_model = new ComboBox();
            label2 = new Label();
            comboBox_brand = new ComboBox();
            label3 = new Label();
            textBox_det = new TextBox();
            label4 = new Label();
            textBox_phone = new TextBox();
            label5 = new Label();
            textBox_name = new TextBox();
            label6 = new Label();
            label_id = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBox_paid);
            panel1.Controls.Add(checkBox_dd);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dateTimePicker);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox_serial);
            panel1.Controls.Add(button_close);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox_checked);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox_model);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox_brand);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox_det);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_phone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox_name);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label_id);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 376);
            panel1.TabIndex = 14;
            panel1.MouseDown += Panel1_MouseDown;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(297, 166);
            label12.Name = "label12";
            label12.Size = new Size(38, 21);
            label12.TabIndex = 22;
            label12.Text = "Paid";
            // 
            // textBox_paid
            // 
            textBox_paid.BorderStyle = BorderStyle.None;
            textBox_paid.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_paid.Location = new Point(341, 166);
            textBox_paid.Name = "textBox_paid";
            textBox_paid.Size = new Size(155, 22);
            textBox_paid.TabIndex = 23;
            // 
            // checkBox_dd
            // 
            checkBox_dd.AutoSize = true;
            checkBox_dd.FlatStyle = FlatStyle.Flat;
            checkBox_dd.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_dd.Location = new Point(341, 208);
            checkBox_dd.Name = "checkBox_dd";
            checkBox_dd.Size = new Size(12, 11);
            checkBox_dd.TabIndex = 21;
            checkBox_dd.UseVisualStyleBackColor = true;
            checkBox_dd.CheckedChanged += CheckBox_dd_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(296, 201);
            label11.Name = "label11";
            label11.Size = new Size(39, 21);
            label11.TabIndex = 20;
            label11.Text = "DD?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(293, 233);
            label10.Name = "label10";
            label10.Size = new Size(42, 21);
            label10.TabIndex = 19;
            label10.Text = "Date";
            label10.Visible = false;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(341, 231);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 18;
            dateTimePicker.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(55, 201);
            label9.Name = "label9";
            label9.Size = new Size(45, 21);
            label9.TabIndex = 16;
            label9.Text = "Serial";
            // 
            // textBox_serial
            // 
            textBox_serial.BorderStyle = BorderStyle.None;
            textBox_serial.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_serial.Location = new Point(106, 201);
            textBox_serial.Name = "textBox_serial";
            textBox_serial.Size = new Size(155, 22);
            textBox_serial.TabIndex = 17;
            // 
            // button_close
            // 
            button_close.BackColor = SystemColors.Control;
            button_close.BackgroundImage = Properties.Resources.close_FILL0_wght100_GRAD0_opsz48;
            button_close.BackgroundImageLayout = ImageLayout.Stretch;
            button_close.FlatAppearance.BorderSize = 0;
            button_close.FlatStyle = FlatStyle.Flat;
            button_close.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_close.ForeColor = SystemColors.ControlText;
            button_close.Location = new Point(541, 3);
            button_close.Name = "button_close";
            button_close.Size = new Size(30, 30);
            button_close.TabIndex = 15;
            button_close.UseVisualStyleBackColor = false;
            button_close.Click += Button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Rectangle_3;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(161, 260);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // checkBox_checked
            // 
            checkBox_checked.AutoSize = true;
            checkBox_checked.FlatStyle = FlatStyle.Flat;
            checkBox_checked.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_checked.Location = new Point(106, 237);
            checkBox_checked.Name = "checkBox_checked";
            checkBox_checked.Size = new Size(12, 11);
            checkBox_checked.TabIndex = 13;
            checkBox_checked.UseVisualStyleBackColor = true;
            checkBox_checked.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 51);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // comboBox_model
            // 
            comboBox_model.FlatStyle = FlatStyle.Flat;
            comboBox_model.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_model.FormattingEnabled = true;
            comboBox_model.Location = new Point(106, 166);
            comboBox_model.Name = "comboBox_model";
            comboBox_model.Size = new Size(155, 29);
            comboBox_model.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 75);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // comboBox_brand
            // 
            comboBox_brand.FlatStyle = FlatStyle.Flat;
            comboBox_brand.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_brand.FormattingEnabled = true;
            comboBox_brand.Location = new Point(106, 131);
            comboBox_brand.Name = "comboBox_brand";
            comboBox_brand.Size = new Size(155, 29);
            comboBox_brand.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 103);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // textBox_det
            // 
            textBox_det.BorderStyle = BorderStyle.None;
            textBox_det.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_det.Location = new Point(341, 50);
            textBox_det.Multiline = true;
            textBox_det.Name = "textBox_det";
            textBox_det.Size = new Size(200, 110);
            textBox_det.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 134);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 3;
            label4.Text = "Brand";
            // 
            // textBox_phone
            // 
            textBox_phone.BorderStyle = BorderStyle.None;
            textBox_phone.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_phone.Location = new Point(106, 103);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(155, 22);
            textBox_phone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 169);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 4;
            label5.Text = "Model";
            // 
            // textBox_name
            // 
            textBox_name.BorderStyle = BorderStyle.None;
            textBox_name.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_name.Location = new Point(106, 75);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(155, 22);
            textBox_name.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 230);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 5;
            label6.Text = "Checked";
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_id.Location = new Point(106, 51);
            label_id.Name = "label_id";
            label_id.Size = new Size(18, 21);
            label_id.TabIndex = 7;
            label_id.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(281, 51);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 6;
            label7.Text = "Details";
            // 
            // AddDevice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.Rectangle_6;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 400);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddDevice";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDevice";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button_close;
        private Label label10;
        private DateTimePicker dateTimePicker;
        private Label label9;
        private TextBox textBox_serial;
        private Button button1;
        private CheckBox checkBox_checked;
        private Label label1;
        private ComboBox comboBox_model;
        private Label label2;
        private ComboBox comboBox_brand;
        private Label label3;
        private TextBox textBox_det;
        private Label label4;
        private TextBox textBox_phone;
        private Label label5;
        private TextBox textBox_name;
        private Label label6;
        private Label label_id;
        private Label label7;
        private Label label12;
        private TextBox textBox_paid;
        private CheckBox checkBox_dd;
        private Label label11;
    }
}