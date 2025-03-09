namespace MovieTalkApp
{
    partial class Application
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            MenuPanel = new Panel();
            pictureBox2 = new PictureBox();
            TxtSearch = new TextBox();
            BtnAdmin = new Button();
            BtnCategory = new Button();
            BtnMessage = new Button();
            BtnProfile = new Button();
            BtnMovie = new Button();
            BtnHome = new Button();
            pictureBox1 = new PictureBox();
            AccountPanel = new Panel();
            BtnLogout = new Button();
            LblUserName = new Label();
            PBoxProfilePhoto = new PictureBox();
            MessagePanel = new Panel();
            LblMessage = new Label();
            RTxtMessage = new RichTextBox();
            PBoxMessage = new PictureBox();
            PanelAdmin = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BtnToDetails = new Button();
            BtnToDelete = new Button();
            BtnToAdd = new Button();
            BtnToList = new Button();
            DGWievUsers = new DataGridView();
            tabPage2 = new TabPage();
            BtnToUpdate2 = new Button();
            BtnToDelete2 = new Button();
            BtnToAdd2 = new Button();
            BtnToList2 = new Button();
            DGWievMovies = new DataGridView();
            FlowMoviePanel = new FlowLayoutPanel();
            FLayoutHomePanel = new FlowLayoutPanel();
            CategoryPanel = new Panel();
            FLayoutCatOfMovie = new FlowLayoutPanel();
            LBoxGenre = new ListBox();
            FSearchPanel = new FlowLayoutPanel();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            AccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxProfilePhoto).BeginInit();
            MessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxMessage).BeginInit();
            PanelAdmin.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGWievUsers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGWievMovies).BeginInit();
            CategoryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(140, 6, 6);
            MenuPanel.Controls.Add(pictureBox2);
            MenuPanel.Controls.Add(TxtSearch);
            MenuPanel.Controls.Add(BtnAdmin);
            MenuPanel.Controls.Add(BtnCategory);
            MenuPanel.Controls.Add(BtnMessage);
            MenuPanel.Controls.Add(BtnProfile);
            MenuPanel.Controls.Add(BtnMovie);
            MenuPanel.Controls.Add(BtnHome);
            MenuPanel.Controls.Add(pictureBox1);
            MenuPanel.Dock = DockStyle.Top;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(1399, 105);
            MenuPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(730, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(768, 38);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Film Arayın";
            TxtSearch.Size = new Size(284, 29);
            TxtSearch.TabIndex = 9;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // BtnAdmin
            // 
            BtnAdmin.Dock = DockStyle.Left;
            BtnAdmin.FlatAppearance.BorderSize = 0;
            BtnAdmin.FlatStyle = FlatStyle.Flat;
            BtnAdmin.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAdmin.ForeColor = Color.White;
            BtnAdmin.Location = new Point(519, 0);
            BtnAdmin.Name = "BtnAdmin";
            BtnAdmin.Size = new Size(119, 105);
            BtnAdmin.TabIndex = 6;
            BtnAdmin.Text = "Yönetim";
            BtnAdmin.UseVisualStyleBackColor = true;
            BtnAdmin.Click += BtnAdmin_Click;
            // 
            // BtnCategory
            // 
            BtnCategory.Dock = DockStyle.Left;
            BtnCategory.FlatAppearance.BorderSize = 0;
            BtnCategory.FlatStyle = FlatStyle.Flat;
            BtnCategory.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCategory.ForeColor = Color.White;
            BtnCategory.Location = new Point(400, 0);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new Size(119, 105);
            BtnCategory.TabIndex = 8;
            BtnCategory.Text = "Kategoriler";
            BtnCategory.UseVisualStyleBackColor = true;
            BtnCategory.Click += BtnCategory_Click;
            // 
            // BtnMessage
            // 
            BtnMessage.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMessage.Dock = DockStyle.Right;
            BtnMessage.FlatAppearance.BorderSize = 0;
            BtnMessage.FlatStyle = FlatStyle.Flat;
            BtnMessage.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMessage.ForeColor = Color.White;
            BtnMessage.Location = new Point(1190, 0);
            BtnMessage.Name = "BtnMessage";
            BtnMessage.Size = new Size(90, 105);
            BtnMessage.TabIndex = 5;
            BtnMessage.Text = "Mesaj Kutusu";
            BtnMessage.UseVisualStyleBackColor = true;
            BtnMessage.MouseEnter += BtnMessage_MouseEnter;
            BtnMessage.MouseLeave += BtnMessage_MouseLeave;
            // 
            // BtnProfile
            // 
            BtnProfile.Dock = DockStyle.Right;
            BtnProfile.FlatAppearance.BorderSize = 0;
            BtnProfile.FlatStyle = FlatStyle.Flat;
            BtnProfile.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnProfile.ForeColor = Color.White;
            BtnProfile.Location = new Point(1280, 0);
            BtnProfile.Name = "BtnProfile";
            BtnProfile.Size = new Size(119, 105);
            BtnProfile.TabIndex = 4;
            BtnProfile.Text = "Hesabım";
            BtnProfile.UseVisualStyleBackColor = true;
            BtnProfile.MouseEnter += BtnProfile_MouseEnter;
            BtnProfile.MouseLeave += BtnProfile_MouseLeave;
            // 
            // BtnMovie
            // 
            BtnMovie.Dock = DockStyle.Left;
            BtnMovie.FlatAppearance.BorderSize = 0;
            BtnMovie.FlatStyle = FlatStyle.Flat;
            BtnMovie.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMovie.ForeColor = Color.White;
            BtnMovie.Location = new Point(281, 0);
            BtnMovie.Name = "BtnMovie";
            BtnMovie.Size = new Size(119, 105);
            BtnMovie.TabIndex = 2;
            BtnMovie.Text = "Filmler";
            BtnMovie.UseVisualStyleBackColor = true;
            BtnMovie.Click += BtnMovie_Click;
            // 
            // BtnHome
            // 
            BtnHome.BackColor = Color.FromArgb(140, 6, 6);
            BtnHome.Dock = DockStyle.Left;
            BtnHome.FlatAppearance.BorderColor = Color.Brown;
            BtnHome.FlatAppearance.BorderSize = 0;
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnHome.ForeColor = Color.White;
            BtnHome.Location = new Point(162, 0);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(119, 105);
            BtnHome.TabIndex = 1;
            BtnHome.Text = "Ana Sayfa";
            BtnHome.UseVisualStyleBackColor = false;
            BtnHome.Click += BtnHome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Movıe_TALK3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AccountPanel
            // 
            AccountPanel.BackColor = Color.FromArgb(140, 6, 6);
            AccountPanel.Controls.Add(BtnLogout);
            AccountPanel.Controls.Add(LblUserName);
            AccountPanel.Controls.Add(PBoxProfilePhoto);
            AccountPanel.Location = new Point(1283, 90);
            AccountPanel.Name = "AccountPanel";
            AccountPanel.Size = new Size(116, 291);
            AccountPanel.TabIndex = 11;
            AccountPanel.MouseLeave += AccountPanel_MouseLeave;
            // 
            // BtnLogout
            // 
            BtnLogout.FlatAppearance.BorderSize = 0;
            BtnLogout.FlatStyle = FlatStyle.Flat;
            BtnLogout.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogout.ForeColor = Color.White;
            BtnLogout.Location = new Point(0, 186);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(116, 71);
            BtnLogout.TabIndex = 11;
            BtnLogout.Text = "Çıkış Yap";
            BtnLogout.UseVisualStyleBackColor = true;
            BtnLogout.Click += BtnLogout_Click;
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblUserName.ForeColor = Color.White;
            LblUserName.Location = new Point(3, 144);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(0, 19);
            LblUserName.TabIndex = 1;
            // 
            // PBoxProfilePhoto
            // 
            PBoxProfilePhoto.Location = new Point(17, 24);
            PBoxProfilePhoto.Name = "PBoxProfilePhoto";
            PBoxProfilePhoto.Size = new Size(80, 100);
            PBoxProfilePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxProfilePhoto.TabIndex = 0;
            PBoxProfilePhoto.TabStop = false;
            // 
            // MessagePanel
            // 
            MessagePanel.BackColor = Color.FromArgb(140, 6, 6);
            MessagePanel.Controls.Add(LblMessage);
            MessagePanel.Controls.Add(RTxtMessage);
            MessagePanel.Controls.Add(PBoxMessage);
            MessagePanel.Location = new Point(931, 105);
            MessagePanel.Name = "MessagePanel";
            MessagePanel.Size = new Size(349, 143);
            MessagePanel.TabIndex = 0;
            MessagePanel.MouseLeave += MessagePanel_MouseLeave;
            // 
            // LblMessage
            // 
            LblMessage.AutoSize = true;
            LblMessage.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LblMessage.ForeColor = Color.White;
            LblMessage.Location = new Point(108, 13);
            LblMessage.Name = "LblMessage";
            LblMessage.Size = new Size(143, 23);
            LblMessage.TabIndex = 2;
            LblMessage.Text = "Movie Talk App";
            // 
            // RTxtMessage
            // 
            RTxtMessage.Location = new Point(108, 38);
            RTxtMessage.Name = "RTxtMessage";
            RTxtMessage.ReadOnly = true;
            RTxtMessage.Size = new Size(227, 86);
            RTxtMessage.TabIndex = 1;
            RTxtMessage.Text = "Değerli kullanıcılar, spoilerlı yorumlar Movie Talk App'in bu sürümünde yasaktır.";
            // 
            // PBoxMessage
            // 
            PBoxMessage.BorderStyle = BorderStyle.Fixed3D;
            PBoxMessage.Image = Properties.Resources.Movıe_TALK7;
            PBoxMessage.Location = new Point(13, 6);
            PBoxMessage.Name = "PBoxMessage";
            PBoxMessage.Size = new Size(78, 71);
            PBoxMessage.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxMessage.TabIndex = 0;
            PBoxMessage.TabStop = false;
            // 
            // PanelAdmin
            // 
            PanelAdmin.Controls.Add(tabControl1);
            PanelAdmin.Location = new Point(0, 105);
            PanelAdmin.Name = "PanelAdmin";
            PanelAdmin.Size = new Size(1399, 662);
            PanelAdmin.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(15, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1399, 662);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(28, 28, 28);
            tabPage1.Controls.Add(BtnToDetails);
            tabPage1.Controls.Add(BtnToDelete);
            tabPage1.Controls.Add(BtnToAdd);
            tabPage1.Controls.Add(BtnToList);
            tabPage1.Controls.Add(DGWievUsers);
            tabPage1.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1391, 626);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kullanıcı Yönetimi";
            // 
            // BtnToDetails
            // 
            BtnToDetails.BackColor = Color.FromArgb(140, 6, 6);
            BtnToDetails.Cursor = Cursors.Hand;
            BtnToDetails.FlatAppearance.BorderSize = 0;
            BtnToDetails.FlatStyle = FlatStyle.Flat;
            BtnToDetails.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToDetails.ForeColor = Color.White;
            BtnToDetails.Location = new Point(47, 455);
            BtnToDetails.Name = "BtnToDetails";
            BtnToDetails.Size = new Size(191, 81);
            BtnToDetails.TabIndex = 10;
            BtnToDetails.Text = "Detaylar";
            BtnToDetails.UseVisualStyleBackColor = false;
            BtnToDetails.Click += BtnToDetails_Click;
            // 
            // BtnToDelete
            // 
            BtnToDelete.BackColor = Color.FromArgb(140, 6, 6);
            BtnToDelete.Cursor = Cursors.Hand;
            BtnToDelete.FlatAppearance.BorderSize = 0;
            BtnToDelete.FlatStyle = FlatStyle.Flat;
            BtnToDelete.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToDelete.ForeColor = Color.White;
            BtnToDelete.Location = new Point(47, 333);
            BtnToDelete.Name = "BtnToDelete";
            BtnToDelete.Size = new Size(191, 81);
            BtnToDelete.TabIndex = 9;
            BtnToDelete.Text = "Sil";
            BtnToDelete.UseVisualStyleBackColor = false;
            BtnToDelete.Click += BtnToDelete_Click;
            // 
            // BtnToAdd
            // 
            BtnToAdd.BackColor = Color.FromArgb(140, 6, 6);
            BtnToAdd.Cursor = Cursors.Hand;
            BtnToAdd.FlatAppearance.BorderSize = 0;
            BtnToAdd.FlatStyle = FlatStyle.Flat;
            BtnToAdd.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToAdd.ForeColor = Color.White;
            BtnToAdd.Location = new Point(47, 207);
            BtnToAdd.Name = "BtnToAdd";
            BtnToAdd.Size = new Size(191, 81);
            BtnToAdd.TabIndex = 8;
            BtnToAdd.Text = "Ekle";
            BtnToAdd.UseVisualStyleBackColor = false;
            BtnToAdd.Click += BtnToAdd_Click;
            // 
            // BtnToList
            // 
            BtnToList.BackColor = Color.FromArgb(140, 6, 6);
            BtnToList.Cursor = Cursors.Hand;
            BtnToList.FlatAppearance.BorderSize = 0;
            BtnToList.FlatStyle = FlatStyle.Flat;
            BtnToList.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToList.ForeColor = Color.White;
            BtnToList.Location = new Point(47, 87);
            BtnToList.Name = "BtnToList";
            BtnToList.Size = new Size(191, 81);
            BtnToList.TabIndex = 7;
            BtnToList.Text = "Listele";
            BtnToList.UseVisualStyleBackColor = false;
            BtnToList.Click += BtnToList_Click;
            // 
            // DGWievUsers
            // 
            DGWievUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGWievUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGWievUsers.BackgroundColor = Color.FromArgb(28, 28, 28);
            DGWievUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWievUsers.GridColor = Color.FromArgb(28, 28, 28);
            DGWievUsers.Location = new Point(277, 39);
            DGWievUsers.Name = "DGWievUsers";
            DGWievUsers.RowHeadersWidth = 51;
            DGWievUsers.RowTemplate.Height = 29;
            DGWievUsers.Size = new Size(1082, 553);
            DGWievUsers.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(28, 28, 28);
            tabPage2.Controls.Add(BtnToUpdate2);
            tabPage2.Controls.Add(BtnToDelete2);
            tabPage2.Controls.Add(BtnToAdd2);
            tabPage2.Controls.Add(BtnToList2);
            tabPage2.Controls.Add(DGWievMovies);
            tabPage2.Font = new Font("Yu Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1391, 626);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Film Yönetimi";
            // 
            // BtnToUpdate2
            // 
            BtnToUpdate2.BackColor = Color.FromArgb(140, 6, 6);
            BtnToUpdate2.Cursor = Cursors.Hand;
            BtnToUpdate2.FlatAppearance.BorderSize = 0;
            BtnToUpdate2.FlatStyle = FlatStyle.Flat;
            BtnToUpdate2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToUpdate2.ForeColor = Color.White;
            BtnToUpdate2.Location = new Point(47, 453);
            BtnToUpdate2.Name = "BtnToUpdate2";
            BtnToUpdate2.Size = new Size(191, 81);
            BtnToUpdate2.TabIndex = 15;
            BtnToUpdate2.Text = "Detaylar";
            BtnToUpdate2.UseVisualStyleBackColor = false;
            BtnToUpdate2.Click += BtnToUpdate2_Click;
            // 
            // BtnToDelete2
            // 
            BtnToDelete2.BackColor = Color.FromArgb(140, 6, 6);
            BtnToDelete2.Cursor = Cursors.Hand;
            BtnToDelete2.FlatAppearance.BorderSize = 0;
            BtnToDelete2.FlatStyle = FlatStyle.Flat;
            BtnToDelete2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToDelete2.ForeColor = Color.White;
            BtnToDelete2.Location = new Point(47, 331);
            BtnToDelete2.Name = "BtnToDelete2";
            BtnToDelete2.Size = new Size(191, 81);
            BtnToDelete2.TabIndex = 14;
            BtnToDelete2.Text = "Sil";
            BtnToDelete2.UseVisualStyleBackColor = false;
            BtnToDelete2.Click += BtnToDelete2_Click;
            // 
            // BtnToAdd2
            // 
            BtnToAdd2.BackColor = Color.FromArgb(140, 6, 6);
            BtnToAdd2.Cursor = Cursors.Hand;
            BtnToAdd2.FlatAppearance.BorderSize = 0;
            BtnToAdd2.FlatStyle = FlatStyle.Flat;
            BtnToAdd2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToAdd2.ForeColor = Color.White;
            BtnToAdd2.Location = new Point(47, 205);
            BtnToAdd2.Name = "BtnToAdd2";
            BtnToAdd2.Size = new Size(191, 81);
            BtnToAdd2.TabIndex = 13;
            BtnToAdd2.Text = "Ekle";
            BtnToAdd2.UseVisualStyleBackColor = false;
            BtnToAdd2.Click += BtnToAdd2_Click;
            // 
            // BtnToList2
            // 
            BtnToList2.BackColor = Color.FromArgb(140, 6, 6);
            BtnToList2.Cursor = Cursors.Hand;
            BtnToList2.FlatAppearance.BorderSize = 0;
            BtnToList2.FlatStyle = FlatStyle.Flat;
            BtnToList2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToList2.ForeColor = Color.White;
            BtnToList2.Location = new Point(47, 85);
            BtnToList2.Name = "BtnToList2";
            BtnToList2.Size = new Size(191, 81);
            BtnToList2.TabIndex = 12;
            BtnToList2.Text = "Listele";
            BtnToList2.UseVisualStyleBackColor = false;
            BtnToList2.Click += BtnToList2_Click;
            // 
            // DGWievMovies
            // 
            DGWievMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGWievMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGWievMovies.BackgroundColor = Color.FromArgb(28, 28, 28);
            DGWievMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWievMovies.GridColor = Color.FromArgb(28, 28, 28);
            DGWievMovies.Location = new Point(277, 36);
            DGWievMovies.Name = "DGWievMovies";
            DGWievMovies.RowHeadersWidth = 51;
            DGWievMovies.RowTemplate.Height = 29;
            DGWievMovies.Size = new Size(1083, 553);
            DGWievMovies.TabIndex = 11;
            // 
            // FlowMoviePanel
            // 
            FlowMoviePanel.AutoScroll = true;
            FlowMoviePanel.Location = new Point(0, 105);
            FlowMoviePanel.Name = "FlowMoviePanel";
            FlowMoviePanel.Size = new Size(1399, 662);
            FlowMoviePanel.TabIndex = 1;
            // 
            // FLayoutHomePanel
            // 
            FLayoutHomePanel.AutoScroll = true;
            FLayoutHomePanel.FlowDirection = FlowDirection.TopDown;
            FLayoutHomePanel.Location = new Point(0, 105);
            FLayoutHomePanel.Name = "FLayoutHomePanel";
            FLayoutHomePanel.Size = new Size(1399, 662);
            FLayoutHomePanel.TabIndex = 0;
            // 
            // CategoryPanel
            // 
            CategoryPanel.Controls.Add(FLayoutCatOfMovie);
            CategoryPanel.Controls.Add(LBoxGenre);
            CategoryPanel.Location = new Point(0, 105);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.Size = new Size(1399, 662);
            CategoryPanel.TabIndex = 0;
            // 
            // FLayoutCatOfMovie
            // 
            FLayoutCatOfMovie.Location = new Point(248, 0);
            FLayoutCatOfMovie.Name = "FLayoutCatOfMovie";
            FLayoutCatOfMovie.Size = new Size(1151, 662);
            FLayoutCatOfMovie.TabIndex = 1;
            // 
            // LBoxGenre
            // 
            LBoxGenre.BackColor = Color.FromArgb(140, 6, 6);
            LBoxGenre.BorderStyle = BorderStyle.None;
            LBoxGenre.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LBoxGenre.ForeColor = Color.White;
            LBoxGenre.FormattingEnabled = true;
            LBoxGenre.ItemHeight = 28;
            LBoxGenre.Items.AddRange(new object[] { "Aksiyon", "Macera", "Drama", "Suç", "Komedi", "Bilim Kurgu", "Fantastik", "Gerilim", "Korku", "Romantik", "Biyografi", "Savaş", "Aksiyon - Macera ", "Aksiyon - Gerilim", "Aksiyon - Suç", "Macera - Fantastik", "Macera - Bilim Kurgu", "Drama - Suç ", "Drama - Romantik", "Drama - Biyografi", "Suç - Gerilim  ", "Suç - Drama", "Komedi - Romantik", "Komedi - Macera", "Bilim Kurgu - Fantastik", "Bilim Kurgu - Gerilim", "Fantastik - Macera", "Fantastik - Korku", "Gerilim - Korku", "Gerilim - Suç", "Korku - Fantastik", "Romantik - Komedi", "Romantik - Drama", "Biyografi - Savaş", "Savaş - Drama", "Savaş - Biyografi" });
            LBoxGenre.Location = new Point(0, 0);
            LBoxGenre.Name = "LBoxGenre";
            LBoxGenre.Size = new Size(246, 672);
            LBoxGenre.TabIndex = 0;
            LBoxGenre.DoubleClick += LBoxGenre_DoubleClick;
            // 
            // FSearchPanel
            // 
            FSearchPanel.AutoScroll = true;
            FSearchPanel.Location = new Point(0, 105);
            FSearchPanel.Name = "FSearchPanel";
            FSearchPanel.Size = new Size(1399, 662);
            FSearchPanel.TabIndex = 11;
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1399, 767);
            Controls.Add(FSearchPanel);
            Controls.Add(MenuPanel);
            Controls.Add(AccountPanel);
            Controls.Add(MessagePanel);
            Controls.Add(PanelAdmin);
            Controls.Add(CategoryPanel);
            Controls.Add(FLayoutHomePanel);
            Controls.Add(FlowMoviePanel);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Application";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Talk";
            FormClosing += Application_FormClosing;
            Load += Application_Load;
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            AccountPanel.ResumeLayout(false);
            AccountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxProfilePhoto).EndInit();
            MessagePanel.ResumeLayout(false);
            MessagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxMessage).EndInit();
            PanelAdmin.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGWievUsers).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGWievMovies).EndInit();
            CategoryPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Button BtnMessage;
        private Button BtnProfile;
        private Button BtnMovie;
        private Button BtnHome;
        private PictureBox pictureBox1;
        private Button BtnAdmin;
        private Panel PanelAdmin;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BtnToList;
        private DataGridView DGWievUsers;
        private Button BtnToDelete;
        private Button BtnToAdd;
        private Button BtnToDetails;
        private Button BtnToUpdate2;
        private Button BtnToDelete2;
        private Button BtnToAdd2;
        private Button BtnToList2;
        private DataGridView DGWievMovies;
        private FlowLayoutPanel FlowMoviePanel;
        private FlowLayoutPanel FLayoutHomePanel;
        private PictureBox pictureBox2;
        private TextBox TxtSearch;
        private Button BtnCategory;
        private Panel CategoryPanel;
        private ListBox LBoxGenre;
        private FlowLayoutPanel FLayoutCatOfMovie;
        private Panel MessagePanel;
        private Label LblMessage;
        private RichTextBox RTxtMessage;
        private PictureBox PBoxMessage;
        private Panel AccountPanel;
        private Button BtnLogout;
        private Label LblUserName;
        private PictureBox PBoxProfilePhoto;
        private FlowLayoutPanel FSearchPanel;
    }
}