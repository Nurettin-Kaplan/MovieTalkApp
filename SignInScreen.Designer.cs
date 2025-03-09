namespace MovieTalkApp
{
    partial class signInScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signInScreen));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            MTBoxPhone = new MaskedTextBox();
            label4 = new Label();
            TxtEmail = new TextBox();
            pictureBoxProfile = new PictureBox();
            BtnLoadPhoto = new Button();
            BtnSignIn = new Button();
            BtnBack = new Button();
            TxtPassword2 = new TextBox();
            label5 = new Label();
            LblInfo = new Label();
            LblUsernameErr = new Label();
            LblEmailErr = new Label();
            LblPhoneErr = new Label();
            LblPasswordErr = new Label();
            LblPassword2Err = new Label();
            LblUsernameInfo = new Label();
            LblEmailInfo = new Label();
            LblPhoneInfo = new Label();
            LblInfo2 = new Label();
            PBoxWievPassword = new PictureBox();
            PBoxWievPassword2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBoxWievPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBoxWievPassword2).BeginInit();
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
            panel1.Size = new Size(721, 138);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Movıe_TALK5;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(721, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 167);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // TxtUsername
            // 
            TxtUsername.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.Location = new Point(43, 202);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(306, 35);
            TxtUsername.TabIndex = 1;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(43, 446);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(306, 35);
            TxtPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 411);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 334);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 5;
            label3.Text = "Telefon";
            // 
            // MTBoxPhone
            // 
            MTBoxPhone.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MTBoxPhone.Location = new Point(43, 368);
            MTBoxPhone.Mask = "0000000000";
            MTBoxPhone.Name = "MTBoxPhone";
            MTBoxPhone.Size = new Size(306, 35);
            MTBoxPhone.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 253);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(43, 287);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(306, 35);
            TxtEmail.TabIndex = 2;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(446, 190);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(191, 197);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 11;
            pictureBoxProfile.TabStop = false;
            // 
            // BtnLoadPhoto
            // 
            BtnLoadPhoto.BackColor = Color.FromArgb(140, 6, 6);
            BtnLoadPhoto.FlatAppearance.BorderSize = 0;
            BtnLoadPhoto.FlatStyle = FlatStyle.Flat;
            BtnLoadPhoto.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLoadPhoto.ForeColor = Color.White;
            BtnLoadPhoto.Location = new Point(481, 419);
            BtnLoadPhoto.Name = "BtnLoadPhoto";
            BtnLoadPhoto.Size = new Size(109, 62);
            BtnLoadPhoto.TabIndex = 6;
            BtnLoadPhoto.Text = "Fotoğraf Yükle";
            BtnLoadPhoto.UseVisualStyleBackColor = false;
            BtnLoadPhoto.Click += BtnLoadPhoto_Click;
            // 
            // BtnSignIn
            // 
            BtnSignIn.BackColor = Color.FromArgb(140, 6, 6);
            BtnSignIn.FlatAppearance.BorderSize = 0;
            BtnSignIn.FlatStyle = FlatStyle.Flat;
            BtnSignIn.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSignIn.ForeColor = Color.White;
            BtnSignIn.Location = new Point(240, 588);
            BtnSignIn.Name = "BtnSignIn";
            BtnSignIn.Size = new Size(109, 62);
            BtnSignIn.TabIndex = 7;
            BtnSignIn.Text = "Kayıt Ol";
            BtnSignIn.UseVisualStyleBackColor = false;
            BtnSignIn.Click += BtnSignIn_Click;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.FromArgb(140, 6, 6);
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack.ForeColor = Color.White;
            BtnBack.Location = new Point(43, 588);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(109, 62);
            BtnBack.TabIndex = 8;
            BtnBack.Text = "Geri";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // TxtPassword2
            // 
            TxtPassword2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword2.Location = new Point(43, 529);
            TxtPassword2.Name = "TxtPassword2";
            TxtPassword2.PasswordChar = '●';
            TxtPassword2.Size = new Size(306, 35);
            TxtPassword2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 494);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 12;
            label5.Text = "Şifre (Tekrar)";
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblInfo.ForeColor = Color.Red;
            LblInfo.Location = new Point(43, 687);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(0, 23);
            LblInfo.TabIndex = 13;
            // 
            // LblUsernameErr
            // 
            LblUsernameErr.AutoSize = true;
            LblUsernameErr.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsernameErr.ForeColor = Color.Red;
            LblUsernameErr.Location = new Point(355, 205);
            LblUsernameErr.Name = "LblUsernameErr";
            LblUsernameErr.Size = new Size(0, 28);
            LblUsernameErr.TabIndex = 14;
            // 
            // LblEmailErr
            // 
            LblEmailErr.AutoSize = true;
            LblEmailErr.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmailErr.ForeColor = Color.Red;
            LblEmailErr.Location = new Point(355, 290);
            LblEmailErr.Name = "LblEmailErr";
            LblEmailErr.Size = new Size(0, 28);
            LblEmailErr.TabIndex = 15;
            // 
            // LblPhoneErr
            // 
            LblPhoneErr.AutoSize = true;
            LblPhoneErr.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblPhoneErr.ForeColor = Color.Red;
            LblPhoneErr.Location = new Point(355, 371);
            LblPhoneErr.Name = "LblPhoneErr";
            LblPhoneErr.Size = new Size(0, 28);
            LblPhoneErr.TabIndex = 16;
            // 
            // LblPasswordErr
            // 
            LblPasswordErr.AutoSize = true;
            LblPasswordErr.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblPasswordErr.ForeColor = Color.Red;
            LblPasswordErr.Location = new Point(355, 449);
            LblPasswordErr.Name = "LblPasswordErr";
            LblPasswordErr.Size = new Size(0, 28);
            LblPasswordErr.TabIndex = 17;
            // 
            // LblPassword2Err
            // 
            LblPassword2Err.AutoSize = true;
            LblPassword2Err.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblPassword2Err.ForeColor = Color.Red;
            LblPassword2Err.Location = new Point(355, 532);
            LblPassword2Err.Name = "LblPassword2Err";
            LblPassword2Err.Size = new Size(0, 28);
            LblPassword2Err.TabIndex = 18;
            // 
            // LblUsernameInfo
            // 
            LblUsernameInfo.AutoSize = true;
            LblUsernameInfo.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsernameInfo.ForeColor = Color.Red;
            LblUsernameInfo.Location = new Point(400, 553);
            LblUsernameInfo.Name = "LblUsernameInfo";
            LblUsernameInfo.Size = new Size(0, 23);
            LblUsernameInfo.TabIndex = 19;
            // 
            // LblEmailInfo
            // 
            LblEmailInfo.AutoSize = true;
            LblEmailInfo.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmailInfo.ForeColor = Color.Red;
            LblEmailInfo.Location = new Point(400, 608);
            LblEmailInfo.Name = "LblEmailInfo";
            LblEmailInfo.Size = new Size(0, 23);
            LblEmailInfo.TabIndex = 20;
            // 
            // LblPhoneInfo
            // 
            LblPhoneInfo.AutoSize = true;
            LblPhoneInfo.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblPhoneInfo.ForeColor = Color.Red;
            LblPhoneInfo.Location = new Point(400, 668);
            LblPhoneInfo.Name = "LblPhoneInfo";
            LblPhoneInfo.Size = new Size(0, 23);
            LblPhoneInfo.TabIndex = 21;
            // 
            // LblInfo2
            // 
            LblInfo2.AutoSize = true;
            LblInfo2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblInfo2.ForeColor = Color.Lime;
            LblInfo2.Location = new Point(152, 687);
            LblInfo2.Name = "LblInfo2";
            LblInfo2.Size = new Size(0, 23);
            LblInfo2.TabIndex = 22;
            // 
            // PBoxWievPassword
            // 
            PBoxWievPassword.BackColor = Color.White;
            PBoxWievPassword.BorderStyle = BorderStyle.FixedSingle;
            PBoxWievPassword.Image = Properties.Resources.wievPassword;
            PBoxWievPassword.Location = new Point(314, 446);
            PBoxWievPassword.Name = "PBoxWievPassword";
            PBoxWievPassword.Size = new Size(35, 35);
            PBoxWievPassword.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxWievPassword.TabIndex = 23;
            PBoxWievPassword.TabStop = false;
            PBoxWievPassword.MouseDown += PBoxWievPassword_MouseDown;
            PBoxWievPassword.MouseUp += PBoxWievPassword_MouseUp;
            // 
            // PBoxWievPassword2
            // 
            PBoxWievPassword2.BackColor = Color.White;
            PBoxWievPassword2.BorderStyle = BorderStyle.FixedSingle;
            PBoxWievPassword2.Image = Properties.Resources.wievPassword;
            PBoxWievPassword2.Location = new Point(314, 529);
            PBoxWievPassword2.Name = "PBoxWievPassword2";
            PBoxWievPassword2.Size = new Size(35, 35);
            PBoxWievPassword2.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxWievPassword2.TabIndex = 24;
            PBoxWievPassword2.TabStop = false;
            PBoxWievPassword2.MouseDown += PBoxWievPassword2_MouseDown;
            PBoxWievPassword2.MouseUp += PBoxWievPassword2_MouseUp;
            // 
            // signInScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(721, 736);
            Controls.Add(PBoxWievPassword2);
            Controls.Add(PBoxWievPassword);
            Controls.Add(LblInfo2);
            Controls.Add(LblPhoneInfo);
            Controls.Add(LblEmailInfo);
            Controls.Add(LblUsernameInfo);
            Controls.Add(LblPassword2Err);
            Controls.Add(LblPasswordErr);
            Controls.Add(LblPhoneErr);
            Controls.Add(LblEmailErr);
            Controls.Add(LblUsernameErr);
            Controls.Add(LblInfo);
            Controls.Add(TxtPassword2);
            Controls.Add(label5);
            Controls.Add(BtnBack);
            Controls.Add(BtnSignIn);
            Controls.Add(BtnLoadPhoto);
            Controls.Add(pictureBoxProfile);
            Controls.Add(TxtEmail);
            Controls.Add(label4);
            Controls.Add(MTBoxPhone);
            Controls.Add(label3);
            Controls.Add(TxtPassword);
            Controls.Add(label2);
            Controls.Add(TxtUsername);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "signInScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ekranı";
            FormClosing += signInScreen_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBoxWievPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBoxWievPassword2).EndInit();
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
        private Label label3;
        private MaskedTextBox MTBoxPhone;
        private Label label4;
        private TextBox TxtEmail;
        private PictureBox pictureBoxProfile;
        private Button BtnLoadPhoto;
        private Button BtnSignIn;
        private Button BtnBack;
        private TextBox TxtPassword2;
        private Label label5;
        private Label LblInfo;
        private Label LblUsernameErr;
        private Label LblEmailErr;
        private Label LblPhoneErr;
        private Label LblPasswordErr;
        private Label LblPassword2Err;
        private Label LblUsernameInfo;
        private Label LblEmailInfo;
        private Label LblPhoneInfo;
        private Label LblInfo2;
        private PictureBox PBoxWievPassword;
        private PictureBox PBoxWievPassword2;
    }
}