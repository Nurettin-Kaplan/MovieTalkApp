namespace MovieTalkApp
{
    partial class RefreshPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefreshPassword));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TxtEmail = new TextBox();
            label2 = new Label();
            TxtPhone = new TextBox();
            BtnSendCode = new Button();
            button1 = new Button();
            TxtUsername = new TextBox();
            label3 = new Label();
            LblInfo = new Label();
            label4 = new Label();
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
            panel1.Size = new Size(436, 132);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Movıe_TALK6;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 319);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = Color.White;
            TxtEmail.BorderStyle = BorderStyle.FixedSingle;
            TxtEmail.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(49, 353);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(329, 35);
            TxtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 410);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 7;
            label2.Text = "Telefon";
            // 
            // TxtPhone
            // 
            TxtPhone.BackColor = Color.White;
            TxtPhone.BorderStyle = BorderStyle.FixedSingle;
            TxtPhone.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPhone.Location = new Point(49, 444);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(329, 35);
            TxtPhone.TabIndex = 6;
            // 
            // BtnSendCode
            // 
            BtnSendCode.BackColor = Color.FromArgb(140, 6, 6);
            BtnSendCode.FlatAppearance.BorderSize = 0;
            BtnSendCode.FlatStyle = FlatStyle.Flat;
            BtnSendCode.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSendCode.ForeColor = Color.White;
            BtnSendCode.Location = new Point(269, 560);
            BtnSendCode.Name = "BtnSendCode";
            BtnSendCode.Size = new Size(109, 62);
            BtnSendCode.TabIndex = 8;
            BtnSendCode.Text = "Kod Gönder";
            BtnSendCode.UseVisualStyleBackColor = false;
            BtnSendCode.Click += BtnSendCode_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(140, 6, 6);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(49, 560);
            button1.Name = "button1";
            button1.Size = new Size(109, 62);
            button1.TabIndex = 9;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.White;
            TxtUsername.BorderStyle = BorderStyle.FixedSingle;
            TxtUsername.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.Location = new Point(49, 265);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(329, 35);
            TxtUsername.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(49, 231);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 11;
            label3.Text = "Kullanıcı Adı";
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblInfo.ForeColor = Color.Red;
            LblInfo.Location = new Point(28, 508);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(0, 23);
            LblInfo.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(89, 163);
            label4.Name = "label4";
            label4.Size = new Size(254, 36);
            label4.TabIndex = 13;
            label4.Text = "ŞİFRE YENİLEME";
            // 
            // RefreshPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(436, 663);
            Controls.Add(label4);
            Controls.Add(LblInfo);
            Controls.Add(TxtUsername);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(BtnSendCode);
            Controls.Add(TxtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(TxtPhone);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RefreshPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifre Yenileme Ekranı";
            FormClosing += RefreshPassword_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox TxtEmail;
        private Label label2;
        private TextBox TxtPhone;
        private Button BtnSendCode;
        private Button button1;
        private TextBox TxtUsername;
        private Label label3;
        private Label LblInfo;
        private Label label4;
    }
}