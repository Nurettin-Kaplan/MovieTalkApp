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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieTalkApp
{
    public partial class AddUserScreen : Form
    {
        public AddUserScreen()
        {
            InitializeComponent();
        }

        public string imagePath = "";
        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");

        public bool IsUsernameEmpty()
        {
            if (TxtUsername.Text == "") // username text boxı boş ise çarpı koyuyorum.
            {
                MessageBox.Show("Kullanıcı adı alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else  // değilse
            {
                connection.Open();
                string query = "select count(*) from Users where Username=@username"; // kullanıcı adının alınıp alınmadığını kontrol ediyorum
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", TxtUsername.Text);
                int userCount = (int)command.ExecuteScalar();

                if (userCount > 0)      // kullanıcı adı db'de var ise bağlantıyı kapat false döndür
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

        public bool IsEmailEmpty()
        {
            if (TxtEmail.Text == "")
            {
                MessageBox.Show("Email alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                connection.Open();
                string query = "select count(*) from Users where Email=@email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", TxtEmail.Text);
                int emailCount = (int)command.ExecuteScalar();

                if (emailCount > 0)
                {
                    connection.Close();
                    return false;
                }
                else
                {
                    connection.Close();
                    return true;
                }
            }
            return true;
        }

        public bool IsPhoneEmpty()
        {
            if (MTBoxPhone.Text == "")
            {
                MessageBox.Show("Telefon alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                connection.Open();
                string query = "select count(*) from Users where Phone=@phone";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@phone", MTBoxPhone.Text);
                int phoneCount = (int)command.ExecuteScalar();

                if (phoneCount > 0)
                {
                    connection.Close();
                    return false;
                }
                else
                {
                    connection.Close();
                    return true;
                }
            }
            return true;
        }

        private void BtnToList_Click(object sender, EventArgs e)
        {
            string query = "select * from Users";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            connection.Open();
            adapter.Fill(table);

            DGViewUsers.DataSource = table;

            connection.Close();
        }

        private void BtnLoadPhoto_Click(object sender, EventArgs e)
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

        private void BtnToAdd_Click(object sender, EventArgs e)
        {
            bool isUsernameEmpty = IsUsernameEmpty();
            bool isEmailEmpty = IsEmailEmpty();
            bool isPhoneEmpty = IsPhoneEmpty();
            bool author;

            if (MTBoxAuthor.Text == "" || Convert.ToInt16(MTBoxAuthor.Text) == 0)
            {
                author = false;
            }
            else
            {
                author = true;
            }

            if (isUsernameEmpty == false)
            {
                MessageBox.Show("Bu kullanıcı adı kullanılıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isEmailEmpty == false)
            {
                MessageBox.Show("Bu email adresi kullanılıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isPhoneEmpty == false)
            {
                MessageBox.Show("Bu telefon numarası kullanılıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                string query2 = "insert into Users (ProfilePicture, Username, Email, Phone, UserPassword" +
                ", CreatedAt, Author) values (@profilePicture, @username, @email, @phone" +
                ", @userPassword, GETDATE(), @author)";
                SqlCommand command2 = new SqlCommand(query2, connection);

                if (imagePath != null)
                {
                    command2.Parameters.AddWithValue("@profilePicture", imagePath);
                }
                else
                {
                    command2.Parameters.AddWithValue("@profilePicture", TxtProfileUrl.Text);
                }

                command2.Parameters.AddWithValue("@username", TxtUsername.Text);
                command2.Parameters.AddWithValue("@email", TxtEmail.Text);
                command2.Parameters.AddWithValue("@phone", MTBoxPhone.Text.ToString());
                command2.Parameters.AddWithValue("@userPassword", TxtPassword.Text);
                command2.Parameters.AddWithValue("@author", author);
                command2.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DGViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Sadece veri satırına tıklanırsa çalışır
            {
                DataGridViewRow row = DGViewUsers.Rows[e.RowIndex];

                // Verileri TextBox'lara aktar
                imagePath = row.Cells["ProfilePicture"].Value.ToString();
                //pictureBoxProfile.Image = Image.FromFile(imagePath);

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

        private void AddUserScreen_Load(object sender, EventArgs e)
        {
            DGViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGViewUsers.MultiSelect = false;
        }
    }
}
