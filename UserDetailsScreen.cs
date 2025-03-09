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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace MovieTalkApp
{
    public partial class UserDetailsScreen : Form
    {
        public UserDetailsScreen()
        {
            InitializeComponent();
        }

        public string imagePath = "";
        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");
        User user = new User();

        private void CreateUser(string data)
        {
            try
            {
                int userID = Convert.ToInt16(data);

                connection.Open();
                string query = "select * from Users where UserID=@userid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userid", userID);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    user.Id = Convert.ToInt32(reader["UserID"]);
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
            catch (Exception)
            {
                MessageBox.Show("Güncellenecek olan kullanıcının ID alanı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                pictureBoxProfile.Image = Image.FromFile(openFileDialog.FileName);
                imagePath = openFileDialog.FileName;    // yüklenen dosyanın yolunu atadım
            }
        }

        private void BtnToList_Click(object sender, EventArgs e)
        {
            string query = "select * from Users";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            connection.Open();
            adapter.Fill(table);

            DGWievUsersDetails.DataSource = table;

            connection.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CreateUser(TxtUserID.Text);

            bool author;

            if (TxtUserID.Text == "")
            {
                MessageBox.Show("Güncellenecek olan kullanıcının id numarası boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToInt16(MTBoxAuthor.Text) == 0)
                {
                    author = false;
                }
                else
                {
                    author = true;
                }

                connection.Open();
                string query2 = "update Users set ProfilePicture=@profilePicture, Username=@username, Email=@email, Phone=@phone, UserPassword=@userPassword," +
                "Author=@author where UserID=@userID";
                SqlCommand command = new SqlCommand(query2, connection);

                command.Parameters.AddWithValue("@userID", user.Id);

                if (imagePath == "")
                {
                    command.Parameters.AddWithValue("@profilePicture", user.ImagePath);
                }
                else
                {
                    command.Parameters.AddWithValue("@profilePicture", imagePath);
                }
                if (TxtUsername.Text == "")
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                }
                else
                {
                    command.Parameters.AddWithValue("@username", TxtUsername.Text);
                }
                if (TxtEmail.Text == "")
                {
                    command.Parameters.AddWithValue("@email", user.Email);
                }
                else
                {
                    command.Parameters.AddWithValue("@email", TxtEmail.Text);
                }
                if (MTBoxPhone.Text.ToString() == "")
                {
                    command.Parameters.AddWithValue("@phone", user.Phone);
                }
                else
                {
                    command.Parameters.AddWithValue("@phone", MTBoxPhone.Text.ToString());
                }
                if (TxtPassword.Text == "")
                {
                    command.Parameters.AddWithValue("@userPassword", user.UserPassword);
                }
                else
                {
                    command.Parameters.AddWithValue("@userPassword", TxtPassword.Text);
                }
                if (MTBoxAuthor.Text.ToString() == "")
                {
                    command.Parameters.AddWithValue("@author", user.Author);
                }
                else
                {
                    command.Parameters.AddWithValue("@author", author);
                }
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DGWievUsersDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Sadece veri satırına tıklanırsa çalışır
            {
                DataGridViewRow row = DGWievUsersDetails.Rows[e.RowIndex];

                // Verileri TextBox'lara aktar
                TxtUserID.Text = row.Cells["UserID"].Value.ToString();
                imagePath = row.Cells["ProfilePicture"].Value.ToString();

                // Eğer imagePath boş değilse, URL veya dosya yolu olabilir
                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        // URL'den resim yükle
                        pictureBoxProfile.Load(imagePath);  // Bu, URL veya geçerli dosya yolunu yükler
                    }
                    catch (Exception)
                    {
                        pictureBoxProfile.Image = null;  // Hata durumunda resmi temizle
                    }
                }
                else
                {
                    pictureBoxProfile.Image = null;  // imagePath yoksa resmi temizle
                }
                TxtUsername.Text = row.Cells["Username"].Value.ToString();
                TxtEmail.Text = row.Cells["Email"].Value.ToString();
                MTBoxPhone.Text = row.Cells["Phone"].Value.ToString();
                TxtPassword.Text = row.Cells["UserPassword"].Value.ToString();
                MTBoxAuthor.Text = row.Cells["Author"].Value.ToString();
            }
        }

        private void UserDetailsScreen_Load(object sender, EventArgs e)
        {
            DGWievUsersDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGWievUsersDetails.MultiSelect = false;
        }
    }
}
