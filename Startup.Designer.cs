namespace Donna
{
    partial class Startup
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label3 = new Label();
            label_vr = new Label();
            label_startup = new Label();
            timer = new System.Windows.Forms.Timer(components);
            label_per = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 57);
            label2.Name = "label2";
            label2.Size = new Size(118, 37);
            label2.TabIndex = 1;
            label2.Text = "DONNA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(91, 40);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 2;
            label3.Text = "Starting up";
            // 
            // label_vr
            // 
            label_vr.AutoSize = true;
            label_vr.BackColor = Color.Transparent;
            label_vr.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_vr.Location = new Point(97, 94);
            label_vr.Name = "label_vr";
            label_vr.Size = new Size(55, 17);
            label_vr.TabIndex = 3;
            label_vr.Text = "v 0.0.0.0";
            // 
            // label_startup
            // 
            label_startup.AutoSize = true;
            label_startup.BackColor = Color.Transparent;
            label_startup.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_startup.Location = new Point(57, 124);
            label_startup.Name = "label_startup";
            label_startup.Size = new Size(116, 17);
            label_startup.TabIndex = 4;
            label_startup.Text = "starting up Donna...";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // label_per
            // 
            label_per.AutoSize = true;
            label_per.BackColor = Color.Transparent;
            label_per.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_per.Location = new Point(12, 124);
            label_per.Name = "label_per";
            label_per.Size = new Size(25, 17);
            label_per.TabIndex = 5;
            label_per.Text = "0%";
            label_per.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Startup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Rectangle_6;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(250, 150);
            Controls.Add(label_per);
            Controls.Add(label_startup);
            Controls.Add(label_vr);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Startup";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Startup";
            TopMost = true;
            Load += Startup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label_vr;
        private Label label_startup;
        private System.Windows.Forms.Timer timer;
        private Label label_per;
    }
}