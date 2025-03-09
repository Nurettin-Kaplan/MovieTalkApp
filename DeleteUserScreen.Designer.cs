namespace MovieTalkApp
{
    partial class DeleteUserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUserScreen));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            DGViewUsers = new DataGridView();
            BtnToList = new Button();
            BtnToDelete = new Button();
            TxtUserID = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGViewUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(140, 6, 6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
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
            label1.Location = new Point(1318, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(449, 60);
            label1.TabIndex = 1;
            label1.Text = "KULLANICI SİLME";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Movıe_TALK7;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 52);
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
            DGViewUsers.Location = new Point(396, 81);
            DGViewUsers.Margin = new Padding(2, 3, 2, 3);
            DGViewUsers.Name = "DGViewUsers";
            DGViewUsers.RowHeadersWidth = 51;
            DGViewUsers.RowTemplate.Height = 29;
            DGViewUsers.Size = new Size(1337, 612);
            DGViewUsers.TabIndex = 56;
            DGViewUsers.CellClick += DGViewUsers_CellClick;
            // 
            // BtnToList
            // 
            BtnToList.BackColor = Color.FromArgb(140, 6, 6);
            BtnToList.Cursor = Cursors.Hand;
            BtnToList.FlatAppearance.BorderSize = 0;
            BtnToList.FlatStyle = FlatStyle.Flat;
            BtnToList.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToList.ForeColor = Color.White;
            BtnToList.Location = new Point(27, 631);
            BtnToList.Name = "BtnToList";
            BtnToList.Size = new Size(123, 62);
            BtnToList.TabIndex = 71;
            BtnToList.Text = "Listele";
            BtnToList.UseVisualStyleBackColor = false;
            BtnToList.Click += BtnToList_Click;
            // 
            // BtnToDelete
            // 
            BtnToDelete.BackColor = Color.FromArgb(140, 6, 6);
            BtnToDelete.Cursor = Cursors.Hand;
            BtnToDelete.FlatAppearance.BorderSize = 0;
            BtnToDelete.FlatStyle = FlatStyle.Flat;
            BtnToDelete.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnToDelete.ForeColor = Color.White;
            BtnToDelete.Location = new Point(248, 631);
            BtnToDelete.Name = "BtnToDelete";
            BtnToDelete.Size = new Size(123, 62);
            BtnToDelete.TabIndex = 72;
            BtnToDelete.Text = "Sil";
            BtnToDelete.UseVisualStyleBackColor = false;
            BtnToDelete.Click += BtnToDelete_Click;
            // 
            // TxtUserID
            // 
            TxtUserID.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUserID.Location = new Point(27, 119);
            TxtUserID.Margin = new Padding(2, 3, 2, 3);
            TxtUserID.Name = "TxtUserID";
            TxtUserID.Size = new Size(344, 35);
            TxtUserID.TabIndex = 74;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(27, 89);
            label8.Name = "label8";
            label8.Size = new Size(110, 23);
            label8.TabIndex = 73;
            label8.Text = "Kullanıcı ID";
            // 
            // DeleteUserScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1767, 723);
            Controls.Add(TxtUserID);
            Controls.Add(label8);
            Controls.Add(BtnToDelete);
            Controls.Add(BtnToList);
            Controls.Add(DGViewUsers);
            Controls.Add(panel1);
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "DeleteUserScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Silme Ekranı";
            Load += DeleteUserScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView DGViewUsers;
        private Button BtnToList1;
        private Button BtnToList;
        private Button BtnToDelete;
        private TextBox TxtUserID;
        private Label label8;
    }
}