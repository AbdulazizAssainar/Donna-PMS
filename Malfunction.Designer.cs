namespace Donna
{
    partial class Malfunction
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
            dataGridView1 = new DataGridView();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button_close = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button_close);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 326);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(376, 246);
            dataGridView1.TabIndex = 22;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(229, 20);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 19);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "Malfunction";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(150, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 19);
            radioButton1.TabIndex = 20;
            radioButton1.TabStop = true;
            radioButton1.Text = "Category";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 19;
            textBox1.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Rectangle_3;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(150, 48);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All" });
            comboBox1.Location = new Point(23, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
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
            button_close.Location = new Point(343, 3);
            button_close.Name = "button_close";
            button_close.Size = new Size(30, 30);
            button_close.TabIndex = 16;
            button_close.UseVisualStyleBackColor = false;
            // 
            // Malfunction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Rectangle_6;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(400, 350);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Malfunction";
            Text = "Malfunction";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_close;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}