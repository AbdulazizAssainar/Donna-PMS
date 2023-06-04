namespace Donna
{
    partial class Devices
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
            radioButton_delivered = new RadioButton();
            radioButton_refused = new RadioButton();
            radioButton_done = new RadioButton();
            radioButton_received = new RadioButton();
            radioButton_all = new RadioButton();
            dataGridView = new DataGridView();
            button_close = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(radioButton_delivered);
            panel1.Controls.Add(radioButton_refused);
            panel1.Controls.Add(radioButton_done);
            panel1.Controls.Add(radioButton_received);
            panel1.Controls.Add(radioButton_all);
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(button_close);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 376);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // radioButton_delivered
            // 
            radioButton_delivered.AutoSize = true;
            radioButton_delivered.FlatAppearance.BorderSize = 0;
            radioButton_delivered.FlatStyle = FlatStyle.Flat;
            radioButton_delivered.Location = new Point(268, 72);
            radioButton_delivered.Name = "radioButton_delivered";
            radioButton_delivered.Size = new Size(73, 19);
            radioButton_delivered.TabIndex = 21;
            radioButton_delivered.Text = "Delivered";
            radioButton_delivered.UseVisualStyleBackColor = true;
            // 
            // radioButton_refused
            // 
            radioButton_refused.AutoSize = true;
            radioButton_refused.FlatAppearance.BorderSize = 0;
            radioButton_refused.FlatStyle = FlatStyle.Flat;
            radioButton_refused.Location = new Point(196, 72);
            radioButton_refused.Name = "radioButton_refused";
            radioButton_refused.Size = new Size(66, 19);
            radioButton_refused.TabIndex = 20;
            radioButton_refused.Text = "Refused";
            radioButton_refused.UseVisualStyleBackColor = true;
            radioButton_refused.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton_done
            // 
            radioButton_done.AutoSize = true;
            radioButton_done.FlatAppearance.BorderSize = 0;
            radioButton_done.FlatStyle = FlatStyle.Flat;
            radioButton_done.Location = new Point(137, 72);
            radioButton_done.Name = "radioButton_done";
            radioButton_done.Size = new Size(52, 19);
            radioButton_done.TabIndex = 19;
            radioButton_done.Text = "Done";
            radioButton_done.UseVisualStyleBackColor = true;
            radioButton_done.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton_received
            // 
            radioButton_received.AutoSize = true;
            radioButton_received.FlatAppearance.BorderSize = 0;
            radioButton_received.FlatStyle = FlatStyle.Flat;
            radioButton_received.Location = new Point(59, 72);
            radioButton_received.Name = "radioButton_received";
            radioButton_received.Size = new Size(71, 19);
            radioButton_received.TabIndex = 18;
            radioButton_received.Text = "Received";
            radioButton_received.UseVisualStyleBackColor = true;
            radioButton_received.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton_all
            // 
            radioButton_all.AutoSize = true;
            radioButton_all.FlatAppearance.BorderSize = 0;
            radioButton_all.FlatStyle = FlatStyle.Flat;
            radioButton_all.Location = new Point(14, 72);
            radioButton_all.Name = "radioButton_all";
            radioButton_all.Size = new Size(38, 19);
            radioButton_all.TabIndex = 17;
            radioButton_all.Text = "All";
            radioButton_all.UseVisualStyleBackColor = true;
            radioButton_all.CheckedChanged += radioButton_CheckedChanged;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.Location = new Point(0, 97);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(574, 277);
            dataGridView.TabIndex = 16;
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
            button_close.Click += button_close_Click;
            // 
            // Devices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Rectangle_6;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 400);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Devices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Devices";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_close;
        private RadioButton radioButton_refused;
        private RadioButton radioButton_done;
        private RadioButton radioButton_received;
        private RadioButton radioButton_all;
        private DataGridView dataGridView;
        private RadioButton radioButton_delivered;
    }
}