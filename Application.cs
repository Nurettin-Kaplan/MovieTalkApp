using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace MovieTalkApp
{
    public partial class Application : Form
    {
        public string username = "";
        User user = new User();
        public Application(string data)
        {
            InitializeComponent();
            username = data;
        }

        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");

        private void CreateUser(User user)
        {
            connection.Open();
            string query = "select * from Users where Username=@username";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                user.Id = Convert.ToInt16(reader["UserID"]);
                user.ImagePath = reader["ProfilePicture"].ToString();
                user.Username = reader["Username"].ToString();
                user.Email = reader["Email"].ToString();
                user.Phone = reader["Phone"].ToString();
                user.UserPassword = reader["UserPassword"].ToString();
                user.CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);
                user.Author = reader["Author"].ToString();
            }
            connection.Close();
        }

        private void HideAllPanels()
        {
            PanelAdmin.Visible = false;
            FlowMoviePanel.Visible = false;
            FLayoutHomePanel.Visible = false;
            CategoryPanel.Visible = false;
            MessagePanel.Visible = false;
            AccountPanel.Visible = false;
            FSearchPanel.Visible = false;
        }

        private void Application_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Application_Load(object sender, EventArgs e)
        {
            HideAllPanels();
            BtnHome.PerformClick();
            CreateUser(user);

            PBoxProfilePhoto.Load(user.ImagePath);
            LblUserName.Text = user.Username;

            if (user.Id == 1)
            {
                BtnAdmin.Visible = true;
            }
            else
            {
                BtnAdmin.Visible = false;
            }
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            PanelAdmin.Visible = true;
        }

        private void BtnToList_Click(object sender, EventArgs e)
        {
            string query2 = "select UserID, Username, UserPassword, CreatedAt from Users";
            SqlCommand command2 = new SqlCommand(query2, connection);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            DataTable table2 = new DataTable();

            connection.Open();
            adapter2.Fill(table2);

            DGWievUsers.DataSource = table2;

            connection.Close();
        }

        private void BtnToDetails_Click(object sender, EventArgs e)
        {
            UserDetailsScreen userDetails = new UserDetailsScreen();
            userDetails.Owner = this;
            userDetails.Show();
        }

        private void BtnToAdd_Click(object sender, EventArgs e)
        {
            AddUserScreen addUser = new AddUserScreen();
            addUser.Owner = this;
            addUser.Show();
        }

        private void BtnToDelete_Click(object sender, EventArgs e)
        {
            DeleteUserScreen deleteUser = new DeleteUserScreen();
            deleteUser.Owner = this;
            deleteUser.Show();
        }

        private void BtnToList2_Click(object sender, EventArgs e)
        {
            string query3 = "select MovieID, Title, ReleaseDate from Movies";
            SqlCommand command3 = new SqlCommand(query3, connection);
            SqlDataAdapter adapter3 = new SqlDataAdapter(command3);
            DataTable table3 = new DataTable();

            connection.Open();
            adapter3.Fill(table3);

            DGWievMovies.DataSource = table3;

            connection.Close();
        }

        private void BtnToUpdate2_Click(object sender, EventArgs e)
        {
            MovieDetailsScreen movieDetails = new MovieDetailsScreen();
            movieDetails.Owner = this;
            movieDetails.Show();
        }

        private void BtnToAdd2_Click(object sender, EventArgs e)
        {
            AddMovieScreen addMovie = new AddMovieScreen();
            addMovie.Owner = this;
            addMovie.Show();
        }

        private void BtnToDelete2_Click(object sender, EventArgs e)
        {
            DeleteMovieScreen deleteMovie = new DeleteMovieScreen();
            deleteMovie.Owner = this;
            deleteMovie.Show();
        }

        private void BtnMovie_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            FlowMoviePanel.Visible = true;
            FlowMoviePanel.Controls.Clear();
            LoadMovie();
        }

        private void LoadMovie()
        {
            string query = "select PosterImage, title from Movies";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string picture = reader["PosterImage"].ToString();
                string movieName = reader["Title"].ToString();
                AddMovieToPanel(picture, movieName);
            }

            connection.Close();
        }

        private void AddMovieToPanel(string moviePictureUrl, string movieTitle)
        {
            Panel moviePanel = new Panel
            {
                Size = new Size(250, 400),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(12)
            };

            // Týklama olayýný merkezi olarak tanýmlýyoruz
            EventHandler clickHandler = (sender, e) =>
            {
                ShowMovieDetails movieDetails = new ShowMovieDetails(movieTitle, user);
                movieDetails.Owner = this;
                movieDetails.Show();
            };

            // Panel için týklama olayý
            moviePanel.Click += clickHandler;

            // Panelin üzerine gelindiðinde fare iþaretçisinin el þekline dönmesini saðlýyoruz
            moviePanel.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
            moviePanel.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(230, 325),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(10, 10)
            };

            try
            {
                pictureBox.Load(moviePictureUrl);
            }
            catch
            {
                pictureBox.Image = null;
            }

            pictureBox.Click += clickHandler;

            pictureBox.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
            pictureBox.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

            Label label = new Label
            {
                Text = movieTitle,
                AutoSize = false,
                Size = new Size(moviePanel.Width - 20, 50),
                Location = new Point((moviePanel.Width - (moviePanel.Width - 20)) / 2, 340),
                Font = new Font("Tahoma", 11, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter
            };

            label.Click += clickHandler;

            label.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
            label.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

            moviePanel.Controls.Add(pictureBox);
            moviePanel.Controls.Add(label);

            FlowMoviePanel.Controls.Add(moviePanel);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            FLayoutHomePanel.Visible = true;

            // FlowLayoutPanel'deki önceki öðeleri temizleyelim
            FLayoutHomePanel.Controls.Clear();

            // "En Çok Beðenilenler" baþlýðýný ekleyelim
            Label LblBestRated = new Label
            {
                Text = "EN ÇOK BEÐENÝLENLER TOP 5!",
                Font = new Font("Tahoma", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Margin = new Padding(10)
            };
            FLayoutHomePanel.Controls.Add(LblBestRated);

            // "En Çok Beðenilenler" filmleri listeleme
            ListMovies("select top 5 Title, PosterImage, avg(Rating) as AverageRating from Movies m join Reviews r on m.MovieID = r.MovieID group by Title, PosterImage order by AverageRating desc");

            // Yeni bir boþ satýr ekleyelim
            FLayoutHomePanel.Controls.Add(new Label() { Text = "", AutoSize = true });

            // "Deðerlendirilmeyenler" baþlýðýný ekleyelim
            Label LblUnrated = new Label
            {
                Text = "ÝLK SEN DEÐERLENDÝR!",
                Font = new Font("Tahoma", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Margin = new Padding(10)
            };
            FLayoutHomePanel.Controls.Add(LblUnrated);

            // "Deðerlendirilmeyenler" filmleri listeleme
            ListMovies("select top 5 Title, PosterImage from Movies where MovieID not in (select MovieID from Reviews)");
        }

        private void ListMovies(string query)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            // Filmleri eklemek için bir panel oluþturuyoruz
            FlowLayoutPanel moviePanelContainer = new FlowLayoutPanel
            {
                WrapContents = true,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            while (reader.Read())
            {
                // Film bilgilerini alýyoruz
                string title = reader["Title"].ToString();
                string imagePath = reader["PosterImage"].ToString();

                Panel moviePanel = new Panel
                {
                    Size = new Size(250, 400),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(12)
                };

                // Týklama olayýný merkezi olarak tanýmlýyoruz
                EventHandler clickHandler = (sender, e) =>
                {
                    ShowMovieDetails movieDetails = new ShowMovieDetails(title, user);
                    movieDetails.Owner = this;
                    movieDetails.Show();
                };

                // Panel için týklama olayý
                moviePanel.Click += clickHandler;

                // Panelin üzerine gelindiðinde fare iþaretçisinin el þekline dönmesini saðlýyoruz
                moviePanel.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
                moviePanel.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(230, 325),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(10, 10)
                };

                try
                {
                    pictureBox.Load(imagePath);
                }
                catch
                {
                    pictureBox.Image = null;
                }

                pictureBox.Click += clickHandler;

                pictureBox.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
                pictureBox.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

                Label label = new Label
                {
                    Text = title,
                    AutoSize = false,
                    Size = new Size(moviePanel.Width - 20, 50),
                    Location = new Point((moviePanel.Width - (moviePanel.Width - 20)) / 2, 340),
                    Font = new Font("Tahoma", 11, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                label.Click += clickHandler;

                label.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
                label.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

                moviePanel.Controls.Add(pictureBox);
                moviePanel.Controls.Add(label);

                moviePanelContainer.Controls.Add(moviePanel);
            }

            // Filmleri barýndýran paneli, FLayoutPanel'e ekliyoruz
            FLayoutHomePanel.Controls.Add(moviePanelContainer);

            connection.Close();
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            CategoryPanel.Visible = true;
        }

        private void LBoxGenre_DoubleClick(object sender, EventArgs e)
        {
            FLayoutCatOfMovie.Controls.Clear();

            int isFind = 0;
            // çift týklanan elemanýn indeksini al
            int index = LBoxGenre.SelectedIndex;

            // Seçilen elemanýn deðerini bir deðiþkene ata
            string selectedGenre = LBoxGenre.Items[index].ToString();

            connection.Open();
            string query = "select * from Movies where Genre=@genre";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@genre", selectedGenre);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                isFind++;
                // Film bilgilerini alýyoruz
                string title = reader["Title"].ToString();
                string imagePath = reader["PosterImage"].ToString();

                Panel moviePanel = new Panel
                {
                    Size = new Size(250, 400),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(12)
                };

                // Týklama olayýný merkezi olarak tanýmlýyoruz
                EventHandler clickHandler = (sender, e) =>
                {
                    ShowMovieDetails movieDetails = new ShowMovieDetails(title, user);
                    movieDetails.Owner = this;
                    movieDetails.Show();
                };

                // Panel için týklama olayý
                moviePanel.Click += clickHandler;

                // Panelin üzerine gelindiðinde fare iþaretçisinin el þekline dönmesini saðlýyoruz
                moviePanel.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
                moviePanel.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(230, 325),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(10, 10)
                };

                try
                {
                    pictureBox.Load(imagePath);
                }
                catch
                {
                    pictureBox.Image = null;
                }

                pictureBox.Click += clickHandler;

                pictureBox.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
                pictureBox.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

                Label label = new Label
                {
                    Text = title,
                    AutoSize = false,
                    Size = new Size(moviePanel.Width - 20, 50),
                    Location = new Point((moviePanel.Width - (moviePanel.Width - 20)) / 2, 340),
                    Font = new Font("Tahoma", 11, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                label.Click += clickHandler;

                label.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
                label.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

                moviePanel.Controls.Add(pictureBox);
                moviePanel.Controls.Add(label);

                FLayoutCatOfMovie.Controls.Add(moviePanel);
            }
            connection.Close();
            if (isFind == 0)
            {
                Label LblFind = new Label
                {
                    Text = "ARANAN KATEGORÝDE FÝLM BULUNAMADI!",
                    Font = new Font("Tahoma", 14, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = true,
                    Margin = new Padding(10)
                };
                FLayoutCatOfMovie.Controls.Add(LblFind);
            }
        }

        private void BtnMessage_MouseEnter(object sender, EventArgs e)
        {
            MessagePanel.Visible = true;
        }

        private void BtnMessage_MouseLeave(object sender, EventArgs e)
        {
            if (!MessagePanel.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                if (!PBoxMessage.Bounds.Contains(PointToClient(Cursor.Position)))
                {
                    if (!RTxtMessage.Bounds.Contains(PointToClient(Cursor.Position)))
                    {
                        if (!LblMessage.Bounds.Contains(PointToClient(Cursor.Position)))
                        {
                            MessagePanel.Visible = false;
                        }
                    }
                }

            }
        }

        private void MessagePanel_MouseLeave(object sender, EventArgs e)
        {
            if (!MessagePanel.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                if (!PBoxMessage.Bounds.Contains(PointToClient(Cursor.Position)))
                {
                    if (!RTxtMessage.Bounds.Contains(PointToClient(Cursor.Position)))
                    {
                        if (!LblMessage.Bounds.Contains(PointToClient(Cursor.Position)))
                        {
                            MessagePanel.Visible = false;
                        }
                    }
                }
            }
        }

        private void BtnProfile_MouseEnter(object sender, EventArgs e)
        {
            AccountPanel.Visible = true;
        }

        private void BtnProfile_MouseLeave(object sender, EventArgs e)
        {
            if (!AccountPanel.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                if (!PBoxProfilePhoto.Bounds.Contains(PointToClient(Cursor.Position)))
                {
                    if (!LblUserName.Bounds.Contains(PointToClient(Cursor.Position)))
                    {
                        if (!BtnLogout.Bounds.Contains(PointToClient(Cursor.Position)))
                        {
                            AccountPanel.Visible = false;
                        }
                    }
                }
            }
        }

        private void AccountPanel_MouseLeave(object sender, EventArgs e)
        {
            if (!AccountPanel.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                if (!PBoxProfilePhoto.Bounds.Contains(PointToClient(Cursor.Position)))
                {
                    if (!LblUserName.Bounds.Contains(PointToClient(Cursor.Position)))
                    {
                        if (!BtnLogout.Bounds.Contains(PointToClient(Cursor.Position)))
                        {
                            AccountPanel.Visible = false;
                        }
                    }
                }
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            HideAllPanels();
            FSearchPanel.Controls.Clear();
            FSearchPanel.Visible = true;

            string searchString = TxtSearch.Text;

            // SQL baðlantýsý ve sorgusu
            string query = "SELECT * FROM Movies WHERE Title LIKE @string"; // LIKE kullanarak arama yap

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@string", "%" + searchString + "%");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string title = reader["Title"].ToString();
                string imagePath = reader["PosterImage"].ToString();

                Panel moviePanel = new Panel
                {
                    Size = new Size(250, 400),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(12)
                };

                // Týklama olayýný merkezi olarak tanýmlýyoruz
                EventHandler clickHandler = (sender, e) =>
                {
                    ShowMovieDetails movieDetails = new ShowMovieDetails(title, user);
                    movieDetails.Owner = this;
                    movieDetails.Show();
                };

                // Panel için týklama olayý
                moviePanel.Click += clickHandler;

                // Panelin üzerine gelindiðinde fare iþaretçisinin el þekline dönmesini saðlýyoruz
                moviePanel.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
                moviePanel.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(230, 325),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(10, 10)
                };

                try
                {
                    pictureBox.Load(imagePath);
                }
                catch
                {
                    pictureBox.Image = null;
                }

                pictureBox.Click += clickHandler;

                pictureBox.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
                pictureBox.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

                Label label = new Label
                {
                    Text = title,
                    AutoSize = false,
                    Size = new Size(moviePanel.Width - 20, 50),
                    Location = new Point((moviePanel.Width - (moviePanel.Width - 20)) / 2, 340),
                    Font = new Font("Tahoma", 11, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                label.Click += clickHandler;

                label.MouseEnter += (sender, e) => moviePanel.Cursor = Cursors.Hand;
                label.MouseLeave += (sender, e) => moviePanel.Cursor = Cursors.Default;

                moviePanel.Controls.Add(pictureBox);
                moviePanel.Controls.Add(label);

                FSearchPanel.Controls.Add(moviePanel);
            }
            connection.Close();
        }
    }
}