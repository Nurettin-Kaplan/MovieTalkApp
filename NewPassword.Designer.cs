namespace MovieTalkApp
{
    partial class NewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPassword));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            TxtPassword = new TextBox();
            label2 = new Label();
            TxtPassword2 = new TextBox();
            label1 = new Label();
            BtnAccept = new Button();
            LblInfo = new Label();
            pictureBox2 = new PictureBox();
            LblUsername = new Label();
            PBoxWievPassword = new PictureBox();
            PBoxWievPassword2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 133);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Movıe_TALK7;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(466, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(84, 434);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(304, 35);
            TxtPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 399);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 7;
            label2.Text = "Şifre";
            // 
            // TxtPassword2
            // 
            TxtPassword2.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword2.Location = new Point(84, 527);
            TxtPassword2.Name = "TxtPassword2";
            TxtPassword2.PasswordChar = '●';
            TxtPassword2.Size = new Size(304, 35);
            TxtPassword2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 492);
            label1.Name = "label1";
            label1.Size = new Size(126, 23);
            label1.TabIndex = 9;
            label1.Text = "Şifre (Tekrar)";
            // 
            // BtnAccept
            // 
            BtnAccept.BackColor = Color.FromArgb(140, 6, 6);
            BtnAccept.FlatAppearance.BorderSize = 0;
            BtnAccept.FlatStyle = FlatStyle.Flat;
            BtnAccept.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAccept.ForeColor = Color.White;
            BtnAccept.Location = new Point(279, 633);
            BtnAccept.Name = "BtnAccept";
            BtnAccept.Size = new Size(109, 62);
            BtnAccept.TabIndex = 3;
            BtnAccept.Text = "Onayla";
            BtnAccept.UseVisualStyleBackColor = false;
            BtnAccept.Click += BtnAccept_Click;
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblInfo.ForeColor = Color.Red;
            LblInfo.Location = new Point(84, 588);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(0, 23);
            LblInfo.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(151, 170);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsername.ForeColor = Color.White;
            LblUsername.Location = new Point(151, 354);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(0, 28);
            LblUsername.TabIndex = 13;
            // 
            // PBoxWievPassword
            // 
            PBoxWievPassword.BackColor = Color.White;
            PBoxWievPassword.BorderStyle = BorderStyle.FixedSingle;
            PBoxWievPassword.Image = Properties.Resources.wievPassword;
            PBoxWievPassword.Location = new Point(353, 434);
            PBoxWievPassword.Name = "PBoxWievPassword";
            PBoxWievPassword.Size = new Size(35, 35);
            PBoxWievPassword.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxWievPassword.TabIndex = 14;
            PBoxWievPassword.TabStop = false;
            PBoxWievPassword.MouseDown += PBoxWievPassword_MouseDown;
            PBoxWievPassword.MouseUp += PBoxWievPassword_MouseUp;
            // 
            // PBoxWievPassword2
            // 
            PBoxWievPassword2.BackColor = Color.White;
            PBoxWievPassword2.BorderStyle = BorderStyle.FixedSingle;
            PBoxWievPassword2.Image = Properties.Resources.wievPassword;
            PBoxWievPassword2.Location = new Point(353, 527);
            PBoxWievPassword2.Name = "PBoxWievPassword2";
            PBoxWievPassword2.Size = new Size(35, 35);
            PBoxWievPassword2.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxWievPassword2.TabIndex = 15;
            PBoxWievPassword2.TabStop = false;
            PBoxWievPassword2.MouseDown += PBoxWievPassword2_MouseDown;
            PBoxWievPassword2.MouseUp += PBoxWievPassword2_MouseUp;
            // 
            // NewPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(466, 735);
            Controls.Add(PBoxWievPassword2);
            Controls.Add(PBoxWievPassword);
            Controls.Add(LblUsername);
            Controls.Add(pictureBox2);
            Controls.Add(LblInfo);
            Controls.Add(BtnAccept);
            Controls.Add(TxtPassword2);
            Controls.Add(label1);
            Controls.Add(TxtPassword);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "NewPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifreyi Değiştir";
            Load += NewPassword_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBoxWievPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBoxWievPassword2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox TxtPassword;
        private Label label2;
        private TextBox TxtPassword2;
        private Label label1;
        private Button BtnAccept;
        private Label LblInfo;
        private PictureBox pictureBox2;
        private Label LblUsername;
        private PictureBox PBoxWievPassword;
        private PictureBox PBoxWievPassword2;
    }
}