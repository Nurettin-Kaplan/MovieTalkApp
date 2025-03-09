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

namespace MovieTalkApp
{
    public partial class signInScreen : Form
    {
        public signInScreen()
        {
            InitializeComponent();
        }

        public string imagePath = "";       // dosya yolunu tutmak için string türünde değişken tanımladım
        SqlConnection connection = new SqlConnection(@"Server=.;Database=MovieTalkApp;Integrated Security=True;TrustServerCertificate=True;");
        // bağlantıyı tanımladım
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

        public bool IsUsernameEmpty()
        {
            if (TxtUsername.Text == "") // username text boxı boş ise çarpı koyuyorum.
            {
                LblUsernameErr.Text = "❌";
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
                LblEmailErr.Text = "❌";
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
                LblPhoneErr.Text = "❌";
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void signInScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == TxtPassword2.Text)
            {
                bool isUsernameEmpty = IsUsernameEmpty();
                bool isEmailEmpty = IsEmailEmpty();
                bool isPhoneEmpty = IsPhoneEmpty();

                if (isUsernameEmpty == false)
                {
                    LblUsernameInfo.Text = "Bu kullanıcı adı kullanılıyor.";
                }
                else if (isEmailEmpty == false)
                {
                    LblEmailInfo.Text = "Bu email adresi kullanılıyor.";
                }
                else if (isPhoneEmpty == false)
                {
                    LblPhoneInfo.Text = "Bu telefon numarası kullanılıyor.";

                }
                else
                {
                    connection.Open();
                    string query2 = "insert into Users (ProfilePicture, Username, Email, Phone, UserPassword" +
                    ", CreatedAt, Author) values (@profilePicture, @username, @email, @phone" +
                    ", @userPassword, GETDATE(), 0)";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@profilePicture", imagePath);
                    command2.Parameters.AddWithValue("@username", TxtUsername.Text);
                    command2.Parameters.AddWithValue("@email", TxtEmail.Text);
                    command2.Parameters.AddWithValue("@phone", MTBoxPhone.Text.ToString());
                    command2.Parameters.AddWithValue("@userPassword", TxtPassword.Text);
                    command2.ExecuteNonQuery();
                    connection.Close();

                    LblInfo2.Text = "Kayıt başarılı.";
                }
            }
            else
            {
                LblInfo.Text = "Girilen şifreler birbiri ile uyuşmuyor.";
            }
        }

        private void PBoxWievPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.PasswordChar = '\0';
        }

        private void PBoxWievPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword.PasswordChar = '●';
        }

        private void PBoxWievPassword2_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.PasswordChar = '\0';
        }

        private void PBoxWievPassword2_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword.PasswordChar = '●';
        }
    }
}
