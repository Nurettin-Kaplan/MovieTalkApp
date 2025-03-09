namespace MovieTalkApp
{
    partial class DeleteMovieScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMovieScreen));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            TxtMovieID = new TextBox();
            label8 = new Label();
            BtnToDelete = new Button();
            BtnToList = new Button();
            DGViewMovies = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGViewMovies).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(140, 6, 6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
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
            label1.Location = new Point(1460, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 60);
            label1.TabIndex = 1;
            label1.Text = "FİLM SİLME";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Movıe_TALK7;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TxtMovieID
            // 
            TxtMovieID.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMovieID.Location = new Point(27, 120);
            TxtMovieID.Margin = new Padding(2, 3, 2, 3);
            TxtMovieID.Name = "TxtMovieID";
            TxtMovieID.Size = new Size(344, 35);
            TxtMovieID.TabIndex = 79;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(27, 90);
            label8.Name = "label8";
            label8.Size = new Size(110, 23);
            label8.TabIndex = 78;
            label8.Text = "Kullanıcı ID";
            // 
            // BtnToDelete
            // 
            BtnToDelete.BackColor = Color.FromArgb(140, 6, 6);
            BtnToDelete.Cursor = Cursors.Hand;
            BtnToDelete.FlatAppearance.BorderSize = 0;
            BtnToDelete.FlatStyle = FlatStyle.Flat;
            BtnToDelete.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToDelete.ForeColor = Color.White;
            BtnToDelete.Location = new Point(248, 632);
            BtnToDelete.Name = "BtnToDelete";
            BtnToDelete.Size = new Size(123, 62);
            BtnToDelete.TabIndex = 77;
            BtnToDelete.Text = "Sil";
            BtnToDelete.UseVisualStyleBackColor = false;
            BtnToDelete.Click += BtnToDelete_Click;
            // 
            // BtnToList
            // 
            BtnToList.BackColor = Color.FromArgb(140, 6, 6);
            BtnToList.Cursor = Cursors.Hand;
            BtnToList.FlatAppearance.BorderSize = 0;
            BtnToList.FlatStyle = FlatStyle.Flat;
            BtnToList.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToList.ForeColor = Color.White;
            BtnToList.Location = new Point(27, 632);
            BtnToList.Name = "BtnToList";
            BtnToList.Size = new Size(123, 62);
            BtnToList.TabIndex = 76;
            BtnToList.Text = "Listele";
            BtnToList.UseVisualStyleBackColor = false;
            BtnToList.Click += BtnToList_Click;
            // 
            // DGViewMovies
            // 
            DGViewMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGViewMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGViewMovies.BackgroundColor = Color.FromArgb(28, 28, 28);
            DGViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGViewMovies.GridColor = Color.FromArgb(28, 28, 28);
            DGViewMovies.Location = new Point(396, 82);
            DGViewMovies.Margin = new Padding(2, 3, 2, 3);
            DGViewMovies.Name = "DGViewMovies";
            DGViewMovies.RowHeadersWidth = 51;
            DGViewMovies.RowTemplate.Height = 29;
            DGViewMovies.Size = new Size(1337, 612);
            DGViewMovies.TabIndex = 75;
            DGViewMovies.CellClick += DGViewMovies_CellClick;
            // 
            // DeleteMovieScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1767, 723);
            Controls.Add(TxtMovieID);
            Controls.Add(label8);
            Controls.Add(BtnToDelete);
            Controls.Add(BtnToList);
            Controls.Add(DGViewMovies);
            Controls.Add(panel1);
            Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "DeleteMovieScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Film Silme Ekranı";
            Load += DeleteMovieScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGViewMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox TxtMovieID;
        private Label label8;
        private Button BtnToDelete;
        private Button BtnToList;
        private DataGridView DGViewMovies;
    }
}