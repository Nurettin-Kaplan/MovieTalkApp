namespace MovieTalkApp
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            TxtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            TxtPassword = new TextBox();
            BtnLogin = new Button();
            LinkLblRefPass = new LinkLabel();
            BtnSignIn = new Button();
            BtnAdminLogin = new Button();
            LblInfo = new Label();
            PBoxWievPassword = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBoxWievPassword).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(140, 6, 6);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 151);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Movıe_TALK3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.White;
            TxtUsername.BorderStyle = BorderStyle.FixedSingle;
            TxtUsername.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.Location = new Point(54, 474);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(329, 35);
            TxtUsername.TabIndex = 1;
            TxtUsername.Text = "sergen1903";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngegg__8_;
            pictureBox2.Location = new Point(110, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 222);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 440);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 520);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 5;
            label2.Text = "Şifre";
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.White;
            TxtPassword.BorderStyle = BorderStyle.FixedSingle;
            TxtPassword.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(54, 554);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.PlaceholderText = "kartal1903";
            TxtPassword.Size = new Size(329, 35);
            TxtPassword.TabIndex = 2;
            TxtPassword.Text = "kartal1903";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(140, 6, 6);
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(285, 640);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(109, 62);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Giriş Yap";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LinkLblRefPass
            // 
            LinkLblRefPass.AutoSize = true;
            LinkLblRefPass.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LinkLblRefPass.LinkColor = Color.FromArgb(140, 6, 6);
            LinkLblRefPass.Location = new Point(54, 601);
            LinkLblRefPass.Name = "LinkLblRefPass";
            LinkLblRefPass.Size = new Size(212, 23);
            LinkLblRefPass.TabIndex = 3;
            LinkLblRefPass.TabStop = true;
            LinkLblRefPass.Text = "Şifrenizi mi unuttunuz?";
            LinkLblRefPass.LinkClicked += LinkLblRefPass_LinkClicked;
            // 
            // BtnSignIn
            // 
            BtnSignIn.BackColor = Color.FromArgb(140, 6, 6);
            BtnSignIn.FlatAppearance.BorderSize = 0;
            BtnSignIn.FlatStyle = FlatStyle.Flat;
            BtnSignIn.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSignIn.ForeColor = Color.White;
            BtnSignIn.Location = new Point(170, 640);
            BtnSignIn.Name = "BtnSignIn";
            BtnSignIn.Size = new Size(109, 62);
            BtnSignIn.TabIndex = 5;
            BtnSignIn.Text = "Kayıt Ol";
            BtnSignIn.UseVisualStyleBackColor = false;
            BtnSignIn.Click += BtnSignIn_Click;
            // 
            // BtnAdminLogin
            // 
            BtnAdminLogin.BackColor = Color.FromArgb(140, 6, 6);
            BtnAdminLogin.FlatAppearance.BorderSize = 0;
            BtnAdminLogin.FlatStyle = FlatStyle.Flat;
            BtnAdminLogin.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAdminLogin.ForeColor = Color.White;
            BtnAdminLogin.Location = new Point(55, 640);
            BtnAdminLogin.Name = "BtnAdminLogin";
            BtnAdminLogin.Size = new Size(109, 62);
            BtnAdminLogin.TabIndex = 6;
            BtnAdminLogin.Text = "Admin Girişi";
            BtnAdminLogin.UseVisualStyleBackColor = false;
            BtnAdminLogin.Click += BtnAdminLogin_Click;
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblInfo.ForeColor = Color.Red;
            LblInfo.Location = new Point(55, 731);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(0, 23);
            LblInfo.TabIndex = 7;
            // 
            // PBoxWievPassword
            // 
            PBoxWievPassword.BackColor = Color.White;
            PBoxWievPassword.BorderStyle = BorderStyle.FixedSingle;
            PBoxWievPassword.Image = Properties.Resources.wievPassword;
            PBoxWievPassword.Location = new Point(348, 554);
            PBoxWievPassword.Name = "PBoxWievPassword";
            PBoxWievPassword.Size = new Size(35, 35);
            PBoxWievPassword.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxWievPassword.TabIndex = 9;
            PBoxWievPassword.TabStop = false;
            PBoxWievPassword.MouseDown += PBoxWievPassword_MouseDown;
            PBoxWievPassword.MouseUp += PBoxWievPassword_MouseUp;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(435, 813);
            Controls.Add(PBoxWievPassword);
            Controls.Add(LblInfo);
            Controls.Add(BtnAdminLogin);
            Controls.Add(BtnSignIn);
            Controls.Add(LinkLblRefPass);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(TxtUsername);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            FormClosing += LoginScreen_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBoxWievPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox TxtUsername;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox TxtPassword;
        private Button BtnLogin;
        private LinkLabel LinkLblRefPass;
        private Button BtnSignIn;
        private Button BtnAdminLogin;
        private Label LblInfo;
        private PictureBox PBoxWievPassword;
    }
}