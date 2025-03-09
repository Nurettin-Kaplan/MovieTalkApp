namespace MovieTalkApp
{
    partial class MovieDetailsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetailsScreen));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BtnLoadPicture = new Button();
            BtnUpdate = new Button();
            BtnToList = new Button();
            pictureBoxMovie = new PictureBox();
            TxtMovieID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            TxtTitle = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TxtPosterUrl = new TextBox();
            label5 = new Label();
            DGWievMoviesDetails = new DataGridView();
            DTimeRelease = new DateTimePicker();
            CMBoxGenre = new ComboBox();
            label6 = new Label();
            TxtDirector = new TextBox();
            RTxtDescription = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGWievMoviesDetails).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(140, 6, 6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1767, 52);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Yu Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1274, 0);
            label1.Name = "label1";
            label1.Size = new Size(493, 60);
            label1.TabIndex = 1;
            label1.Text = "FİLM GÜNCELLEME";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Movıe_TALK7;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnLoadPicture
            // 
            BtnLoadPicture.BackColor = Color.FromArgb(140, 6, 6);
            BtnLoadPicture.Cursor = Cursors.Hand;
            BtnLoadPicture.FlatAppearance.BorderSize = 0;
            BtnLoadPicture.FlatStyle = FlatStyle.Flat;
            BtnLoadPicture.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLoadPicture.ForeColor = Color.White;
            BtnLoadPicture.Location = new Point(251, 189);
            BtnLoadPicture.Name = "BtnLoadPicture";
            BtnLoadPicture.Size = new Size(123, 62);
            BtnLoadPicture.TabIndex = 89;
            BtnLoadPicture.Text = "Fotoğraf Yükle";
            BtnLoadPicture.UseVisualStyleBackColor = false;
            BtnLoadPicture.Click += BtnLoadPicture_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.FromArgb(140, 6, 6);
            BtnUpdate.Cursor = Cursors.Hand;
            BtnUpdate.FlatAppearance.BorderSize = 0;
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(251, 918);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(123, 62);
            BtnUpdate.TabIndex = 88;
            BtnUpdate.Text = "Güncelle";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnToList
            // 
            BtnToList.BackColor = Color.FromArgb(140, 6, 6);
            BtnToList.Cursor = Cursors.Hand;
            BtnToList.FlatAppearance.BorderSize = 0;
            BtnToList.FlatStyle = FlatStyle.Flat;
            BtnToList.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToList.ForeColor = Color.White;
            BtnToList.Location = new Point(30, 918);
            BtnToList.Name = "BtnToList";
            BtnToList.Size = new Size(123, 62);
            BtnToList.TabIndex = 87;
            BtnToList.Text = "Listele";
            BtnToList.UseVisualStyleBackColor = false;
            BtnToList.Click += BtnToList_Click;
            // 
            // pictureBoxMovie
            // 
            pictureBoxMovie.Location = new Point(30, 149);
            pictureBoxMovie.Margin = new Padding(2, 3, 2, 3);
            pictureBoxMovie.Name = "pictureBoxMovie";
            pictureBoxMovie.Size = new Size(140, 141);
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMovie.TabIndex = 86;
            pictureBoxMovie.TabStop = false;
            // 
            // TxtMovieID
            // 
            TxtMovieID.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMovieID.Location = new Point(30, 93);
            TxtMovieID.Margin = new Padding(2, 3, 2, 3);
            TxtMovieID.Name = "TxtMovieID";
            TxtMovieID.Size = new Size(344, 35);
            TxtMovieID.TabIndex = 85;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 63);
            label8.Name = "label8";
            label8.Size = new Size(72, 23);
            label8.TabIndex = 84;
            label8.Text = "Film ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 763);
            label7.Name = "label7";
            label7.Size = new Size(38, 23);
            label7.TabIndex = 82;
            label7.Text = "Tür";
            // 
            // TxtTitle
            // 
            TxtTitle.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTitle.Location = new Point(30, 422);
            TxtTitle.Margin = new Padding(2, 3, 2, 3);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(344, 35);
            TxtTitle.TabIndex = 76;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 393);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 81;
            label4.Text = "Film Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 472);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 80;
            label3.Text = "Konu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 687);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 77;
            label2.Text = "Çıkış Tarihi";
            // 
            // TxtPosterUrl
            // 
            TxtPosterUrl.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPosterUrl.Location = new Point(30, 339);
            TxtPosterUrl.Margin = new Padding(2, 3, 2, 3);
            TxtPosterUrl.Name = "TxtPosterUrl";
            TxtPosterUrl.Size = new Size(344, 35);
            TxtPosterUrl.TabIndex = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 309);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 74;
            label5.Text = "Poster URL";
            // 
            // DGWievMoviesDetails
            // 
            DGWievMoviesDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGWievMoviesDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGWievMoviesDetails.BackgroundColor = Color.FromArgb(28, 28, 28);
            DGWievMoviesDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWievMoviesDetails.GridColor = Color.FromArgb(28, 28, 28);
            DGWievMoviesDetails.Location = new Point(400, 83);
            DGWievMoviesDetails.Margin = new Padding(2, 3, 2, 3);
            DGWievMoviesDetails.Name = "DGWievMoviesDetails";
            DGWievMoviesDetails.RowHeadersWidth = 51;
            DGWievMoviesDetails.RowTemplate.Height = 29;
            DGWievMoviesDetails.Size = new Size(1339, 897);
            DGWievMoviesDetails.TabIndex = 73;
            DGWievMoviesDetails.CellClick += DGWievfMoviesDetails_CellClick;
            // 
            // DTimeRelease
            // 
            DTimeRelease.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DTimeRelease.Location = new Point(30, 713);
            DTimeRelease.Name = "DTimeRelease";
            DTimeRelease.Size = new Size(344, 35);
            DTimeRelease.TabIndex = 90;
            // 
            // CMBoxGenre
            // 
            CMBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            CMBoxGenre.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CMBoxGenre.FormattingEnabled = true;
            CMBoxGenre.Items.AddRange(new object[] { "Aksiyon", "Macera", "Drama", "Suç", "Komedi", "Bilim Kurgu", "Fantastik", "Gerilim", "Korku", "Romantik", "Biyografi", "Savaş", "Aksiyon - Macera ", "Aksiyon - Gerilim", "Aksiyon - Suç", "Macera - Fantastik", "Macera - Bilim Kurgu", "Drama - Suç ", "Drama - Romantik", "Drama - Biyografi", "Suç - Gerilim  ", "Suç - Drama", "Komedi - Romantik", "Komedi - Macera", "Bilim Kurgu - Fantastik", "Bilim Kurgu - Gerilim", "Fantastik - Macera", "Fantastik - Korku", "Gerilim - Korku", "Gerilim - Suç", "Korku - Fantastik", "Romantik - Komedi", "Romantik - Drama", "Biyografi - Savaş", "Savaş - Drama", "Savaş - Biyografi" });
            CMBoxGenre.Location = new Point(30, 789);
            CMBoxGenre.Name = "CMBoxGenre";
            CMBoxGenre.Size = new Size(344, 36);
            CMBoxGenre.TabIndex = 91;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 839);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 92;
            label6.Text = "Yönetmen";
            // 
            // TxtDirector
            // 
            TxtDirector.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDirector.Location = new Point(30, 865);
            TxtDirector.Margin = new Padding(2, 3, 2, 3);
            TxtDirector.Name = "TxtDirector";
            TxtDirector.Size = new Size(344, 35);
            TxtDirector.TabIndex = 94;
            // 
            // RTxtDescription
            // 
            RTxtDescription.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            RTxtDescription.Location = new Point(30, 498);
            RTxtDescription.Name = "RTxtDescription";
            RTxtDescription.Size = new Size(344, 173);
            RTxtDescription.TabIndex = 95;
            RTxtDescription.Text = "";
            // 
            // MovieDetailsScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1767, 1012);
            Controls.Add(RTxtDescription);
            Controls.Add(TxtDirector);
            Controls.Add(label6);
            Controls.Add(CMBoxGenre);
            Controls.Add(DTimeRelease);
            Controls.Add(BtnLoadPicture);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnToList);
            Controls.Add(pictureBoxMovie);
            Controls.Add(TxtMovieID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(TxtTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtPosterUrl);
            Controls.Add(label5);
            Controls.Add(DGWievMoviesDetails);
            Controls.Add(panel1);
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MovieDetailsScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Film Detay Ekranı";
            Load += MovieDetailsScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGWievMoviesDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button BtnLoadPicture;
        private Button BtnUpdate;
        private Button BtnToList;
        private PictureBox pictureBoxMovie;
        private TextBox TxtMovieID;
        private Label label8;
        private Label label7;
        private TextBox TxtTitle;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TxtPosterUrl;
        private Label label5;
        private DataGridView DGWievMoviesDetails;
        private DateTimePicker DTimeRelease;
        private ComboBox CMBoxGenre;
        private Label label6;
        private TextBox TxtDirector;
        private RichTextBox RTxtDescription;
    }
}