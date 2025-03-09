using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace MovieTalkApp
{
    public partial class MovieDetailsScreen : Form
    {
        public MovieDetailsScreen()
        {
            InitializeComponent();
        }

        public string imagePath = "";
        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");
        Movie movie = new Movie();

        private void CreateMovie(string idData)
        {
            try
            {
                int movieID = Convert.ToInt16(idData);

                connection.Open();
                string query = "select * from Movies where MovieID=@movieid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@movieid", movieID);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    movie.Id = Convert.ToInt32(reader["MovieID"]);
                    movie.PosterImage = reader["PosterImage"].ToString();
                    movie.Title = reader["Title"].ToString();
                    movie.MovieDescription = reader["MovieDescription"].ToString();
                    movie.ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]);
                    movie.Genre = reader["Genre"].ToString();
                    movie.Director = reader["Director"].ToString();
                }
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Güncellenecek olan kullanıcının ID alanı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnToList_Click(object sender, EventArgs e)
        {
            string query = "select * from Movies";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            connection.Open();
            adapter.Fill(table);

            DGWievMoviesDetails.DataSource = table;

            connection.Close();
        }

        private void BtnLoadPicture_Click(object sender, EventArgs e)
        {
            // OpenFileDialog oluştur
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Yalnızca resim dosyalarını filtrele
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Kullanıcı bir dosya seçerse
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen dosyayı PictureBox'a yükle
                pictureBoxMovie.Image = Image.FromFile(openFileDialog.FileName);
                imagePath = openFileDialog.FileName;    // yüklenen dosyanın yolunu atadım
            }
        }

        private void DGWievfMoviesDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // sadece veri satırına tıklanırsa çalışır
            {
                DataGridViewRow row = DGWievMoviesDetails.Rows[e.RowIndex];

                // veriyi TxtMovieID alanına aktardım
                TxtMovieID.Text = row.Cells["MovieID"].Value.ToString();

                imagePath = row.Cells["PosterImage"].Value.ToString();

                // Eğer imagePath boş değilse, URL veya dosya yolu olabilir
                if (!string.IsNullOrEmpty(imagePath))
                {
                    TxtPosterUrl.Text = imagePath;  // URL'yi TextBox'a aktar

                    try
                    {
                        // URL'den resim yükle
                        pictureBoxMovie.Load(imagePath);  // Bu, URL veya geçerli dosya yolunu yükler
                    }
                    catch (Exception)
                    {
                        pictureBoxMovie.Image = null;  // Hata durumunda resmi temizle
                    }
                }
                else
                {
                    pictureBoxMovie.Image = null;  // imagePath yoksa resmi temizle
                }

                TxtTitle.Text = row.Cells["Title"].Value.ToString();
                RTxtDescription.Text = row.Cells["MovieDescription"].Value.ToString();

                // tarih formatını düzgün bir şekilde ayarlama
                if (row.Cells["ReleaseDate"].Value != DBNull.Value)
                {
                    DTimeRelease.Text = Convert.ToDateTime(row.Cells["ReleaseDate"].Value).ToString("yyyy-MM-dd");
                }

                string selectedGenre = row.Cells["Genre"].Value.ToString(); // 'Genre' sütununu seçiyoruz
                CMBoxGenre.SelectedItem = selectedGenre;  // ComboBox'a aktar
                TxtDirector.Text = row.Cells["Director"].Value.ToString();
            }
        }

        private void MovieDetailsScreen_Load(object sender, EventArgs e)
        {
            DGWievMoviesDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGWievMoviesDetails.MultiSelect = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CreateMovie(TxtMovieID.Text);

            if (TxtMovieID.Text == "")
            {
                MessageBox.Show("Güncellenecek olan filmin id numarası boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.Open();
                string query2 = "update Movies set PosterImage=@posterImage, Title=@title, MovieDescription=@description, ReleaseDate=@date, Genre=@genre," +
                "Director=@director where MovieID=@movieId";
                SqlCommand command = new SqlCommand(query2, connection);

                command.Parameters.AddWithValue("@movieId", movie.Id);

                if (imagePath == "")
                {
                    command.Parameters.AddWithValue("@posterImage", movie.PosterImage);
                }
                else
                {
                    command.Parameters.AddWithValue("@posterImage", imagePath);
                }
                if (TxtTitle.Text == "")
                {
                    command.Parameters.AddWithValue("@title", movie.Title);
                }
                else
                {
                    command.Parameters.AddWithValue("@title", TxtTitle.Text);
                }
                if (RTxtDescription.Text == "")
                {
                    command.Parameters.AddWithValue("@description", movie.MovieDescription);
                }
                else
                {
                    command.Parameters.AddWithValue("@description", RTxtDescription.Text);
                }
                if (DTimeRelease.Text == "")
                {
                    command.Parameters.AddWithValue("@date", movie.ReleaseDate);
                }
                else
                {
                    command.Parameters.AddWithValue("@date", Convert.ToDateTime(DTimeRelease.Text));
                }
                if (CMBoxGenre.Text == "")
                {
                    command.Parameters.AddWithValue("@genre", movie.Genre);
                }
                else
                {
                    command.Parameters.AddWithValue("@genre", CMBoxGenre.Text);
                }
                if (TxtDirector.Text == "")
                {
                    command.Parameters.AddWithValue("@director", movie.Director);
                }
                else
                {
                    command.Parameters.AddWithValue("@director", TxtDirector.Text);
                }
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
