namespace MovieTalkApp
{
    partial class AddUserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserScreen));
            label5 = new Label();
            BtnToList = new Button();
            BtnToAdd = new Button();
            BtnLoadPhoto = new Button();
            pictureBoxProfile = new PictureBox();
            TxtEmail = new TextBox();
            label4 = new Label();
            MTBoxPhone = new MaskedTextBox();
            label3 = new Label();
            TxtPassword = new TextBox();
            label2 = new Label();
            TxtUsername = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            DGViewUsers = new DataGridView();
            MTBoxAuthor = new MaskedTextBox();
            TxtProfileUrl = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGViewUsers).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 632);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(293, 23);
            label5.TabIndex = 39;
            label5.Text = "Yetki (Admin = 1 / Kullanıcı = 0 )";
            // 
            // BtnToList
            // 
            BtnToList.BackColor = Color.FromArgb(140, 6, 6);
            BtnToList.Cursor = Cursors.Hand;
            BtnToList.FlatAppearance.BorderSize = 0;
            BtnToList.FlatStyle = FlatStyle.Flat;
            BtnToList.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToList.ForeColor = Color.White;
            BtnToList.Location = new Point(37, 733);
            BtnToList.Name = "BtnToList";
            BtnToList.Size = new Size(123, 62);
            BtnToList.TabIndex = 37;
            BtnToList.Text = "Listele";
            BtnToList.UseVisualStyleBackColor = false;
            BtnToList.Click += BtnToList_Click;
            // 
            // BtnToAdd
            // 
            BtnToAdd.BackColor = Color.FromArgb(140, 6, 6);
            BtnToAdd.Cursor = Cursors.Hand;
            BtnToAdd.FlatAppearance.BorderSize = 0;
            BtnToAdd.FlatStyle = FlatStyle.Flat;
            BtnToAdd.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToAdd.ForeColor = Color.White;
            BtnToAdd.Location = new Point(258, 733);
            BtnToAdd.Name = "BtnToAdd";
            BtnToAdd.Size = new Size(123, 62);
            BtnToAdd.TabIndex = 35;
            BtnToAdd.Text = "Ekle";
            BtnToAdd.UseVisualStyleBackColor = false;
            BtnToAdd.Click += BtnToAdd_Click;
            // 
            // BtnLoadPhoto
            // 
            BtnLoadPhoto.BackColor = Color.FromArgb(140, 6, 6);
            BtnLoadPhoto.Cursor = Cursors.Hand;
            BtnLoadPhoto.FlatAppearance.BorderSize = 0;
            BtnLoadPhoto.FlatStyle = FlatStyle.Flat;
            BtnLoadPhoto.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLoadPhoto.ForeColor = Color.White;
            BtnLoadPhoto.Location = new Point(258, 107);
            BtnLoadPhoto.Name = "BtnLoadPhoto";
            BtnLoadPhoto.Size = new Size(123, 62);
            BtnLoadPhoto.TabIndex = 34;
            BtnLoadPhoto.Text = "Fotoğraf Yükle";
            BtnLoadPhoto.UseVisualStyleBackColor = false;
            BtnLoadPhoto.Click += BtnLoadPhoto_Click;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(37, 76);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(123, 122);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 38;
            pictureBoxProfile.TabStop = false;
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(37, 420);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(344, 35);
            TxtEmail.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 386);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 36;
            label4.Text = "Email";
            // 
            // MTBoxPhone
            // 
            MTBoxPhone.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MTBoxPhone.Location = new Point(37, 506);
            MTBoxPhone.Mask = "0000000000";
            MTBoxPhone.Name = "MTBoxPhone";
            MTBoxPhone.Size = new Size(344, 35);
            MTBoxPhone.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 472);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 32;
            label3.Text = "Telefon";
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.Location = new Point(37, 584);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(344, 35);
            TxtPassword.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 549);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 29;
            label2.Text = "Şifre";
            // 
            // TxtUsername
            // 
            TxtUsername.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsername.Location = new Point(37, 339);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(344, 35);
            TxtUsername.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 304);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 27;
            label1.Text = "Kullanıcı Adı";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(140, 6, 6);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1767, 52);
            panel1.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Right;
            label6.Font = new Font("Yu Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1270, 0);
            label6.Name = "label6";
            label6.Size = new Size(497, 60);
            label6.TabIndex = 1;
            label6.Text = "KULLANICI EKLEME";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Movıe_TALK7;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DGViewUsers
            // 
            DGViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGViewUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGViewUsers.BackgroundColor = Color.FromArgb(28, 28, 28);
            DGViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGViewUsers.GridColor = Color.FromArgb(28, 28, 28);
            DGViewUsers.Location = new Point(416, 76);
            DGViewUsers.Name = "DGViewUsers";
            DGViewUsers.RowHeadersWidth = 51;
            DGViewUsers.RowTemplate.Height = 29;
            DGViewUsers.Size = new Size(1320, 719);
            DGViewUsers.TabIndex = 53;
            DGViewUsers.CellClick += DGViewUsers_CellClick;
            // 
            // MTBoxAuthor
            // 
            MTBoxAuthor.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MTBoxAuthor.Location = new Point(37, 668);
            MTBoxAuthor.Mask = "0";
            MTBoxAuthor.Name = "MTBoxAuthor";
            MTBoxAuthor.Size = new Size(344, 35);
            MTBoxAuthor.TabIndex = 54;
            // 
            // TxtProfileUrl
            // 
            TxtProfileUrl.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtProfileUrl.Location = new Point(37, 256);
            TxtProfileUrl.Name = "TxtProfileUrl";
            TxtProfileUrl.Size = new Size(344, 35);
            TxtProfileUrl.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(37, 221);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 23);
            label7.TabIndex = 56;
            label7.Text = "Fotoğraf Url";
            // 
            // AddUserScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1767, 820);
            Controls.Add(TxtProfileUrl);
            Controls.Add(label7);
            Controls.Add(MTBoxAuthor);
            Controls.Add(DGViewUsers);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(BtnToList);
            Controls.Add(BtnToAdd);
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
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUserScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Ekleme Ekranı";
            Load += AddUserScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button BtnToList;
        private Button BtnToAdd;
        private Button BtnLoadPhoto;
        private PictureBox pictureBoxProfile;
        private TextBox TxtEmail;
        private Label label4;
        private MaskedTextBox MTBoxPhone;
        private Label label3;
        private TextBox TxtPassword;
        private Label label2;
        private TextBox TxtUsername;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private PictureBox pictureBox1;
        private DataGridView DGViewUsers;
        private MaskedTextBox MTBoxAuthor;
        private TextBox TxtProfileUrl;
        private Label label7;
    }
}