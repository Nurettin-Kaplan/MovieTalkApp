namespace MovieTalkApp
{
    partial class AdminLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginScreen));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            label2 = new Label();
            BtnLogin = new Button();
            BtnBack = new Button();
            LblInfo = new Label();
            PBoxWievPassword = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBoxWievPassword).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(140, 6, 6);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 140);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Movıe_TALK4;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 234);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // TxtUsername
            // 
            TxtUsername.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.Location = new Point(50, 269);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(304, 35);
            TxtUsername.TabIndex = 1;
            TxtUsername.Text = "nurettinkaplan";
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(50, 352);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(304, 35);
            TxtPassword.TabIndex = 2;
            TxtPassword.Text = "123456";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 318);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(140, 6, 6);
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(245, 411);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(109, 62);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "Giriş Yap";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.FromArgb(140, 6, 6);
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack.ForeColor = Color.White;
            BtnBack.Location = new Point(50, 411);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(109, 62);
            BtnBack.TabIndex = 4;
            BtnBack.Text = "Geri";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblInfo.ForeColor = Color.Red;
            LblInfo.Location = new Point(50, 502);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(0, 23);
            LblInfo.TabIndex = 8;
            // 
            // PBoxWievPassword
            // 
            PBoxWievPassword.BackColor = Color.White;
            PBoxWievPassword.BorderStyle = BorderStyle.FixedSingle;
            PBoxWievPassword.Image = Properties.Resources.wievPassword;
            PBoxWievPassword.Location = new Point(319, 352);
            PBoxWievPassword.Name = "PBoxWievPassword";
            PBoxWievPassword.Size = new Size(35, 35);
            PBoxWievPassword.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxWievPassword.TabIndex = 15;
            PBoxWievPassword.TabStop = false;
            PBoxWievPassword.MouseDown += PBoxWievPassword_MouseDown;
            PBoxWievPassword.MouseUp += PBoxWievPassword_MouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(95, 171);
            label3.Name = "label3";
            label3.Size = new Size(208, 36);
            label3.TabIndex = 16;
            label3.Text = "ADMİN GİRİŞİ";
            // 
            // AdminLoginScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(398, 553);
            Controls.Add(label3);
            Controls.Add(PBoxWievPassword);
            Controls.Add(LblInfo);
            Controls.Add(BtnBack);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(label2);
            Controls.Add(TxtUsername);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "AdminLoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Girişi";
            FormClosing += AdminLoginScreen_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBoxWievPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Label label2;
        private Button BtnLogin;
        private Button BtnBack;
        private Label LblInfo;
        private PictureBox PBoxWievPassword;
        private Label label3;
    }
}