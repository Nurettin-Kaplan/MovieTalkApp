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
using Microsoft.VisualBasic.Devices;

namespace MovieTalkApp
{
    public partial class AddMovieScreen : Form
    {
        public AddMovieScreen()
        {
            InitializeComponent();
        }

        public string imagePath = "";
        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");

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

        public bool IsMovieNameEmpty()
        {
            if (TxtTitle.Text == "") // username text boxı boş ise çarpı koyuyorum.
            {
                MessageBox.Show("Film adı alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else  // değilse
            {
                connection.Open();
                string query = "select count(*) from Movies where Title=@title"; // kullanıcı adının alınıp alınmadığını kontrol ediyorum
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@title", TxtTitle.Text);
                int movieCount = (int)command.ExecuteScalar();

                if (movieCount > 0)      // kullanıcı adı db'de var ise bağlantıyı kapat false döndür
                {
                    connection.Close();
                    return false;
                }
                else
                {
                    connection.Close();     // kullanıcı adı db'de yok ise bağlantıyı kapat true döndür
                    return true;
                }
            }
            return true;    // fonksiyonun varsayılan dönüş değeri true'dur. fonksiyon geri dönüş değerinin verilmesi için ekledim
        }

        private void BtnToAdd_Click(object sender, EventArgs e)
        {
            bool isMovieNameEmpty = IsMovieNameEmpty();

            if (isMovieNameEmpty == false)
            {
                MessageBox.Show("Bu film adı kullanılıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                string query2 = "insert into Movies (PosterImage, Title, MovieDescription, ReleaseDate, Genre" +
                ", Director) values (@posterImage, @title, @movieDescription, @releaseDate" +
                ", @genre, @director)";
                SqlCommand command2 = new SqlCommand(query2, connection);

                if (imagePath != "")
                {
                    command2.Parameters.AddWithValue("@posterImage", TxtPosterUrl.Text);
                }
                else
                {
                    command2.Parameters.AddWithValue("@posterImage", imagePath);
                }

                command2.Parameters.AddWithValue("@title", TxtTitle.Text);
                command2.Parameters.AddWithValue("@movieDescription", RTxtDescription.Text);
                command2.Parameters.AddWithValue("@releaseDate", Convert.ToDateTime(DTimeRelease.Text));
                command2.Parameters.AddWithValue("@genre", CMBoxGenre.Text);
                command2.Parameters.AddWithValue("@director", TxtDirector.Text);
                command2.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DGWievMoviesDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // sadece veri satırına tıklanırsa çalışır
            {
                DataGridViewRow row = DGWievMoviesDetails.Rows[e.RowIndex];

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

        private void AddMovieScreen_Load(object sender, EventArgs e)
        {
            DGWievMoviesDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGWievMoviesDetails.MultiSelect = false;
        }
    }
}
