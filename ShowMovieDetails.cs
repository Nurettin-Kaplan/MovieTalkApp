using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using System.Data.SqlClient;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection;
using System.Net;

namespace MovieTalkApp
{
    public partial class ShowMovieDetails : Form
    {
        private string imagePath = "";
        private string title = "";
        internal User user;
        int movieID = 0;
        private int star = 0;
        private int rate = 0;
        private Image filledStarImage;
        private Image emptyStarImage;

        internal ShowMovieDetails(string data1, User data2)
        {
            InitializeComponent();
            title = data1;

            user = new User();
            user = data2;
        }

        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");
        WebClient client = new WebClient();

        private void ShowMovieDetails_Load(object sender, EventArgs e)
        {
            client.Headers.Add("User-Agent", "MovieTalkApp (movietalkapplication@gmail.com)");

            VotesCalculate();

            movieID = GetIDMovie(title);

            filledStarImage = Image.FromFile("C:\\MovieTalkApp\\star.png");
            emptyStarImage = Image.FromFile("C:\\MovieTalkApp\\Star-empty.png");

            this.Text = title + " Film Yorumları";

            string query = "select * from Movies where Title=@movieName";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@movieName", title);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                imagePath = reader["PosterImage"].ToString();
                PBoxMovie.Load(imagePath);
                LblTitle.Text = reader["Title"].ToString();
                LblDescription.Text = reader["MovieDescription"].ToString();
                LblDate.Text = reader["ReleaseDate"].ToString();
                LblGenre.Text = reader["Genre"].ToString();
                LblDirector.Text = reader["Director"].ToString();
            }
            connection.Close();

            PBoxProfilePicture.Load(user.ImagePath);

            if (Convert.ToInt16(user.Author) == 1)
            {
                LblAdmin.Visible = true;
            }
            else
            {
                LblAdmin.Visible = false;
            }

            // yapılmış olan yorumları listele
            ListComments();
        }

        private void PBoxOne_MouseEnter(object sender, EventArgs e)
        {
            star = 1;
            HiglightsStar();
        }

        private void PBoxOne_MouseLeave(object sender, EventArgs e)
        {
            RateUpdate();
        }

        private void PBoxTwo_MouseEnter(object sender, EventArgs e)
        {
            star = 2;
            HiglightsStar();
        }

        private void PBoxTwo_MouseLeave(object sender, EventArgs e)
        {
            RateUpdate();
        }

        private void PBoxThree_MouseEnter(object sender, EventArgs e)
        {
            star = 3;
            HiglightsStar();
        }

        private void PBoxThree_MouseLeave(object sender, EventArgs e)
        {
            RateUpdate();
        }

        private void PBoxFour_MouseEnter(object sender, EventArgs e)
        {
            star = 4;
            HiglightsStar();
        }

        private void PBoxFour_MouseLeave(object sender, EventArgs e)
        {
            RateUpdate();
        }

        private void PBoxFive_MouseEnter(object sender, EventArgs e)
        {
            star = 5;
            HiglightsStar();
        }

        private void PBoxFive_MouseLeave(object sender, EventArgs e)
        {
            RateUpdate();
        }

        private void RateUpdate()
        {
            if (rate == 0)
            {
                star = 0;
                HiglightsStar();
            }
            else
            {
                star = rate;
                HiglightsStar();
            }
        }

        private void PBoxOne_Click(object sender, EventArgs e)
        {
            rate = 1;  // Rate değerini 1 yapıyoruz
            HiglightsStar();  // Yıldızları güncelliyoruz
        }

        private void PBoxTwo_Click(object sender, EventArgs e)
        {
            rate = 2;
            HiglightsStar();
        }

        private void PBoxThree_Click(object sender, EventArgs e)
        {
            rate = 3;
            HiglightsStar();
        }

        private void PBoxFour_Click(object sender, EventArgs e)
        {
            rate = 4;
            HiglightsStar();
        }

        private void PBoxFive_Click(object sender, EventArgs e)
        {
            rate = 5;
            HiglightsStar();
        }

        private void HiglightsStar()
        {
            // Bir dizi ile PictureBox öğelerini alıyoruz
            PictureBox[] starBoxes = { PBoxOne, PBoxTwo, PBoxThree, PBoxFour, PBoxFive };

            // Yıldız sayısına göre resim ayarlaması yapıyoruz
            for (int i = 0; i < starBoxes.Length; i++)
            {
                // Yıldız sayısına göre resim belirleniyor.
                starBoxes[i].Image = i < star ? filledStarImage : emptyStarImage;
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (star == 0)
            {
                MessageBox.Show("Yıldız değerlendirmesi yapmadan yorum gönderilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // veritabanına yorum ekleme
                ReviewAddToDB();

                // yorumları yeniden listeleme
                ListComments();
            }
        }

        private void ReviewAddToDB()
        {
            string query2 = "INSERT INTO Reviews (Rating, ReviewText, UserID, MovieID) " +
                           "VALUES (@rating, @reviewText, @userId, @movieId)";

            connection.Open();
            SqlCommand cmd = new SqlCommand(query2, connection);
            cmd.Parameters.AddWithValue("@rating", star); // Yıldız derecelendirmesi
            cmd.Parameters.AddWithValue("@reviewText", RTxtReview.Text); // Yorum metni
            cmd.Parameters.AddWithValue("@userId", user.Id); // Kullanıcı ID'si
            cmd.Parameters.AddWithValue("@movieId", movieID); // Film ID'sini alıyoruz
            cmd.ExecuteNonQuery(); // Veriyi ekliyoruz

            connection.Close();
        }

        private void ListComments()
        {
            // Önce eski yorumları temizleyelim
            FLayoutReviews.Controls.Clear();
            string query = "select r.ReviewText, r.Rating, r.CreatedAt, u.Username, u.ProfilePicture from Reviews r INNER JOIN Users u ON r.UserID = u.UserID WHERE r.MovieID = @movieId";

            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@movieId", movieID); // Film ID'sini alıyoruz
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                // Yeni bir panel oluşturuyoruz
                Panel commentPanel = new Panel
                {
                    Size = new Size(540, 175),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(12)
                };

                PictureBox pictureBox = new PictureBox
                {
                    Location = new Point(10, 10), // Panelin üst sol köşesine yerleştiriyoruz
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(60, 60) // Fotoğraf boyutu
                };

                string profilePath = reader["ProfilePicture"].ToString();
                pictureBox.Load(profilePath);

                // Yıldız Sayısını Gösteren Label
                Label ratingLabel = new Label
                {
                    Text = reader["Rating"].ToString() + " Yıldız", // Kullanıcının verdiği yıldız sayısını gösteriyoruz
                    AutoSize = true,
                    Location = new Point(450, 10), // Profil fotoğrafının sağına yerleştiriliyor
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    ForeColor = Color.White
                };

                // Yorum Metni için Bir Alt Panel (Beyaz Arka Plan)
                Panel textPanel = new Panel
                {
                    Location = new Point(80, 40), // Profil fotoğrafının sağ tarafına hizalanıyor
                    Size = new Size(450, 100), // Yorum metni alanı
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoScroll = true // Uzun metinler için kaydırma çubuğu ekleniyor
                };

                // Yorumun İçeriğini Gösteren Label
                Label commentLabel = new Label
                {
                    Text = reader["ReviewText"].ToString(),
                    AutoSize = false, // Metin alanını sabit bir genişlikte tutuyoruz
                    Size = new Size(440, 90), // Genişliği sınırlıyoruz
                    Font = new Font("Tahoma", 10, FontStyle.Regular),
                    ForeColor = Color.Black,
                    TextAlign = ContentAlignment.TopLeft
                };

                using (Graphics g = CreateGraphics())
                {
                    SizeF size = g.MeasureString(commentLabel.Text, commentLabel.Font, textPanel.Width - 10);
                    commentLabel.Height = (int)size.Height + 10; // Metne göre yüksekliği ayarla
                }

                textPanel.Controls.Add(commentLabel);

                Label dateLabel = new Label
                {
                    Text = reader["CreatedAt"].ToString(), // Tarihi ve saati formatlı bir şekilde alıyoruz
                    AutoSize = true,
                    Location = new Point(390, commentPanel.Height - 25), // Sol alt köşeye hizalama
                    Font = new Font("Tahoma", 9, FontStyle.Italic),
                    ForeColor = Color.White
                };

                // Kullanıcı adı ekleniyor
                Label userLabel = new Label
                {
                    Text = reader["Username"].ToString(),
                    AutoSize = true,
                    Location = new Point(80, 10),
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    ForeColor = Color.White
                };

                // Panel'e Label'ları ekliyoruz
                commentPanel.Controls.Add(pictureBox);
                commentPanel.Controls.Add(ratingLabel);
                commentPanel.Controls.Add(textPanel);
                commentPanel.Controls.Add(dateLabel);
                commentPanel.Controls.Add(userLabel);

                // Yorum panelini ekliyoruz
                FLayoutReviews.Controls.Add(commentPanel);
            }

            connection.Close();
        }
        // Film başlığına göre Film ID'sini alacak fonksiyon
        private int GetIDMovie(string movieTitle)
        {
            string query = "SELECT MovieID FROM Movies WHERE Title = @movieTitle";

            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@movieTitle", movieTitle);
            movieID = Convert.ToInt32(cmd.ExecuteScalar()); // Film ID'sini alıyoruz

            connection.Close();

            return movieID;
        }

        private void VotesCalculate()
        {
            movieID = GetIDMovie(title);

            double voteSum = 0, count = 0, rate = 0;
            string query = "select Rating from Reviews where MovieID=@movieId";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@movieId", movieID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                voteSum += Convert.ToDouble(reader["Rating"]);
                count++;
            }
            connection.Close();

            count *= 5;
            rate = (voteSum / count) * 100;

            if (count == 0)
            {
                LblVotes.Text = "Henüz değerlendirilmedi";
            }
            else if (rate > 0 && rate <= 25)
            {
                LblVotes.Text = "Çok olumsuz (" + (count / 5).ToString() + ")";
            }
            else if (rate > 25 && rate <= 50)
            {
                LblVotes.Text = "Çoğunlukla olumsuz (" + (count / 5).ToString() + ")";
            }
            else if (rate > 50 && rate <= 75)
            {
                LblVotes.Text = "Çoğunlukla olumlu (" + (count / 5).ToString() + ")";
            }
            else if (rate > 75 && rate <= 100)
            {
                LblVotes.Text = "Çok olumlu (" + (count / 5).ToString() + ")";
            }
        }
    }
}
