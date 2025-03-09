namespace MovieTalkApp
{
    partial class UserDetailsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetailsScreen));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            LblDetails = new Label();
            DGWievUsersDetails = new DataGridView();
            pictureBoxProfile = new PictureBox();
            TxtUserID = new TextBox();
            label8 = new Label();
            MTBoxAuthor = new MaskedTextBox();
            label7 = new Label();
            TxtEmail = new TextBox();
            label4 = new Label();
            MTBoxPhone = new MaskedTextBox();
            label3 = new Label();
            TxtPassword = new TextBox();
            label2 = new Label();
            TxtUsername = new TextBox();
            label1 = new Label();
            BtnToList = new Button();
            BtnUpdate = new Button();
            BtnLoadPicture = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGWievUsersDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(140, 6, 6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LblDetails);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1767, 45);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Movıe_TALK7;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LblDetails
            // 
            LblDetails.AutoSize = true;
            LblDetails.Dock = DockStyle.Right;
            LblDetails.Font = new Font("Yu Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LblDetails.ForeColor = Color.White;
            LblDetails.Location = new Point(1223, 0);
            LblDetails.Name = "LblDetails";
            LblDetails.Size = new Size(544, 52);
            LblDetails.TabIndex = 44;
            LblDetails.Text = "KULLANICI GÜNCELLEME";
            // 
            // DGWievUsersDetails
            // 
            DGWievUsersDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGWievUsersDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGWievUsersDetails.BackgroundColor = Color.FromArgb(28, 28, 28);
            DGWievUsersDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWievUsersDetails.GridColor = Color.FromArgb(28, 28, 28);
            DGWievUsersDetails.Location = new Point(397, 70);
            DGWievUsersDetails.Margin = new Padding(2, 3, 2, 3);
            DGWievUsersDetails.Name = "DGWievUsersDetails";
            DGWievUsersDetails.RowHeadersWidth = 51;
            DGWievUsersDetails.RowTemplate.Height = 29;
            DGWievUsersDetails.Size = new Size(1339, 619);
            DGWievUsersDetails.TabIndex = 1;
            DGWievUsersDetails.CellClick += DGWievUsersDetails_CellClick;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(27, 143);
            pictureBoxProfile.Margin = new Padding(2, 3, 2, 3);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(76, 67);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 69;
            pictureBoxProfile.TabStop = false;
            // 
            // TxtUserID
            // 
            TxtUserID.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUserID.Location = new Point(27, 87);
            TxtUserID.Margin = new Padding(2, 3, 2, 3);
            TxtUserID.Name = "TxtUserID";
            TxtUserID.Size = new Size(344, 35);
            TxtUserID.TabIndex = 67;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(27, 57);
            label8.Name = "label8";
            label8.Size = new Size(110, 23);
            label8.TabIndex = 66;
            label8.Text = "Kullanıcı ID";
            // 
            // MTBoxAuthor
            // 
            MTBoxAuthor.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MTBoxAuthor.Location = new Point(27, 575);
            MTBoxAuthor.Margin = new Padding(2, 3, 2, 3);
            MTBoxAuthor.Mask = "0";
            MTBoxAuthor.Name = "MTBoxAuthor";
            MTBoxAuthor.Size = new Size(344, 35);
            MTBoxAuthor.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(27, 549);
            label7.Name = "label7";
            label7.Size = new Size(293, 23);
            label7.TabIndex = 64;
            label7.Text = "Yetki (Admin = 1 / Kullanıcı = 0 )";
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(27, 329);
            TxtEmail.Margin = new Padding(2, 3, 2, 3);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(344, 35);
            TxtEmail.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 300);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 61;
            label4.Text = "Email";
            // 
            // MTBoxPhone
            // 
            MTBoxPhone.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MTBoxPhone.Location = new Point(27, 410);
            MTBoxPhone.Margin = new Padding(2, 3, 2, 3);
            MTBoxPhone.Mask = "0000000000";
            MTBoxPhone.Name = "MTBoxPhone";
            MTBoxPhone.Size = new Size(344, 35);
            MTBoxPhone.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 379);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 60;
            label3.Text = "Telefon";
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(27, 494);
            TxtPassword.Margin = new Padding(2, 3, 2, 3);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(344, 35);
            TxtPassword.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 463);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 57;
            label2.Text = "Şifre";
            // 
            // TxtUsername
            // 
            TxtUsername.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.Location = new Point(27, 246);
            TxtUsername.Margin = new Padding(2, 3, 2, 3);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(344, 35);
            TxtUsername.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 216);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 54;
            label1.Text = "Kullanıcı Adı";
            // 
            // BtnToList
            // 
            BtnToList.BackColor = Color.FromArgb(140, 6, 6);
            BtnToList.Cursor = Cursors.Hand;
            BtnToList.FlatAppearance.BorderSize = 0;
            BtnToList.FlatStyle = FlatStyle.Flat;
            BtnToList.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToList.ForeColor = Color.White;
            BtnToList.Location = new Point(27, 636);
            BtnToList.Name = "BtnToList";
            BtnToList.Size = new Size(123, 62);
            BtnToList.TabIndex = 70;
            BtnToList.Text = "Listele";
            BtnToList.UseVisualStyleBackColor = false;
            BtnToList.Click += BtnToList_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.FromArgb(140, 6, 6);
            BtnUpdate.Cursor = Cursors.Hand;
            BtnUpdate.FlatAppearance.BorderSize = 0;
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(248, 636);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(123, 62);
            BtnUpdate.TabIndex = 71;
            BtnUpdate.Text = "Güncelle";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnLoadPicture
            // 
            BtnLoadPicture.BackColor = Color.FromArgb(140, 6, 6);
            BtnLoadPicture.Cursor = Cursors.Hand;
            BtnLoadPicture.FlatAppearance.BorderSize = 0;
            BtnLoadPicture.FlatStyle = FlatStyle.Flat;
            BtnLoadPicture.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLoadPicture.ForeColor = Color.White;
            BtnLoadPicture.Location = new Point(248, 148);
            BtnLoadPicture.Name = "BtnLoadPicture";
            BtnLoadPicture.Size = new Size(123, 62);
            BtnLoadPicture.TabIndex = 72;
            BtnLoadPicture.Text = "Fotoğraf Yükle";
            BtnLoadPicture.UseVisualStyleBackColor = false;
            BtnLoadPicture.Click += BtnLoadPicture_Click;
            // 
            // UserDetailsScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1767, 723);
            Controls.Add(BtnLoadPicture);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnToList);
            Controls.Add(pictureBoxProfile);
            Controls.Add(TxtUserID);
            Controls.Add(label8);
            Controls.Add(MTBoxAuthor);
            Controls.Add(label7);
            Controls.Add(TxtEmail);
            Controls.Add(label4);
            Controls.Add(MTBoxPhone);
            Controls.Add(label3);
            Controls.Add(TxtPassword);
            Controls.Add(label2);
            Controls.Add(TxtUsername);
            Controls.Add(label1);
            Controls.Add(DGWievUsersDetails);
            Controls.Add(panel1);
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserDetailsScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Detayları";
            Load += UserDetailsScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGWievUsersDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView DGWievUsersDetails;
        private Label LblDetails;
        private PictureBox pictureBoxProfile;
        private TextBox TxtUserID;
        private Label label8;
        private MaskedTextBox MTBoxAuthor;
        private Label label7;
        private TextBox TxtEmail;
        private Label label4;
        private MaskedTextBox MTBoxPhone;
        private Label label3;
        private TextBox TxtPassword;
        private Label label2;
        private TextBox TxtUsername;
        private Label label1;
        private Button BtnToList;
        private Button BtnUpdate;
        private Button BtnLoadPicture;
    }
}