namespace MovieTalkApp
{
    partial class MailCodeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailCodeScreen));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            LblCountdown = new Label();
            TxtCode = new TextBox();
            label1 = new Label();
            BtnAccept = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(140, 6, 6);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Movıe_TALK6;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // LblCountdown
            // 
            LblCountdown.AutoSize = true;
            LblCountdown.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LblCountdown.ForeColor = Color.FromArgb(140, 6, 6);
            LblCountdown.Location = new Point(95, 188);
            LblCountdown.Name = "LblCountdown";
            LblCountdown.Size = new Size(187, 77);
            LblCountdown.TabIndex = 1;
            LblCountdown.Text = "02:00";
            // 
            // TxtCode
            // 
            TxtCode.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCode.Location = new Point(38, 337);
            TxtCode.Name = "TxtCode";
            TxtCode.Size = new Size(304, 35);
            TxtCode.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 302);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 3;
            label1.Text = "Kodu Girin";
            // 
            // BtnAccept
            // 
            BtnAccept.BackColor = Color.FromArgb(140, 6, 6);
            BtnAccept.FlatAppearance.BorderSize = 0;
            BtnAccept.FlatStyle = FlatStyle.Flat;
            BtnAccept.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAccept.ForeColor = Color.White;
            BtnAccept.Location = new Point(233, 405);
            BtnAccept.Name = "BtnAccept";
            BtnAccept.Size = new Size(109, 62);
            BtnAccept.TabIndex = 4;
            BtnAccept.Text = "Onayla";
            BtnAccept.UseVisualStyleBackColor = false;
            BtnAccept.Click += BtnAccept_Click;
            // 
            // MailCodeScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(382, 505);
            Controls.Add(BtnAccept);
            Controls.Add(TxtCode);
            Controls.Add(label1);
            Controls.Add(LblCountdown);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MailCodeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kod Onayı";
            Load += MailCodeScreen_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label LblCountdown;
        private TextBox TxtCode;
        private Label label1;
        private Button BtnAccept;
    }
}